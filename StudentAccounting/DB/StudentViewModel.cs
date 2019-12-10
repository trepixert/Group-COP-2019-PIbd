using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        public string FIO { get; set; }

        public string EntryDate { get; set; }

        public string Profiles { get; set; }
    }
}
