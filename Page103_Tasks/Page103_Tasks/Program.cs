using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page103_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Task 1 : Adding text to a 1D array of strings

            //string[] stringArray1 = { "Quick", "Smart", "Easy", "Wired", "Sluggish" };
            //Console.WriteLine("Please input text that will be added to each element in the array:");
            //string addition = Console.ReadLine();
            //for(int counter1 = 0; counter1 < stringArray1.Length; counter1++)
            //{
            //    Console.WriteLine(stringArray1[counter1] + addition);
            //}
            //Console.ReadLine();

            //// Task 2 : Infinite Loop

            //for (int counter2 = 1; counter2 <= 10;)
            //    //Trying to count up to 10, but oopsie I forgot to increment the counter each time through!
            //{
            //    Console.WriteLine(counter2);
            //}
            //Console.ReadLine();

            //// Task 3 : Fixing the Infinite Loop

            //for (int counter3 = 1; counter3 <= 10; counter3++)
            //{
            //    Console.WriteLine(counter3);
            //}
            //Console.ReadLine();

            //// Task 4 : Loop with a "<" operator.

            //int[] intArray1 = { 55, 22, 2, 69, 38, 13, 21 };
            //for (int counter4 = 0; counter4 < intArray1.Length; counter4++)
            //{
            //    Console.WriteLine(intArray1[counter4]);
            //}
            //Console.ReadLine();

            //// Task 5 : Loop with a "<=" operator.

            //int[] intArray2 = { 28, 91, 30, 22, 11, 8, 3 };
            //for (int counter5 = 1; counter5 <= intArray2.Length; counter5++)
            //{
            //    Console.WriteLine(intArray2[counter5 - 1]);
            //}
            //Console.ReadLine();

            //// Task 6, 7 and 8 : List of unique strings, loop that searches based on user input

            //List<string> stringList1 = new List<string>
            //{
            //    "Peter",
            //    "Joseph",
            //    "Quagmire",
            //    "Cleveland"
            //};
            //Console.WriteLine("Please input a name. If it exists in the list, the index where it is will be displayed.");
            //string userInput = Console.ReadLine();
            //for (int counter6 = 0; counter6 < stringList1.Count; counter6++)
            //{
            //    if (userInput == stringList1[counter6])
            //    {
            //        Console.WriteLine(userInput + " is on the " + counter6 + "th index in the list");
            //        break;
            //    }
            //    if (counter6 == stringList1.Count - 1 && userInput != stringList1[counter6])
            //    {
            //        Console.WriteLine("The text you input is not within this list.");
            //    }
            //}
            //Console.ReadLine();

            //// Task 9 & 10 : List of strings with two identical strings. Loop that displays indices of matching text

            //List<string> stringList2 = new List<string>
            //{
            //    "Florida",
            //    "Georgia",
            //    "South Carolina",
            //    "Georgia",
            //    "Florida",
            //    "North Carolina",
            //    "Alabama"
            //};
            //Console.WriteLine("Please input a state name. If it exists in the list, its index(es) will be displayed.");
            //string stateInput = Console.ReadLine();
            //for (int counter7 = 0; counter7 < stringList2.Count; counter7++)
            //{
            //    if (stateInput == stringList2[counter7])
            //    {
            //        Console.WriteLine(stateInput + " is on index " + counter7);
            //    }
            //    if (stateInput != stringList2[counter7] && counter7 == stringList2.Count -1)
            //    {
            //        Console.WriteLine(stateInput + " is not in this list.");
            //    }
            //}
            //Console.ReadLine();

            //// Task 11 : List of string w/ 2 identical strings. foreach loop on if something has occurred already in the list.

            //List<string> stringList3 = new List<string>
            //{
            //    "Turkey",
            //    "Ham & Swiss",
            //    "Tuna Melt",
            //    "Italian",
            //    "Ham & Swiss",
            //    "Turkey Club",
            //    "Italian"
            //};

            //List<string> AlreadyExists = new List<string>();
            //foreach (string sandwich in stringList3)
            //{
            //    if (AlreadyExists.Contains(sandwich))
            //    {
            //        Console.WriteLine(sandwich + ".  Has appeared before in the list");
            //    }
            //    else
            //    {
            //        Console.WriteLine(sandwich + ". Has not appeared before in the list");
            //    }
            //    AlreadyExists.Add(sandwich);
            //}
            
            //Console.ReadLine();
        }
    }
}
