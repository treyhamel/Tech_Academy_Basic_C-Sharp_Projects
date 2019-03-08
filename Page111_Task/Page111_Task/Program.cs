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
            Console.WriteLine("Please enter a whole number you'd like to square.");
            int numOne = Convert.ToInt32(Console.ReadLine());
            int square = Operations.Square(numOne);

            Console.WriteLine(numOne + " squared is " + square);

            Console.WriteLine("Please enter a whole number you'd like to divide by 2.");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            int divide = Operations.Divide(numTwo);
            Console.WriteLine(numTwo + " divided by 2 is " + divide);

            Console.WriteLine("Please enter a whole number you'd like to subtract by 2.");
            int numThree = Convert.ToInt32(Console.ReadLine());
            int subtract = Operations.Subtract(numThree);
            Console.WriteLine(numThree + " minus 2 is " + subtract);
            Console.ReadLine();
        }
    }
}
