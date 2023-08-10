using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1___Programmering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set console title
            Console.Title = "Stars And Stripes";

            // Loop to create the top part of the flag (stripes and stars)
            for (int i = 0; i < 24; i++)
            {
                if (i == 0 || i == 10)
                {
                    // Create blue stripes and stars on the first and eleventh lines
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("                       ");

                    if (i == 0)
                    {
                        // Add a red rectangle and blue stars on the first line
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("               ");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(" *   *   *   *   *   * ");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("               ");
                    }
                    else
                    {
                        // Create a white stripe on the eleventh line
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("               ");
                    }
                }
                else if (i >= 1 && i <= 9)
                {
                    // Create alternating blue and white stripes, and position stars
                    if (i == 1 || i == 5)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("   *   *   *   *   *   ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("               ");
                    }
                    else if (i == 2 || i == 6)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(" *   *   *   *   *   * ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("               ");
                    }
                    else if (i == 3 || i == 7)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("   *   *   *   *   *   ");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("               ");
                    }
                    else if (i == 4 || i == 8)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(" *   *   *   *   *   * ");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("               ");
                    }
                }
            }

            // Loop to create the bottom part of the flag (stripes)
            for (int i = 1; i < 16; i++)
            {
                if (i == 1 || i == 4 || i == 5 || i == 8 || i == 9 || i == 12 || i == 13)
                {
                    // Create white stripes on specific lines
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("                                      ");
                }
                else
                {
                    // Create red stripes on other lines
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("                                      ");
                }
            }

            // Wait for user input before exiting
            Console.ReadLine();
        }
    }
}
