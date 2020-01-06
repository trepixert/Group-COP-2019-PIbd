using AnikyevLibNotVisual;
using DAL.Implementations;
using DAO;
using PluginInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginReport {
    [Export(typeof(IPlugin))]
    public class ClassReport : IPlugin {
        public string Name => "Отчет по заказу";
        public void run(int id) {
            var studentService = new StudentServiceImpl(new StudentDbContext());
            var student = studentService.getOneById(id);
            var reportPDF1 = new ComponentExportReport();

            var saveFileDialog = new SaveFileDialog {
                Filter = "pdf|*.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                var path = saveFileDialog.FileName;

                reportPDF1.SetHeaders(new List<string> { "ФИО студента", "Курс", "Стипуха" });

                var data = new List<List<string>>
                {
                    new List<string> { student.FIO, student.Course.ToString(), student.Scholarship.ToString() }
                };

                reportPDF1.SetValues(data);
                reportPDF1.Export(path);
            }
        }
    }
}
