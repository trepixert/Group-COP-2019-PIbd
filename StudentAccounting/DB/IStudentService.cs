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

        StudentBindingModel GetElement(int id);

        void AddElement(StudentBindingModel model);

        StudentViewModel GetElementView(int id);

        void UpdateElement(StudentBindingModel model);
    }
}
