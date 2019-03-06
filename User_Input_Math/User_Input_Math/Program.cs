using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number: ");
            string number1 = Console.ReadLine();
            double num1 = Convert.ToDouble(number1);
            double result1 = 50 * num1;
            Console.WriteLine(number1 + " times 50 is " + result1);

            Console.WriteLine("");
            Console.WriteLine("Please input another number: ");
            string number2 = Console.ReadLine();
            double num2 = Convert.ToDouble(number2);
            double result2 = num2 + 25;
            Console.WriteLine(number2 + " plus 25 is " + result2);

            Console.WriteLine("");
            Console.WriteLine("Please input a third number: ");
            string number3 = Console.ReadLine();
            double num3 = Convert.ToDouble(number3);
            double result3 = num3 / 12.5;
            Console.WriteLine(number3 + " divided by 12.5 is " + result3);

            Console.WriteLine("");
            Console.WriteLine("Please input a fourth number:");
            string number4 = Console.ReadLine();
            double num4 = Convert.ToDouble(number4);
            bool result4 = num4 > 50;
            Console.WriteLine("Is " + number4 + " greater than 50? " + result4.ToString());

            Console.WriteLine("");
            Console.WriteLine("Please input a fifth number:");
            string number5 = Console.ReadLine();
            double num5 = Convert.ToDouble(number5);
            double result5 = num5 % 7;
            Console.WriteLine("The remainder when " + number5 + " is divided by 7 is: " + result5);
            Console.ReadLine();
        }
    }
}
