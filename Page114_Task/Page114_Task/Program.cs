using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page114_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 function = new Class1();
            Console.WriteLine(function.Operation(5));

            Console.WriteLine(function.Operation(6.0));

            Console.WriteLine(function.Operation("10"));
            Console.ReadLine();
        }
    }
}
