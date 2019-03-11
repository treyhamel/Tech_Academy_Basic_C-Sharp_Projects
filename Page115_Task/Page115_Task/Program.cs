using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page115_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 function = new Class1();
            Console.WriteLine("Please input the first whole number.");
            int int1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second whole number, or leave this blank.");
            string input2 = Console.ReadLine();
            if (input2 == "")
            {
                Console.WriteLine("The sum of the squares of the number(s) you input is: " + function.TwoInt(int1));
            }
            else
            {
                int int2 = Convert.ToInt32(input2);
                Console.WriteLine("The sum of the square of the number(s) you input is: " + function.TwoInt(int1, int2));
            }
            Console.ReadLine();
        }
    }
}
