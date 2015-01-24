/*
 * Problem 9. Trapezoids
Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */

using System;

class AreaOfTrapezoid
{
    static void Main()
    {
        Console.WriteLine("Calculate the area of trapezoid.");
        Console.Write("Enter sides a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter sides b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter height h: ");
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) / 2) * h;

        Console.WriteLine("The area of the trapezoid is: {0}", area);




    }
}
