using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page94_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the 9th prime number?");
            double answer = Convert.ToDouble(Console.ReadLine());
            while (answer != 23)
            {
                if (answer < 23)
                {
                    Console.WriteLine("Your guess is too small. Try again.");
                    answer = Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Your guess is too large. Try again.");
                    answer = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.WriteLine("That's correct! 23 is the 9th prime number.");
            Console.ReadLine();
        }
    }
}
