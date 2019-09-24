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

        public string FieldType {
            get;set;
        }
        public UserControlMalinin()
        {
            InitializeComponent();
        }

        public void LoadResults(List<object> list)
        {
            List<string> strlist = new List<string>();
            foreach(var obj in list)
            {
                string outstr = "";
                var filtredProp = obj.GetType().GetProperties().Where((x) => FieldType.Split(' ').Contains(x.Name));
                foreach(var x in filtredProp)
                {
                    outstr += " " + x.GetValue(obj).ToString();
                }
                strlist.Add(outstr);
            }
            listBox.Items.AddRange(strlist.ToArray());
        }
    }
}
