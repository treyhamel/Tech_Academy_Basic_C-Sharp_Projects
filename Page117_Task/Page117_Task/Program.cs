using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page117_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tasks 1-4

            Class1 function = new Class1();
            Console.WriteLine("Input a whole number to be divided by two.");
            int int1 = Convert.ToInt32(Console.ReadLine());
            function.divTwo(int1, out int result);

            // Task 5

            Console.WriteLine("Input the length of the sides of a square to find the area.");
            int side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(function.Area(side) + " is the area of this square.");

            Console.WriteLine("Input the length of a rectangle");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now input the width of the same rectangle");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(function.Area(length, width) + " is the area of this rectangle.");

            // Task 6

            Console.WriteLine("Input a temperature to be converted from deg F to deg C");
            string fahrenheit = Console.ReadLine();
            Console.WriteLine(fahrenheit + " degrees F is " + TempConvert.FahrenheitToCelsius(fahrenheit) + " degrees Celsius.");
            Console.ReadLine();
        }
    }
}
