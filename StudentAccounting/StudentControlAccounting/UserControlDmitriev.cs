﻿using System;
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
        public UserControlDmitriev()
        {
            InitializeComponent();
        }

        public void LoadData(List<object> list)
        {
            if (list != null)
            {
                dataGridView.DataSource = list;
            }
        }
    }
}
