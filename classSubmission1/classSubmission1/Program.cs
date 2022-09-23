using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classSubmission1
{
    class Program
    {
       
        
            static void Main(string[] args)
            {
             MathMethod b = new MathMethod(); //Instantiate
            Console.WriteLine("Enter in a number");
            int c= Convert.ToInt32(Console.ReadLine());
            b.Output(c);
            Console.ReadLine();

        }
        }
    }
   