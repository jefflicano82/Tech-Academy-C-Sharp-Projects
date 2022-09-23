using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {

        enum Days
        {
            Sunday,    // 0
            Monday,   // 1
            Tuesday,      // 2
            Wednesday,      // 3
            Thursday,        // 4
            Friday,       // 5
            Saturday        // 6
        }

        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Enter a day of the week");
                string strUserInput = Console.ReadLine();
                Days Input = (Days)Enum.Parse(typeof(Days), strUserInput);
            }

            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }


        }
    }
    } 