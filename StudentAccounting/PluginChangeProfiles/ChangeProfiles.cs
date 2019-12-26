using DB;
using Plugins;
using System.ComponentModel.Composition;
using Unity;
using Unity.Lifetime;

namespace PluginChangeProfiles
{
    [Export(typeof(IPlugin))]
    public class ChangeProducts : IPlugin
    {
        public string Name => "Изменение списка направлений";

        public void Run(int id)
        {
            var container = BuildUnityContainer();
            var form = container.Resolve<FormChangeProfiles>();
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
