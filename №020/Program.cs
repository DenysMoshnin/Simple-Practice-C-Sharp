using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Создайте класс Аудиоплеер, в котором есть поле громкость звука, для доступа к этому полю реализуйте свойство. Громкость может быть в диапазоне от 0 до 100
             */

            Console.WriteLine("Введите громкость: ");
            AudioPlayer ap = new AudioPlayer();
            ap.Volume = int.Parse(Console.ReadLine());
            Console.WriteLine("\nГромкость:" + ap.Volume);
        }
    }
}
