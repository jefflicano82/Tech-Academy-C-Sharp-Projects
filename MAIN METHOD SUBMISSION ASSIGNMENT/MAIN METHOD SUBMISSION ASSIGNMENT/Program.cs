using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN_METHOD_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var operatorObject = new Operator();
            Console.WriteLine(operatorObject.Add(5));

            Console.WriteLine(operatorObject.Add(.5m));

            Console.WriteLine(operatorObject.Add("10"));
            //Passed in an integer, a decimal, and a string. 
        }
    }
}
