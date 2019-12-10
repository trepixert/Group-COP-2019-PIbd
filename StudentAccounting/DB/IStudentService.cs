using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public interface IStudentService
    {
        List<StudentViewModel> GetList();

        StudentViewModel GetElement(int id);

        void AddElement(StudentBindingModel model);
    }
}
