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

        /// <summary>
        /// Конструктор
        /// </summary>
        public UserControlMalinin()
        {
            InitializeComponent();
        }

        [Category("Спецификация"), Description("Выбранная дата")]
        public string SelectedText
        {
            get { return dateTimePicker.Value.ToShortDateString(); }
        }

        [Category("Спецификация"), Description("Дата начала")]
        public DateTime MaxDate
        {
            set { dateTimePicker.MaxDate = DateTime.MaxValue; }
            get { return dateTimePicker.MaxDate; }
        }

        [Category("Спецификация"), Description("Дата конца")]
        public DateTime MinValue
        {
            set { dateTimePicker.MinDate = DateTime.MinValue; }
            get { return dateTimePicker.MinDate; }
        }
    }
}
