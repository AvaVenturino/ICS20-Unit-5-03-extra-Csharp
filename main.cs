// Created by: Ava Venturino
// Created on: April 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int userAge;

        Console.WriteLine("Write your age:");
        userAge = int.Parse(Console.ReadLine());
        if (userAge > 17)
        {
            Console.WriteLine("You are eligible to watch R rated movies alone.");
        }
        else if (userAge > 12)
        {
            Console.WriteLine("You are eligible to watch PG 13 rated movies alone.");
        }
        else if (userAge > 4)
        {
            Console.WriteLine("You are eligible to watch G and PG rated movies alone.");
        }
        else
        {
            Console.WriteLine("You cannot watch any rated movies alone");
        }
        Console.WriteLine("Done.");
    }
}