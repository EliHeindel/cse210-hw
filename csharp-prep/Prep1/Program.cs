using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt for first name
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();

        // Prompt for last name
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        // Combine and display the name
        string fullName = $"{lastName}, {firstName} {lastName}.";
        Console.WriteLine($"Your name is {fullName}");

        // Wait for user input to exit
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
