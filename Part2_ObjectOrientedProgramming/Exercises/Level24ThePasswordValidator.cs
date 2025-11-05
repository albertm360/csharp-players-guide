using Part2_ObjectOrientedProgramming.Models;

namespace Part2_ObjectOrientedProgramming.Exercises;

public class Level24ThePasswordValidator
{
    private const string Exit = "exit";
    const string PasswordPrompt = "Enter a password to validate (or type 'exit' to quit): ";

    public void Run()
    {
        while (true)
        {
            string input = Utils.GetValidString(PasswordPrompt);

            if (input.ToLower() == Exit) return;

            bool isValid = PasswordValidator.IsValid(input);

            if (isValid)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password is valid.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password is invalid.");
                Console.ResetColor();
            }
        }
    }
}