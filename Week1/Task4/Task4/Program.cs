using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Ввод n определяющего количество рядов и количесто столбцов в последнем ряду

            for(int i = 0; i < n; i++) // Цикл складывающий строку, с переходом на следующий ряд
            {
                for(int j = 0; j < i + 1; j++)
                {
                    Console.WriteLine("[*]");
                }
            }
            Console.ReadLine(); // Костыль для того, чтобы окно терминала не закрывалось после завершения работы
        }
    }
}
