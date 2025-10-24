namespace Part1_TheBasics;

public class Level12_ReplicatorOfDTo
{
    static int ValidateNumber(int numberPrompt)
    {
        do
        {
            Console.Write($"Enter number #{numberPrompt + 1}: ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int number)) return number;

            Console.WriteLine("Wrong input, please enter an integer.");
        } while (true);
    }

    public static void Run()
    {
        int[] originals = new int[5];
        int[] replicated = new int[5];

        Console.WriteLine("Please, enter five numbers:");

        for (int i = 0; i < originals.Length; i++)
        {
            originals[i] = ValidateNumber(i);
        }

        for (int i = 0; i < originals.Length; i++)
        {
            replicated[i] = originals[i];
        }

        for (int i = 0; i < replicated.Length; i++)
        {
            Console.WriteLine($"{nameof(originals)}[{i}] = {originals[i]}");
            Console.WriteLine($"{nameof(replicated)}[{i}] = {replicated[i]}");
            Console.WriteLine("---");
        }
    }
}