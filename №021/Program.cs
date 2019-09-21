using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Напишите программу – эмулятор работы холодильника. Программа должна позволять выполнять через меню в консольном приложении те или иные действия с холодильником, 
                например, включать или выключать его, и т.п. При этом после каждого действия пользователя, программа должна отобразить на экране текущее состояние холодильника и меню всех функций.
                Класс холодильника должен иметь метод, отображающий на экран его текущее состояние, а также методы, позволяющие это состояние изменять.
                Главный метод программы (Main) должен выполнять задачу отображения меню и передачу команд пользователя объекту класса холодильника.   
           */
            Refrigerator RF = new Refrigerator(true, 5, -10);
            while (true)
            {
                Console.Clear();
                RF.Info();
                RF.ComandMenu();
                Console.Write("\nВведите команду: ");
                string[] commands = Console.ReadLine().Split(' ');
                if (commands.Length == 1)
                {
                    if (commands[0] == "exit")
                    {
                        return;
                    }
                    if (commands[0] == "power")
                    {
                        RF.SwichStatus();
                        continue;
                    }
                    else
                    {
                        RF.Eror();
                        continue;
                    }
                }
                if (commands.Length == 2)
                {
                    if (commands[0] == "plus")
                    {
                        if (commands[1] == "ref")
                        {
                            RF.PlusTempRef();
                            continue;
                        }
                        if (commands[1] == "fr")
                        {
                            RF.PlusTempFr();
                            continue;
                        }
                    }
                    if (commands[0] == "dec")
                    {
                        if (commands[1] == "ref")
                        {
                            RF.DecTempRef();
                            continue;
                        }
                        if (commands[1] == "fr")
                        {
                            RF.DecTempRef();
                            continue;
                        }
                    }
                    else
                    {
                        RF.Eror();
                        continue;
                    }
                }
                else
                {
                    RF.Eror();
                }
            }
        }
    }
}
