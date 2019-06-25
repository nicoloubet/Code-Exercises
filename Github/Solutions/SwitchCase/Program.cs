using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a movie genre");
            string genre = Console.ReadLine();


            switch (genre)
            {
                case "Horror":
                    Console.WriteLine("Childs Play");
                    Console.ReadLine();
                    break;
                case "Comedy":
                    Console.WriteLine("Step Brothers");
                    Console.ReadLine();
                    break;
                case "Science Fiction":
                    Console.WriteLine("Pandorum");
                    Console.ReadLine();
                    break;
                case "Action":
                    Console.WriteLine("Taken");
                    Console.ReadLine();
                    break;
                case "Drama":
                    Console.WriteLine("Mystic River");
                    Console.ReadLine();
                    break;

                default:
                break;
            }
        }
    }
}
