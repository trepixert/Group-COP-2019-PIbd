using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace StudentControlAccounting
{
    public partial class UserNonVisualComponentMalinin : Component
    {
        public UserNonVisualComponentMalinin()
        {
            InitializeComponent();
        }

        public UserNonVisualComponentMalinin(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void SaveData<T>(IEnumerable<T> data, string path)
        {
            var attr = (DataContractAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(DataContractAttribute));

            if (attr == null)
            {
                throw new Exception("Serrialize error");
            }

            var jsonFormatter = new DataContractJsonSerializer(typeof(IEnumerable<T>));

            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, data);
            }
        }

        public IEnumerable<T> LoadData<T>(string path)
        {
            IEnumerable<T> data;

            var attr = (DataContractAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(DataContractAttribute));

            if (attr == null)
            {
                throw new Exception("Deserialize error");
            }

            var jsonFormatter = new DataContractJsonSerializer(typeof(IEnumerable<T>));

            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                data = (IEnumerable<T>)jsonFormatter.ReadObject(fs);
            }

            return data;
        }
    }
}
