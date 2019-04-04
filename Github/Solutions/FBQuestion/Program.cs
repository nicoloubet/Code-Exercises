using System;

namespace FBProblem
//Given an array of non negative integers tht represent a 2D elevation map  where each element is unit-width wall and the integer is the height. Suppose it will rain and all spots between two walls get filled up.

{
    class Program
    {
        static int CalculateWaterStored(int[] elevationMap)
        {
            int waterStored = 0;
            int landValue = 0;
            int leftWallIndex = 0;
            for (int i = 1; i < elevationMap.Length; i++)
            {
                if (elevationMap[leftWallIndex] <= elevationMap[i])
                {
                    waterStored += (i - leftWallIndex - 1) * Math.Min(elevationMap[leftWallIndex], elevationMap[i]);
                    waterStored -= landValue;
                    landValue = 0;
                    leftWallIndex = i;
                }
                else
                {
                    landValue += elevationMap[i];
                }
            }
            return waterStored;
        }

        static void Main(string[] args)
        {
            int[] elevationMap1 = { 2, 1, 2 };
            Console.WriteLine($"Water Stored: {CalculateWaterStored(elevationMap1)}");
            int[] elevationMap2 = { 3, 0, 1, 3, 0, 5 };
            Console.WriteLine($"Water Stored: {CalculateWaterStored(elevationMap2)}");
        }
    }
}
