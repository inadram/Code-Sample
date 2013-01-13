namespace targetFileGenerator
{
    partial class FilterForm
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
            this.ExcludeList = new System.Windows.Forms.GroupBox();
            this.ListOfFilteredFiles = new System.Windows.Forms.ListBox();
            this.ExcludeGridView = new System.Windows.Forms.DataGridView();
            this.StartWith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndWith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.AddExclude = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ExtentionTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EndWithTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartWithTxt = new System.Windows.Forms.TextBox();
            this.StartWithLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CancelForm = new System.Windows.Forms.Button();
            this.AddRuls = new System.Windows.Forms.Button();
            this.ExcludeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExcludeGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExcludeList
            // 
            this.ExcludeList.Controls.Add(this.ListOfFilteredFiles);
            this.ExcludeList.Controls.Add(this.ExcludeGridView);
            this.ExcludeList.Controls.Add(this.AddExclude);
            this.ExcludeList.Controls.Add(this.label3);
            this.ExcludeList.Controls.Add(this.ExtentionTxt);
            this.ExcludeList.Controls.Add(this.label2);
            this.ExcludeList.Controls.Add(this.EndWithTxt);
            this.ExcludeList.Controls.Add(this.label1);
            this.ExcludeList.Controls.Add(this.StartWithTxt);
            this.ExcludeList.Controls.Add(this.StartWithLbl);
            this.ExcludeList.Location = new System.Drawing.Point(12, 12);
            this.ExcludeList.Name = "ExcludeList";
            this.ExcludeList.Size = new System.Drawing.Size(418, 334);
            this.ExcludeList.TabIndex = 0;
            this.ExcludeList.TabStop = false;
            this.ExcludeList.Text = "Exclude files rules";
            // 
            // ListOfFilteredFiles
            // 
            this.ListOfFilteredFiles.FormattingEnabled = true;
            this.ListOfFilteredFiles.Location = new System.Drawing.Point(21, 221);
            this.ListOfFilteredFiles.Name = "ListOfFilteredFiles";
            this.ListOfFilteredFiles.Size = new System.Drawing.Size(381, 108);
            this.ListOfFilteredFiles.TabIndex = 9;
            // 
            // ExcludeGridView
            // 
            this.ExcludeGridView.AllowUserToAddRows = false;
            this.ExcludeGridView.AllowUserToDeleteRows = false;
            this.ExcludeGridView.AllowUserToOrderColumns = true;
            this.ExcludeGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.ExcludeGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ExcludeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ExcludeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartWith,
            this.EndWith,
            this.Extension,
            this.Remove});
            this.ExcludeGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ExcludeGridView.EnableHeadersVisualStyles = false;
            this.ExcludeGridView.Location = new System.Drawing.Point(21, 89);
            this.ExcludeGridView.Name = "ExcludeGridView";
            this.ExcludeGridView.ReadOnly = true;
            this.ExcludeGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ExcludeGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ExcludeGridView.Size = new System.Drawing.Size(381, 115);
            this.ExcludeGridView.TabIndex = 8;
            this.ExcludeGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ExcludeGridView_CellMouseClick);
            // 
            // StartWith
            // 
            this.StartWith.HeaderText = "StartWith";
            this.StartWith.Name = "StartWith";
            this.StartWith.ReadOnly = true;
            this.StartWith.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StartWith.Width = 80;
            // 
            // EndWith
            // 
            this.EndWith.HeaderText = "EndWith";
            this.EndWith.Name = "EndWith";
            this.EndWith.ReadOnly = true;
            this.EndWith.Width = 90;
            // 
            // Extension
            // 
            this.Extension.HeaderText = "Extention";
            this.Extension.Name = "Extension";
            this.Extension.ReadOnly = true;
            this.Extension.Width = 90;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Text = "Remove";
            this.Remove.ToolTipText = "Remove";
            this.Remove.UseColumnTextForLinkValue = true;
            this.Remove.Width = 78;
            // 
            // AddExclude
            // 
            this.AddExclude.Location = new System.Drawing.Point(327, 61);
            this.AddExclude.Name = "AddExclude";
            this.AddExclude.Size = new System.Drawing.Size(75, 23);
            this.AddExclude.TabIndex = 7;
            this.AddExclude.Text = "Add";
            this.AddExclude.UseVisualStyleBackColor = true;
            this.AddExclude.Click += new System.EventHandler(this.AddExclude_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = ".";
            // 
            // ExtentionTxt
            // 
            this.ExtentionTxt.Location = new System.Drawing.Point(231, 63);
            this.ExtentionTxt.Name = "ExtentionTxt";
            this.ExtentionTxt.Size = new System.Drawing.Size(76, 20);
            this.ExtentionTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Have extention";
            // 
            // EndWithTxt
            // 
            this.EndWithTxt.Location = new System.Drawing.Point(140, 62);
            this.EndWithTxt.Name = "EndWithTxt";
            this.EndWithTxt.Size = new System.Drawing.Size(69, 20);
            this.EndWithTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "End With";
            // 
            // StartWithTxt
            // 
            this.StartWithTxt.Location = new System.Drawing.Point(61, 63);
            this.StartWithTxt.Name = "StartWithTxt";
            this.StartWithTxt.Size = new System.Drawing.Size(64, 20);
            this.StartWithTxt.TabIndex = 1;
            // 
            // StartWithLbl
            // 
            this.StartWithLbl.AutoSize = true;
            this.StartWithLbl.Location = new System.Drawing.Point(58, 35);
            this.StartWithLbl.Name = "StartWithLbl";
            this.StartWithLbl.Size = new System.Drawing.Size(54, 13);
            this.StartWithLbl.TabIndex = 0;
            this.StartWithLbl.Text = "Start With";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CancelForm);
            this.groupBox2.Controls.Add(this.AddRuls);
            this.groupBox2.Location = new System.Drawing.Point(12, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 48);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // CancelForm
            // 
            this.CancelForm.Location = new System.Drawing.Point(21, 19);
            this.CancelForm.Name = "CancelForm";
            this.CancelForm.Size = new System.Drawing.Size(75, 23);
            this.CancelForm.TabIndex = 1;
            this.CancelForm.Text = "Cancel";
            this.CancelForm.UseVisualStyleBackColor = true;
            this.CancelForm.Click += new System.EventHandler(this.CancelForm_Click);
            // 
            // AddRuls
            // 
            this.AddRuls.Location = new System.Drawing.Point(327, 19);
            this.AddRuls.Name = "AddRuls";
            this.AddRuls.Size = new System.Drawing.Size(75, 23);
            this.AddRuls.TabIndex = 0;
            this.AddRuls.Text = "Add Ruls";
            this.AddRuls.UseVisualStyleBackColor = true;
            this.AddRuls.Click += new System.EventHandler(this.AddRuls_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 405);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ExcludeList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FilterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FilterForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FilterForm_Load);
            this.ExcludeList.ResumeLayout(false);
            this.ExcludeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExcludeGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ExcludeList;
        private System.Windows.Forms.TextBox ExtentionTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EndWithTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StartWithTxt;
        private System.Windows.Forms.Label StartWithLbl;
        private System.Windows.Forms.Button AddExclude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ExcludeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartWith;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndWith;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
        private System.Windows.Forms.DataGridViewLinkColumn Remove;
        private System.Windows.Forms.ListBox ListOfFilteredFiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddRuls;
        private System.Windows.Forms.Button CancelForm;
    }
}