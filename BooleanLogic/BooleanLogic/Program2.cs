using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string val = Console.ReadLine();
            int res = Convert.ToInt32(val);
            
            Console.WriteLine("Have you ever had a DUI?");
            bool val2 = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            string val3 = Console.ReadLine();
            int res2 = Convert.ToInt32(val);

            Console.WriteLine("Qualified?");
            Console.ReadLine();
            bool result = (res > 15 && val2 == false && res2 >= 3);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
.
