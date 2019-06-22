using System;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Welcome to Money Maker!");

            Console.WriteLine("Enter an amount to convert to coins:");
            string totalAsString = Console.ReadLine();
            int totalAsInt = int.Parse(totalAsString);

            int bronzeValue = 1;
            int silverValue = 5;
            int goldValue = 10;

            int currGoldCoin = totalAsInt / goldValue;
            int remainder = totalAsInt % goldValue;

            int currSilverCoin = remainder / silverValue; 
           
            int newRemainder = remainder % silverValue;

            int currBronzeCoin = newRemainder/ bronzeValue;
            


            Console.WriteLine($"{totalAsInt} is eqaul to... Gold coins: {currGoldCoin} Silver coins: {currSilverCoin} Bronze coins: {currBronzeCoin}");
            Console.ReadLine();

        }
    }
}
