using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task3
{
    class Program
    {
       static void Rec(DirectoryInfo direct, string level)
        {
            Console.WriteLine(level + direct.Name);
            level += "    ";
            FileSystemInfo[] files = direct.GetFileSystemInfos();
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].GetType() == typeof(FileInfo))
                {
                    Console.WriteLine(level + files[i].Name);
                }
                else
                {
                    Rec(files[i] as DirectoryInfo, level);
                }
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo direct = new DirectoryInfo(@"C:\My\Study at Uni\PP2\Week2");
            Rec(direct, "");

            Console.ReadKey();
        }
    }
}