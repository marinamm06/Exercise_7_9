using System;

class Digits
{
    static void Main()
    {
        //counters of number of digits a is for one digit, b is for 2 digits, c is for 3 digits and d is for more than 3 digits
        int oneDigit = 0, twoDigits = 0, threeDigits = 0, moreDigits = 0;

        Console.Write("Insert a number: ");
        // read the number as string to check the word "end"
        string userInsert = Console.ReadLine();

        while (userInsert != "end")
        {
            int numberUser = Convert.ToInt32(userInsert);

            if (numberUser != 0)
            {
                if (numberUser / 10 == 0)
                    oneDigit++;  // it only has one digit
                else if (numberUser / 100 == 0)
                    twoDigits++;  // the number has 2 digits
                else if (numberUser / 1000 == 0)
                    threeDigits++;  // the number has 3 digits
                else
                    moreDigits++;  // the number has more than 3 digits
            }

            userInsert = Console.ReadLine();
        }

        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", oneDigit, twoDigits, threeDigits, moreDigits);
    }
}
