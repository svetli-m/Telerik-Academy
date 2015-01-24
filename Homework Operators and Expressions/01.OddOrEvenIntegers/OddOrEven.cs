/*
 * Problem 1. Odd or Even Integers
Write an expression that checks if given integer is odd or even.
 */

//  Reshenie 1.
using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool Odd = !(number % 2 == 0);

        Console.WriteLine("Odd? {0}", Odd);


    }
}

// Reshenie 2.
/*
 using System;
class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
       
            if (number % 2 == 0)
            {
                Console.WriteLine("Odd? false");
            }
            else
            {
                Console.WriteLine("Odd? true");
            }
       
    }
}
*/