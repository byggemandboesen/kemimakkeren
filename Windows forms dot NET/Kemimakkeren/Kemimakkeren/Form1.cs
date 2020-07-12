using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Kemimakkeren
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            values.outputPath = Path.Combine(Directory.GetCurrentDirectory(), "Output files");
        }

        private void getDirButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileBrowseDialog = new OpenFileDialog();
            fileBrowseDialog.Title = "Vælg Excel-filen med data";
            fileBrowseDialog.Filter = "Excel filer (*.xlsx; *.csv;)|*.xlsx; *.csv;|All files (*.*)|*.*";
            if (fileBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                values.filePath = fileBrowseDialog.FileName;
                ExcelExecutions.initExcel();
                updateListBoxValues(xValues, yValues);
            }
            else
            {
                MessageBox.Show("Error browsing for file... Please try again");
            }
        }

        public static void updateListBoxValues(ListBox xValues, ListBox yValues)
        {
            for (int i = 1; i < ExcelExecutions.xlColumnTitles.Length; i++)
            {
                xValues.Items.Add(ExcelExecutions.xlColumnTitles[i]);
                yValues.Items.Add(ExcelExecutions.xlColumnTitles[i]);
            }
        }

    }

    // Contains values such as directories and etc.
    class values
    {
        public static String filePath { get; set; }
        public static String outputPath { get; set; }

    }
}
