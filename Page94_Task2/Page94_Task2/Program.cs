using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page94_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name a factor of the number 1001");
            int answer = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (answer == 7)
                {
                    Console.WriteLine("That's correct! " + answer + " is a factor of 1001.");
                    Console.ReadLine();
                }
                else if (answer == 11)
                {
                    Console.WriteLine("That's correct! " + answer + " is a factor of 1001.");
                    Console.ReadLine();
                }
                else if (answer == 13)
                {
                    Console.WriteLine("That's correct! " + answer + " is a factor of 1001.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong. " + answer + " is not a factor of 1001. Try again");
                    Console.WriteLine("Name a factor of the number 1001");
                    answer = Convert.ToInt32(Console.ReadLine());
                }
            }
            while (answer != 7 && answer != 11 && answer != 13);
            Console.WriteLine("That's correct! " + answer + " is a factor of 1001.");
            Console.ReadLine();
        }
    }
}
