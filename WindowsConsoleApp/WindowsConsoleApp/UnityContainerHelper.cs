using WindowsConsoleApp.Library;
using IO;
using Microsoft.Practices.Unity;

namespace WindowsConsoleApp
{
    public static class UnityContainerHelper
    {

        public static UnityContainer DependencyContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IEmployee, Employee>();
            container.RegisterType<IFileSystemHelper, FileSystemHelper>();
            container.RegisterType<IEmployeeProcesser, EmployeeProcessor>();
            return container;
        }
    }
}