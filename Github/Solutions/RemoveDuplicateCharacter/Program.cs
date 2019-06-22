using System;

namespace DuplicateNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 4, 1, 1, 2, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.Write(arr[i]);
                        Console.ReadLine();
                    }
                }
            }



        }

    }
}
