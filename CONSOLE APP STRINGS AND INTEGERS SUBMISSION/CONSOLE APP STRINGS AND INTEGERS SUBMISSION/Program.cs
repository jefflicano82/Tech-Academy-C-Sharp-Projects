using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_APP_STRINGS_AND_INTEGERS_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myValues = new List<int>(new int[] { 4, 6, 8, 10 });
            Console.WriteLine("Please pick a number to divide by");
            int number1= Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < myValues.Count; i++)
            {
                var result = myValues [4] / number1;
                var result2 = myValues[6] / number1;
                var result3 = myValues[8] / number1;
                var result4 = myValues[10] / number1;
            }
            Console.ReadLine();
        }
    }
}
