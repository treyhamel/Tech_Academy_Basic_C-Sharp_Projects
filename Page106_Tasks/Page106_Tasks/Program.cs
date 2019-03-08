using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page106_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> intList = new List<int>
                { 5, 20, 69, 29, 49, 290, 11, 22, 8, 12 };
                Console.WriteLine("Choose a number to divide each number in the list by.");
                int divisor = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < intList.Count; i++)
                {
                    double result = intList[i] / divisor;
                    Console.WriteLine(intList[i] + " / " + divisor + " = " + result);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please input a whole number.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
