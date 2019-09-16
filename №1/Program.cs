using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Даны три целых числа. Найдите количество положительных и количество отрицательных чисел в исходном наборе.*/
            int Positive = 0;
            int Negative = 0;
            int Zero = 0;
            int[] array = new int[3];
            Console.WriteLine("Введите три целых числа:");
            array[0] = Convert.ToInt32(Console.ReadLine());
            array[1] = Convert.ToInt32(Console.ReadLine());
            array[2] = Convert.ToInt32(Console.ReadLine());
            // Осуществляем перебор чисел в массиве
            for (int i = 0; i < 3; i++)
            {
                if (array[i] > 0)
                {
                    Positive++;
                }
                else if (array[i] == 0)
                {
                    Zero++;
                }
                else
                {
                    Negative++;
                }
            }
            if (Zero != 0)
            {
                Console.WriteLine("Количество позитивных чисел: " + Positive + "\nКолдичество негативных чисел: " + Negative + "\nКоличество нолей: " + Zero);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Количество позитивных чисел: " + Positive + "\nКолдичество негативных чисел: " + Negative);
                Console.ReadKey();
            }
        }
    }
    
}
