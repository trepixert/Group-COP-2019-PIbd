using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    public interface EmployeeService {
        void hireEmployee(Employee employee);

        void dismissEmployee(int id);
    }
}
