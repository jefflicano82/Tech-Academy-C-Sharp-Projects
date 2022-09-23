using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_PartApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Elements = new string[5];

            Elements[0] = "fire";
            Elements[1] = "Earth";
            Elements[2] = "Water";
            Elements[3] = "Air";
            Elements[4] = "matter";


            Console.WriteLine("Please write some text");
            string userInput = Console.ReadLine();
            for (int i = 0; i < Elements.Length; i++)
            {
                Elements[i] += userInput;
            }
            for (int i = 0; i < Elements.Length; i++)
            {
                Console.WriteLine(Elements[i]);
            }

            Console.ReadLine();

            //for (int a = 0; a < 50; a--)
            //{
            //    Console.WriteLine("value : {0}", a);
            //}
            //Console.ReadLine(); //in this example I decremented a which started at 0. 
            //to correct this I started incrementing. 

            for (int a = 0; a < 50; a++)
            {
                Console.WriteLine("value : {0}", a);
            }
            Console.ReadLine();

            for (int a = 0; a <= 50; a++)
            {
                Console.WriteLine("value : {0}", a);
            }
            Console.ReadLine();


            List<string> names = new List<string>() { "Dodgers", "Cubs", "Yankees", "Braves" };
            Console.WriteLine("Please write the name of an MLB team");
            string userInput2 = Console.ReadLine();

            int foundAt = -1;
            for (int d = 0; 0 < names.Count; d++)
            {
                string lookingAt = names[d];
                if (lookingAt == userInput2)
                {
                    foundAt = d;
                    break; //exit the loop early
                }
            }
            if (foundAt == -1)
                Console.WriteLine("The list doesn't have the team you're looking for");
            else
                Console.WriteLine("The team you're looking for is in list index " + foundAt);
            Console.ReadLine();

            List<string> cities = new List<string>() { "Korea", "Korea", "Japan", "China" };
            Console.WriteLine("Please write the name of Southeast Asian country, either Korea, Japan, or China");
            string userInput3 = Console.ReadLine();

            int foundAt1 = -1;
            for (int d = 0; 0 < cities.Count; d++)
            {
                string lookingAt1 = cities[d];
                if (lookingAt1 == userInput3)
                {
                    foundAt1 = d;
                    break; //exit the loop early
                }
            }
            if (foundAt1 == -1)
                Console.WriteLine("The list doesn't have the country you're looking for");
            else
                Console.WriteLine("The country you're looking for is in list index " + foundAt1);
            Console.ReadLine();

            List<string> countries = new List<string>() { "Korea", "Korea", "Japan", "China" };
            List<string> countries2 = new List<string>() { };
            
            foreach (string country in countries )
            {
                if (countries2.Contains(country))
                {
                    Console.WriteLine("We have seen this before: {0}", country); 
                }
               
                else
                {
                    Console.WriteLine("We have not seen this before; {0}", country);
                    countries2.Add(country);
                }
   
            }
                
        }
    }
}

