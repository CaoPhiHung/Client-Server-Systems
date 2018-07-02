using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Tossing
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            int heads = 0;
            int tails = 0;
            while (!exit)
            {
                Console.WriteLine("1. Toss Coin \n2. Exit");
                Console.Write("Enter choice: ");
                int choice = Int16.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if (flip())
                        {
                            heads++;
                        }
                        else
                        {
                            tails++;
                        }
                        Console.WriteLine("Heads: " + heads + ", Tails: " + tails);
                        break;
                    case 2:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\n Invalid Input \n");
                        break;
                }
            }
            Console.ReadLine();
        }

        static bool flip()
        {
            Random rand = new Random();
            return rand.Next(0,2) > 0 ? true : false;
        }
    }
}
