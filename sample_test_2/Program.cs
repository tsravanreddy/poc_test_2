using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your birth year: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int birthYear))
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;

            Console.WriteLine($"Your age is: {age}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid year.");
        }
    }
}