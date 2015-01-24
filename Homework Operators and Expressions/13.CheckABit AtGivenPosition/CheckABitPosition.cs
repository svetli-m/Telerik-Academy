/*
 * Problem 13. Check a Bit at Given Position
Write a Boolean expression that returns if the bit at position p 
 * (counting from 0, starting from the right) in given integer number n, has value of 1.
 */


using System;
class CheckABitPosition
{
    static void Main()
    {
        bool isDigit1 = false;
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter index p for position: ");
        int index = int.Parse(Console.ReadLine());

        int number1 = 1;
        int numBit = (number >> index);
        int result = number1 & numBit;

        if (result == 1)
        {
            isDigit1 = true;
        }
        Console.WriteLine("Is bit {0} of intiger {1} equal to 1?: {2}", index, number, isDigit1);
    }
}