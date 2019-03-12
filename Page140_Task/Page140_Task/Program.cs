using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page140_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { firstName = "John", lastName = "Ellisor", Id = 1 };
            Employee employee2 = new Employee() { firstName = "Joe", lastName = "Schilkofski", Id = 2};
            Employee employee3 = new Employee() { firstName = "Larry", lastName = "Ellis", Id = 4};
            Employee employee4 = new Employee() { firstName = "Haley", lastName = "Smith", Id = 5};
            Employee employee5 = new Employee() { firstName = "Raul", lastName = "Corrida", Id = 9};
            Employee employee6 = new Employee() { firstName = "James", lastName = "Robinson", Id = 12};
            Employee employee7 = new Employee() { firstName = "Brad", lastName = "Pinkerman", Id = 13};
            Employee employee8 = new Employee() { firstName = "Joe", lastName = "Thomas", Id = 18};
            Employee employee9 = new Employee() { firstName = "Steve", lastName = "Anderson", Id = 20};
            Employee employee10 = new Employee() { firstName = "Jolene", lastName = "Cavins", Id = 22};

            List<Employee> empList = new List<Employee>()
            { employee1, employee2, employee3, employee4, employee5,
                employee6, employee7, employee8, employee9, employee10};

            List<Employee> empList_Joe = new List<Employee>();

            foreach (Employee emp in empList)
            {
                if (emp.firstName == "Joe")
                {
                    empList_Joe.Add(emp);
                }
            }

            List<Employee> empList_Joe_Lambda = empList.Where(x => x.firstName == "Joe").ToList();

            List<Employee> empList_IdOver5 = empList.Where(x => x.Id > 5).ToList();
        }
    }
}
