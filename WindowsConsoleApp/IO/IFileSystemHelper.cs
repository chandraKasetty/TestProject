using System.Collections.Generic;
using System.Threading.Tasks;

namespace IO
{
    public interface IFileSystemHelper
    {
        Task<List<string>> ReadAllFileLinesAsync(string path);
        Task WriteAllLinesToFile(string path, List<string> contents);
    }
}