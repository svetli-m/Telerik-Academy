/*
 * Problem 13.* Comparing Floats
Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b 
 * because of the nature of the floating-point arithmetic. Therefore, we assume two numbers
 * are equal if they are more closely to each other than a fixed constant eps.
 */


using System;
class PrecisionComparingFloats
{
    static void Main()
    {
        Console.Write("Enter Number1: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter Number2: ");
        double number2 = double.Parse(Console.ReadLine());
        double eps = 0.000001d;
        double result = number1 - number2;

        if (result < eps)
        {
            Console.WriteLine("Precision of 0.000001 between {0}:{1} is true", number1, number2);
        }
        else
        {
            Console.WriteLine("Precision of 0.000001 between {0}:{1} is false", number1, number2);
        }
    }
}
