namespace Part1_TheBasics;

public class Level13_TakingANumber
{
    static int AskForNumber(string text)
    {
        do
        {
            Console.WriteLine(text);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                return number;
            }

            Console.WriteLine("Wrong input, try again...");
        } while (true);
    }

    static int AskForNumberInRange(string text, int min, int max)
    {
        do
        {
            Console.WriteLine(text);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= min && number <= max)
            {
                return number;
            }

            Console.WriteLine("Wrong input, try again...");
        } while (true);
    }

    public static void Run()
    {
        const string prompt = "What is the airspeed velocity of an unladen swallow?";

        int anyNumber = AskForNumber(prompt);
        int anInRangeNumber = AskForNumberInRange(text: prompt, min: 1, max: 50);

        string result =
            $"You first said {anyNumber} and then {anInRangeNumber}, so I don't know which is correct...";
        Console.WriteLine(result);
    }
}