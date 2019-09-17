using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишите метод Even(K) логического типа, возвращающий TRUE, если целый параметр K является четным, и FALSE в противном случае*/
            Console.WriteLine("Введите чило K");
            int K = int.Parse(Console.ReadLine());
            bool res = Even(K);
            Console.WriteLine(res);

        }
        static bool Even(int K)
        {
            return (K % 2) == 0; // четное число это true
            
        }
    }
}
