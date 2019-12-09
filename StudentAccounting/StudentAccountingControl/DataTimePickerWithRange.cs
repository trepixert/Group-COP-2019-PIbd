using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAccountingControl
{
    public partial class DataTimePickerWithRange : UserControl
    {
        public DataTimePickerWithRange()
        {
            InitializeComponent();
        }

        [Category("Спецификация"), Description("Выбранная дата")]
        public string SelectedText
        {
            get { return dateTimePicker.Value.ToShortDateString(); }
        }

        [Category("Спецификация"), Description("Дата начала")]
        public string MaxDate
        {
            set { dateTimePicker.MaxDate = DateTime.Parse(value); }
            get { return dateTimePicker.MaxDate.ToShortDateString(); }
        }

        [Category("Спецификация"), Description("Дата конца")]
        public string MinValue
        {
            set { dateTimePicker.MinDate = DateTime.Parse(value); }
            get { return dateTimePicker.MinDate.ToShortDateString(); }
        }
    }
}