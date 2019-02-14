using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\My\Study at Uni\PP2\Week2\Path\Example.txt";
            string path1 = @"C:\My\Study at Uni\PP2\Week2\Path1";

            DirectoryInfo directInfo = new DirectoryInfo(path1);
            FileInfo file = new FileInfo(path);
            if(file.Exists && directInfo.Exists)
            {
                file.CopyTo(path1 + @"\Copied.txt", true);
                file.Delete();
            }
            else
            {
                Console.WriteLine("Данный путь не найден");
            }
        }
    }
}