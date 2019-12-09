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

namespace FormTestProject
{
    public partial class FormAdd : Form
    {
        [Dependency] 
        public new IUnityContainer Container { get; set; }

        public int Id { set { id = value; } }

        private readonly IStudentService service;

        private int? id;

        public FormAdd(IStudentService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            controlListBoxSelected.LoadEnumeration(new List<string> { "ПИ", "ИСЭ", "ИВТ" });
        }

        private void buttonSave_Click(object sender, EventArgs e)   
        {
            if (string.IsNullOrEmpty(controlListBoxSelected.SelectedText))
            {
                MessageBox.Show("Выберете Направление", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(controlDataTimePicker))
            {
                MessageBox.Show("Выберете Дату", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                service.AddElement(new Student
                {
                    Profile = controlListBoxSelected.SelectedText,
                    EntryDate = controlDataTimePicker
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}