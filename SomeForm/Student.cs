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
        public String Email { get; set; }

        public DateTime Date { get; set; }

        public Student(String name, String surname, String email) {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
        }

        public Student(String name, String surname, String email, DateTime date)
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Date = date;
        }
    }
}
