using DAL.Implementations;
using DAL.Interfaces;
using DAO;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    public class EmployeeAdapterFromStudent : EmployeeService {
        private IStudentService studentService = new StudentServiceImpl(new StudentDbContext());

        public void dismissEmployee(int id) {
            throw new NotImplementedException();
        }

        public void hireEmployee(Employee employee) {
            studentService.add(new Student() {
                FIO = employee.Name,
                Scholarship = employee.Wage
            });
        }
    }
}
