using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Page97Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string Title = "Smash Mouth - All Star";
            Title = Title.ToUpper();
            Console.WriteLine(Title);

            string AllStar1 = "Somebody once told me the world was gonna roll me ";
            string AllStar2 = "I ain't the sharpest tool in the shed ";
            string AllStar3 = "She was looking kind of dumb with her finger and her thumb in the shape of an \"L\" on her forehead";

            StringBuilder lyrics = new StringBuilder();
            lyrics.Append("Well the years start coming and they don't stop coming");
            lyrics.Append("Fed to the rules and I hit the ground running");
            lyrics.Append("Didn't make sense not to live for fun");
            lyrics.Append("Your brain gets smart but your head gets dumb");

            Console.WriteLine(AllStar1 + AllStar2 + AllStar3);
            Console.ReadLine();
            Console.WriteLine(lyrics);
            Console.ReadLine();
        }
    }
}
