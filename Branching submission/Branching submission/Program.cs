using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.ReadLine();
            Console.WriteLine("Please enter in package weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Sorry, your package is too heavy");
                Console.ReadLine();

            }

            else
            {
                Console.WriteLine("Please enter package width");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter package height");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter package length");
                int length = Convert.ToInt32(Console.ReadLine());

                int total = height + length + width;

                if (total > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    int product = height * width * length * weight */ 100;
                    Console.WriteLine(product);
                    Console.WriteLine("Your estimated total for shipping this package is:" + "$" + product);
                    Console.ReadLine();
                    Console.ReadLine();
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }


            }
        }

    }