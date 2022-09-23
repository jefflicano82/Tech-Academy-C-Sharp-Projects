using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment3
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


            foreach (string name in names)
            {
                if (userInput2 == name)
                {
                    Console.WriteLine("good choice");
                    break;
                }

                else
                {
                    Console.WriteLine("Please pick another team. The team you picked is not on the list.");
                }

            }
            Console.ReadLine();

            List<string> cities = new List<string>() { "Korea", "Korea", "Japan", "China" };
            Console.WriteLine("Please write the name of Southeast Asian country");
            string userInput3 = Console.ReadLine();

            for (int i = 0; i < cities.Count; i++)
            {
                cities[i] += userInput3;
            }
            Console.ReadLine();

            if (userInput3 != "Japan" || userInput3 != "Korea" || userInput3 != "China")

            {
                Console.Write("Please pick another country");
            }

            List<string> countries = new List<string>() { "Korea", "Korea", "Japan", "China" };
            for (int i = 0; i < countries.Count; i++)
            {
                while (i == "Japan" || i == "China")
                {
                    Console.WriteLine("This value is unique");
                }
                while (i == Korea)
                {
                    Console.WriteLine("This value is not unique");
                }
            }
        }
    }
}
