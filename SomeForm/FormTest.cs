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
        public FormTest()
        {
            InitializeComponent();
            userControlAgliullin1.LoadEnumeration(typeof(Enumeration));
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have choosed: " + userControlAgliullin1.GetSelectedNumber);
        }
    }
}
