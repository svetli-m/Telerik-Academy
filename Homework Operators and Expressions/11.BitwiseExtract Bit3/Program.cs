﻿/*
 * Problem 11. Bitwise: Extract Bit #3
Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
 */


using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter positive number: ");
        int number = int.Parse(Console.ReadLine());
        int number3 = number >> 3;
        int number1 = 1;
        int result = number3 & number1;
        Console.WriteLine("The bit at position 3 is: {0}", result);
    }
}
