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

        private readonly StudentServiceDB service;

        public FormAdd(StudentServiceDB service)
        {
            InitializeComponent();
            this.service = service;

            var products = new List<string> { "ПИ", "ИВТ", "ИСЭ", "ИСТ" };
            checkedListBox1.LoadList(products);
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            var newStudent = new StudentBindingModel
            {
                FIO = textBox1.Text,
                Profiles = string.Join(", ", checkedListBox1.CheckedValue),
                EntryDate = dataTimePicker1.SelectedText
            };

            service.AddElement(newStudent);
        }
    }
}
