using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
             Создайте структуру, которая хранит информацию о товарах (название товара, дата поступления, масса, стоимость, название поставщика, гарантийный срок) некоторого склада.
             Структура должна быть описана в отдельном файле проекта. Создайте три структуры, заполните первые две структуры при помощи обращения к переменным, 
             третью структуру заполните при помощи конструктора. После этого выведите всю информацию на экран.
             */
            StokDB[] arrStok = new StokDB[2];
            //1я
            arrStok[0].name = "USB-flesh 32Gb";
            arrStok[0].day = 2;
            arrStok[0].month = 1;
            arrStok[0].year = 2017;
            arrStok[0].weight = 0.070;
            arrStok[0].cost = 140;
            arrStok[0].provider = "Transend";
            arrStok[0].shelfLife = 60;
            //2я
            arrStok[1].name = "USB-flesh 64Gb";
            arrStok[1].day = 22;
            arrStok[1].month = 2;
            arrStok[1].year = 2018;
            arrStok[1].weight = 0.100;
            arrStok[1].cost = 355;
            arrStok[1].provider = "Kingston";
            arrStok[1].shelfLife = 60;
            //через конструктор

            //arrStok[3] = new StokDB("Накопитель SSD 2.5 SATA 500Gb Samsung 860 EVO(MZ - 76E500BW)", 20, 5, 2018, 0.051, 2863, "Sumsung", 60);
            StokDB st1 = new StokDB("Накопитель SSD 2.5 SATA 500Gb Samsung 860 EVO(MZ - 76E500BW)", 20, 5, 2018, 0.051, 2863, "Sumsung", 60);
            foreach (StokDB arr in arrStok) // выводим данные 
            {
                arr.Info();
            }
            st1.Info();
        }

        struct StokDB
        {
            public string name;
            public int day;
            public int month;
            public int year;
            public double weight;
            public double cost;
            public string provider;
            public int shelfLife;
            //конструктор
            public StokDB(string n, int d, int m, int y, double w, double c, string p, int sl)
            {
                name = n;
                day = d;
                month = m;
                year = y;
                weight = w;
                cost = c;
                provider = p;
                shelfLife = sl;
            }
            public void Info() //вывод информации
            {
                Console.WriteLine("Товар: '" + name + "', дата поступления: " + day + "/" + month + "/" + year + ", масса: " + weight + " кг, стоимость: " +
                    cost + " грн, поставщик: '" + provider + "', срок хранения: " + shelfLife + " месяцев");
            }

        }
    }
}
