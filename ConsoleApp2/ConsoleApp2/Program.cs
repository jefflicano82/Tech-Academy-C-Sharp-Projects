using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           
           

            bool teamName = false;

            do
            {
                Console.WriteLine("Guess a team");
                string team = Console.ReadLine();
                switch (team)
                {
                    case "Giants":
                        Console.WriteLine("You guessed the Giants. Terrible choice");
                        Console.ReadLine();
                        break;
                    case "Padres":
                        Console.WriteLine("You guessed the Padres. Try again");
                        Console.ReadLine();
                        break;

                    case "Dodgers":
                        Console.WriteLine("You guessed correctly.");
                        teamName = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong");
                        Console.ReadLine();
                        break;


                }
            }
            while (!teamName);
                    Console.WriteLine("Good job");
                Console.ReadLine();
            
       }
    } 
}










  