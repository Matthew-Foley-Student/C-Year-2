/*
 * Matthew Foley
 * CST-250
 * 10/13/2025
 * Activity 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FactorialRecursion.Services.BuisnessLogicLayer
{
    internal class FactorialLogic
    {
        internal BigInteger SolveIteritaveFactorial(int factorial)
        {
            BigInteger result = 1;
            for(int i = factorial; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }

        internal BigInteger SolveRecursiveFactorial (int factorial)
        {
            if(factorial == 0 || factorial == 1)
            {
                return 1;
            }
            return factorial * SolveRecursiveFactorial(factorial - 1);
        }
    }
}
