using System;
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
        public class Test
        {
            public string FIO;

            public string Profile;

            public string Date;
        }

        public FormTest()
        {
            InitializeComponent();
            userControlMalinin.LoadEnumeration(new List<string> { "one", "two", "three" });
        }

        private void userControlMalinin_ListBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(userControlMalinin.SelectedText);
        }

        private void Button_TestThree_Click(object sender, EventArgs e)
        {
            userControlMalinin.SelectedIndex = 0;
        }

        private void userControlDmitriev_Load(object sender, EventArgs e)
        {
            var list = new List<Test> { new Test { FIO = "Дмитриев Валерий", Profile = "ПИ", Date = "10.07.2019" }, new Test { FIO = "Андреев Леонид", Profile = "ПИ", Date = "15.06.2019" } };
            userControlDmitriev.AddData(list, "FIO,Profile,Date");
        }
        
        private void ButtonVvod_Click(object sender, EventArgs e)
        {
            int? sum = userControlAgliullin.TextBoxValue;

            if (userControlAgliullin.IsChecked)
            {
                MessageBox.Show("Выбрано значение null");
            }
            else
            {
                if (sum.HasValue)
                {
                    if (sum != -1)
                    {
                        MessageBox.Show("Введено значение: " + sum.Value);
                    }
                    else
                    {
                        MessageBox.Show("Некорректное значение");
                    }
                }
                else
                {
                    userControlAgliullin.IsChecked = true;
                }
            }
        }        
    }
}
