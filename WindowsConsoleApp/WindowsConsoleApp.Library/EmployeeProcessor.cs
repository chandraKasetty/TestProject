using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace WindowsConsoleApp.Library
{
    public class EmployeeProcessor : IEmployeeProcesser
    {
        private readonly IEmployee _employee;
        public EmployeeProcessor(IEmployee employee)
        {
            _employee = employee ?? throw new ArgumentNullException($"Employee parameter cannot be null");
        }

        public async Task<bool> ProcessEmployee(string employeeFilePath, string employeeToDeleteFilePath, string remaingEmployeeFilePath)
        {
            try
            {
                var employeeTask = Task.Run(() => _employee.ReadEmployeeTextFileAsync(employeeFilePath));
                var employesToDeleteTask = Task.Run(() => _employee.ReadEmployeeToDeleteTextFileAsync(employeeToDeleteFilePath));

                Task.WaitAll(employeeTask, employesToDeleteTask);

                var employees = employeeTask.Result;
                var employeesToDelete = employesToDeleteTask.Result;

                var remainingEmployeeList = employees.Except((from emp in employees
                                                              join empDel in employeesToDelete
                                                              on emp.Split(',')[0] equals empDel
                                                              select emp)).ToList();

              await   _employee.WriteEmployeesAsync(remaingEmployeeFilePath, remainingEmployeeList);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }
}