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
    public partial class UserControlDmitriev : UserControl
    {
        /// <summary>
        /// Порядковые номера выбранных элементов
        /// </summary>
        private List<int> _checkedIndex;

        /// <summary>
        /// Событие выбора элемента из списка
        /// </summary>
        private event EventHandler _checkedListBoxSelectedElementChange;

        /// <summary>
        /// Порядковые номера отмеченных элементов
        /// </summary>
        [Category("Спецификация"), Description("Порядковые номера выбранных элементов")]
        public List<int> CheckedIndex
        {
            get { return _checkedIndex; }
            set
            {
                checkedListBox.ClearSelected();
                if (value == null) return;
                for (int i = 0; i < value.Count; i++)
                {
                    if (value[i] > -1 && value[i] <= checkedListBox.Items.Count)
                    {
                        checkedListBox.SetItemChecked(value[i], true);
                    }
                }
                _checkedIndex = value;
            }
        }

        /// <summary>
        /// Текст выбранных записей
        /// </summary>
        [Category("Спецификация"), Description("Текст выбранной записи")]
        public List<string> CheckedValue
        {
            get
            {
                List<string> list = new List<string>();
                for (int i = 0; i < checkedListBox.CheckedItems.Count; i++)
                {
                    list.Add(checkedListBox.CheckedItems[i].ToString());
                }
                return list;
            }
        }

        /// <summary>
        /// Событие выбора элемента из списка
        /// </summary>
        [Category("Спецификация"), Description("Событие выбора элемента из списка")]
        public event EventHandler CheckedListBoxSelectedElementChange
        {
            add { _checkedListBoxSelectedElementChange += value; }
            remove { _checkedListBoxSelectedElementChange -= value; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public UserControlDmitriev()
        {
            InitializeComponent();
            checkedListBox.SelectedIndexChanged += (sender, e) => {
                _checkedListBoxSelectedElementChange?.Invoke(sender, e);
            };
        }

        /// <summary>
        /// Заполнение списка значениями из справочника
        /// </summary>
        /// <param name="type">тип-справочник</param>
        public void LoadList(List<string> elements)
        {
            elements.ForEach(element => checkedListBox.Items.Add(element));
        }   
    }
}
