using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Создайте класс Студент, определите в нем поля: имя, курс, есть ли у него стипендия.
             Создайте в классе несколько конструкторов, для возможности задания сразу всех указанных параметров или нескольких при создании экземпляров
             */
            Student st1 = new Student("Мафусаил");
            Student st2 = new Student("Илья", 3);
            Student st3 = new Student("Михаил", 5, "На стипендии.");

            st1.Info();
            st2.Info();
            st3.Info();
        }
    }
}
