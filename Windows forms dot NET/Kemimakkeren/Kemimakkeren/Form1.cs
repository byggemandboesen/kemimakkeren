using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kemimakkeren
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void getDirButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileBrowseDialog = new OpenFileDialog();
            fileBrowseDialog.Title = "Vælg Excel-filen med data";
            fileBrowseDialog.Filter = "Excel filer (*.xlsx; *.csv; *.xls;)|*.xlsx; *.csv; *.xls;|All files (*.*)|*.*";
            if (fileBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                inputOutputPath.filePath = fileBrowseDialog.FileName;
                inputOutputPath.outputPath = fileBrowseDialog.FileName.Replace("\\" + Path.GetFileName(fileBrowseDialog.FileName), "");
                ExcelExecutions.initExcel();
                updateListBoxValues(xValues, yValues);
            }
            else
            {
                MessageBox.Show("Error browsing for file... Please try again");
            }
        }

        // Updates the two listboxes with new titles
        public static void updateListBoxValues(ListBox xValues, ListBox yValues)
        {
            xValues.Items.Clear();
            yValues.Items.Clear();
            for (int i = 0; i < ExcelExecutions.xlColumnTitles.Length; i++)
            {
                xValues.Items.Add(ExcelExecutions.xlColumnTitles[i]);
                yValues.Items.Add(ExcelExecutions.xlColumnTitles[i]);
            }
        }

        // Opens the output folder
        private void button1_Click(object sender, EventArgs e)
        {
            if (inputOutputPath.outputPath == null)
            {
                MessageBox.Show("Output-placeringen bestemmes først, når du har valgt en Excel-fil.", "Vælg Excel-fil først");
            }
            else
            {
                Process.Start(inputOutputPath.outputPath);
            }
            
        }

        // Selects the x-values and stores them in array
        private void xValues_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int locationPressed = xValues.IndexFromPoint(e.Location);
            ExcelExecutions.xTitle = ExcelExecutions.xlColumnTitles[locationPressed];
            chosenXValue.Text = "Valgt: " + ExcelExecutions.xTitle;
            chosenXValue.ForeColor = Color.Green;
            ExcelExecutions.xPressed = locationPressed;
            
            // ExcelExecutions.xValues = ExcelExecutions.addValuesToArray(locationPressed);
        }

        // Selects the y-values and stores them in array
        private void yValues_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int locationPressed = xValues.IndexFromPoint(e.Location);
            ExcelExecutions.yTitle = ExcelExecutions.xlColumnTitles[locationPressed];
            chosenYValue.Text = "Valgt: " + ExcelExecutions.yTitle;
            chosenYValue.ForeColor = Color.Green;
            ExcelExecutions.yPressed = locationPressed;

            ExcelExecutions.yValues = ExcelExecutions.addValuesToArray(locationPressed);
        }

        private void initPlot_Click(object sender, EventArgs e)
        {
            if (ExcelExecutions.xTitle == null || ExcelExecutions.yTitle == null)
            {
                MessageBox.Show("Vælg venligst hvilke værdier, du ønsker at plotte på x- og y-aksen");
            }
            else
            {
                plotFunctions.plotMain(plotReactionOrder);
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (inputOutputPath.filePath != null)
            {
                ExcelExecutions.xlWorksheet.SaveAs(inputOutputPath.outputPath + "\\Kemimakkeren.xlsx");
                ExcelExecutions.xlApp.Quit();
            }
        }
    }

    // Contains input & output path.
    class inputOutputPath
    {
        public static String filePath { get; set; }
        public static String outputPath { get; set; }

    }
}
