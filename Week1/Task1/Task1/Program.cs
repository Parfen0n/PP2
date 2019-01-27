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
            // Ввод числа для определения длины массива
            int n = int.Parse(Console.ReadLine()); 
            // Ввод чисел через строчный массив и разделение чисел через пробел
            string[] s = Console.ReadLine().Split();
            // Создание числового массива с длиной n
            int[] arr = new int[n];
            // Создание счетчика для простых чисел
            int cnt = 0;
            // Создание отдельного массива для простых чисел
            int[] arrPrime = new int[n];
            // Преобразование строчного массива в числовой
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(s[i]);
            }
            // Создание j в роли итератора по массиву c простыми числами arrPrime
            int j = 0;
            // Проверка для простых чисел из первого массива arr и добавление их в массив для простых чисел arrPrime
            for(int i = 0; i < n; i++)
            {
                if(Prime(arr[i]) == true)
                {
                    arrPrime[j] = arr[i];
                    cnt++;
                    j++;
                }
            }
            // Вывод размера массива для простых чисел arrPrime
            Console.WriteLine(cnt);
            // Вывод чисел массива для простых чисел arrPrime
            for(int i = 0; i < cnt; i++)
            {
                Console.Write(arrPrime[i] + " ");
            }
            // Костыль для того, чтобы окно терминала не закрывалось после завершения работы
            Console.ReadLine();

        }
       
    }
}
