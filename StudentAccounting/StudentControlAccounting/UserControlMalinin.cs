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
        public Color DangerColor { get; set; }
        public Color AcceptColor { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public UserControlMalinin()
        {
            InitializeComponent();
            DangerColor = Color.Red;
            AcceptColor = Color.Green;
        }

        /// <summary>
        /// Начальная дата
        /// </summary>
        /// <returns>Возвращает начальную дату</returns>
        public DateTime StartDate()
        {
            return dateTimePickerStart.Value;
        }

        /// <summary>
        /// Конечная дата
        /// </summary>
        /// <returns>возвращает конечную дату</returns>
        public DateTime EndDate()
        {
            return dateTimePickerEnd.Value;
        }
    }
}
