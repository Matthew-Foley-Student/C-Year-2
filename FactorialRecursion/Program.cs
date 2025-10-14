/*
 * Matthew Foley
 * CST-250
 * 10/13/2025
 * Activity 2
 */
using System.Numerics;
using FactorialRecursion.Services.BuisnessLogicLayer;

//------------------------------------------------------------------------------------------------
//Start Of The Methods
//------------------------------------------------------------------------------------------------
FactorialLogic factorialLogic = new FactorialLogic();
int input = 0;
BigInteger iterativeAns = 0, recursiveAns = 0;
Console.Write("Enter a positve Integer: ");
input = Utility.ReadIntFromConsole();

Console.WriteLine("Solveing the Factorial using an iterative method.....");
iterativeAns = factorialLogic.SolveIteritaveFactorial(input);
Console.WriteLine($"Answer is: {iterativeAns}");

Console.WriteLine("Solving the factorial using the recusive method......");
recursiveAns = factorialLogic.SolveRecursiveFactorial(input);
Console.WriteLine($"Answer: {recursiveAns}");
//------------------------------------------------------------------------------------------------
//End Of the Main Methods
//------------------------------------------------------------------------------------------------
static class Utility
{
    internal static int ReadIntFromConsole()
    {
        string input = "";
        int number = -1;
        input = Console.ReadLine();
            while(!int.TryParse(input, out number))
        {
            Console.WriteLine("Invalid Inpue, Try Again: ");
            input = Console.ReadLine();
        }
            return number;
    }
}