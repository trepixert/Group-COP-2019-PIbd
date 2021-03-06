﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTestProject
{
    public partial class FormTest : Form
    {


        public FormTest()
        {
            InitializeComponent();
            userControlAgliullin.LoadEnumeration(typeof(Enumeration));
        }

        private void ButtonTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.IsNullOrEmpty(userControlAgliullin.GetSelectedText)?
                "Need to choose some of variant"
                :
                "You have choosed: " + userControlAgliullin.GetSelectedNumber);
        }

        private void Button_TestTwo_Click(object sender, EventArgs e)
        {
            userControlDmitriev.GetEmail();
        }

        private void Button_TestThree_Click(object sender, EventArgs e)
        {
            userControlMalinin.LoadResults(new List<object> { "one", "two" });
        }

        private void Test_button_backup_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>
            {
                new Student("lul", "lu", "l")
            };
            userNonVisualComponenetAgliullin.SaveData(students);
        }

        private void ReportToExcel_Button_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>() {
                new Student("Ramis","Agliullin","pixert@mail.ru"),
                new Student("la","lala","lalala")
            };
            userNonVisualComponentDmitriev1.CreateExcelReport(students,"C:\\Users\\Ramis\\Documents",false);
        }

        private void PdfReport_Button_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>() {
                new Student("Ramis","Agliullin","pixert@mail.ru", new DateTime(2014,5,1)),
                new Student("la","lala","lalala",new DateTime(2014,5,1)),
                new Student("la","lala","lalala",new DateTime(2017,8,9))
            };
            userNonVisualComponentMalinin1.CreateDiagram(students, @"C:\\Temp\\diagram.pdf");
        }
    }
}
