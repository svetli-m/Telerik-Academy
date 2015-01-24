/*
 * Problem 5. Third Digit is 7?
Write an expression that checks for given integer if its third digit from right-to-left is 7.
Examples:
n	    Third digit 7?
5	    false
701	    true
9703	true
877	    false
777877	false
9999799	true
 */


using System;
class ThirdDigit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        bool check = false;
        int number;
        bool CheckNumber = int.TryParse(Console.ReadLine(), out number);
        while (CheckNumber == false)
        {
            Console.Write("Enter a valid number: ");
            CheckNumber = int.TryParse(Console.ReadLine(), out number);
        }
        if (number % 1000 > 699 && number % 1000 < 800)
        {
            check = true; 
        }
        Console.WriteLine("Third digit is7? \n{0} \t{1}", number, check);
    }
}
