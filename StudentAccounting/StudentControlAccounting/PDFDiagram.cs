using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace StudentControlAccounting
{
    public partial class PDFDiagram : Component
    {
        Chart chart;

        public PDFDiagram()
        {
            InitializeComponent();
        }

        public PDFDiagram(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Doc(IEnumerable<object> objects, string path, string AxisX, string AxisY)
        {

            using (Document doc = new Document())
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();
                var chart = CreateDiagram(objects, AxisX, AxisY);

                chart.SaveImage("D://PDFDiagram.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                using (var imageStream = new FileStream("D://PDFDiagram.jpeg", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var image = Image.GetInstance(imageStream);
                    doc.Add(image);
                }
                doc.Close();
                writer.Close();
            }
        }

        private Chart CreateDiagram(IEnumerable<object> objects, string AxisX, string AxisY)
        {
            chart = new Chart();
            ChartArea area = new ChartArea();
            area.Name = "myDiagram";
            chart.ChartAreas.Add(area);
            Series series1 = new Series();
            series1.ChartArea = "myDiagram";
            series1.ChartType = SeriesChartType.Line;
            Name(series1, area);
            chart.Series.Add(series1);

            Legend legend = new Legend();
            chart.Legends.Add(legend);

            var fields = objects.First().GetType().GetProperties();

            this.chart.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM.yyyy";
            chart.Series[0].XValueType = ChartValueType.DateTime;

            var obs = objects.ToArray();

            var dates = fields.First(x => x.Name == AxisX);
            var nums = fields.First(x => x.Name == AxisY);

            for (var j = 0; j < obs.Length; j++)
            {
                chart.Series[0].Points.AddXY(dates.GetValue(obs[j]), nums.GetValue(obs[j]));
            }
            return chart;
        }

        private void Name(Series series, ChartArea area)
        {
            series.LegendText = "Линейная";
        }
    }
}
