using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Approval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Questionnaire");
            Console.WriteLine("");
            Console.WriteLine("What is your age?");
            string applicantAge = Console.ReadLine();
            int Age = Convert.ToInt16(applicantAge);
            Console.WriteLine("");
            Console.WriteLine("Have you ever had a DUI? Answer with either \"true\" or \"false\"");
            string applicantDUI = Console.ReadLine();
            bool DUI = Convert.ToBoolean(applicantDUI);
            Console.WriteLine("");
            Console.WriteLine("How many speeding tickets do you have?");
            string applicantTickets = Console.ReadLine();
            int Tickets = Convert.ToInt16(applicantTickets);
            Console.WriteLine("");
            Console.WriteLine("Qualified?");
            bool tooManyTickets = Tickets >= 4;
            bool disqualifyDUI = DUI != false;
            bool ageTooLow = Age <= 15;
            bool notQualified = (tooManyTickets || disqualifyDUI || ageTooLow);
            bool Qualified = notQualified != true;
            Console.WriteLine(Qualified);
            Console.ReadLine();
        }
    }
}
