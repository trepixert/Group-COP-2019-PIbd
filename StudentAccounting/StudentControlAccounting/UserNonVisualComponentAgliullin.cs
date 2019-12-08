using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentControlAccounting
{
    public partial class UserNonVisualComponentAgliullin : Component
    {
        private List<int> values = new List<int>();
        private List<string> captions = new List<string>();

        public UserNonVisualComponentAgliullin()
        {
            InitializeComponent();
        }

        public UserNonVisualComponentAgliullin(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Export(string fileName)
        {
            if (values.Count == 0) throw new Exception("Данные не заданы");

            var excel = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                if (File.Exists(fileName))
                {
                    excel.Workbooks.Open(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                else
                {
                    excel.SheetsInNewWorkbook = 2;
                    excel.Workbooks.Add(Type.Missing);
                    excel.Workbooks[1].SaveAs(fileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8, Type.Missing,
                     Type.Missing, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing,
                     Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                var workbook = excel.Workbooks[1];

                Microsoft.Office.Interop.Excel.Sheets excelsheets = workbook.Worksheets;
                var excelworksheetData = (Microsoft.Office.Interop.Excel.Worksheet)excelsheets.get_Item(1);
                excelworksheetData.Cells.Clear();
                excelworksheetData.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
                excelworksheetData.PageSetup.CenterHorizontally = true;
                excelworksheetData.PageSetup.CenterVertically = true;
                for (var i = 1; i <= values.Count; i++)
                {
                    if (i <= captions.Count) excelworksheetData.Range["A" + i].Value = captions[i - 1];
                    excelworksheetData.Range["B" + i].Value = values[i - 1];
                }
                excelworksheetData.Name = "Data";

                var excelworksheetDia = (Microsoft.Office.Interop.Excel.Worksheet)excelsheets.get_Item(2);
                excelworksheetDia.Name = "Diagram";
                var charts = excelworksheetDia.ChartObjects() as Microsoft.Office.Interop.Excel.ChartObjects;
                var chartObject = charts.Add(60, 10, 300, 300) as Microsoft.Office.Interop.Excel.ChartObject;
                var chart = chartObject.Chart;
                chart.ChartWizard(excelworksheetData.Range["A1", $"B{values.Count}"], Microsoft.Office.Interop.Excel.XlChartType.xl3DColumn, "New Chart");

                excel.Workbooks[1].Save();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                excel.Quit();
            }
            releaseObject(excel);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                throw new Exception("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        public void SetValues(List<int> values)
        {
            this.values = values;
        }
        public void SetCaptions(List<string> captions)
        {
            this.captions = captions;
        }
    }
}