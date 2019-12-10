using Newtonsoft.Json;
using StudentControlAccounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FormTestProject.FormTest;

namespace FormTestProject
{
    public partial class FormTest2 : Form
    {
        public FormTest2()
        {
            InitializeComponent();
        }

        [DataContract]
        public class TestClass
        {
            [DataMember]
            public string FIO { get; set; }
            [DataMember]
            public string Profile { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var list = new List<Test> { new Test { FIO = "Дмитриев Валерий", Profile = "ПИ", Date = "10.07.2019" }, new Test { FIO = "Андреев Леонид", Profile = "ПИ", Date = "15.06.2019" } };
            wordReport1.Doc(list, "D:\\report.doc", "FIO,Profile,Date");
            MessageBox.Show("Сохранение прошло успешно");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            componentExportDiagram1.SetCaptions(new List<string> { "Дмитриев", "Андреев", "Малинин", "Аглиуллин" });
            componentExportDiagram1.SetValues(new List<int> { 24, 7, 2, 15 });
            componentExportDiagram1.Export("D:\\diagram.xls");
            MessageBox.Show("Сохранение прошло успешно");
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            var a = new List<TestClass> { new TestClass { FIO = "Дмитриев", Profile = "ПИ" }, new TestClass { FIO = "Андреев", Profile = "ПИ" } } ;
            jsonStoreComponent.SaveData(a, "D:\\test.json");
            MessageBox.Show("Сохранение прошло успешно");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            jsonStoreComponent.LoadData<TestClass>("D:\\test.json");
            MessageBox.Show("Десериализация успешна");

        }
    }
}