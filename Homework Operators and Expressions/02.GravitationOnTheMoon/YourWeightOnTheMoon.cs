/*
 * Problem 2. Gravitation on the Moon
The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 */


using System;

class YourWeightOnTheMoon
{
    static void Main()
    {
        Console.Write("Enter your Erth weight: ");
       
        double EarthWeight;
        bool isDouble = double.TryParse(Console.ReadLine(), out EarthWeight);
        double MoonGravity = 17.0 / 100;
        double WeightOnMoon = EarthWeight * MoonGravity;
       
        if (isDouble == true)
        {
            Console.WriteLine("Your weight on the Moon is: "+ WeightOnMoon);
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}
