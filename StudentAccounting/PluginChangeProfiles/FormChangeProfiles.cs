using DB;
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

namespace PluginChangeProfiles
{
    public partial class FormChangeProfiles : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IStudentService studentService;

        public int StudentId { get; set; }

        public FormChangeProfiles(IStudentService studentService)
        {
            InitializeComponent();
            this.studentService = studentService;
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {
            try
            {
                var products = new List<string> { "ПИ", "ИВТ", "ИСЭ", "ИСТ" };
                checkedListBox1.LoadList(products);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var student = studentService.GetElement(StudentId);

                studentService.UpdateElement(new StudentBindingModel
                {
                    Id = StudentId,
                    Profiles = string.Join(", ", checkedListBox1.CheckedValue), 
                    EntryDate = student.EntryDate
                });

                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
