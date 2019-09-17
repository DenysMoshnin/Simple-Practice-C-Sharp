using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите метод, который сначала запрашивает имя пользователя, а потом говорит ему привет.

            Hello(); //вызов метода


        }
        static void Hello()
        {
            //задаем вызов для ввода имени
            Console.WriteLine("Введите имя, кому вы потите передать привет:");
            string name = Console.ReadLine();
            Console.WriteLine("\nПривет " + name); //Выводим приветствие
            Console.ReadKey();

        }
    }
}
