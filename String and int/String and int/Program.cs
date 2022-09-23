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
            try
            {
                List<int> myValues = new List<int>(new int[] { 4, 6, 8, 10 });
                Console.WriteLine("Please pick a number to divide by");
                int number1 = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < myValues.Count; i++)
                {
                    Console.WriteLine(myValues[i] / number1);
                }


                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}

