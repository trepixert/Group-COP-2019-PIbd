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

namespace PluginChangeDate
{
    public partial class FormChangeDate : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IStudentService studentService;

        public int StudentId { get; set; }

        public FormChangeDate(IStudentService studentService)
        {
            InitializeComponent();
            this.studentService = studentService;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var student = studentService.GetElement(StudentId);

                studentService.UpdateElement(new StudentBindingModel
                {
                    Id = StudentId,
                    Profiles = student.Profiles,
                    EntryDate = dataTimePicker1.SelectedText
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

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
