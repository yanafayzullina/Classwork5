using Superpower;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите количсетво чисел в массиве");
            uint count = uint.Parse(Console.ReadLine());
            Console.WriteLine("Массив первой команды:");
            int[] array1 = new int[count];
            Random numbers = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = numbers.Next(0, 10) ;
                Console.WriteLine(array1[i] + " ");
            }
            Console.WriteLine("Массив второй команды:");
            int[] array2 = new int[count];
            Random num = new Random();
            for (int j = 0; j < array2.Length; j++)
            {
                array2[j] = num.Next(0, 10);
                Console.WriteLine(array2[j] + " ");
            }
            int fife1 = array1.Where(i => i - 5 == 0).Count();
            int fife2 = array2.Where(i => i - 5 == 0).Count();
            if (fife1 == fife2)
            {
                Console.WriteLine("Drinks All Round! Free Beers on Bjorg!");
            }
            else
            {
                Console.WriteLine("Ой, Бьорг - пончик! Ни для кого пива!");
            }


            Console.WriteLine("Задание 3");
            List<string> students = new List<string>();
            students.Add("Хасанов Булат, 2002, английский, 274");
            students.Add("Халилулин Рафаэль, 2002, физика, 271");
            students.Add("Шигина Арина, 2004, английский, 242");
            students.Add("Балаболина Алиса, 2004, информатика, 244");
            students.Add("Тальдаева Лия, 2003, физика, 246");
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();
            if (word == "Новый студент")
            {
                Console.WriteLine("Введите информацию о студенте");
                students.Add(Console.ReadLine());
                foreach (string student in students)
                {
                    Console.WriteLine(student);
                }
            }
            else if (word == "Удалить")
            {
                Console.WriteLine("Введите фамилию и имя студента, год рождения, предмет, балл");
                string delete = Console.ReadLine();
                if (students.Remove(delete))
                {
                    foreach (string student in students)
                    {
                        Console.WriteLine("Изменённый список:");
                        Console.WriteLine(student);
                    }
                }
            }
            else if (word == "Сортировать")
            {
                Console.WriteLine(students[2]);
                Console.WriteLine(students[3]);
                Console.WriteLine(students[4]);
                Console.WriteLine(students[1]);
                Console.WriteLine(students[0]);
            }
            else
            {
                Console.WriteLine("Некорректное слово");
            }
                


            Console.WriteLine("Задание 4");
            List<string> workers = new List<string>();
            workers.Add("Семён, менеджер, степень наглости: 4, тупость: 0");
            workers.Add("Георгий, директор, степень наглости:6, тупость: 0");
            workers.Add("Арина, старший менеджер, степень наглости:2, тупость: 0");
            workers.Add("Анна, секретарь, степень наглости:0, тупость: 1");
            workers.Add("Александр, администратор, степень наглости:3, тупость: 1");
            workers.Add("Ирина, менеджер, степень наглости:3, тупость: 1");
            workers.Add("Олег, директор, степень наглости:3, тупость: 0");
            workers.Add("Владимир, старший менеджер, степень наглости:5, тупость: 1");
            workers.Add("Тимур, секретарь, степень наглости:4, тупость: 1");
            workers.Add("Сергей, администратор, степень наглости:2, тупость: 0");
            Console.WriteLine("За первым столом:" + '\n' + workers[0] + '\n' + workers[4] + '\n' + workers[5]);
            workers.RemoveAt(0);
            workers.RemoveAt(4);
            workers.RemoveAt(5);
            Console.WriteLine("За вторым столом:" + '\n' + workers[0] + '\n' + workers[4] + '\n' + workers[1]);
            workers.RemoveAt(0);
            workers.RemoveAt(4);
            workers.RemoveAt(1);
            Console.WriteLine("За третьим столом:" + '\n' + workers[0] + '\n' + workers[2] + '\n' + workers[1]);
            workers.RemoveAt(0);
            workers.RemoveAt(2);
            workers.RemoveAt(1);
            Console.WriteLine("За четвертым столом:" + '\n' + workers[0]);
            Console.ReadKey();
        }
    }
}
