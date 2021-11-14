using System;

namespace HelloWorld
{
    class Program
    {
        /// <summary>
        /// Entry point lol
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int index;
            string text, character, firstName, lastName, fullName;
            
            Console.Write("Enter a string here: ");
            text = Console.ReadLine();
            
            Console.Write("Wich character do you want to search for: ");
            character = Console.ReadLine();

            index = text.IndexOf(character);

            Console.WriteLine($"The character {character} is located at index {index}.");
            
            Console.Write("\nFirst name: ");
            firstName = Console.ReadLine();
            
            Console.Write("Last name: ");
            lastName = Console.ReadLine();

            fullName = firstName + " " + lastName;

            Console.WriteLine($"Your name is {fullName}");

        }
    }
}