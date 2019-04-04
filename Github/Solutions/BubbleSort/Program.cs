using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    //BUBBLE SORT
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[] { 16, 5, 8, 9, 7, 6, 3, 4, 1 };
            
            //Create variable(temp) to hold value
            int temp = 0;
            
            // initilaze i and Check condition
            for (int i = 0; i < Arr.Length; i++)
            {
                //initilaze j and Check condition
                for (int j = Arr.Length - 1; j >= 0; j--)
                {
                    //Comapre i to j value. If true, make swap.
                    while (Arr[j] > Arr[i])
                    {
                        //Swap 
                        temp = Arr[j];
                        Arr[j] = Arr[i];
                        Arr[i] = temp;

                    }
                }

                foreach (int num in Arr)
                {
                    Console.Write(num.ToString());
                }

            }

       

            Console.ReadLine();
        }
    }
}
