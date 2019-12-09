using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FIO { get; set; }

        [DataMember]
        public string Profile { get; set; }

        [DataMember]
        public DateTime EntryDate { get; set; }
    }
}
