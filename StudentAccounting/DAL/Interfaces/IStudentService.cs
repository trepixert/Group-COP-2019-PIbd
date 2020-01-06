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
        void update(int studentId, Course course);
        List<Student> getAll();
        void update(int studentId, int value);

        Student getOneById(int id);
    }
}
