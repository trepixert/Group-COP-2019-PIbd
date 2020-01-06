using DAL.Implementations;
using DAL.Interfaces;
using DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace FormProject
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormStudents>());
        }

        public static IUnityContainer BuildUnityContainer() {
            var currentContainer = new UnityContainer();

            currentContainer.RegisterType<DbContext, StudentDbContext>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<IStudentService, StudentServiceImpl>(new HierarchicalLifetimeManager());

            return currentContainer;
        }
    }
}
