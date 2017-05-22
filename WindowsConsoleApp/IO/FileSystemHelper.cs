using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class FileSystemHelper : IFileSystemHelper
    {


        public async Task<List<string>> ReadAllFileLinesAsync(string path)
        {
            var lines = new List<string>();

            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))

            using (var reader = new StreamReader(stream))
            {
                string line;

                while ((line = await reader.ReadLineAsync()) != null)
                {
                    lines.Add(line);
                }
            }

            return lines;
        }

        public async Task WriteAllLinesToFile(string path, List<string> contents)
        {
            File.WriteAllLines(path, contents);
            await Task.Run(() => File.WriteAllText(path, string.Join(Environment.NewLine, contents)));
        }

        //public async Task WriteAllLinesToFile(string file, List<string> lines)
        //{
        //    if (File.Exists(file))
        //        File.Delete(file);


        //    try
        //    {
        //        using (var writer = File.OpenWrite(file))
        //        {
        //            using (var streamWriter = new StreamWriter(writer))
        //                foreach (var line in lines)
        //                    await streamWriter.WriteLineAsync(line);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }
            
        //}
    }
}
