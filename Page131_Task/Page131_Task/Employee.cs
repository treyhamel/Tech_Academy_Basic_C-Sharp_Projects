using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page131_Task
{
    public class Employee<T>
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public List<T> Things { get; set; }
    }
}
