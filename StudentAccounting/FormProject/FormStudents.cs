using Adapter;
using DAL.Implementations;
using DAL.Interfaces;
using Model.Models;
using PluginInterface;
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

        private PluginManager pluginManager;

        private List<IPlugin> plugins;

        private EmployeeService adapter;
        public FormStudents(IStudentService service)
        {
            InitializeComponent();
            userControlAgliullin_Course_Field.LoadEnumeration(typeof(Course));
            this.service = service;
            adapter = new EmployeeAdapterFromStudent();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            string fio = fio_field.Text;
            string course = userControlAgliullin_Course_Field.GetSelectedText;
            Course parsedCourse = (Course) Enum.Parse(typeof(Course), course);
            var stipihaFromText = controlTextBoxInput1.TextBoxValue;
            double stipuha = stipihaFromText.GetValueOrDefault(0);
            Student student = new Student() {
                FIO = fio,
                Course = parsedCourse,
                Scholarship = stipuha
            };
            service.add(student);
            LoadData();
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
                default:
                    Employee employee = new Employee() {
                        Name = student.FIO,
                        Wage = student.Scholarship
                    };
                    controlTreeView1.AddNode(employee.ToString(), "/Первый/Второй/Третий/Четвёртый/Сотрудники/");
                    break;
            }
        }

        public void LoadData() {
            try {
                controlTreeView1.Clear();
                controlTreeView1.AddNode("Первый", "/");
                controlTreeView1.AddNode("Второй", "/Первый/");
                controlTreeView1.AddNode("Третий", "/Первый/Второй/");
                controlTreeView1.AddNode("Четвёртый", "/Первый/Второй/Третий/");
                controlTreeView1.AddNode("Сотрудники", "/Первый/Второй/Третий/Четвёртый/");
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
            pluginManager = new PluginManager();
            plugins = pluginManager.Plugins.ToList();
            foreach (var plugin in plugins) {
                listBox1.Items.Add(plugin.Name);
            }
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

        private void Button4_Click(object sender, EventArgs e) {
            //plugin 
            //TODO: сделать получение ID
            var studentId = controlTreeView1.SelectedId;
            var pluginIndex = listBox1.SelectedIndex;

            if (studentId != -1 && pluginIndex != -1) {
                plugins[pluginIndex].run(studentId);
            }
            LoadData();
        }

        private void Button5_Click(object sender, EventArgs e) {
            //ADD
            var studentId = controlTreeView1.SelectedId;
            Student student = service.getOneById(studentId);
            controlTreeView2.AddNode(student.ToString() + " " + userControlAbstractFactory1.GetString, "/");
        }

        private void Button6_Click(object sender, EventArgs e) {
            //employee
            string FIO = userControlAdapter1.FIO;
            int wage = userControlAdapter1.Wage;

            adapter.hireEmployee(new Employee() {
                Name = FIO,
                Wage = wage
            });
            LoadData();
        }
    }
}
