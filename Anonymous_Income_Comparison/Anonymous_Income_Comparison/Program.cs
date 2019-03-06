using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("");
            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly Rate?");
            string person1Hourly = Console.ReadLine();
            double person1Rate = Convert.ToDouble(person1Hourly);
            Console.WriteLine("Hours worked per week?");
            string person1HoursWorked = Console.ReadLine();
            double person1Hours = Convert.ToDouble(person1HoursWorked);

            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly Rate?");
            string person2Hourly = Console.ReadLine();
            double person2Rate = Convert.ToDouble(person2Hourly);
            Console.WriteLine("Hours worked per week?");
            string person2HoursWorked = Console.ReadLine();
            double person2Hours = Convert.ToDouble(person2HoursWorked);

            double person1Annual = 50 * person1Hours * person1Rate;
            double person2Annual = 50 * person2Hours * person2Rate;
            Console.WriteLine("");
            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(person1Annual);
            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(person2Annual);
            Console.ReadLine();
        }
    }
}
