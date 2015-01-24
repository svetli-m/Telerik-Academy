/*
 * Problem 7. Point in a Circle
Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
 */


using System;
class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Check coordinates X and Y.");
        Console.Write("Enter coordinate x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter coordinate y: ");
        double y = double.Parse(Console.ReadLine());

        bool position = ((double)x * x) + ((double)y * y) <= 2;
        Console.WriteLine("The point is in the circle. {0}", position);
    }
}
