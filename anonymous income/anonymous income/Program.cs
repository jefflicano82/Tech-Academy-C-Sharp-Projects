using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_income
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person1");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate?");
            string val = Console.ReadLine();
            int res = Convert.ToInt32(val);

            Console.WriteLine("Hours worked per week");
            string val2 = Console.ReadLine();
            int res2 = Convert.ToInt32(val2);

            Console.WriteLine("Person2");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate?");
            string val3 = Console.ReadLine();
            int res4 = Convert.ToInt32(val3);

            Console.WriteLine("Hours worked per week");
            string val5 = Console.ReadLine();
            int res6 = Convert.ToInt32(val5);

            Console.WriteLine("Annual salary of Person 1");
            int product = res * res2*52;
            Console.WriteLine(product);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2");
            int product2 = res4 * res6 * 52;
            Console.WriteLine(product2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueorfalse = product > product2;
            Console.Write(trueorfalse.ToString());
            Console.ReadLine();
        }
    }
}
