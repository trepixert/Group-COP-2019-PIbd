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
        public String Name { get; set; }
        [DataMember]
        public String Surname { get; set; }
        [DataMember]
        public String FatherName { get; set; }

        public Student(String name, String surname, String fatherName)
        {
            this.Name = name;
            this.Surname = surname;
            this.FatherName = fatherName;
        }
    }
}