using System;

namespace RandomPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM!@#$%";
            Random rnd = new Random();
            int maxLen = 12;
            string password = "";

            while (password.Length < maxLen)
            {
                password += letters[rnd.Next(letters.Length)];
            }

            Console.WriteLine($"Random Password: { password}");
            Console.ReadKey();
        }
    }
}
