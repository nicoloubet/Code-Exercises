using System;

namespace Madlib
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
      This program is a Madlib, to keep it short and sweet just fill in the blanks and have fun!
      Author: Nico Loubet
      */


            // Let the user know that the program is starting:
            Console.WriteLine("The program will begin shortly");


            // Give the Mad Lib a title:
            string title = "Title: When i wake";
            Console.WriteLine(title);

            


            // Define user input and variables:
            // The template for the story:

            Console.WriteLine("The Madlib will now begin!");
            Console.Write("Enter a name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter an adjective:");
            string adjective1 = Console.ReadLine();
            Console.WriteLine("Please enter an adjective:");
            string adjective2 = Console.ReadLine();
            Console.WriteLine("Please enter an adjective:");
            string adjective3 = Console.ReadLine();

            Console.WriteLine("Please enter a verb:");
            string verb = Console.ReadLine();

            Console.WriteLine("Please enter a noun:");
            string noun1 = Console.ReadLine();
            Console.WriteLine("Please enter a noun:");
            string noun2 = Console.ReadLine();

            Console.WriteLine("Please enter an animal:");
            string animal = Console.ReadLine();
            Console.WriteLine("Please enter a food:");
            string food = Console.ReadLine();
            Console.WriteLine("Please enter a fruit:");
            string fruit = Console.ReadLine();
            Console.WriteLine("Please enter a superhero:");
            string superhero = Console.ReadLine();
            Console.WriteLine("Please enter a country:");
            string country = Console.ReadLine();
            Console.WriteLine("Please enter a dessert:");
            string dessert = Console.ReadLine();
            Console.WriteLine("Please enter a year:");
            string year = Console.ReadLine();


            string story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adjective3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}
