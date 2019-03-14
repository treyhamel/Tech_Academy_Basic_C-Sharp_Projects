using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page165_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age?");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0) throw new ArgumentException();
                
                DateTime current = new DateTime();
                current = DateTime.Now;
                DateTime born = new DateTime();
                born = current.AddYears(-age);
                Console.WriteLine("You were born in {0}", born.Year);
                Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("You can't be 0 years or younger. Please input a positive whole number");
                Console.ReadLine();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was something wrong with your input. Please input a positive whole number");
                Console.ReadLine();
                return;
            }
        }
    }
}
