using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormTestProject
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
            userControlDmitriev.LoadList(new List<string> { "Первый", "Второй", "Третий", "Четвертый" });
        }

        private void userControlDmitriev_CheckedListBoxSelectedElementsChange(object sender, EventArgs e)
        {
            userControlDmitriev.CheckedValue.ForEach(element => MessageBox.Show(element));
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            userControlDmitriev.CheckedIndex = new List<int> { 3 };
        }
    }
}
