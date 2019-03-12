using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page131_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> empStr = new Employee<string>();
            empStr.Things = new List<string>()
                { "Longing", "Rusted", "Seventeen", "Daybreak", "Furnace", "Nine", "Benign", "Homecoming", "One", "Freight car"};

            Employee<int> empInt = new Employee<int>();
            empInt.Things = new List<int>()
                { 87, 65, 78, 1, 53, 21, 28, 18};

            foreach (string thing in empStr.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in empInt.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
