using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Assignment
{
   public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }

        public void Quit ()
        {
            Console.WriteLine("I don't like bills, and I'm not goint to pay them anymore.");
        }

        public static bool operator ==(Employee emp1, Employee emp2) //Establisehd comparison operators for employees. 
        {
            return emp1.Id == emp2.Id;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.Id != emp2.Id;
        }

    }
}

//Make the Employee class take a generic type parameter.

//Add a property to the Employee class called “things” and have its data type be a generic list matching the generic type of the class.

//Instantiate an Employee object with type “string” as its generic parameter. Assign a list of strings as the property value of Things.

//Instantiate an Employee object with type “int” as its generic parameter. Assign a list of integers as the property value of Things.

//Create a loop that prints all of the Things to the Console.

//Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.