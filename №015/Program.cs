using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Напишите метод, который принимает любое количество параметров целого типа и возвращает их сумму.
             */
            int S = 0;
            Console.WriteLine("Введите сколько символов вы хотите ввести: ");
            int LenghtAr = int.Parse(Console.ReadLine());
            int[] array = new int[LenghtAr];
            Console.WriteLine("\nВведите числа: ");
            for (int i = 0; i < LenghtAr; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Sum(array, ref S);

            Console.WriteLine("\nS = " + S);


        }
        static void Sum(int[] array, ref int S)
        {
            for (int i = 0; i < array.Length; i++)
            {
                S += array[i];
            }

        }
    }
}
