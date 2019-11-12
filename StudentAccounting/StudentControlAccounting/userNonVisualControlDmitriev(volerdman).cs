using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

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

        public T LoadObject<T>(string zipPath)
        {
            string path = "";
            using (ZipArchive archive = ZipFile.OpenRead(zipPath))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                    {
                        path = Path.GetFullPath(Path.Combine(zipPath, entry.FullName));
                    }
                }
            }
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(path)))
            {
                DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(T));
                T Test = (T)deserializer.ReadObject(ms);
                var type = Test.GetType();
                var attr = (DataContractAttribute)Attribute.GetCustomAttribute(type, typeof(DataContractAttribute));
                if (attr == null)
                {
                    throw new Exception("Дессериализация класса невозможна");
                }
                return Test;
            }
        }
    }
}
