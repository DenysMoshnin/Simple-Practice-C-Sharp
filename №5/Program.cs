using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задание №5. Массивы. Циклы
Дан массив размера N. Выведите его элементы в обратном порядке.*/
            Console.WriteLine("Введите размер массива: ");
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            Console.WriteLine("\nМассив в первоначальной последовательности: ");
            foreach (int k in arr)
            {
                Console.WriteLine(k);
            }
            Array.Reverse(arr); //переворачиваем массив
            Console.WriteLine("\nМассив в обратной последовательности: ");
            foreach (int t in arr)
            {
                Console.WriteLine(t);
            }
        }
    }
}
