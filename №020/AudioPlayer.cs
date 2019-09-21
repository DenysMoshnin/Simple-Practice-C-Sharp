using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020
{
    class AudioPlayer
    {
        private int volume;
        public int Volume
        {
            set
            {
                if (value >= 0 && value <= 100) //ограничиваем принимаемое значение громкости в районе от 0 до 100
                {
                    volume = value;
                }
                else
                {
                    if (value < 0)
                    {
                        volume = 0;
                    }
                    else if (value > 100)
                    {
                        volume = 100;
                    }

                }
            }
            get
            {
                return volume;
            }
        }
    }
}
