// Created by: Ava Venturino
// Created on: April 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int num;
        Console.Write("Determine what movie a person is aloud to watch based off of their age:");
        Console.ReadLine();
        Console.Write("Enter your age : ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num == 17) {
            Console.WriteLine("You can see an R rated movie alone!");
        }  else if (num == 13) {
            Console.WriteLine("You can see a PG 13 rated movie alone!");
        }  else if (num == 5) {
            Console.WriteLine("You can see a G rated movie alone!");
        }  else {
            Console.WriteLine("Uh. You are too young for most things!");
        }
        Console.WriteLine("\nDone.");
    }
}