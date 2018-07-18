using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Race
{
    class Program
    {
        static int positionH = 0;
        static int positionT = 3;
        static Timer t;
        static int count = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("ON YOUR MARK, GET SET");
            Console.WriteLine("BANG!!!!!!!!!!!");
            Console.WriteLine("AND THEY'RE OFF");
            Console.WriteLine("H T");

                t = new Timer(TimerCallback, null, 0, 1000);
            
            Console.ReadLine();
        }
        private static void TimerCallback(Object o)
        {
            // Display the date/time when this method got called.
            //Console.WriteLine("In TimerCallback: " + DateTime.Now);
            //Console.WriteLine("Hello");
            count++;
            positionH = move(positionH, "H");
            positionT = move(positionT, "T");
            if (positionH == positionT)
            {
                Console.WriteLine("OUCH!!!");
            }
            else if(positionH < 70 && positionT < 70)
            {
                draw(positionH, positionT);
            }
            else
            {
                if (positionT >= 70)
                {
                    Console.WriteLine("Tortoise Wins!!! YAY");
                }
                else if (positionH >= 70)
                {
                    Console.WriteLine("Hare Wins!!! Yuch");
                }
                Console.WriteLine("TIME ELAPSED = " + count + " seconds");
                t.Dispose();
            }

            
            Console.WriteLine("");
        }

        private static void draw(int positionH, int positionT)
        {
            int max = positionH;
            if (positionH < positionT)
            {
                max = positionT;
            }
            for (int i = 0; i <= max; i++)
            {
                
                if (i == positionH)
                {
                    Console.Write("H");
                }
                else if(i == positionT)
                {
                    Console.Write("T");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }

        private static int move(int x, string a)
        {
            Random rand = new Random();
            int t = rand.Next(10) + 1;
            switch (a)
            {
                case "H":
                    if (t <= 2)
                    {
                        //do nothing
                    }
                    else if (t <= 4)
                    {
                        x += 9;
                    }
                    else if (t <= 5)
                    {
                        x -= 12;
                    }
                    else if (t <= 8)
                    {
                        x += 1;
                    }
                    else
                    {
                        x -= 2;
                    }
                    break;
                case "T":
                    if (t <= 5)
                    {
                        x += 3;
                    }
                    else if (t <= 7)
                    {
                        x += 1;
                    }
                    else
                    {
                        x -= 6;
                    }
                    break;
            }
            if (x <= 0)
            {
                x = 1;
            }
            return x;
        }

    }
}
