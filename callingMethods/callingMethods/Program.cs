using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here I allow the user to insert their input and convert it to an integer. 
            Console.WriteLine("Enter input:");
            var userValue = Convert.ToInt32(Console.ReadLine());

            //I instantiate the operatorObject here and call each mathmatical operation. 
            var operatorObject = new Operator();
            var result = operatorObject.Add(userValue, 4);
            Console.WriteLine(result);
            Console.ReadLine();
            result = operatorObject.Subtract(result, 3);
            Console.WriteLine(result);
            Console.ReadLine();
            result = operatorObject.Divide(result, 1);
            Console.WriteLine(result);
            Console.ReadLine();

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
