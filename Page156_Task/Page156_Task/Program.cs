using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page156_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = new DateTime();
            current = DateTime.Now;
            Console.WriteLine(current);
            Console.WriteLine("Please input a whole number");
            int response = Convert.ToInt32(Console.ReadLine());

            DateTime future = new DateTime();
            future = current.AddHours(response);
            Console.WriteLine("In {0} hours, it will be: {1}", response, future);
            Console.ReadLine();
        }
    }
}
