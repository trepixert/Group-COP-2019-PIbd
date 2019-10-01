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
        private int _selectedIndex;

        private event EventHandler _listBoxSelectedElementChange;

        public UserControlMalinin()
        {
            InitializeComponent();
            listBox.SelectedIndexChanged += (sender, e) => {_listBoxSelectedElementChange?.Invoke(sender, e);};
        }

        [Category("Спецификация"), Description("Порядковый номер выбранного элемента")]
        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                if (value > -2 && value < listBox.Items.Count)
                {
                    _selectedIndex = value;
                    listBox.SelectedIndex = _selectedIndex;
                }
            }
        }

        [Category("Спецификация"), Description("Текст выбранной записи")]
        public string SelectedText
        {
            get { return listBox.Text; }
        }

        [Category("Спецификация"), Description("Событие выбора элемента из списка")]
        public event EventHandler ListBoxSelectedElementChange
        {
            add { _listBoxSelectedElementChange += value; }
            remove { _listBoxSelectedElementChange -= value; }
        }

        public void LoadEnumeration(List<string> elements)
        {
            elements.ForEach(element => listBox.Items.Add(element));
        }
    }
}