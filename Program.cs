﻿using System;

namespace Learn_dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!, loving .NET core already. aren't you?");
        }
    }
}
