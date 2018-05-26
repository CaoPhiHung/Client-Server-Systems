using System;

namespace BarChart
{
    class Program
    {
        static void Main(string[] args)
        {
            // loop 3 times
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\nEnter number between 1 and 30: ");
                int num = Int16.Parse(Console.ReadLine());
                //check input
                if (num >= 1 && num <= 30) {
                    drawChart(num);
                }
                else
                {
                    //display error message
                    Console.WriteLine("Invalid input");
                    i--;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        //draw chart
        static void drawChart(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write("*");
            }
        }
    }
}
