/*
 * Matthew Foley
 * CST-250
 * 10/13/2025
 * Activity 2
 */

//---------------------------------------------------------------------------------------
//Start Of The Main Methods
//---------------------------------------------------------------------------------------
int number1 = 440, number2 = 80, result = 0;
result = Utiliy.GreatestCommonDivisor(number1, number2);
Console.WriteLine($"The Greatest Common Denominator between {number1} and {number2} is {result}");
//---------------------------------------------------------------------------------------
//End Of The Main Methods
//---------------------------------------------------------------------------------------
public class Utiliy
{
    internal static int GreatestCommonDivisor(int num1, int num2)
    {

        int remainder = 0;
        if(num1==0 || num2 == 0)
        {
            return num1;
        }
        else
        {
            remainder = num1 % num2;
        }
        return GreatestCommonDivisor(num2,remainder);
    }
}