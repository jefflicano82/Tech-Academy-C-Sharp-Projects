using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jeff";
            string state = "is good";
            string life = "with life";
            string myUpper = life.ToUpper();


            Console.WriteLine(name + state + myUpper);
            Console.ReadLine();

            StringBuilder sbr = new StringBuilder("My Favourite Programming Font is ");
            sbr.Append("Inconsolata");
        }
    }
}
