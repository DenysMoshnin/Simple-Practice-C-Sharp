using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016
{
    class Program
    {
        /*
             Напишите перечисление с арифметическими операциями: add, sub, mul, div.Перечисление должно быть описано в отдельном файле проекта.
Напишите метод с тремя параметрами:	
1. Первый параметр – число с плавающей точкой;
2. Второй параметр – число с плавающей точкой;
3. Третий параметр – переменная типа перечисления, которое было создано ранее.
В зависимости от значения третьего параметра, метод выполняет конкретную операцию над первым и втором параметром. После этого возвращает результат.

             */
        enum Arith
        {
            add = 1, //0 сложение
            sub, //1 вычетание
            mul, //2 умножение
            div  //3 деление
        }

        static void Main(string[] args)
        {
            int s = 0;
            Console.WriteLine("Введите значение а:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите какую операцию в хотите осуществить (сложение, вычетание, умножения, деление):");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "сложение":
                    Console.WriteLine("Вы выбрали операцию сложения");
                    s = 1;
                    break;
                case "вычетание":
                    Console.WriteLine("Вы выбрали операцию вычетания");
                    s = 2;
                    break;
                case "умножение":
                    Console.WriteLine("Вы выбрали операцию умножения");
                    s = 3;
                    break;
                case "деление":
                    Console.WriteLine("Вы выбрали операцию деления");
                    s = 4;
                    break;

                default:
                    Console.WriteLine("Вы ввели чушь. Выберете операцию из перечисленных выше!");
                    break;
            }
            Oper(a, b, s);


        }
        static void Oper(double a, double b, int s)
        {
            double result;
            if (s == (int)Arith.add)
            {
                result = a + b;
                Console.WriteLine("\nResulat = " + result);
            }
            if (s == (int)Arith.sub)
            {
                result = a - b;
                Console.WriteLine("\nResulat = " + result);
            }
            if (s == (int)Arith.mul)
            {
                result = a * b;
                Console.WriteLine("\nResulat = " + result);
            }
            if (s == (int)Arith.div)
            {
                result = a / b;
                Console.WriteLine("\nResulat = " + result);
            }
        }
    }
}
