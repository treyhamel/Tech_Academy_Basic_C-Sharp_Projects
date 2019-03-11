using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page114_Task
{
    class Class1
    {
        public int Operation(int int1)
        {
            int result = int1 * int1 * int1;
            return result;
        }

        public int Operation(double dub1)
        {
            int result = Convert.ToInt32(dub1 * dub1 * dub1);
            return result;
        }

        public int Operation(string str1)
        {
            int int1 = Convert.ToInt32(str1);
            int result = int1 * int1 * int1;
            return result;
        }
    }
}
