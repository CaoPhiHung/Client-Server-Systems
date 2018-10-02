using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtle_Graphics
{
    class Program
    {
        static void Main(string[] args)
        {
            int command = 0;
            String[,] array2D = new String[20,20];
            int currentRow = 0;
            int currentCol = 0;
            int spaces = 0;
            String direction = "right";
            bool isDown = false;

            for (int i = 0; i< 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    array2D[i, j] = " ";
                }
            }

            do
            {
                Console.Write("Enter command (9 to end input): ");
                command = Int16.Parse(Console.ReadLine());
                switch (command) {
                    case 1:
                        isDown = false;
                        break;
                    case 2:
                        isDown = true;
                        break;
                    case 5:
                        if (isDown) {

                            Console.Write("Enter forward spaces: ");
                            spaces = Int16.Parse(Console.ReadLine());
                            if (direction == "right") {
                                for (int col = 0; col < spaces; col++)
                                {
                                    array2D[currentRow, col] = "*";
                                }
                                currentCol = spaces;
                            }
                            else if (direction == "down")
                            {
                                for (int row = currentRow; row < spaces; row++)
                                {
                                    array2D[row, currentCol] = "*";
                                }
                                currentRow = spaces;
                            }else if (direction == "left")
                            {
                                for (int col = spaces; col > 0; col--)
                                {
                                    array2D[currentRow, col] = "*";
                                }
                                currentCol -= spaces;
                            }else if (direction == "up")
                            {
                                for (int row = currentRow; row > currentRow - spaces; row--)
                                {
                                    array2D[row, currentCol] = "*";
                                }
                                currentRow -= spaces;
                            }
                        }

                        break;
                    case 3: //move right
                        if (direction == "none")
                        {
                            direction = "right";
                        }
                        else if (direction == "right")
                        {
                            direction = "down";
                        } else if (direction == "down")
                        {
                            direction = "left";
                        } else if (direction == "left")
                        {
                            direction = "up";
                        }
                        break;
                    case 6:
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 20; j++)
                            {
                                Console.Write(array2D[i, j]);
                            }
                            Console.WriteLine("");
                        }
                        break;
                } 
            } while (command != 9);
        }
    }
}
