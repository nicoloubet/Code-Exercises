using System;

namespace FactorialRecursive
{
    class Program
    {
        public static int Factorial(int num)
        {
            //Checks to see if condition is met (less than 1)
            if (num == 1)
            {
                return num; 
            }
            else
            {
                //Otherwise takes the input number and multiplies it by the output of the function with the number - 1. num - 1 translates to ("what ever number user deceided to input ex.4 = 4*3*2*1) and returns it.
                //This is RECURSION a method calling its self until a "base condition" is true and exection stops.
                return num * Factorial(num - 1);
            }
        }

        static void Main(string[] args)
        {
            //User is asked to input a number
            Console.WriteLine("Please enter a number:");
            //Users number is stored in variable
            int inputNum = int.Parse(Console.ReadLine());
            //The result takes the output of the Factorial function
            int Result = Factorial(inputNum);
            //Writes out the factorial and result to the console.
            Console.WriteLine($"The factorial of {inputNum} is {Result}.");
            Console.ReadKey();
        }
    }
}
