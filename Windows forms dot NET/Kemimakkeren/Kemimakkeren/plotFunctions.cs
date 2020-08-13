using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Kemimakkeren
{
    class plotFunctions
    {
        public static void plotMain()
        {
            Excel.Range chartRange;
            object misValue = System.Reflection.Missing.Value;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)ExcelExecutions.xlWorksheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = xlCharts.Add(200, 50, 400, 250);
            Excel.Chart xlChart = myChart.Chart;
            xlChart.ChartType = Excel.XlChartType.xlXYScatter;

            /*
            chartRange = ExcelExecutions.xlWorksheet.get_Range("A2: A5", "C2: C5");


            xlChart.SetSourceData(chartRange, misValue);
            xlChart.ChartType = Excel.XlChartType.xlXYScatter;
            */

            string xColumn = ExcelExecutions.columnNames[ExcelExecutions.xPressed];
            string yColumn = ExcelExecutions.columnNames[ExcelExecutions.yPressed];
            Excel.Range xValues = ExcelExecutions.xlWorksheet.Range[xColumn + "2", (xColumn + ExcelExecutions.xlRange.Rows.Count.ToString())];
            Excel.Range yvalues = ExcelExecutions.xlWorksheet.Range[yColumn + "2", (yColumn + ExcelExecutions.xlRange.Rows.Count.ToString())];

            Excel.SeriesCollection seriesCollection = xlChart.SeriesCollection();

            Excel.Series series1 = seriesCollection.NewSeries();
            series1.XValues = xValues;
            // Fix title to the y-value column name
            series1.Name = ExcelExecutions.xlWorksheet.Cells[1, ExcelExecutions.yPressed + 1].Value;
            series1.Values = yvalues;



        }

    }
}
