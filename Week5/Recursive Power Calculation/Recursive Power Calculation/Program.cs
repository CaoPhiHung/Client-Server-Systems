using System;

namespace Recursive_Power_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            // get the base number
            Console.Write("Enter base: ");
            int base_number = Int16.Parse(Console.ReadLine());

            //get the exponent number
            Console.Write("Enter exponent: ");
            int exponent = Int16.Parse(Console.ReadLine());
            //display result
            Console.Write("Value is " + Power(base_number, exponent));
            Console.ReadLine();
        }

        static int Power(int base_number, int exponent)
        {
            //base case return the base_number
            if (exponent == 1)
            {
                return base_number;
            }
            //multiple the base number with the recursion of power function
            return base_number * Power(base_number, exponent - 1);
        }
    }
}
