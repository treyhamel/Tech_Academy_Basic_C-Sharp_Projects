using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page162_Task
{
    public class Student
    {
        public Student() : this("NA", 0)
        {

        }
        public Student(string name) : this(name, 0)
        {
            Name = name;
        }
        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }

        public int Grade { get; set; }
        public string Name { get; set; }
    }
}
