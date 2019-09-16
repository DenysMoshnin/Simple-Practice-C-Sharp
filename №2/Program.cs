using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задание №2. Условные конструкции
           Даны два числа.Выведите большее из них.*/
            Console.WriteLine("Введите два целых числа:");
            int first = int.Parse(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            if (first != second)
            {
                if (first > second)
                {
                    Console.WriteLine("\nБольшее число: " + first);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nБольшее число: " + second);
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("\nЧисла равны");
                Console.ReadKey();
            }
        }
    }
}
