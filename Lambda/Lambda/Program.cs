using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employee = new List<Employee>()

            {
                new Employee() { FirstName = "Joe", LastName = "Shoe", Id = 5 },
                new Employee() { FirstName = "Joe", LastName = "Poe", Id = 4},
                new Employee() { FirstName = "Hyein", LastName = "Kim", Id = 12 },
                new Employee() { FirstName = "Taehee", LastName = "Licano", Id = 7 },
                new Employee() { FirstName = "Soyoun", LastName = "Park", Id = 6 },
                new Employee() { FirstName = "Jon", LastName = "Scottsdale", Id = 1 },
                new Employee() { FirstName = "Elliott", LastName = "George", Id = 5 },
                new Employee() { FirstName = "Joseph", LastName = "MacDonald", Id = 15 },
                new Employee() { FirstName = "Kate", LastName = "Buss", Id = 27 },
                new Employee() { FirstName = "Sunny", LastName = "Peterson", Id = 101 },
            };

            List<Employee> People = new List<Employee>();

            foreach (Employee name in Employee)
                if (name.FirstName=="Joe")
            {
                People.Add(name);
                Console.WriteLine("Names with " + name.FirstName + " using foreach loop");
              

            }

            List<Employee> People2 = new List<Employee>();
            People2 = Employee.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee person in People2)
            {
                Console.WriteLine("Names " + person.FirstName + " Added to the List using lambda");
              

            }


            List<Employee> People3 = new List<Employee>();
            People3 = Employee.Where(x => (x.Id > 5)).ToList();
            foreach(Employee personId in People3)
            {
                Console.WriteLine(personId.Id);
              
            }
            Console.ReadLine();

        }


    }
}
