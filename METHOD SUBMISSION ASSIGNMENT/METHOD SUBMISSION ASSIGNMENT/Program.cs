using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            New numbers = new New();
            Console.WriteLine("Enter a number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number if you would like, or see your total now.");

            int total; 
            var validInput = int.TryParse(Console.ReadLine(), out int input2); 


            if (validInput)
            {
                total = New.twoParameters(input1, input2);
            }
            else
            {
                total = New.twoParameters(input1);
            }

            Console.WriteLine("Your total is: " + total);
            Console.ReadLine();

        }
    }
}
 