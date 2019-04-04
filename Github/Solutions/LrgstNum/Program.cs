using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ogArr = { 1, 2, 5, 7, 8 };
            int largestNum = largeNum(ogArr);
            Console.WriteLine(largestNum);
            Console.ReadKey();


        }

        public static int largeNum (int[] num)
        {
            int bigNum = 0;
            for (int i = 0; i < num.Length - 1; i++)
            {
                if (num[i] < num[i + 1])
                {
                    bigNum = num[i + 1];
                }
            }return bigNum;
        }
    }
}
