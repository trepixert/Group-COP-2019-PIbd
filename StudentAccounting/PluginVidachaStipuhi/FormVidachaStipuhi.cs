using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginVidachaStipuhi {
    public partial class FormVidachaStipuhi : Form {
        private readonly IStudentService service;
        public FormVidachaStipuhi(IStudentService service) {
            InitializeComponent();
            this.service = service;
        }

        public int StudentId { get; internal set; }

        private void Button1_Click(object sender, EventArgs e) {
            //update
            var value = controlTextBoxInput1.TextBoxValue;
            service.update(StudentId, value.GetValueOrDefault(0));
            MessageBox.Show("Сохранение прошло успешно", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Button2_Click(object sender, EventArgs e) {
            //cancel
            Close();
        }
    }
}
