using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_APP_ARRAY_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] array = new string[5];

            array[0] = "hi";
            array[1] = "Hello";
            array[2] = "why"; 
            array[3] = "never";
            array[4] = "forever";


            Console.WriteLine("Please pick a number 0-4");
            int var = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(array [var]);
            Console.ReadLine();

            if (var > 4)
            {

                Console.WriteLine("Index does not exist ");
                
            }
            Console.ReadLine();

            int[] array2 = new int[5];

            array[0] = "1";
            array[1] = "2";
            array[2] = "3";
            array[3] = "4";
            array[4] = "5";


            Console.WriteLine("Please pick a number 0-4");
            int var2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(array2[var2]);
            Console.ReadLine();

            if (var2 > 4)
            {
                Console.WriteLine("Index does not exist ");
            }
            Console.ReadLine();

            var countries = new List<string>();
            countries.Add("India");
            countries.Add("Australia");
            countries.Add("Japan");

            Console.WriteLine("Please pick a number 0-2");
            int var3 = Convert.ToInt32(Console.Read());
            Console.WriteLine(countries[var3]);
        }
    }
}
