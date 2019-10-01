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
    }
}
