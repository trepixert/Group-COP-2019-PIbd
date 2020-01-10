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

        /** 
         * TODO: 1 препод - 1 студент
         * Диссертация, диплом и кандидатская
         * 1 абстрактная - 3 реализации
         * 2 интерфейса - ??? то есть поведение --- нужно состояние - придумать!!!
         * универ, колледж
         */

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

        public void update(int studentId, Course course) {
            var student = this.context.Students.FirstOrDefault(rec => rec.Id == studentId);
            if(student != null) {
                student.Course = course;
                this.context.SaveChanges();
                return;
            }
            throw new Exception("Студент не найден");

        }


        public List<Student> getAll() {
            return this.context.Students.ToList();
        }

        public void update(int studentId, int value) {
            var student = this.context.Students.FirstOrDefault(rec => rec.Id == studentId);
            if (student != null) {
                student.Scholarship = value;
                this.context.SaveChanges();
                return;
            }
            throw new Exception("Студент не найден");
        }

        public Student getOneById(int id) {
            return this.context.Students.FirstOrDefault(rec => rec.Id == id);
        }
    }
}
