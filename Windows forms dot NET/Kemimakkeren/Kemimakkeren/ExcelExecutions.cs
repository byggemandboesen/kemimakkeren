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
            xlApp = new Excel.Application();
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

                // Tries to parse comma and dot numbers
                if (tempValue.Contains(",")){
                    tempValue = tempValue.Replace(",", ".");
                    xlWorksheet.Cells[i + 2, indexChosen + 1].Value = tempValue;
                    tempArray[i] = double.Parse(tempValue);
                }
                else
                {
                    tempArray[i] = double.Parse(tempValue.Replace(",", "."));
                }
                
            }
            return tempArray;
        }


        public static Excel.Range xlRange { get; set; }
        public static Excel._Worksheet xlWorksheet { get; set; }
        public static Excel.Application xlApp { get; set; }


        // Array stores column titles in Excel file loaded
        public static string[] xlColumnTitles { get; set; }

        // Arrays that store the active x- and y-titles
        public static String xTitle { get; set; }
        public static String yTitle { get; set; }

        // Two integers that store the chosen x- and y-value (column number)
        public static int xPressed { get; set; }
        public static int yPressed { get; set; }
        // String array with column names
        public static string[] columnNames = { "A", "B", "C", "D", "E", "F", "G" };


        
        // Arrays that store active x- and y-value
        public static double[] xValues { get; set; }
        public static double[] yValues { get; set; }
        
    }

}
