using DAL.Implementations;
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

namespace FormProject
{
    public partial class FormStudents : Form
    {
        private readonly IStudentService service;
        public FormStudents(IStudentService service)
        {
            InitializeComponent();
            userControlAgliullin_Course_Field.LoadEnumeration(typeof(Course));
            this.service = service;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            string fio = FIO_Field.Text;
            string course = userControlAgliullin_Course_Field.GetSelectedText;
            Course parsedCourse = (Course) Enum.Parse(typeof(Course), course);
            double stipuha = double.Parse(Scholarship_Field.Text);
            Student student = new Student() {
                FIO = fio,
                Course = parsedCourse,
                Scholarship = stipuha
            };
            service.add(student);
            addNode(student);
        }

        public void addNode(Student student) {
            switch (student.Course) {
                case Course.Первый:
                    controlTreeView1.AddNode(student.ToString(), "/Первый/");
                    break;
                case Course.Второй:
                    controlTreeView1.AddNode(student.ToString(), "/Первый/Второй/");
                    break;
                case Course.Третий:
                    controlTreeView1.AddNode(student.ToString(), "/Первый/Второй/Третий/");
                    break;
                case Course.Четвёртый:
                    controlTreeView1.AddNode(student.ToString(), "/Первый/Второй/Третий/Четвёртый/");
                    break;
            }
        }

        public void LoadData() {
            try {
                List<Student> list = service.getAll();
                if (list != null) {
                    list.ForEach(addNode);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            controlTreeView1.AddNode("Первый", "/");
            controlTreeView1.AddNode("Второй", "/Первый/");
            controlTreeView1.AddNode("Третий", "/Первый/Второй/");
            controlTreeView1.AddNode("Четвёртый", "/Первый/Второй/Третий/");
            LoadData();
        }

        private void Button1_Click(object sender, EventArgs e) {
            userNonVisualComponenetAgliullin1.SaveData(service.getAll());
        }

        private void Button2_Click(object sender, EventArgs e) {
            //отчёт
            var list = service.getAll();
            wordReport1.Doc(list, "C:/Temp/data.doc", "Id,FIO,Course,Scholarship");
        }

        private void Button3_Click(object sender, EventArgs e) {
            //диаграмма
            List<object> newList = new List<object>();
            var list = service.getAll();
            var q = from x in list
                    group x by x.Scholarship into g
                    let count = g.Count()
                    select new { Scholarship = g.Key, Count = count };
            newList.AddRange(q);
            wordDiagram1.CreateDiagram(newList, "result", "Count", "Scholarship");
        }
    }
}
