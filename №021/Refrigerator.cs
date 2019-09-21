using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021
{
    class Refrigerator
    {
        private bool status;
        private int tempRef;
        private int tempFr;
        public bool Status
        {
            set
            {
                value = status;
            }
            get
            {
                return status;
            }
        }
        public int TempRef
        {
            set
            {
                if (value >= 5 && value <= 15) //ограничиваем принимаемую температуру в районе от 5 до 15
                {
                    tempRef = value;
                }
                else
                {
                    if (value < 5)
                    {
                        tempRef = 5;
                    }
                    else if (value > 15)
                    {
                        tempRef = 15;
                    }

                }
            }
            get
            {
                return tempRef;
            }
        }
        public int TempFr
        {
            set
            {
                if (value <= -5 && value >= -24) //ограничиваем принимаемую температуру в районе от 5 до 15
                {
                    tempFr = value;
                }
                else
                {
                    if (value > -5)
                    {
                        tempFr = -5;
                    }
                    else if (value < -24)
                    {
                        tempFr = -24;
                    }

                }
            }
            get
            {
                return tempFr;
            }
        }
        public Refrigerator(bool status, int tempRef, int tempFr)

        {
            Status = status;
            TempFr = tempFr;
            TempRef = tempRef;
        } //создаем холодильник
        public void SwichStatus()
        {
            if (status == true)
            {
                status = false;
            }
            else
            {
                status = true;
            }
        } //вкл или выкл 
        public void PlusTempRef()
        {
            TempRef++;
        } //увеличить темп холодильника
        public void DecTempRef()
        {
            TempRef--;
        } //увеличить темп холодильника
        public void PlusTempFr()
        {
            TempFr++;
        } //увеличить темп морозилки
        public void DecTempFr()
        {
            TempFr--;
        } //уменьшить темп морозилки
        public void Info()
        {
            if (status == true) //включенный холодильник
            {
                Console.WriteLine("Холодильник: " + status + "\nТемпература холодильника: " + tempRef + "\nТемпература морозилки: " + tempFr);
            }
            else
            {
                Console.WriteLine("Холодильник: " + status); //выключенный
            }

        }
        public void ComandMenu() //список команд
        {
            Console.WriteLine("\npower - включить или выключить холодильник;\nplus ref/fr - увеличить температуру холодильника/морозилки;" +
                "\ndec ref/fr - уменьшить теипературу холодильника/морозилки\nexit - выйти из меню");
        }
        public void Eror() //неучтенный вод
        {
            Console.WriteLine("\n\tКоманда была введена неправильно, или такой команды не существует");
            Console.WriteLine("\nexit - выход.");
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
        }
    }
}
