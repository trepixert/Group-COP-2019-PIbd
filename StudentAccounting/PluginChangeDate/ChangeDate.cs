using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using System.ComponentModel.Composition;
using DB;
using Unity.Lifetime;
using Plugins;

namespace PluginChangeDate
{
    [Export(typeof(IPlugin))]
    public class ChangeDate : IPlugin
    {
        public string Name => "Изменение даты зачисления";
        public void Run(int id)
        {
            var container = BuildUnityContainer();
            var form = container.Resolve<FormChangeDate>();
            form.StudentId = id;
            form.Show();
        }

        public static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IStudentService, StudentServiceDB>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
