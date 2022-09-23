using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateandTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Current Date and Time is : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.ReadLine();


            Console.WriteLine("Enter in a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            DateTime now2 = now.AddHours(userInput);

            Console.WriteLine(now2);
            Console.ReadLine();
        }
    }
}
