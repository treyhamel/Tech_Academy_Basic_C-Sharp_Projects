using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page111_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number.");
            int numOne = Convert.ToInt32(Console.ReadLine());
            int divide = Operations.Divide(numOne);
            int subtract = Operations.Subtract(numOne);
            int square = Operations.Square(numOne);

            Console.WriteLine(numOne + " squared is " + square);
            Console.WriteLine(numOne + " divided by 2 is " + divide);
            Console.WriteLine(numOne + " minus 2 is " + subtract);
            Console.ReadLine();
        }
    }
}
