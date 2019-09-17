using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013
{
    class Program
    {
        static void Main(string[] args)
        {
            
                /*Напишите метод TrianglePS(a, P, S), вычисляющий по стороне a равностороннего треугольника его периметр P = 3•a и площадь
                  S = a * a * (√ 3) / 4 (a – входной параметр, P и S – выходные параметры; все параметры являются вещественными).*/
                Console.WriteLine("Введите значение стороны а:");
                int a = int.Parse(Console.ReadLine());
                int P = 0;
                double S = 0;
                TrianglePS(a, ref P, ref S); //передача по ссылке
                Console.WriteLine("\nP = " + P + "\nS = " + S);

            }
        static void TrianglePS(int a, ref int P, ref double S)
            {
                P = 3 * a;
                S = a * a * Math.Sqrt(3) / 4;

            }
        }
    }

