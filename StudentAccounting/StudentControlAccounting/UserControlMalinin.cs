using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentControlAccounting
{
    public partial class UserControlMalinin : UserControl
    {
        public UserControlMalinin()
        {
            InitializeComponent();
        }

        public void LoadResults(List<object> list)
        {
            if (list != null)
            {
                listBox.DataSource = list;
            }
        }
    }
}
