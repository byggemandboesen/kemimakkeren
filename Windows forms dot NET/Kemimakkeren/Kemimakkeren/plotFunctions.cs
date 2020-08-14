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
        public static void plotMain(System.Windows.Forms.CheckBox plotReactionOrder)
        {
            // Title of the y-values(will be used as chart title for example
            string columnTitle = ExcelExecutions.xlWorksheet.Cells[1, ExcelExecutions.yPressed + 1].Value;

            if (plotReactionOrder.Checked)
            {
                Excel.Range lnValueLocation = findCell("ln(" + columnTitle + ")");
                Excel.Range inverseValueLocation = findCell("1/" + columnTitle);
                if (lnValueLocation == null || inverseValueLocation == null)
                {
                    // Add first and second order column
                    addReactionOrderColumns(columnTitle);
                }

                // Plots the 0th, 1st and 2nd order reaction chart
                for (int i = 0; i < 3; i++)
                {
                    string[] chartTitles = {columnTitle, "ln(" + columnTitle + ")", "1/" + columnTitle};
                    plotChart(chartTitles[i]);
                }
            }
            else
            {
                plotChart(columnTitle);
            }
            
            
        }

        // Function that creates the plot
        public static void plotChart(string columnTitle)
        {
            Excel.Range chartRange;
            object misValue = System.Reflection.Missing.Value;

            // Creates the chart
            Excel.ChartObjects xlCharts = (Excel.ChartObjects)ExcelExecutions.xlWorksheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = xlCharts.Add(250, 50, 400, 250);
            Excel.Chart xlChart = myChart.Chart;
            xlChart.ChartType = Excel.XlChartType.xlXYScatter;

            // Gets the range for the column title
            Excel.Range XcolumnTitleLocation = findCell(ExcelExecutions.xTitle);
            Excel.Range YcolumnTitleLocation = findCell(columnTitle); 

            // The title and value for the x- and y-axis
            string xColumnPrefix = ExcelExecutions.columnNames[XcolumnTitleLocation.Column - 1];
            string yColumnPrefix = ExcelExecutions.columnNames[YcolumnTitleLocation.Column - 1];
            Excel.Range xValues = ExcelExecutions.xlWorksheet.Range[xColumnPrefix + "2", (xColumnPrefix + ExcelExecutions.xlRange.Rows.Count.ToString())];
            Excel.Range yvalues = ExcelExecutions.xlWorksheet.Range[yColumnPrefix + "2", (yColumnPrefix + ExcelExecutions.xlRange.Rows.Count.ToString())];

            // Assigns the value to the chart
            Excel.SeriesCollection seriesCollection = xlChart.SeriesCollection();
            Excel.Series series1 = seriesCollection.NewSeries();
            series1.XValues = xValues;
            series1.Name = columnTitle;
            series1.Values = yvalues;

            saveChart(xlChart, series1.Name);
        }

        // Searches for a given value in the used range
        public static Excel.Range findCell(string value)
        {
            Excel.Range valueLocation;
            // Updates the UsedRange since it could have changed since opening the document(new columns added)
            ExcelExecutions.xlRange = ExcelExecutions.xlWorksheet.UsedRange;

            valueLocation = ExcelExecutions.xlRange.Find(value);

            return valueLocation;
        }


        // Adds columns with ln(concentration) and 1/concentration
        public static void addReactionOrderColumns(string columnName)
        {
            for (int i = 1; i < 3; i++)
            {
                switch (i)
                {
                    case 1:
                        ExcelExecutions.xlWorksheet.Cells[1, ExcelExecutions.xlRange.Columns.Count + i].Value = "ln(" + columnName + ")";
                        for (int j = 2; j <= ExcelExecutions.xlRange.Rows.Count; j++)
                        {
                            ExcelExecutions.xlWorksheet.Cells[j, ExcelExecutions.xlRange.Columns.Count + i].Value = Math.Log(ExcelExecutions.yValues[j - 2]);
                        }
                        break;
                    case 2:
                        ExcelExecutions.xlWorksheet.Cells[1, ExcelExecutions.xlRange.Columns.Count + i].Value = "1/" + columnName;
                        for (int j = 2; j <= ExcelExecutions.xlRange.Rows.Count; j++)
                        {
                            ExcelExecutions.xlWorksheet.Cells[j, ExcelExecutions.xlRange.Columns.Count + i].Value = 1/ExcelExecutions.yValues[j - 2];
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        // Exports the chart the function is given
        public static void saveChart(Excel.Chart chart, string chartName)
        {
            chartName = chartName.Replace("/", " divby ");
            chart.Export(Path.Combine(inputOutputPath.outputPath , chartName + ".png"));
        }

    }
}
