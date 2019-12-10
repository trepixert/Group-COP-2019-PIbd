using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

        public List<T> LoadObject<T>(string zipPath)
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

            string result = "";
            if (File.Exists(zipPath))
            {
                string[] json = File.ReadAllLines(zipPath);
                result = String.Concat(json);
            }
            var arrayModels = new List<T>();
            arrayModels = JsonConvert.DeserializeObject<List<T>>(result);
            return arrayModels;

        }

    }

}