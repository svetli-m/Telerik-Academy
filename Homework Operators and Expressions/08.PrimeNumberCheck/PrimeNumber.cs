/*
 * Problem 8. Prime Number Check
Write an expression that checks if given positive integer number n (n <= 100) is prime 
 * (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
Examples:
n	Prime?
1	false
2	true
3	true
4	false
9	false
97	true
51	false
-3	false
0	false
 */


using System;
class PrimeNumber
{
    static void Main()
    {
        Console.Write("Please enter integer number: ");
        int nummber = int.Parse(Console.ReadLine());

        bool prime = true;
        int devider = 2;
        int maxDevider = (int)Math.Sqrt(nummber);

        if (nummber > 0 && nummber != 1)
        {
            while (devider <= maxDevider)
            {
                if (nummber % devider == 0)
                {
                    prime = false;
                }
                devider++;
            }
        }
        else if (nummber < 0 && (nummber != 1))
        {
            while (devider >= maxDevider)
            {
                if (nummber % devider == 0)
                {
                    prime = false;
                }
                devider--;
            }

        }
        else
        {
            prime = false;
        }
        Console.WriteLine("The number is prime. {0}", prime);
    }
}
