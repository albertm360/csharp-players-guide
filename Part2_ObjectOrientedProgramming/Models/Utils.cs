namespace Part2_ObjectOrientedProgramming.Models;

public static class Utils
{
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
}