using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Напишите метод InvertDigits(K), меняющий порядок следования цифр целого положительного числа K на обратный(K – параметр целого типа).*/
            Console.WriteLine("Введите чило K");
            int K = int.Parse(Console.ReadLine());
            InvertDigits(K);
            
        }
        static void InvertDigits(int K)
        {
            Char[] InvertedNumbers = K.ToString().ToCharArray(); //переводим число К в массив символов
            Array.Reverse(InvertedNumbers); //переворачиваем
            Console.WriteLine("\nReverse = {0}", Convert.ToInt32(new String(InvertedNumbers))); //выводим перевернутый массив символов с преобразованием в число
            Console.ReadKey();
        }
    }
}
