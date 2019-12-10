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
    public partial class CheckedListBox : UserControl
    {
        private List<int> _checkedIndeces;

        /// <summary>
        /// Событие выбора элемента из списка
        /// </summary>
        private event EventHandler _checkedListBox1SelectedElementChoose;

        /// <summary>
        /// Порядковые номера отмеченных элементов
        /// </summary>
        [Category("Спецификация"), Description("Порядковые номера отмеченных элементов")]
        public List<int> CheckedIndeces
        {
            get { return _checkedIndeces; }
            set
            {
                checkedListBox1.ClearSelected();
                if (value == null) return;
                for (int i = 0; i < value.Count; i++)
                {
                    if (value[i] > -1 && value[i] <= checkedListBox1.Items.Count)
                    {
                        checkedListBox1.SetItemChecked(value[i], true);
                    }
                }
                _checkedIndeces = value;
            }
        }

        /// <summary>
        /// Текст отмеченных записей
        /// </summary>
        [Category("Спецификация"), Description("Текст выбранной записи")]
        public List<string> CheckedValue
        {
            get
            {
                List<string> list = new List<string>();
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    list.Add(checkedListBox1.CheckedItems[i].ToString());
                }
                return list;
            }
        }

        /// <summary>
        /// Событие отметки элемента из списка
        /// </summary>
        [Category("Спецификация"), Description("Событие отметки элемента из списка")]
        public event EventHandler CheckedListBoxSelectedElementChoose
        {
            add { _checkedListBox1SelectedElementChoose += value; }
            remove { _checkedListBox1SelectedElementChoose -= value; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public CheckedListBox()
        {
            InitializeComponent();
            checkedListBox1.ItemCheck += (sender, e) => {
                _checkedListBox1SelectedElementChoose?.Invoke(sender, e);
            };
        }

        /// <summary>
        /// Заполнение списка значениями из листа
        /// </summary>
        /// <param name="type">тип-справочник</param>
        public void LoadList(List<string> elements)
        {
            elements.ForEach(element => checkedListBox1.Items.Add(element));
        }
    }
}
