namespace targetFileGenerator
{
    partial class TargetFileGeneratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BrowseProjectFile = new System.Windows.Forms.Button();
            this.openProjectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pathOfTheProjectFile = new System.Windows.Forms.TextBox();
            this.targetGeneratorTabs = new System.Windows.Forms.TabControl();
            this.browseTab = new System.Windows.Forms.TabPage();
            this.NavigationButtons = new System.Windows.Forms.GroupBox();
            this.NextStep = new System.Windows.Forms.Button();
            this.BrowseProjectGroupBox = new System.Windows.Forms.GroupBox();
            this.selectSources = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GenerateTargetFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SourcePath = new System.Windows.Forms.TextBox();
            this.BrowseSource = new System.Windows.Forms.Button();
            this.folderBrowserSourceDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.targetGeneratorTabs.SuspendLayout();
            this.browseTab.SuspendLayout();
            this.NavigationButtons.SuspendLayout();
            this.BrowseProjectGroupBox.SuspendLayout();
            this.selectSources.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrowseProjectFile
            // 
            this.BrowseProjectFile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BrowseProjectFile.Location = new System.Drawing.Point(503, 16);
            this.BrowseProjectFile.Name = "BrowseProjectFile";
            this.BrowseProjectFile.Size = new System.Drawing.Size(75, 23);
            this.BrowseProjectFile.TabIndex = 0;
            this.BrowseProjectFile.Text = "Browse";
            this.BrowseProjectFile.UseVisualStyleBackColor = true;
            this.BrowseProjectFile.Click += new System.EventHandler(this.BrowseProjectFile_Click);
            // 
            // openProjectFileDialog
            // 
            this.openProjectFileDialog.Filter = "Project file | *.csproj";
            this.openProjectFileDialog.Title = "select your project file";
            // 
            // pathOfTheProjectFile
            // 
            this.pathOfTheProjectFile.Location = new System.Drawing.Point(28, 19);
            this.pathOfTheProjectFile.Name = "pathOfTheProjectFile";
            this.pathOfTheProjectFile.ReadOnly = true;
            this.pathOfTheProjectFile.Size = new System.Drawing.Size(459, 20);
            this.pathOfTheProjectFile.TabIndex = 1;
            // 
            // targetGeneratorTabs
            // 
            this.targetGeneratorTabs.Controls.Add(this.browseTab);
            this.targetGeneratorTabs.Controls.Add(this.selectSources);
            this.targetGeneratorTabs.Location = new System.Drawing.Point(12, 12);
            this.targetGeneratorTabs.Name = "targetGeneratorTabs";
            this.targetGeneratorTabs.SelectedIndex = 0;
            this.targetGeneratorTabs.Size = new System.Drawing.Size(658, 194);
            this.targetGeneratorTabs.TabIndex = 2;
            this.targetGeneratorTabs.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.targetGeneratorTabs_Selecting);
            // 
            // browseTab
            // 
            this.browseTab.Controls.Add(this.NavigationButtons);
            this.browseTab.Controls.Add(this.BrowseProjectGroupBox);
            this.browseTab.Location = new System.Drawing.Point(4, 22);
            this.browseTab.Name = "browseTab";
            this.browseTab.Padding = new System.Windows.Forms.Padding(3);
            this.browseTab.Size = new System.Drawing.Size(650, 168);
            this.browseTab.TabIndex = 0;
            this.browseTab.Text = "Browse project";
            this.browseTab.UseVisualStyleBackColor = true;
            // 
            // NavigationButtons
            // 
            this.NavigationButtons.Controls.Add(this.NextStep);
            this.NavigationButtons.Location = new System.Drawing.Point(30, 95);
            this.NavigationButtons.Name = "NavigationButtons";
            this.NavigationButtons.Size = new System.Drawing.Size(601, 54);
            this.NavigationButtons.TabIndex = 3;
            this.NavigationButtons.TabStop = false;
            // 
            // NextStep
            // 
            this.NextStep.Location = new System.Drawing.Point(494, 19);
            this.NextStep.Name = "NextStep";
            this.NextStep.Size = new System.Drawing.Size(75, 23);
            this.NextStep.TabIndex = 0;
            this.NextStep.Text = "Next";
            this.NextStep.UseVisualStyleBackColor = true;
            this.NextStep.Click += new System.EventHandler(this.NextStepToSelectSourceFiles_Click);
            // 
            // BrowseProjectGroupBox
            // 
            this.BrowseProjectGroupBox.Controls.Add(this.pathOfTheProjectFile);
            this.BrowseProjectGroupBox.Controls.Add(this.BrowseProjectFile);
            this.BrowseProjectGroupBox.Location = new System.Drawing.Point(21, 16);
            this.BrowseProjectGroupBox.Name = "BrowseProjectGroupBox";
            this.BrowseProjectGroupBox.Size = new System.Drawing.Size(611, 52);
            this.BrowseProjectGroupBox.TabIndex = 2;
            this.BrowseProjectGroupBox.TabStop = false;
            // 
            // selectSources
            // 
            this.selectSources.Controls.Add(this.groupBox2);
            this.selectSources.Controls.Add(this.groupBox1);
            this.selectSources.Location = new System.Drawing.Point(4, 22);
            this.selectSources.Name = "selectSources";
            this.selectSources.Padding = new System.Windows.Forms.Padding(3);
            this.selectSources.Size = new System.Drawing.Size(650, 168);
            this.selectSources.TabIndex = 1;
            this.selectSources.Text = "Select sources";
            this.selectSources.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GenerateTargetFile);
            this.groupBox2.Location = new System.Drawing.Point(26, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 54);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // GenerateTargetFile
            // 
            this.GenerateTargetFile.Location = new System.Drawing.Point(494, 19);
            this.GenerateTargetFile.Name = "GenerateTargetFile";
            this.GenerateTargetFile.Size = new System.Drawing.Size(75, 23);
            this.GenerateTargetFile.TabIndex = 0;
            this.GenerateTargetFile.Text = "Finish";
            this.GenerateTargetFile.UseVisualStyleBackColor = true;
            this.GenerateTargetFile.Click += new System.EventHandler(this.GenerateTargetFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SourcePath);
            this.groupBox1.Controls.Add(this.BrowseSource);
            this.groupBox1.Location = new System.Drawing.Point(26, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select folder you want to pass it to the bin folder";
            // 
            // SourcePath
            // 
            this.SourcePath.Location = new System.Drawing.Point(20, 32);
            this.SourcePath.Name = "SourcePath";
            this.SourcePath.ReadOnly = true;
            this.SourcePath.Size = new System.Drawing.Size(459, 20);
            this.SourcePath.TabIndex = 3;
            // 
            // BrowseSource
            // 
            this.BrowseSource.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BrowseSource.Location = new System.Drawing.Point(494, 30);
            this.BrowseSource.Name = "BrowseSource";
            this.BrowseSource.Size = new System.Drawing.Size(75, 23);
            this.BrowseSource.TabIndex = 2;
            this.BrowseSource.Text = "Browse";
            this.BrowseSource.UseVisualStyleBackColor = true;
            this.BrowseSource.Click += new System.EventHandler(this.BrowseSource_Click);
            // 
            // folderBrowserSourceDialog
            // 
            this.folderBrowserSourceDialog.ShowNewFolderButton = false;
            // 
            // TargetFileGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(682, 218);
            this.Controls.Add(this.targetGeneratorTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TargetFileGeneratorForm";
            this.Text = "targetFileGenerator";
            this.targetGeneratorTabs.ResumeLayout(false);
            this.browseTab.ResumeLayout(false);
            this.NavigationButtons.ResumeLayout(false);
            this.BrowseProjectGroupBox.ResumeLayout(false);
            this.BrowseProjectGroupBox.PerformLayout();
            this.selectSources.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BrowseProjectFile;
        private System.Windows.Forms.OpenFileDialog openProjectFileDialog;
        private System.Windows.Forms.TextBox pathOfTheProjectFile;
        private System.Windows.Forms.TabControl targetGeneratorTabs;
        private System.Windows.Forms.TabPage browseTab;
        private System.Windows.Forms.TabPage selectSources;
        private System.Windows.Forms.GroupBox NavigationButtons;
        private System.Windows.Forms.GroupBox BrowseProjectGroupBox;
        private System.Windows.Forms.Button NextStep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SourcePath;
        private System.Windows.Forms.Button BrowseSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GenerateTargetFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserSourceDialog;
    }
}

