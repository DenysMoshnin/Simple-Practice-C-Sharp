using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задание №4.Условные конструкции
        Дано целое число в диапазоне 1–7.Выведите строку - название дня недели, соответствующее данному числу(1 – «понедельник», 2 – «вторник» и т.д.).*/
            string[] week = new string[7];
            week[0] = "Sunday";
            week[1] = "Monday";
            week[2] = "Tuesday";
            week[3] = "Wednesday";
            week[4] = "Thursday";
            week[5] = "Friday";
            week[6] = "Saturday";

            Console.WriteLine("Введите число в диапазоне от 1 до 7:");
            int day = Convert.ToInt32(Console.ReadLine());
            if (1 <= day && day <= 7)
            {
                Console.WriteLine("\n"+day + " - " + week[day]+"\n");
            }
            else
            {
                Console.WriteLine("\nВы ввели значение вне диапазона.\n");
            }
        }
    }
}
