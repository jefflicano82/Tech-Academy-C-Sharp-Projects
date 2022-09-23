using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classSubmission1 { 

    public class MathMethod
    {
        // out - means that parameter will be passed out of method
        public void Output(out string d) //Defining output and assining the value
        {
            d = "hey"; 
            Console.WriteLine(d);
            
        }
        public void Output(int number)
        {
            Console.WriteLine(number / 2);
        }

     
