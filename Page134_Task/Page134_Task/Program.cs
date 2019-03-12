using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page134_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the day of the week.");
            try
            {
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());
                Console.WriteLine("Today is " + day);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
