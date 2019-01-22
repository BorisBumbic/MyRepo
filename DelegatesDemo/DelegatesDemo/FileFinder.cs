using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DelegatesDemo
{
    class FileFinder
    {
        public void FindFiles(string dirPath, Func<string, bool> filter)
        {
            var filePaths = Directory.GetFiles(dirPath);

            foreach (var path in filePaths)
            {
                if (filter(path))
                Console.WriteLine(path);
            }
        }
    }
}
