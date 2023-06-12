using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Hello, my email is omkamble121@gmail.com and my phone number is (123) 456-7890.";
        string emailPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";
        string phonePattern = @"\(\d{3}\)\s*\d{3}-\d{4}";
        Regex emailRegex = new Regex(emailPattern);
        Regex phoneRegex = new Regex(phonePattern);

        MatchCollection emailMatches = emailRegex.Matches(input);
        Console.WriteLine("Email Matches:");
        foreach (Match match in emailMatches)
        {
            Console.WriteLine(match.Value);
        }

        Console.WriteLine();
        MatchCollection phoneMatches = phoneRegex.Matches(input);
        Console.WriteLine("Phone Number Matches:");
        foreach (Match match in phoneMatches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
