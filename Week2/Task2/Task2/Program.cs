using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static bool isPrime(int k)
        {
            if (k == 1) return false;
            for (int i = 2; i <= Math.Sqrt(k); i++)
            {
                if (k % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            FileStream input = new FileStream(@"C:\My\Study at Uni\PP2\Week2\T2input.txt", FileMode.Open, FileAccess.Read);
            StreamReader inputStr = new StreamReader(input);

            string[] s = inputStr.ReadLine().Split();

            int[] arr = new int[s.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(s[i]);
            }

            int[] arrPrime = new int[arr.Length];

            int cnt = 0;

            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (isPrime(arr[i]) == true)
                {
                    arrPrime[j] = arr[i];
                    cnt++;
                    j++;
                }
            }

            int[] arrPrime2 = new int[cnt];

            for(int i = 0; i < cnt; i++)
            {
                arrPrime2[i] = arrPrime[i];
            }

            string Ans = String.Join(" ", arrPrime2);

            input.Close();
            inputStr.Close();

            FileStream output = new FileStream(@"C:\My\Study at Uni\PP2\Week2\T2output.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter outputStr = new StreamWriter(output);

            outputStr.WriteLine(Ans);

            outputStr.Close();
            output.Close();
        }
    }
}
