using DAL.Interfaces;
using DAO;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Implementations {
    public class StudentServiceImpl : IStudentService {
        private readonly StudentDbContext context;
        
        public StudentServiceImpl(StudentDbContext context) {
            this.context = context;
        }

        public void add(Student student) {
            using(var transaction = context.Database.BeginTransaction()) {
                try {
                    this.context.Students.Add(student);
                    this.context.SaveChanges();
                    transaction.Commit();
                } catch(Exception e) {
                    transaction.Rollback();
                }
            }
        }


        public List<Student> getAll() {
            return this.context.Students.ToList();
        }
    }
}
