using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page162_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            const double CelsiusToKelvin = 273.15;
            var TempCelsius = 24.5;
        
            var TempKelvin = TempCelsius + CelsiusToKelvin;
            Console.WriteLine("It is {0} deg C, or {1} K", TempCelsius, TempKelvin);
            Console.ReadLine();

            Student student1 = new Student();
            Student student2 = new Student("Trey");
            Student student3 = new Student("Caleb", 10);
        }
    }
}
