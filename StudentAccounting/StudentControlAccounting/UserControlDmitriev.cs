using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StudentControlAccounting
{
    public partial class UserControlDmitriev : UserControl
    {
        public Color DangerColor { get; set; }
        public Color AcceptColor { get; set; }

        public String Mail { get; }

        string pattern = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";

        public UserControlDmitriev()
        {
            InitializeComponent();
            toolTip.SetToolTip(textBoxEmail, "For example com@com.ru");
            DangerColor = Color.Red;
            AcceptColor = Color.Green;
        }

        public String GetEmail()
        {
            if (Regex.IsMatch(textBoxEmail.Text, pattern))
            {
                textBoxEmail.BackColor = AcceptColor;
                return textBoxEmail.Text;
            }
            else
            {
                textBoxEmail.BackColor = DangerColor;
                return null;
            }
        }

    }
}
