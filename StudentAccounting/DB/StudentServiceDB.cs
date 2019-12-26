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
        private readonly AbstractDBContext context;

        public StudentServiceDB(AbstractDBContext context)
        {
            this.context = context;
        }


        public List<StudentViewModel> GetList()
        {
            return context.Students.Select(rec => new StudentViewModel
            {
                Id = rec.Id,
                FIO = rec.FIO,
                EntryDate = SqlFunctions.DateName("dd", rec.EntryDate) + " " +
                             SqlFunctions.DateName("mm", rec.EntryDate) +
                             " " + SqlFunctions.DateName("yyyy", rec.EntryDate),
                Profiles = rec.Profile
            }).ToList();
        }

        public StudentBindingModel GetElement(int id)
        {
            var student = context.Students.FirstOrDefault(rec => rec.Id == id);

            if (student == null) throw new Exception("Студент не найден");

            return new StudentBindingModel
            {
                Id = student.Id,
                FIO = student.FIO,
                EntryDate = student.EntryDate,
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
        public void UpdateElement(StudentBindingModel model)
        {
            var student = context.Students.FirstOrDefault(ord => ord.Id == model.Id);

            if (student == null)
            {
                throw new Exception("Студент не найден");
            }
            student.Profile = model.Profiles;
            student.EntryDate = model.EntryDate;

            context.SaveChanges();
        }

        public StudentViewModel GetElementView(int id)
        {
            var element = context.Students.FirstOrDefault(rec => rec.Id == id);

            if (element != null)
            {
                return new StudentViewModel
                {
                    FIO = element.FIO,
                    Profiles = element.Profile,
                    EntryDate = element.EntryDate
                };
            }
            throw new Exception("Элемент не найден");
        }
    }
}
