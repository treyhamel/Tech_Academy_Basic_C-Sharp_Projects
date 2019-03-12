using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page129_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Id = 13;

            Employee employee2 = new Employee();
            employee2.Id = 22;

            Employee employee3 = new Employee();
            employee3.Id = 13;

            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee1 == employee3);
            Console.WriteLine(employee3 != employee2);

            Console.ReadLine();
        }
    }
}
