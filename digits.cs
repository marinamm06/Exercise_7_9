//This program calculates how many numers of 1, 2, 3 or more digits are entered by the user until he/she types "end"

using System;

class Digits
{
    static void Main()
    {        
        int oneDigit = 0, twoDigits = 0, threeDigits = 0, moreDigits = 0;

        Console.Write("Insert a number: ");
        string userInsert = Console.ReadLine();

        while (userInsert != "end")
        {
            int numberUser = Convert.ToInt32(userInsert);

            if (numberUser != 0)
            {
                if (numberUser / 10 == 0)
                    oneDigit++;  
                else if (numberUser / 100 == 0)
                    twoDigits++;  
                else if (numberUser / 1000 == 0)
                    threeDigits++;  
                else
                    moreDigits++;  
            }

            userInsert = Console.ReadLine();
        }

        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", oneDigit, twoDigits, threeDigits, moreDigits);
    }
}
