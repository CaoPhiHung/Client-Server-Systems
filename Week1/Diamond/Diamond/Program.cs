using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variable 
            int noOfRows = 0;
            bool stop = false;

            //Get user input
            while (!stop) {
                Console.Write("Enter number of rows 1 to 19: ");
                noOfRows = Int16.Parse(Console.ReadLine());

                // check user input 
                if ((noOfRows >= 1 && noOfRows <= 19 ) && noOfRows % 2 != 0)
                {
                    // height of half diamond
                    int height = (noOfRows + 1) / 2;

                    drawTopDiamond(height); // draw first half
                    drawBottomDiamond(height - 1); // draw second half

                    Console.ReadLine();
                    stop = true; // stop the loop
                }
                else
                {
                    Console.WriteLine("Invalid Input"); // display error message
                }
            }
        }
        static void drawTopDiamond(int height)
        {
            int rows = height;
            int noOfStar = 1;
            int noOfSpace = rows - 1;

            // loop through each row
            for (int rowCount = 1; rowCount <= rows; rowCount++)
            {
                //draw space
                for (int i = 0; i < noOfSpace; i++)
                {
                    Console.Write(" ");
                }
                // draw atterisk
                for (int i = 0; i < noOfStar; i++)
                {
                    Console.Write("*");
                }
                //increase number of star by 2 (to become odd number)
                noOfStar += 2;
                noOfSpace--; // decrease number of space
                Console.WriteLine(""); // go to the next line
            }
        }

        static void drawBottomDiamond(int height)
        {
            int rows = height;
            int noOfStar = 2 * (rows - 1) + 1;
            int noOfSpace = 1;
            // loop through each row
            for (int rowCount = 1; rowCount <= rows; rowCount++)
            {
                //draw space
                for (int i = 0; i < noOfSpace; i++)
                {
                    Console.Write(" ");
                }
                // draw atterisk
                for (int i = 0; i < noOfStar; i++)
                {
                    Console.Write("*");
                }

                //decrease number of star
                noOfStar -= 2;
                noOfSpace++; // increase number of space
                Console.WriteLine(""); // go to the next line
            }
        }
    }
}
