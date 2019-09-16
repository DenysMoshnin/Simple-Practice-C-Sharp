using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Даны целые положительные числа A и B (A<B). Выведите все целые числа от A до B включительно; 
              при этом каждое число должно выводиться столько раз, каково его значение (например, число 3 выводится 3 раза).
             */
            Console.WriteLine("Введите число А (A>0): ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число В (В должно быть больше А): ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if (A < B && A > 0) //отсекаем ввод данных не проходящих по условию
            {
                int distinction = B - A;   // определяем разницу
                for (int i = A; i <= B; i++) // значения числа из диапазона от А до В включительно
                {
                    for (int j = 1; j <= i; j++) //колиество повторений найденного числа
                    {
                        Console.WriteLine(i);
                    }
                    
                }

            }
            else if (A < 0)
            {
                Console.WriteLine("Значение A должно быть больше 0! ");
            }
            else
            {
                Console.WriteLine("Значение A должно быть меньше В!");
            }
        }
    }
}
