namespace Part1_TheBasics;

public class Level03_ConsolasAndTelim
{
    public static void Run()
    {
        while (true)
        {
            Console.WriteLine("\nBread is ready.");
            Console.WriteLine("Who is the bread for?");
            
            string name = Console.ReadLine() ?? "Nobody";

            if (string.IsNullOrEmpty(name))
            {
                name = "Nobody";
            }
            
            Console.WriteLine($"Noted. {name} got bread.");
        }
    }
}