using Excel = Microsoft.Office.Interop.Excel;
using OxyPlot.WindowsForms;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Security.Policy;

namespace Kemimakkeren
{
    class ExcelExecutions
    {
        public static void initExcel()
        {
            Excel.Application xlApp = new Excel.Application();
            xlApp.Visible = false;
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(inputOutputPath.filePath);
            xlWorksheet = xlWorkBook.Worksheets[1];
            xlRange = xlWorksheet.UsedRange;
            
            updateTitles();

        }

        // Updates the titles in the document
        public static void updateTitles()
        {
            string[] tempTitleArray = new string[xlRange.Columns.Count];

            // Loops through the column titles in the Excel file
            for (int i = 0; i < tempTitleArray.Length; i++)
            {
                tempTitleArray[i] = xlWorksheet.Cells[1, i + 1].Value2;
            }

            xlColumnTitles = tempTitleArray;
        }

        // Adds the chosen values to its corresponding value array
        public static double[] addValuesToArray(int indexChosen)
        {
            double[] tempArray = new double[xlRange.Rows.Count-1];
            string tempValue;
            for (int i = 0; i < xlRange.Rows.Count-1; i++)
            {
                tempValue = Convert.ToString(xlWorksheet.Cells[i + 2, indexChosen + 1].Value2);
                if (tempValue == null)
                {
                    tempValue = "0";
                }
                tempArray[i] = double.Parse(tempValue);
            }
            return tempArray;
        }


        public static Excel.Range xlRange { get; set; }
        public static Excel._Worksheet xlWorksheet { get; set; }


        // Array stores column titles in Excel file loaded
        public static string[] xlColumnTitles { get; set; }

        // Arrays that store the active x- and y-titles
        public static String xTitle { get; set; }
        public static String yTitle { get; set; }

        // Arrays that store active x- and y-value
        public static double[] xValues { get; set; }
        public static double[] yValues { get; set; }
    }

}
