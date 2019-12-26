using DB;
using Plugins;
using StudentControlAccounting;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginReport
{
    [Export(typeof(IPlugin))]
    public class ClassPlugin : IPlugin
    {
        public string Name => "Отчет по заказу";
        public void Run(int id)
        {
            var studentService = new StudentServiceDB(new AbstractDBContext());
            var student = studentService.GetElementView(id);
            var reportPDF1 = new PDFReport();

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "pdf|*.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName;

                reportPDF1.SetHeaders(new List<string> { "ФИО студента", "Направления", "Дата поступления" });

                var data = new List<List<string>>
                {
                    new List<string> { student.FIO, student.Profiles, student.EntryDate }
                };

                reportPDF1.SetValues(data);
                reportPDF1.Export(path);
            }
        }
    }
}
