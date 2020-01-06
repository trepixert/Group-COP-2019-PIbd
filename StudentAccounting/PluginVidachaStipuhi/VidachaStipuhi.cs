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

namespace PluginVidachaStipuhi
{
    [Export(typeof(IPlugin))]
    public class VidachaStipuhi : IPlugin {
        public string Name => "Выдача стипухи";

        public void run(int id) {
            var container = BuildUnityContainer();
            var form = container.Resolve<FormVidachaStipuhi>();
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
