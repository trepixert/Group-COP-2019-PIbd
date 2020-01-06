using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IStudentService
    {
        void add(Student student);
        List<Student> getAll();
    }
}
