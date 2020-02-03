using System;

namespace ReverseDigits
{
    class Program
    {
        
        public static int ReverseDigits(int inputDigits)
        {
            int returnDigits = 0;

            while (inputDigits > 0)
            {
                //First multiplies returnDigits(0) "At the moment" ) by 10. 
                returnDigits = returnDigits * 10;
                
                //Adds the returnDigits plus the modulus(last digit in whatever digits user decided to input) and assigns it to returnDigits.
                returnDigits += inputDigits % 10;
                
                //Basically gives you the digits entered minus the last digit
                inputDigits = inputDigits / 10;

            }
            return returnDigits ;
        }

        static void Main(string[] args)
        {
           Console.WriteLine("Please enter digits to be reversed:");
           int userInput = int.Parse(Console.ReadLine());
           int output = ReverseDigits(userInput);
           Console.WriteLine($"The digits you entered reversed are: {output}");
           Console.ReadKey();
        }
        


        
        
    }
}	
