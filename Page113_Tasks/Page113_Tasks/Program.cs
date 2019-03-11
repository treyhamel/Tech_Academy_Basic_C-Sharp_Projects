using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page113_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 function = new Class1();
            function.TwoInt(5, 10);

            function.TwoInt(int1: 20, int2: 100);
            Console.ReadLine();
        }
    }
}
