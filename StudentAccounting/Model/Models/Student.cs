using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model.Models
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FIO { get; set; }
        [DataMember]
        public Course Course { get; set; }
        [DataMember]
        public double Scholarship { get; set; }

        public override string ToString() {
            return string.Format("ФИО: {0} Стипуха: {1}", FIO, Scholarship);
        }
    }
}
