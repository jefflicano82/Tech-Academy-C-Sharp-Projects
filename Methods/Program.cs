using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input:");
            var userValue = Convert.ToInt32(Console.ReadLine());

            var operatorObject = new Operator();
            var result = operatorObject.Add(userValue, 4);
            result = operatorObject.Subtract(result, 3);
            result = operatorObject.Divide(result, 1);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
