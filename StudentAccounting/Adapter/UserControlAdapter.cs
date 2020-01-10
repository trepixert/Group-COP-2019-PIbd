using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adapter {
    public partial class UserControlAdapter : UserControl {
        public UserControlAdapter() {
            InitializeComponent();
        }

        public string FIO {
            get {
                return textBox1.Text;
            }
        }

        public int Wage {
            get {
                return controlTextBoxInput1.TextBoxValue.GetValueOrDefault(0);
            }
        }
    }
}
