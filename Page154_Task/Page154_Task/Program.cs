using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Page154_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number, your favorite number.");
            string favNum = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Thamel\logs\log1.txt", favNum);
            string response = File.ReadAllText(@"C:\Users\Thamel\logs\log1.txt");
            Console.WriteLine("Your favorite number is {0}.", response);
            Console.ReadLine();
        }
    }
}
