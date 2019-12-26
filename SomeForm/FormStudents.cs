using DB;
using Plugins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace FormTestProject
{
    public partial class FormStudents : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly StudentServiceDB service;
        private readonly AbstractDBContext context;

        private PluginManager pluginManager;
        private List<IPlugin> plugins;

        public FormStudents(StudentServiceDB service)
        {
            InitializeComponent();
            this.service = service;
            context = new AbstractDBContext();

            pluginManager = new PluginManager();
            plugins = pluginManager.Plugins.ToList();
            foreach (var plugin in plugins)
            {
                listBox1.Items.Add(plugin.Name);
            }
        }

        public void LoadData()
        {
            try
            {
                List<StudentViewModel> list = service.GetList();
                if (list != null)
                {
                    listBoxView1.Pattern = "Id-{Id}, ФИО - {FIO}, Направления - {Profiles}, Дата поступления - {EntryDate}";

                    listBoxView1.LoadData(list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FormStudents_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAdd>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName;

                reportPDF1.SetHeaders(new List<string> { "ФИО студента", "Направления", "Дата поступления" });

                var data = new List<List<string>>();
                var students = service.GetList();

                foreach (var student in students)
                {
                    data.Add(new List<string> { student.FIO, student.Profiles, student.EntryDate });
                }

                reportPDF1.SetValues(data);
                reportPDF1.Export(path);
            }
        }

        private void CreateDiagramPdf_Click(object sender, EventArgs e)
        {
            var data = service.GetList();

            var saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName;

                var docData = data
                    .GroupBy(rec => rec.EntryDate)
                    .Select(g => new { EntryDate = g.Key, Count = g.Count() })
                    .ToList();

                diagramPDF1.Doc(docData, path, "EntryDate", "Count");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var data = context.Students.ToList();

            var saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName;

                storeComponent1.SaveData(data, path);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.FileName;

                var students = storeComponent1.LoadData<Student>(path);
                listBoxView1.LoadData(students.ToList());
            }
        }
        private void ButtonRunPlugin_Click(object sender, EventArgs e)
        {
            var studentId = listBoxView1.SelectedId;
            var pluginIndex = listBox1.SelectedIndex;

            if (studentId != -1 && pluginIndex != -1)
            {
                plugins[pluginIndex].Run(studentId);
            }
        }
    }
}
