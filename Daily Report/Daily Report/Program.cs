using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            string yourname = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
           string val = Console.ReadLine();
            int res  = Convert.ToInt32(val);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool val6 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you would like to share? Please give specifics.");
          string val2 = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
          string ValueType3 = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
           string val4  = Console.ReadLine();
            int res4 = Convert.ToInt32(val);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.Have a great day!") ;
            string val5 = Console.ReadLine();
        }
    }
}

