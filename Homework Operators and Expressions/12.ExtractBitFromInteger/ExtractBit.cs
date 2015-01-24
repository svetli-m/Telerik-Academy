/*
 * Problem 12. Extract Bit from Integer
Write an expression that extracts from given integer n the value of given bit at index p.
 */


using System;
    class ExtractBit
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            int numumber = int.Parse(Console.ReadLine());
            Console.Write("Enter index p for position: ");
            int index = int.Parse(Console.ReadLine());
            int number1 = 1;
            int numBit = (numumber >> index);
            int result = number1 & numBit;
            
         
                Console.WriteLine("The bit at index p is: {0}", result);
    
            
        }
    }
