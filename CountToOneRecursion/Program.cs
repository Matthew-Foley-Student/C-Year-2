/*
 * Matthew Foley
 * CST-250
 * 10/13/2025
 * Activity 2
 */

//----------------------------------------------------------------------------------------------------
//Main Method 
//----------------------------------------------------------------------------------------------------
int choice = 0, result = 0;
string input = "";
Console.Write("Enter A Positive Number");

    input = Console.ReadLine();
    while (!int.TryParse(input, out choice) && choice > 0)
    {
        Console.WriteLine("Invalid number");
        Console.WriteLine("Please Enter A Positive Number: ");
        input = Console.ReadLine();
    }
    result = Utility.CountToOne(choice);
    Console.WriteLine($"The Ending Number Inputed Is {result}");


//----------------------------------------------------------------------------------------------------
//End Of The Main Method
//----------------------------------------------------------------------------------------------------
static class Utility
{
    internal static int CountToOne(int num)
    {
        Console.WriteLine($"The current number is {num}");
        if (num == 1)
        {
            return 1;
        }
        else
        {
            //check if the number that is NOT 1 even or odd
            if(num %2 == 0)
            {
                Console.WriteLine("The Numbere is Even, It will be devided by 2");
                return CountToOne(num / 2);
            }
            else
            {
                Console.WriteLine("The Number Is Odd, Adding 1");
                return CountToOne(num+1);
            }
        }
    }
}