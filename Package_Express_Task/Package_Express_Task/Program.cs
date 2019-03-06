using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Express_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("");
            Console.WriteLine("Please enter the package weight:");
            string packageWeight = Console.ReadLine();
            double packageWt = Convert.ToDouble(packageWeight);
            if (packageWt > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                string packageWidth = Console.ReadLine();
                double packWidth = Convert.ToDouble(packageWidth);
                Console.WriteLine("Please enter the package height:");
                string packageHeight = Console.ReadLine();
                double packHeight = Convert.ToDouble(packageHeight);
                Console.WriteLine("Please enter the package length:");
                string packageLength = Console.ReadLine();
                double packLength = Convert.ToDouble(packageLength);

                double totalDimensions = packLength + packHeight + packWidth;
                if (totalDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    double shipPrice = totalDimensions * packageWt / 100;
                    Console.WriteLine("The cost to ship your package is: ");
                    Console.WriteLine("$" + shipPrice);
                    Console.ReadLine();
                }
            }
        }
    }
}
