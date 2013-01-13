using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace targetFileGenerator
{
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
        }

        private void AddExclude_Click(object sender, EventArgs e)
        {
           var row = new[] { StartWithTxt.Text, EndWithTxt.Text,ExtentionTxt.Text,"Remove" };
           ExcludeGridView.Rows.Add(row);
           ResetTexts();
           AddFilesOfDirectoryToListView();
        }

        private void ResetTexts()
        {
            StartWithTxt.ResetText();
            EndWithTxt.ResetText();
            ExtentionTxt.ResetText();
        }

        private void ExcludeGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
       {
           if(e.ColumnIndex==3)
           {
               ExcludeGridView.Rows.RemoveAt(e.RowIndex);
               AddFilesOfDirectoryToListView();
           }
       }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            AddFilesOfDirectoryToListView();
        }

        private void AddFilesOfDirectoryToListView()
        {
            IEnumerable<string> fileNames = GetAllFileNames();
            addFilesToListView(fileNames);
            RemoveFilterFiles(fileNames);
        }

        private IEnumerable<string> GetAllFileNames()
        {
            var list=new List<string>();
            try
            {
                list = Directory.GetFiles(TargetFileDTO.sourceAddress, "*.*", SearchOption.AllDirectories).ToList();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                Close();
            }
            return list;
        }

        private void RemoveFilterFiles(IEnumerable<string> fileNames)
        {
           foreach (var fileName in fileNames)
            {
                RemoveFilesEndWithCriteria(fileName);
                RemoveFilesStartWithCriteria(fileName);
                RemoveFilesWithExtensionCriteria(fileName);
            }
        }

        private void RemoveFilesWithExtensionCriteria(string fileName)
        {
            IEnumerable<string> extentions = GetExtensionOfExcludeFiles();
            var fileInfo = new FileInfo(fileName);
            foreach (var extention in 
                extentions.Where(extention => fileInfo.Extension.Equals("." + extention)))
                ListOfFilteredFiles.Items.Remove(fileInfo.FullName);
        }

        private void RemoveFilesStartWithCriteria(string fileName)
        {
            IEnumerable<string> StartWithList = GetListOfStartWithCriteriaOfExcludeFiles();
            var fileInfo = new FileInfo(fileName);
            foreach (var startWithstr in 
                StartWithList.Where(StartWithstr => fileInfo.Name.StartsWith(StartWithstr) && StartWithstr.Length > 0))
                ListOfFilteredFiles.Items.Remove(fileName);
        }

        private void RemoveFilesEndWithCriteria(string fileName)
        {
            IEnumerable<string> endWithList = GetListOfEndWithCriteriaOfExcludeFiles();
            var fileInfo = new FileInfo(fileName);
            foreach (var endWithstr in
                endWithList.Where(endWithstr => endWithstr.EndsWith(fileInfo.Name) && endWithstr.Length > 0))
                ListOfFilteredFiles.Items.Remove(fileName);
        }

        private IEnumerable<string> GetListOfEndWithCriteriaOfExcludeFiles()
        {
            TargetFileDTO.excludeEndWith= (ExcludeGridView.Rows.Cast<DataGridViewRow>().Select(
                    dataGridViewRow => dataGridViewRow.Cells[1].Value.ToString())).ToList();
       return TargetFileDTO.excludeEndWith;
        }

        private IEnumerable<string> GetListOfStartWithCriteriaOfExcludeFiles()
        {
            TargetFileDTO.excludeStartWith = (ExcludeGridView.Rows.Cast<DataGridViewRow>().Select(
                    dataGridViewRow => dataGridViewRow.Cells[0].Value.ToString())).ToList();
           return TargetFileDTO.excludeStartWith;

        }

        private IEnumerable<string> GetExtensionOfExcludeFiles()
        {
            TargetFileDTO.excludeExtensions= (ExcludeGridView.Rows.Cast<DataGridViewRow>().Select(
                dataGridViewRow => dataGridViewRow.Cells[2].Value.ToString())).ToList();
           return TargetFileDTO.excludeExtensions;
        }

        private void addFilesToListView(IEnumerable<string> fileNames)
        {
            ListOfFilteredFiles.Items.Clear();
            foreach (var fileName in fileNames)
            {
                ListOfFilteredFiles.Items.Add(fileName);
            }
        }

        private void CancelForm_Click(object sender, EventArgs e)
        {
            TargetFileDTO.excludeEndWith.Clear();
            TargetFileDTO.excludeExtensions.Clear();
            TargetFileDTO.excludeStartWith.Clear();
            Close();
        }

        private void AddRuls_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
   
}
