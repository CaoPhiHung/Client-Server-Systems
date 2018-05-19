using System;

namespace Triples
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, i = 0, limit = 500;
            Console.WriteLine("Pythagorean Triples:");
            for (a = 1; a <= limit; a++)
            {
                for (b = 1 ; b <= limit; b++)
                {
                    for (c = 1; c <= limit; c++)
                    {
                        if (Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c,2))
                        {
                            //   Console.WriteLine("%3d : { %3d, %3d, %3d }\n", ++i, a, b, c);
                            Console.Write(a + " ");
                            Console.Write(b + " ");
                            Console.Write(c + " ");
                            Console.WriteLine();
                        }
                    }
                }  
            }
            Console.ReadLine();
        }
    }
}
