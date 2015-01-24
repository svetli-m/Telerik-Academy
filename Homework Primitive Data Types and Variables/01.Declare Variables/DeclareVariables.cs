/* 
 * Problem 1. Declare Variables
Declare five variables choosing for each of them the most appropriate of the types
 * byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
 */


using System;

class DeclareVariables
{
    static void Main()
    {
        byte number1 = 97;
        sbyte number2 = -115;
        ushort number3 = 52130;
        short number4 = -10000;
        int number5 = 4825932;

        Console.WriteLine("{0}, \n{1}, \n{2}, \n{3}, \n{4}", number1, number2, number3, number4, number5);
    }
}
