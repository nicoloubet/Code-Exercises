using System;

namespace MissingValue
{
    class Program
    {
        //Find the missing value given a list of n-1 integers and these integers are in a range of 1 to n.
        //No duplicates 
        //One of the integers is missing in the list.

        
        public static int FindMissingValue(int[] arr, int n)
        {
            int sum = 0;
            //number of values in array +1. Would then equal make n = 10
            int total = n * (n + 1) / 2;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return total - sum;
        }




        static void Main(string[] args)
        {
            int[] Array = new int[] { 1, 4, 5, 6, 3, 7, 2, 9, 10 };

            Console.WriteLine($"The missing value is: {FindMissingValue(Array, Array.Length + 1 )}");
            Console.ReadKey();
        }
    }
}
