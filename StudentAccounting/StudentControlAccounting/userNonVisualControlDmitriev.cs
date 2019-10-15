using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentControlAccounting
{
    public partial class userNonVisualControlDmitriev : Component
    {
        public userNonVisualControlDmitriev()
        {
            InitializeComponent();
        }

        public userNonVisualControlDmitriev(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
