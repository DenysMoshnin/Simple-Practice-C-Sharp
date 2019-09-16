using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задание №6. Циклы (for)
Даны два целых числа A и B (A<B). Найдите сумму квадратов всех целых чисел от A до B включительно.
*/
            Console.WriteLine("Введите число A");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B (Число В должна быть больше числа А)");
            int B = int.Parse(Console.ReadLine());
            double Sum = 0;
            if (A < B)
            {
                for (double i = A; A <= i && i <= B; i++)
                {
                    Sum += Math.Pow(i, 2);   //возводим в квадрат

                }
                Console.WriteLine("Сумма квадратов = " + Sum);
            }
            else
            {
                Console.WriteLine("Число В должно быть больше числа А!");
            }
        }
    }
}
