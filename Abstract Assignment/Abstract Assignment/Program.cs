using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Employee() { firstName = "Sample", lastName = "Student", Id=3 }; //instantiate the class. 
            Person person2 = new Employee() { firstName = "Sample", lastName = "Student", Id = 4 }; //instantiate the class. 
            person.SayName(); //Perform function on the object 
            IQuittable employee = new Employee();
            employee.Quit();
            Console.WriteLine(person == person2); //Here I utilized comparison operators and returned false. 
            Console.ReadLine();
        }
    }
}
  