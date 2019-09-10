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
    public partial class UserControlAgliullin : UserControl
    {
        private Array arrays;
        public UserControlAgliullin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Getting selected text from comboBox
        /// </summary>
        public string GetSelectedText
        {
            get { return comboBoxCourse.Text; }
        }

        public int GetSelectedNumber
        {
            get {
               return (int)arrays.GetValue(comboBoxCourse.SelectedIndex);
            }
        }

 
        /// <summary>
        /// Loading values to comboBox
        /// </summary>
        /// <param name="type">Type of some enumeration</param>
        public void LoadEnumeration(Type type)
        {
            arrays = Enum.GetValues(type);
            foreach (var elem in Enum.GetValues(type))
            {
                comboBoxCourse.Items.Add(elem);
            }
        }

    }
}
