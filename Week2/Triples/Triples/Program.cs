using System;

namespace Triples
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int side1, side2, hypotenuse, limit = 500;
            Console.WriteLine("Pythagorean Triples:");
            //loop through side1
            for (side1 = 1; side1 <= limit; side1++)
            {
                //loop through side2
                for (side2 = 1 ; side2 <= limit; side2++)
                {
                    //loop through hypotenuse
                    for (hypotenuse = 1; hypotenuse <= limit; hypotenuse++)
                    {
                        //check result if match condition then print result
                        if (Math.Pow(side1,2) + Math.Pow(side2,2) == Math.Pow(hypotenuse,2))
                        {
                            Console.Write(side1 + " ");
                            Console.Write(side2 + " ");
                            Console.Write(hypotenuse + " ");
                            Console.WriteLine();
                        }
                    }
                }  
            }
            Console.ReadLine();
        }
    }
}
