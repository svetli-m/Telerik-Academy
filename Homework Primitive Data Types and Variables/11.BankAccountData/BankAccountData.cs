/*
 * Problem 11. Bank Account Data
A bank account has a holder name (first name, middle name and last name),
 * available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using
 * the appropriate data types and descriptive names.
 */


using System;

class BankAccountData
{
    static void Main()
    {
        string holderFirstName; 
        string holderMiddleName;
        string holderLastName;
        decimal balance;
        string bankName;
        string iBan;
        ulong creditCardNumber1;
        ulong creditCardNumber2;
        ulong creditCardNumber3;

        holderFirstName = "Svetoslav";
        holderMiddleName = "Jivkov";
        holderLastName = "Mitsev";
        balance = 105.75M;
        bankName = "FiBank";
        iBan = "BG39FINV715311BGN09AAA";
        creditCardNumber1 = 3456123923185598;
        creditCardNumber2 = 5488911234234435;
        creditCardNumber3 = 7789012322146578;

        Console.WriteLine("{0} {1} {2} \n{3} \n{4} \n{5} \n{6} \n{7} \n{8}", holderFirstName, holderMiddleName, holderLastName, 
            balance, bankName, iBan, creditCardNumber1, creditCardNumber2, creditCardNumber3);


    }
}
