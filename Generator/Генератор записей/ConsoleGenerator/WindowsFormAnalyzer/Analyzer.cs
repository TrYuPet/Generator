using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Converters;
using RecordAnalyzer;

namespace WindowsFormAnalyzer
{
    public partial class Analyzer : Form
    {
        public FileAnalyzer TempAnalyzer;

        public List<Record> Records;
        public List<Record> AllRecords; 
        public Dictionary<string, string> Parameters;

        public Form ParametersForm;

        public TextBox StartDateBox;
        public TextBox FinishDateBox;
        public TextBox InitialRowBox;
        public TextBox NumberOfRowsBox;

        public RadioButton MethodsRadioButton;
        public RadioButton ExtensionsRadioButton;
        public RadioButton ServerResponseCodesRadioButton;
 
        public Analyzer()
        {
            InitializeComponent();
        }

        private void OpenFIleButton_Click(object sender, EventArgs e)
        {
            var logReader = new LogFileReader();
            var dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                AllRecords = logReader.GiveAllRecordsInFile(dialog.FileName);
                RecordsOutput(AllRecords);
            }
        }

        private void GetReportButton_Click_1(object sender, EventArgs e)
        {
            if (AllRecords == null)
                MessageBox.Show(@"File not found.");
            else
            {
                TempAnalyzer = new FileAnalyzer
                {
                    Records = Records
                };

                if (IpRadioButton.Checked)
                {
                    ReportBox.Text = TempAnalyzer.AnalyzeByType("analyzerbyip");
                }

                if (WeightsRadioButton.Checked)
                {
                    ParametersForm = new Form { Size = new Size(new Point(200, 200)) };
                    ParametersForm.Show();
                    ParametersForm.Text = @"Parameters for WeightsAnalyzer";

                    MethodsRadioButton = new RadioButton{Location = new Point(10, 15), Text = @"Methods" };
                    ExtensionsRadioButton = new RadioButton { Location = new Point(10, 40), Text = @"Extensions"};
                    ServerResponseCodesRadioButton = new RadioButton { Location = new Point(10, 65), Text = @"Codes"};

                    var groupBox = new GroupBox {Text = @"Type ofWeightsReport", Size = new Size(new Point(150, 90)), Location = new Point(10,10)};

                    var applyButton3 = new Button { Text = @"Apply", Width = 60, Location = new Point(10, 125)};
                    var applyHandler = new EventHandler(applyButton3_Click);
                    applyButton3.Click += applyHandler;

                    
                    groupBox.Controls.AddRange(new Control[]{MethodsRadioButton, ExtensionsRadioButton, ServerResponseCodesRadioButton});
                    
                    ParametersForm.Controls.AddRange(new Control[]{groupBox, applyButton3});
                }

                if (SumOfBytesRadioButton.Checked)
                {
                    ReportBox.Text = TempAnalyzer.AnalyzeByType("analyzerbysumofbytes");
                }
            }
        }

        void applyButton3_Click(Object sender, EventArgs e)
        {
            if (MethodsRadioButton.Checked)
            {
                ReportBox.Text = TempAnalyzer.AnalyzeByType("analyzerbyweights.Methods");
                ParametersForm.Close();
            }

            else if (ExtensionsRadioButton.Checked)
            {
                ReportBox.Text = TempAnalyzer.AnalyzeByType("analyzerbyweights.Extensions");
                ParametersForm.Close();
            }

            else if (ServerResponseCodesRadioButton.Checked)
            {
                ReportBox.Text = TempAnalyzer.AnalyzeByType("analyzerbyweights.Codes");
                ParametersForm.Close();
            }
            else
            {
                MessageBox.Show(@"Choose one of the options");
            }
        }

        private void FiltrateButton_Click(object sender, EventArgs e)
        {
            var dateFilter = new DateFilter
            {
                Records = AllRecords
            };
            Records = dateFilter.Filtrate(startDateTextBox.Text, finishDateTextBox.Text);
            RecordsOutput(Records);
        }

        public void RecordsOutput(List<Record> records)
        {
            if (records.Count != 0)
            {
                RecordsGridView.RowCount = records.Count;
                for (var i = 0; i < records.Count; i++)
                {
                    RecordsGridView["IpColumn", i].Value = records[i].Ip;
                    RecordsGridView["QueryTimeColumn", i].Value = records[i].QueryTime;
                    RecordsGridView["QueryMethodColumn", i].Value = records[i].QueryMethod;
                    RecordsGridView["FileNameColumn", i].Value = records[i].FileName;
                    RecordsGridView["ExtensionColumn", i].Value = records[i].Extension;
                    RecordsGridView["ProtocolColumn", i].Value = records[i].Protocol;
                    RecordsGridView["ServerResponseCodeColumn", i].Value = records[i].ServerResponseCode;
                    RecordsGridView["SizeOfResponseColumn", i].Value = records[i].SizeOfTheResponse;
                }
            }
            else
            {
                RecordsGridView.RowCount = 1;
                for(int i = 0; i < RecordsGridView.RowCount;i++)
                    for (int j = 0; j < RecordsGridView.ColumnCount; j++)
                        RecordsGridView[j, i].Value = String.Empty;
            }
        }
    }
}
