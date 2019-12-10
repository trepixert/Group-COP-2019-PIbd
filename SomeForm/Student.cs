using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FormTestProject
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public String Group { get; set; }
        [DataMember]
        public int Course { get; set; }
        [DataMember]
        public int Count { get; set; }

    }
}