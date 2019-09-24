using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentControlAccounting
{
    public partial class userNonVisualComponenetAgliullin : Component
    {
        public userNonVisualComponenetAgliullin()
        {
            InitializeComponent();
        }

        public userNonVisualComponenetAgliullin(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


        public void SaveData<T>(List<T> data)
        {
            
            foreach(var temp in data)
            {
                var typeTemp = temp.GetType().CustomAttributes;
                if (typeTemp.Count() == 0)
                {
                    MessageBox.Show("Не указаны аттрибуты");
                    return;
                }
                foreach (var t in typeTemp)
                {
                    if(!(t.AttributeType.Name.Equals("DataContractAttribute"))){
                        MessageBox.Show("Объект не поддерживает json сериализацию!");
                        return;
                    }
                }

            }
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream("C:/Temp/data.json", FileMode.OpenOrCreate))
            {
                jsonSerializer.WriteObject(fs, data);
            }
        }
    }
}
