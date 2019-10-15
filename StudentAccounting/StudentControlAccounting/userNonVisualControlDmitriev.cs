using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
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

        public static Student[] Deserialize(string file)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Student[]));
            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                return (Student[])jsonFormatter.ReadObject(fs);
            }
        }
    }
}
