namespace WindowsFormAnalyzer
{
    partial class Analyzer
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RecordsGridView = new System.Windows.Forms.DataGridView();
            this.IpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueryTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueryMethodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtensionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProtocolColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerResponseCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeOfResponseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenFIleButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WeightsRadioButton = new System.Windows.Forms.RadioButton();
            this.SumOfBytesRadioButton = new System.Windows.Forms.RadioButton();
            this.IpRadioButton = new System.Windows.Forms.RadioButton();
            this.GetReportButton = new System.Windows.Forms.Button();
            this.ReportBox = new System.Windows.Forms.RichTextBox();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.finishDateTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltrateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecordsGridView
            // 
            this.RecordsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecordsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IpColumn,
            this.QueryTimeColumn,
            this.QueryMethodColumn,
            this.FileNameColumn,
            this.ExtensionColumn,
            this.ProtocolColumn,
            this.ServerResponseCodeColumn,
            this.SizeOfResponseColumn});
            this.RecordsGridView.Location = new System.Drawing.Point(12, 70);
            this.RecordsGridView.Name = "RecordsGridView";
            this.RecordsGridView.Size = new System.Drawing.Size(844, 446);
            this.RecordsGridView.TabIndex = 0;
            // 
            // IpColumn
            // 
            this.IpColumn.HeaderText = "Ip";
            this.IpColumn.Name = "IpColumn";
            this.IpColumn.ReadOnly = true;
            // 
            // QueryTimeColumn
            // 
            this.QueryTimeColumn.HeaderText = "Query Time";
            this.QueryTimeColumn.Name = "QueryTimeColumn";
            this.QueryTimeColumn.ReadOnly = true;
            // 
            // QueryMethodColumn
            // 
            this.QueryMethodColumn.HeaderText = "Query Method";
            this.QueryMethodColumn.Name = "QueryMethodColumn";
            this.QueryMethodColumn.ReadOnly = true;
            // 
            // FileNameColumn
            // 
            this.FileNameColumn.HeaderText = "FileName";
            this.FileNameColumn.Name = "FileNameColumn";
            this.FileNameColumn.ReadOnly = true;
            // 
            // ExtensionColumn
            // 
            this.ExtensionColumn.HeaderText = "Extension";
            this.ExtensionColumn.Name = "ExtensionColumn";
            this.ExtensionColumn.ReadOnly = true;
            // 
            // ProtocolColumn
            // 
            this.ProtocolColumn.HeaderText = "Protocol";
            this.ProtocolColumn.Name = "ProtocolColumn";
            this.ProtocolColumn.ReadOnly = true;
            // 
            // ServerResponseCodeColumn
            // 
            this.ServerResponseCodeColumn.HeaderText = "Server Response Code";
            this.ServerResponseCodeColumn.Name = "ServerResponseCodeColumn";
            this.ServerResponseCodeColumn.ReadOnly = true;
            // 
            // SizeOfResponseColumn
            // 
            this.SizeOfResponseColumn.HeaderText = "SizeOfResponse";
            this.SizeOfResponseColumn.Name = "SizeOfResponseColumn";
            this.SizeOfResponseColumn.ReadOnly = true;
            // 
            // OpenFIleButton
            // 
            this.OpenFIleButton.Location = new System.Drawing.Point(12, 12);
            this.OpenFIleButton.Name = "OpenFIleButton";
            this.OpenFIleButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFIleButton.TabIndex = 8;
            this.OpenFIleButton.Text = "Open file";
            this.OpenFIleButton.UseVisualStyleBackColor = true;
            this.OpenFIleButton.Click += new System.EventHandler(this.OpenFIleButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WeightsRadioButton);
            this.groupBox1.Controls.Add(this.SumOfBytesRadioButton);
            this.groupBox1.Controls.Add(this.IpRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(513, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 52);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of report";
            // 
            // WeightsRadioButton
            // 
            this.WeightsRadioButton.AutoSize = true;
            this.WeightsRadioButton.Location = new System.Drawing.Point(60, 19);
            this.WeightsRadioButton.Name = "WeightsRadioButton";
            this.WeightsRadioButton.Size = new System.Drawing.Size(76, 17);
            this.WeightsRadioButton.TabIndex = 3;
            this.WeightsRadioButton.TabStop = true;
            this.WeightsRadioButton.Text = "By weights";
            this.WeightsRadioButton.UseVisualStyleBackColor = true;
            // 
            // SumOfBytesRadioButton
            // 
            this.SumOfBytesRadioButton.AutoSize = true;
            this.SumOfBytesRadioButton.Location = new System.Drawing.Point(142, 19);
            this.SumOfBytesRadioButton.Name = "SumOfBytesRadioButton";
            this.SumOfBytesRadioButton.Size = new System.Drawing.Size(86, 17);
            this.SumOfBytesRadioButton.TabIndex = 1;
            this.SumOfBytesRadioButton.TabStop = true;
            this.SumOfBytesRadioButton.Text = "Sum of bytes";
            this.SumOfBytesRadioButton.UseVisualStyleBackColor = true;
            // 
            // IpRadioButton
            // 
            this.IpRadioButton.AutoSize = true;
            this.IpRadioButton.Location = new System.Drawing.Point(6, 19);
            this.IpRadioButton.Name = "IpRadioButton";
            this.IpRadioButton.Size = new System.Drawing.Size(48, 17);
            this.IpRadioButton.TabIndex = 0;
            this.IpRadioButton.TabStop = true;
            this.IpRadioButton.Text = "By ip";
            this.IpRadioButton.UseVisualStyleBackColor = true;
            // 
            // GetReportButton
            // 
            this.GetReportButton.Location = new System.Drawing.Point(12, 41);
            this.GetReportButton.Name = "GetReportButton";
            this.GetReportButton.Size = new System.Drawing.Size(75, 23);
            this.GetReportButton.TabIndex = 5;
            this.GetReportButton.Text = "Get Report";
            this.GetReportButton.UseVisualStyleBackColor = true;
            this.GetReportButton.Click += new System.EventHandler(this.GetReportButton_Click_1);
            // 
            // ReportBox
            // 
            this.ReportBox.Location = new System.Drawing.Point(12, 522);
            this.ReportBox.Name = "ReportBox";
            this.ReportBox.Size = new System.Drawing.Size(844, 193);
            this.ReportBox.TabIndex = 10;
            this.ReportBox.Text = "";
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(93, 43);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.startDateTextBox.TabIndex = 11;
            // 
            // finishDateTextBox
            // 
            this.finishDateTextBox.Location = new System.Drawing.Point(257, 43);
            this.finishDateTextBox.Name = "finishDateTextBox";
            this.finishDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.finishDateTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "StartDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Finish Date";
            // 
            // FiltrateButton
            // 
            this.FiltrateButton.Location = new System.Drawing.Point(429, 12);
            this.FiltrateButton.Name = "FiltrateButton";
            this.FiltrateButton.Size = new System.Drawing.Size(78, 52);
            this.FiltrateButton.TabIndex = 15;
            this.FiltrateButton.Text = "Filtrate";
            this.FiltrateButton.UseVisualStyleBackColor = true;
            this.FiltrateButton.Click += new System.EventHandler(this.FiltrateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Format: Year/Month/DayTHour:Minute:Second:Millisecond";
            // 
            // Analyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 727);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FiltrateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finishDateTextBox);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.ReportBox);
            this.Controls.Add(this.GetReportButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OpenFIleButton);
            this.Controls.Add(this.RecordsGridView);
            this.Name = "Analyzer";
            this.Text = "Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.RecordsGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RecordsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueryTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueryMethodColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtensionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProtocolColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerResponseCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeOfResponseColumn;
        private System.Windows.Forms.Button OpenFIleButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton WeightsRadioButton;
        private System.Windows.Forms.RadioButton SumOfBytesRadioButton;
        private System.Windows.Forms.RadioButton IpRadioButton;
        private System.Windows.Forms.Button GetReportButton;
        private System.Windows.Forms.RichTextBox ReportBox;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.TextBox finishDateTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FiltrateButton;
        private System.Windows.Forms.Label label3;
    }
}

