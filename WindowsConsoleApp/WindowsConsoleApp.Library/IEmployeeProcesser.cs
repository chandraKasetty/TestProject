using System.Collections.Generic;
using System.Threading.Tasks;

namespace WindowsConsoleApp.Library
{
    public interface IEmployeeProcesser
    {
        Task<bool> ProcessEmployee(string employeeFilePath, string employeeToDeleteFilePath, string remaingEmployeeFilePath);
    }
}