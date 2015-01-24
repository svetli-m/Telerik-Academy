/*
 * Problem 12. Null Values Arithmetic
Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
 */


using System;
class NullValues
{
    static void Main()
    {
        int? number1 = null;
        double? number2 = null;

        Console.WriteLine(number1);
        Console.WriteLine(number2);

        number1 += 10;
        number2 += 4.4D;

        Console.WriteLine(number1);
        Console.WriteLine(number2);

        number1 += 10;
        number2 += 4.4D;

        Console.WriteLine(number1.GetValueOrDefault());
        Console.WriteLine(number2.GetValueOrDefault());
    }
}
