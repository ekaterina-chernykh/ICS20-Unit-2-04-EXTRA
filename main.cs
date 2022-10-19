// Created by: Ekaterina
// Created on: Oct 2022
//
// This program calculates area of a triangle

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int heightOfTriangle;
        int baseOfTriangle;
        int area;

        Console.WriteLine("This program calculates the area of a triangle.");
        Console.WriteLine(" ");

        Console.Write("Enter the height (cm): ");
        heightOfTriangle = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the base (cm): ");
        baseOfTriangle = Convert.ToInt32(Console.ReadLine());

        area = (heightOfTriangle * baseOfTriangle) / 2;

        Console.WriteLine(" ");
        Console.WriteLine("The area is: " + area + "cm². ");

        Console.WriteLine("\nDone.");
    }
}