/*
 * Problem 3. Divide by 7 and 5
Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
Examples:
n	Divided by 7 and 5?
3	false
0	false
5	false
7	false
35	true
140	true
 */


using System;
class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Please enter a number: ");

        int number;
        bool ValidNumber = int.TryParse(Console.ReadLine(), out number);

        while (ValidNumber == false)
        {
            Console.WriteLine("Error. Enter a valid number.");
            ValidNumber = int.TryParse(Console.ReadLine(), out number);
        }

        bool result1 = (number % 7 == 0) && (number % 5 == 0);

        Console.WriteLine("Divided by 7 and 5? \n{0} \t{1}", number, result1);

    }
}
