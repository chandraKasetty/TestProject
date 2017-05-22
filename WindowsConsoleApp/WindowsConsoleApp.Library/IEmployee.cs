using System.Collections.Generic;
using System.Threading.Tasks;

namespace WindowsConsoleApp.Library
{
    public interface IEmployee
    {
        Task<List<string>> ReadEmployeeTextFileAsync(string path);

        Task<List<string>> ReadEmployeeToDeleteTextFileAsync(string path);
        Task WriteEmployeesAsync(string path, List<string> remainingEmployeeList);
    }
}