using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsConsoleApp.Library;
using IO;
using Microsoft.Practices.Unity;

namespace WindowsConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            var container = UnityContainerHelper.DependencyContainer();
           
            var employeeProcesser = container.Resolve<IEmployeeProcesser>();

            Console.WriteLine("Please enter Employee text file path");
            var empPath = Console.ReadLine();

            Console.WriteLine("Please enter Employees to delete text file path");
            var empToDeletePath = Console.ReadLine();

            Console.WriteLine("Please enter remaining Employees to save text file path");
            var remainingEmployeeWritePath = Console.ReadLine();

            Console.WriteLine("Processing Employees...");

            //var path = @"C:\Users\ckase\Desktop\EmployeeFiles\";
            //empPath = path + "Employees.txt";
           // empToDeletePath = path + "EmployeesToDelete.txt";
            //remainingEmployeeWritePath = path + "RemainingEmployee.txt";

            employeeProcesser.ProcessEmployee(empPath, empToDeletePath, remainingEmployeeWritePath);

            Console.WriteLine("Processing Employees done.");
            Console.ReadLine();
        }


    }
}
