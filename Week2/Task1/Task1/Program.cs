using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool plmCheck(string s)
        {
            string revStr = new string(s.ToCharArray().Reverse().ToArray());

            if (revStr == s)
            {
                return true;
            } else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"C:\My\Study at Uni\PP2\Week2\T1.txt", FileMode.Open, FileAccess.Read);
            StreamReader fileStr = new StreamReader(file);

            string s = fileStr.ReadLine();

            if(plmCheck(s))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.ReadLine();
        }
    }
}
