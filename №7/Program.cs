using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Дано целое число N (N>0). Найдите сумму:
1 + 1/2 + 1/3 + ... + 1/N
(вещественное число).
            */
            Console.WriteLine("Введите число N > 0");
            Double N = Double.Parse(Console.ReadLine());
            Double Res = 0;
            if (N > 0)
            {
                for (Double i = 1; i <= N; i++)
                {
                    Res = (1 / i) + Res;
                }
                Console.WriteLine("\n Сумма = " + Res);
            }
            else
            {
                Console.WriteLine("\nЧисло N должно быть больше 0!");
            }
        }
    }
}
