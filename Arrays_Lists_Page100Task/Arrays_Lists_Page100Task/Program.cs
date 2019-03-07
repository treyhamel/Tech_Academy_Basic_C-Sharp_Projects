using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Lists_Page100Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Sky", "Earth", "Street", "Sign", "Truck", "Phone" };
            int[] intArray = { 34, 3, 8, 41, 11, 48, 27, 5 };
            List<string> stringList = new List<string>();
            stringList.Add("Park");
            stringList.Add("Wheel");
            stringList.Add("Have a nice day.");
            stringList.Add("Temperature");
            stringList.Add("Weight");

            Console.WriteLine("Select a whole number from 0 to 5 for your lucky word!");
            int luckyWord = Convert.ToInt32(Console.ReadLine());
            if (luckyWord == 0 || luckyWord == 1 || luckyWord == 2 || luckyWord == 3 || luckyWord == 4 || luckyWord == 5)
            {
                Console.WriteLine(stringArray[luckyWord]);
            }
            else
            {
                Console.WriteLine("Sorry, whatever you put in is not a whole number between 0 and 5.");
            }

            Console.WriteLine("Select a whole number from 0 to 7 for your lucky powerball number!");
            int luckyNumber = Convert.ToInt32(Console.ReadLine());
            if (luckyNumber == 0 || luckyNumber == 1 || luckyNumber == 2 || luckyNumber == 3 || luckyNumber == 4 || luckyNumber == 5 || luckyNumber == 6 || luckyNumber == 7)
            {
                Console.WriteLine("Your lucky number is " + intArray[luckyNumber]);
            }
            else
            {
                Console.WriteLine("Sorry, whatever you put in is not a whole number between 0 and 7.");
            }

            Console.WriteLine("Select a whole number from 0 and 4 for another lucky word");
            int luckyWord2 = Convert.ToInt32(Console.ReadLine());
            if (luckyWord2 == 0 || luckyWord2 == 1 || luckyWord2 == 2 || luckyWord2 == 3 || luckyWord2 == 4)
            {
                Console.WriteLine("Your lucky word is " + stringList[luckyWord2]);
            }
            else
            {
                Console.WriteLine("Whatever you put in was not a whole number between 0 and 4.");
            }
            Console.ReadLine();
        }
    }
}
