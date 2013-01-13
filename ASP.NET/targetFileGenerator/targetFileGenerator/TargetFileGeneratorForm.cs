using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NUnit.Framework;
using targetFileGenerator.Properties;

namespace targetFileGenerator
{
   public partial class TargetFileGeneratorForm : Form
    {
        private string _addressOfTargetPackage;
        private string _addressOfSourceFile;

       public TargetFileGeneratorForm()
       {
           InitializeComponent();
           InitialiseAddresses();
       }

      
       private void BrowseProjectFile_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openProjectFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                pathOfTheProjectFile.Text = openProjectFileDialog.FileName;
                TargetFileDTO.projectAddress = Directory.GetParent(openProjectFileDialog.FileName).FullName;
                TargetFileDTO.projectName = openProjectFileDialog.SafeFileName;
            }
        }

       private void NextStepToSelectSourceFiles_Click(object sender, EventArgs e)
        {
            if (IsNotValidForSelectSources())
            {
                MessageBox.Show(Resources.please_select_your_project_file_first);
            }
            else
            {
                targetGeneratorTabs.SelectedTab = targetGeneratorTabs.TabPages[1];
            }
           
        }

       private void targetGeneratorTabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(IsNotValidForSelectSources())
            {
                e.Cancel = true;
                MessageBox.Show(Resources.please_select_your_project_file_first);
            }
        }

       private bool IsNotValidForSelectSources()
        {
            return pathOfTheProjectFile.Text.Equals(string.Empty);
        }

       private void BrowseSource_Click(object sender, EventArgs e)
       {
            folderBrowserSourceDialog.SelectedPath = TargetFileDTO.projectAddress;
            DialogResult dialogResult = folderBrowserSourceDialog.ShowDialog();
          
            if (dialogResult == DialogResult.OK)
            {
                SourcePath.Text = openProjectFileDialog.FileName;
                TargetFileDTO.sourceAddress = folderBrowserSourceDialog.SelectedPath;
                DialogResult MessageBoxResult= MessageBox.Show(Resources.Do_you_want_all_the_files,Resources.Filer_files,MessageBoxButtons.YesNo);
                if(MessageBoxResult==DialogResult.No)
                {
                    var filterForm = new FilterForm();
                    filterForm.Show();
                }

            }
        }

       private string _addressOftemplateFile;
       private string _addressOfTargetFile;

       private void InitialiseAddresses()
       {
           _addressOftemplateFile = "../../src/TargetFileTemplate.txt";
           _addressOfTargetFile = TargetFileDTO.projectAddress + "/" + TargetFileDTO.projectName + ".targets";
           _addressOfTargetPackage = TargetFileDTO.projectAddress + "/TempTargetPackageFolderForGeneratingTargetFile";
           _addressOfSourceFile = TargetFileDTO.sourceAddress;
       }

       private static void RemoveEmptyElement()
       {
           RemoveEmptyElementInStartWithList();
           RemoveEmptyElementInEndWithList();
           RemoveEmptyElementInExtensionList();
       }

       private void GenerateTargetFile_Click(object sender, EventArgs e)
       {
           InitialiseAddresses();
           var tempTargetPackage = new TempTargetPackage();
           tempTargetPackage.MoveSelectedFilesToTargetProject(_addressOfSourceFile, _addressOfTargetPackage);

           var fileTemplate = new FileTemplate();
           RemoveEmptyElement();

           var hashtable = new Hashtable
                               {
                                   {"extention", TargetFileDTO.excludeExtensions},
                                   {"startWith", TargetFileDTO.excludeStartWith},
                                   {"endWith", TargetFileDTO.excludeEndWith}
                               };

           fileTemplate.GenerateTemplate(_addressOftemplateFile, _addressOfTargetFile, hashtable);
           Close();
          
           Process.Start("explorer.exe", TargetFileDTO.projectAddress);
          
       }

       private static void RemoveEmptyElementInExtensionList()
       {
           try
           {
               TargetFileDTO.excludeExtensions =
              TargetFileDTO.excludeExtensions.Where(s => !string.IsNullOrEmpty(s)).Distinct().ToList();
           }
           catch (Exception) { }
           
          
       }

       private static void RemoveEmptyElementInStartWithList()
       {
           try
           {
               TargetFileDTO.excludeStartWith =
              TargetFileDTO.excludeStartWith.Where(s => !string.IsNullOrEmpty(s)).Distinct().ToList();
           }
           catch (Exception){}
          
       }

       private static void RemoveEmptyElementInEndWithList()
       {
           try
           {
               TargetFileDTO.excludeEndWith =
              TargetFileDTO.excludeEndWith.Where(s => !string.IsNullOrEmpty(s)).Distinct().ToList();
           }
           catch (Exception) { }
          
       }
    }
  
}

