﻿using System;

namespace M4U2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Iteration {0}", i);
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your fav color is RED!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your fav color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your fav color is cyan...");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your color(yeah, just color) is yellow");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
