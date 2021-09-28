﻿using System;

namespace AronGibsonLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            String again = "";
            Console.WriteLine("Enter name.");
            String name = Console.ReadLine();

            do
            {
                Console.WriteLine($"Enter number {name}");
                int num = int.Parse(Console.ReadLine());

                if (num > 100)
                {
                    Console.WriteLine("Must be between 1 and 100 (inclusive)");
                    continue;
                }
                else if (num < 1)
                {
                    Console.WriteLine("Must be between 1 and 100 (inclusive)");
                    continue;
                }
                else if (num % 2 == 0)
                {
                    if (num < 25)
                        Console.WriteLine($"{num} Even and less than 25");
                    else if (num < 60)
                        Console.WriteLine($"{num} Even and between 25 and 60");
                    else
                        Console.WriteLine($"{num} Even and greater than 60");
                }
                else
                {
                    if (num < 25)
                        Console.WriteLine($"{num} Odd and less than 25");
                    else if (num < 61)
                        Console.WriteLine($"{num} Odd and between 25 and 60");
                    else
                        Console.WriteLine($"{num} Odd and greater than 60");
                }

                Console.WriteLine($"Do you want to keep going {name} ? y or n");
                again = Console.ReadLine().ToLower();

            } while (again == "y");
        }
    }
}