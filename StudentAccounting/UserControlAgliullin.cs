using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAccounting
{
    public partial class UserControlAgliullin : UserControl
    {
        public UserControlAgliullin()
        {
            InitializeComponent();
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void LoadEnumeration(Type type)
        {
            comboBoxCourse.Items.Add("Hello");
        }
    }
}
