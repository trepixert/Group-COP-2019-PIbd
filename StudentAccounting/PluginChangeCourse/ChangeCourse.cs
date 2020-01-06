using DAL.Implementations;
using DAL.Interfaces;
using PluginInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace PluginChangeCourse {
    [Export(typeof(IPlugin))]
    public class ChangeCourse : IPlugin {
        public string Name => "Изменение курса";

        public void run(int id) {
            var container = BuildUnityContainer();
            var form = container.Resolve<FormChangeCourse>();
            form.StudentId = id;
            form.Show();
        }

        public static IUnityContainer BuildUnityContainer() {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IStudentService, StudentServiceImpl>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
