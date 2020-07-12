using Excel = Microsoft.Office.Interop.Excel;
using OxyPlot.WindowsForms;
using System.Windows.Forms;
using System;
using System.Linq;

namespace Kemimakkeren
{
    class ExcelExecutions
    {
        public static void initExcel()
        {
            Excel.Application xlApp = new Excel.Application();
            xlApp.Visible = false;
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(values.filePath);
            Excel.Worksheet xlWorkSheet = xlWorkBook.Worksheets[1];

            Excel.Range xlRange = xlWorkSheet.UsedRange;

            updateTitles(xlRange, xlWorkSheet);



            xlApp.Quit();
        }

        // Updates the titles in the document
        public static void updateTitles(Excel.Range range, Excel.Worksheet sheet)
        {
            string[] tempTitleArray = new string[range.Columns.Count];
            Console.WriteLine(sheet.Cells[1,1].Value);
            for (int i = 1; i <= range.Columns.Count; i++)
            {
                tempTitleArray[i-1] = sheet.Cells[1, i].Value;
            }
            xlColumnTitles = tempTitleArray;
        }




        public static string[] xlColumnTitles { get; set; }

        public static int[] timeValues { get; set; }
    }

}
