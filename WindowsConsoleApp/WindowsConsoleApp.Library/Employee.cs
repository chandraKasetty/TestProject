using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using IO;

namespace WindowsConsoleApp.Library
{
    public class Employee : IEmployee
    {
        private readonly IFileSystemHelper _fileSystemHelper;
        public Employee(IFileSystemHelper fileSystemHelper)
        {
            _fileSystemHelper = fileSystemHelper ?? throw new ArgumentNullException(
                                    $"Argument fileSystemHelper cannot be null.");
        }
        public async Task<List<string>> ReadEmployeeTextFileAsync(string path)
        {
            return await _fileSystemHelper.ReadAllFileLinesAsync(path);
        }


        public async Task<List<string>> ReadEmployeeToDeleteTextFileAsync(string path)
        {
            return await _fileSystemHelper.ReadAllFileLinesAsync(path);
        }

        public async Task WriteEmployeesAsync(string path, List<string> remainingEmployeeList)
        {
            await _fileSystemHelper.WriteAllLinesToFile(path, remainingEmployeeList);
        }
    }
}
