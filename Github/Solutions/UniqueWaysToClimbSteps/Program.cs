using System;

namespace UniqueWaysToClimbSteps
{
    class Program
    {
        private static int UniquePaths(int num)
        {
            //If the number the user decided to input is greater that 1. Execute code.
            if (num > 1)
            {
                //RECURSION&FIBONACCI: Returning (user input number - 1) + (user input number - 2)
                return UniquePaths(num - 1) + UniquePaths(num - 2);
            }
            //Otherwise return 1
            return 1; 
        }





        static void Main(string[] args)
        {
            //User will input a number.
            Console.WriteLine("Please enter a number");
            //The number is converted(parse) from string to an integer and stored into a variable.
            int number = int.Parse(Console.ReadLine());
            //Feeding in the input number from user into the method and then storing it into a variable.
            int result = UniquePaths(number);
            //Writing the solution the console.
            Console.WriteLine($"The number of paths that can be taken are: {result}");
            Console.ReadLine();
        }
    }
}
