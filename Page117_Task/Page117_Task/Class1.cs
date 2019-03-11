using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page117_Task
{
    class Class1
    {
        public void divTwo(int int1, out int result)
        {
            result = int1 / 2;
            Console.WriteLine(int1 + " divided by 2 is: " +result);
        }
        
        public int Area(int int1)
        {
            return int1 * int1;
        }

        public int Area(int int1, int int2)
        {
            return int1 * int2;
        }
    }
}
