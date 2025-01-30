using System;
using System.IO;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Create menu
            Console.WriteLine("1. Add character");
            Console.WriteLine("2. Display characters");
            Console.WriteLine("3. Exit");

            // Get user input
            string input = Console.ReadLine();

            if (input == "1")
            {
                // Add character
                Console.WriteLine("Enter character id:");
                string id = Console.ReadLine();
                Console.WriteLine("Enter character name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter character relationship to Mario:");
                string relationship = Console.ReadLine();
                // Append character data to file
                using (StreamWriter sw = new StreamWriter("characters.txt", true))
                {
                    sw.WriteLine($"{id}|{name}|{relationship}");
                }
            }
            else if (input == "2")
            {
                // Display characters
                if (File.Exists("characters.txt"))
                {
                    string[] characters = File.ReadAllLines("characters.txt");
                    foreach (string character in characters)
                    {
                        Console.WriteLine(character);
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("No characters found.");
                }
            }
            else if (input == "3")
            {
                // Exit
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}