using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Создайте класс Телевизор, в котором есть поле текущий канал. 
             Предусмотрите в нем возможность переключения каналов (методы класса): следующий канал, предыдущий канал, переход к каналу по номеру. 
             Учтите, что канал не может иметь отрицательный номер.
            */
            Television TV = new Television();

            while (true)
            {
                Console.Clear();
                TV.Info(); //вызываем информацию о текущих каналах
                TV.Menu();
                Console.Write("Введите команду: ");
                string[] commands = Console.ReadLine().Split(' '); // убираем пробелы
                if (commands.Length == 1) // команды в одну строку
                {
                    if (commands[0] == "exit")
                    {
                        return;
                    }
                    if (commands[0] == "next")
                    {
                        TV.NextCh();
                        continue;
                    }
                    if (commands[0] == "prev")
                    {
                        TV.PrevCh();
                        continue;
                    }
                    if (commands[0] == "go")
                    {
                        Console.WriteLine("Введите номер канала: ");
                        string str = Console.ReadLine();
                        if (Int32.TryParse(str, out int temp))
                        {
                            if (temp < 0 && temp < 11) //gпромежуток от 1 до 10
                            {
                                Console.WriteLine("Eror! Такого канала не существует!");
                                Console.ReadKey();
                            }
                            else
                            {
                                TV.GoToCh(temp);
                            }
                        }
                        else { }
                        continue;
                    }
                }
            }

        }
    }
}
