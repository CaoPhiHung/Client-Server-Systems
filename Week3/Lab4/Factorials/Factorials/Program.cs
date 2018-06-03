using System;

namespace Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = -1;
            //loop until get valid input (positive integer)
            while (n < 0) {
                Console.Write("Enter positive integer: ");
                n = Int16.Parse(Console.ReadLine());
                if (n > 0) {
                    int result = getFactorial(n);
                    String display = n + "! is " + result + "\n";
                    Console.Write(display);
                }
                else
                {
                    //display error message
                    Console.Write("Invalid input\n");
                }
            }
            Console.ReadLine();
        }

        static int getFactorial(int n)
        {
            //default casae
            if (n == 1 || n == 0)
            {
                return 1;
            }
            //keep looping through smaller number until get the default case
            return n * getFactorial(n - 1);
        }
    }
}
