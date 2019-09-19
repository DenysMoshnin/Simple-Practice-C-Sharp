using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018
{
    class Television
    {
        public int currentCh = 1;
        public void NextCh()
        {
            if (currentCh > 0 && currentCh < 11)
            {
                if (currentCh == 10)
                {
                    currentCh = 1;
                }
                else
                {
                    currentCh++;
                }
            }
            else { }
        }
        public void PrevCh()
        {
            if (currentCh > 0 && currentCh < 11)
            {
                if (currentCh == 1)
                {
                    currentCh = 10;
                }
                else
                {
                    currentCh--;
                }
            }
            else { }
        }
        public void GoToCh(int i)
        {

            if (i > 0 && i < 10)
            {
                currentCh = i;
            }
        }
        public void Info()
        {
            Console.WriteLine("\nНомер канала: " + currentCh + "\nНазвание канала: '" + (DiscoveryCh)currentCh + "'");
        }
        public void Menu()
        {
            Console.WriteLine("\nnext - следующий канал;" + "\nprev - предыдущий канал;" + "\ngo - перейти на канал;" + "\nexit - выйти из меню;" + "\n");
        }
    }
}
