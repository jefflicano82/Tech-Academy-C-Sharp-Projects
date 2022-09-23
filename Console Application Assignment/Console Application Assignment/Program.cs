using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a number! ");
            string val = Console.ReadLine();
            int num1 = Convert.ToInt32(val);
            int product = num1 * 50;
            Console.WriteLine(product);
            Console.ReadLine();

            Console.WriteLine("Enter in a number! ");
            string val1 = Console.ReadLine();
            int num2 = Convert.ToInt32(val1);
            int sum = num2 + 25;
            Console.WriteLine(sum);
            Console.ReadLine();

            Console.WriteLine("Enter in a number! ");
            double num3 = Convert.ToInt32(Console.ReadLine());
            double quotient = num3 / 12.5;
            Console.WriteLine(quotient);
            Console.ReadLine();

            Console.WriteLine("Enter in a number! ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            int remainder = num4 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();
        }
    }
}
