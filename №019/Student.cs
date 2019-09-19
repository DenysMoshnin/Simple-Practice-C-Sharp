using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019
{
    class Student
    {
        public string name;
        public int course;
        public string scholarship;
        public Student(string name, int course, string scholarship)
        {
            this.name = name;
            this.course = course;
            this.scholarship = scholarship;
        }
        public Student(string name)
        {
            this.name = name;
        }
        public Student(string name, int course)
        {
            this.name = name;
            this.course = course;
        }
        public void Info()
        {
            Console.WriteLine("Студент " + name + ", учится на " + course + " курсе. " + scholarship);
        }
    }
}
