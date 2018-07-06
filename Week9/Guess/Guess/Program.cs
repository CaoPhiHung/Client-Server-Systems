using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Random rand = new Random();
            int randomNumber = rand.Next(1000 - 1) + 1;
            do
            {
                Console.WriteLine("Guess a number between 1 and 1000");
                Console.Write("Guess (0 to exit): ");
                num = Int16.Parse(Console.ReadLine().ToString());
                
                if (randomNumber < num)
                {
                    Console.WriteLine(num + " is too high. Try again");
                }
                else if(randomNumber > num)
                {
                    Console.WriteLine(num + " is too low. Try again");
                }
                else
                {
                    Console.WriteLine("Congratualtions. You guessed the number!\n");
                }
            } while (num != 0);

            Console.ReadLine();
        }
    }
}
