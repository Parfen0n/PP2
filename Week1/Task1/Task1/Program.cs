using System;

namespace Task1
{
    class Program
    {
        // Создаём функцию для проверки, является ли число простым или нет
        static bool Prime(int k)
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
            
            int n = int.Parse(Console.ReadLine()); // Ввод числа для определения длины массива
            
            string[] s = Console.ReadLine().Split(); // Ввод чисел через строчный массив и разделение чисел через пробел
            
            int[] arr = new int[n]; // Создание числового массива с длиной n
            
            int cnt = 0; // Создание счетчика для простых чисел
            
            int[] arrPrime = new int[n]; // Создание отдельного массива для простых чисел
            
            for (int i = 0; i < arr.Length; i++) // Преобразование строчного массива в числовой
            {
                arr[i] = int.Parse(s[i]);
            }
            
            int j = 0; // Создание j в роли итератора по массиву c простыми числами arrPrime
            
            for (int i = 0; i < n; i++) // Проверка для простых чисел из первого массива arr и добавление их в массив для простых чисел arrPrime
            {
                if(Prime(arr[i]) == true)
                {
                    arrPrime[j] = arr[i];
                    cnt++;
                    j++;
                }
            }
            
            Console.WriteLine(cnt); // Вывод размера массива для простых чисел arrPrime
            
            for (int i = 0; i < cnt; i++) // Вывод чисел массива для простых чисел arrPrime
            {
                Console.Write(arrPrime[i] + " ");
            }
           
            Console.ReadLine(); // Костыль для того, чтобы окно терминала не закрывалось после завершения работы

        }
       
    }
}
