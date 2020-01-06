using DAL.Interfaces;
using Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginChangeCourse {
    public partial class FormChangeCourse : Form {
        public int StudentId { set; get; }
        private readonly IStudentService service;
        public FormChangeCourse(IStudentService service) {
            InitializeComponent();
            this.service = service;
            userControlAgliullin1.LoadEnumeration(typeof(Course));
        }

        private void Button2_Click(object sender, EventArgs e) {
            //cansel
            Close();
        }

        private void Button1_Click(object sender, EventArgs e) {
            //update
            Course newCourse = (Course) Enum.Parse(typeof(Course), userControlAgliullin1.GetSelectedText);
            service.update(StudentId, newCourse);
            MessageBox.Show("Сохранение прошло успешно", "Сообщение",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
