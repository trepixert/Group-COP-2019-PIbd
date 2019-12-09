using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class StudentServiceDB
    {
        private AbstractDbContext context;

        public StudentServiceDB(AbstractDbContext context)
        {
            this.context = context;
        }

        public List<Student> GetList()
        {
            return context.Students.ToList();
        }

        public void AddElement(Student model)
        {
            context.Students.Add(new Student
            {
                FIO = model.FIO,
                Profile = model.Profile,
                EntryDate = model.EntryDate
            });
            context.SaveChanges();
        }

        public Student GetElement(int id)
        {
            Student element = context.Students.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new Student
                {
                    Id = element.Id,
                    FIO = element.FIO,
                    Profile = element.Profile,
                    EntryDate = element.EntryDate
                };
            }
            throw new Exception("Элемент не найден");
        }


    }
}