using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student // Создаем класс Student
    {
        public string name;
        public string id;
        public int year = 1;

        public Student(string name, string id)
        {
            this.name = name; // Назначение классу Student имени введенного пользозователем
            this.id = id; // Назначение классу Student id введенного пользователем
        }


        public void print()
        {
            Console.WriteLine("Имя студента: {0}", name); // Вывод имени студента
            Console.WriteLine("ID студента: {0}", id); // Вывод ID студента
            year++; // Увелечение года обучения на 1 (инкремент)
            Console.WriteLine("Через год вы будете на {0} курсе", year); // Вывод курса обучающегосяя через год
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя и ID:"); // Вопрос к пользователю
            Student st1 = new Student(Console.ReadLine(), Console.ReadLine()); // Ввод данных
            st1.print(); // Вывод данных
            Console.ReadLine(); // Костыль, для того чтобы терминал не закрывался
        }
    }
}
