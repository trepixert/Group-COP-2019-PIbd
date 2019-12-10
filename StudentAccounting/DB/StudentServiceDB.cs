using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;

namespace DB
{
    public class StudentServiceDB : IStudentService
    {
        private readonly AbstractDbContext context;

        public StudentServiceDB(AbstractDbContext context)
        {
            this.context = context;
        }


        public List<StudentViewModel> GetList()
        {
            return context.Students.Select(rec => new StudentViewModel
            {
                FIO = rec.FIO,
                EntryDate = SqlFunctions.DateName("dd", rec.EntryDate) + " " +
                             SqlFunctions.DateName("mm", rec.EntryDate) +
                             " " + SqlFunctions.DateName("yyyy", rec.EntryDate),
                Profiles = rec.Profile
            }).ToList();
        }

        public StudentViewModel GetElement(int id)
        {
            var student = context.Students.FirstOrDefault(rec => rec.Id == id);

            if (student == null) throw new Exception("Студент не найден");

            return new StudentViewModel
            {
                FIO = student.FIO,
                EntryDate = SqlFunctions.DateName("dd", student.EntryDate) + " " +
                             SqlFunctions.DateName("mm", student.EntryDate) +
                             " " + SqlFunctions.DateName("yyyy", student.EntryDate),
              
                Profiles = student.Profile
            };
        }

        public void AddElement(StudentBindingModel model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.Students.Add(new Student
                    {
                        FIO = model.FIO,
                        Profile = model.Profiles,
                        EntryDate = model.EntryDate
                    });

                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
