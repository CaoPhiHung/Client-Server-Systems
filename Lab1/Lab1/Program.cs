using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfRows = 0;
            Console.Write("Enter number of rows 1 to 19: ");
            noOfRows = Int16.Parse(Console.ReadLine());

            if (noOfRows % 2 == 0 && noOfRows < 1 || noOfRows > 19)
            {
                Console.WriteLine("Invalid Input");
            }

            int height = (noOfRows + 1) / 2;
            drawTopDiamond(height);
            drawBottomDiamond(height - 1);
            Console.ReadLine();
        }

        static void drawTopDiamond(int height)
        {
            int rows = height;
            int starCount = 1;
            int spaceCount = rows - 1;
            for (int rowCount = 1; rowCount <= rows; rowCount++)
            {
                for (int i = 0; i < spaceCount; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < starCount; i++)
                {
                    Console.Write("*");
                }
                starCount += 2;
                spaceCount--;
                Console.WriteLine("");
            }
        }

        static void drawBottomDiamond(int height)
        {
            int rows = height;
            int starCount = 2 * (rows - 1) + 1;
            int spaceCount = 1;
            for (int rowCount = 1; rowCount <= rows; rowCount++)
            {
                for (int i = 0; i < spaceCount; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < starCount; i++)
                {
                    Console.Write("*");
                }
                starCount -= 2;
                spaceCount++;
                Console.WriteLine("");
            }
        }
    }
}
