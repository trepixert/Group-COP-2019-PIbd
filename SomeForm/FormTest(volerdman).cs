using StudentControlAccounting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormTestProject
{
    public partial class FormTest : Form
    {
        List<Student> list;
        public FormTest()
        {
            InitializeComponent();      
            userControlDmitriev.LoadList(new List<string> { "Первый", "Второй", "Третий", "Четвертый" });
            userControlAgliullin1.AddNode("Первый курс", "/");
            userControlAgliullin1.AddNode("Бюджет", "/Первый курс/");
            userControlAgliullin1.AddNode("Группа", "/Первый курс/Бюджет/");
            userControlAgliullin1.AddNode("Второй курс", "/");
            list = new List<Student> { new Student { Group = "ПИбд-21", Course = 1, Count = 5 }, new Student { Group = "ИСЭбд-21", Course = 1, Count = 10 }, new Student { Group = "ПИбд-11", Course = 2, Count = 7 } };
        }

        private void userControlDmitriev_CheckedListBoxSelectedElementsChange(object sender, EventArgs e)
        {
            userControlDmitriev.CheckedValue.ForEach(element => MessageBox.Show(element));
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            userControlDmitriev.CheckedIndex = new List<int> { 3 };
        }

        private void FormTest_Load(object sender, EventArgs e)
        {

        }

        private void диаграммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userNonVisualComponentAgliullin1.CreateWord(list,"Student", "Group", "Count", @"C:\Users\user\Desktop\diagram");

            MessageBox.Show("Успешно", " Диаграмма", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userNonVisualControlMalinin1.SetHeaders(new List<string> { "1 курс", "2 курс", "3 курс" });
            userNonVisualControlMalinin1.SetValues(new List<List<string>> {
                new List<string> { "ПИбд-11", "ИСЭбд-21", "ПИбд-31"},
                new List<string> { "Пибд-12", "ПИбд-21", ""},
                new List<string> { "ИСЭбд-11", "", "ИСЭбд-31"} });
            userNonVisualControlMalinin1.SetStringConcatenation(new List<int[]> {
                new int[] { 0, 2, 2},
                new int[] { 1, 1, 2}});
            userNonVisualControlMalinin1.Export(@"C:\Users\user\Desktop\report.pdf");
            MessageBox.Show("Успешно", " Отчет", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                userNonVisualControlDmitriev1.LoadObject<Student>(@".\Student.json");
                MessageBox.Show("Успешно", " BackUp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch {
                MessageBox.Show("Ошибка", " BackUp", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
