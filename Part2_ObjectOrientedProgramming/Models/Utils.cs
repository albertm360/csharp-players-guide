using Part2_ObjectOrientedProgramming.Models.Enums;

namespace Part2_ObjectOrientedProgramming.Models;

/// <summary>
/// Provides generic utility methods for console input, validation, and display.
/// </summary>
public static class Utils
{
    /// <summary>
    /// Prints all defined values of a specific enumeration to the console in a numbered list format.
    /// </summary>
    /// <typeparam name="TEnum">The enum type to display.</typeparam>
    /// <returns>The total count of items in the enumeration.</returns>
    public static int PrintEnumValues<TEnum>() where TEnum : Enum
    {
        Type enumType = typeof(TEnum);

        var enumValues = Enum.GetValues(enumType);

        Console.WriteLine($"--- {enumType.Name} Options ---");
        for (int i = 0; i < enumValues.Length; i++)
        {
            var enumValue = enumValues.GetValue(i);
            Console.WriteLine($"{i + 1} - {enumValue}");
        }

        return enumValues.Length;
    }

    /// <summary>
    /// Prompts the user to select an option by number, validating that the input is an integer between 1 and the specified total items.
    /// </summary>
    /// <param name="prompt">The text to display to the user before waiting for input.</param>
    /// <param name="totalItems">The maximum valid number the user can enter (assumes starting at 1).</param>
    /// <returns>The valid integer choice selected by the user.</returns>
    public static int GetValidChoice(string prompt, int totalItems)
    {
        do
        {
            Console.Write(prompt);
            Console.ForegroundColor = ConsoleColor.Yellow;
            string? input = Console.ReadLine();
            Console.ResetColor();

            if (int.TryParse(input, out int choice) && choice > 0 && choice <= totalItems) return choice;

            Console.WriteLine("Wrong input, enter the number of the item...");
        } while (true);
    }

    /// <summary>
    /// Prompts the user to enter a number within a specific inclusive range, looping until valid input is received.
    /// </summary>
    /// <param name="prompt">The text to display to the user.</param>
    /// <param name="min">The minimum allowed value.</param>
    /// <param name="max">The maximum allowed value.</param>
    /// <returns>A valid integer within the specified [min, max] range.</returns>
    public static int GetValidChoiceInRange(string prompt, int min, int max)
    {
        do
        {
            Console.Write(prompt);
            Console.ForegroundColor = ConsoleColor.Yellow;
            string? input = Console.ReadLine();
            Console.ResetColor();

            if (int.TryParse(input, out int number) && number >= min && number <= max) return number;

            Console.WriteLine($"Wrong input, enter a number between {min} and {max}...");
        } while (true);
    }

    /// <summary>
    /// Prompts the user for a text string, ensuring the input is not null, empty, or whitespace.
    /// </summary>
    /// <param name="prompt">The text to display to the user.</param>
    /// <returns>The validated non-empty string entered by the user.</returns>
    public static string GetValidString(string prompt)
    {
        do
        {
            Console.Write(prompt);
            Console.ForegroundColor = ConsoleColor.Yellow;
            string? input = Console.ReadLine();
            Console.ResetColor();

            if (!String.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            Console.WriteLine("Wrong input, please enter some text: ");
        } while (true);
    }

    /// <summary>
    /// Waits for the user to press a specific key (Arrow keys or WASD) to return a Direction, or 'Q' to return null.
    /// </summary>
    /// <param name="prompt">The text to display before waiting for a key press.</param>
    /// <returns>A <see cref="Direction"/> if a movement key is pressed, or <c>null</c> if 'Q' is pressed.</returns>
    public static Direction? GetValidDirection(string prompt)
    {
        Console.Write(prompt);
        do
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    return Direction.Up;
                case ConsoleKey.DownArrow:
                    return Direction.Down;
                case ConsoleKey.LeftArrow:
                    return Direction.Left;
                case ConsoleKey.RightArrow:
                    return Direction.Right;
                case ConsoleKey.W:
                    return Direction.Up;
                case ConsoleKey.S:
                    return Direction.Down;
                case ConsoleKey.A:
                    return Direction.Left;
                case ConsoleKey.D:
                    return Direction.Right;
                case ConsoleKey.Q:
                    return null;
            }
        } while (true);
    }
}