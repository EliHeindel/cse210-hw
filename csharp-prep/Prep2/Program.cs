using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt for grade percentage
        Console.WriteLine("Enter your grade percentage:");
        int gradePercentage = Convert.ToInt32(Console.ReadLine());

        // Determine letter grade
        char letter;
        if (gradePercentage >= 90)
        {
            letter = 'A';
        }
        else if (gradePercentage >= 80)
        {
            letter = 'B';
        }
        else if (gradePercentage >= 70)
        {
            letter = 'C';
        }
        else if (gradePercentage >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        // Determine pass/fail
        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Congratulations! You passed with a {letter}.");
        }
        else
        {
            Console.WriteLine($"Keep working hard! You got a {letter}.");
        }

        // Stretch Challenge: Determine "+" or "-" sign
        char sign = ' ';
        int lastDigit = gradePercentage % 10;
        if (letter != 'F' && lastDigit >= 7)
        {
            sign = '+';
        }
        else if (letter != 'F' && lastDigit < 3)
        {
            sign = '-';
        }

        // Print letter grade with sign
        if (letter == 'A' && sign == '+')
        {
            Console.WriteLine($"Your final grade is A.");
        }
        else if (letter == 'F' || (letter == 'A' && sign == '-'))
        {
            Console.WriteLine($"Your final grade is {letter}.");
        }
        else
        {
            Console.WriteLine($"Your final grade is {letter}{sign}.");
        }

        // Wait for user input to exit
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
