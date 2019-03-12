﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page129_Task
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public static bool operator== (Employee employee1, Employee employee2)
        {
            return (employee1.Id == employee2.Id);
        }

        public static bool operator!= (Employee employee1, Employee employee2)
        {
            return (employee1.Id != employee2.Id);
        }
    }
}
