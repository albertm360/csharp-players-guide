namespace Part1_TheBasics;

public class Level09_RepairingTheClocktower
{
    public static string Pendulum(string prompt)
    {
        string tick = "Tick";
        string tock = "Tock";
        
        do
        {
            int number;
            Console.WriteLine(prompt);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out number) && number >= 0)
            {
                return number % 2 == 0 ? tick : tock;
            }
            
            Console.WriteLine("Wrong input. Please enter a non-negative integer.");
        } while (true);
    }
    public static void Run()
    {
        const string prompt = "Enter the number: ";
        string pendulum = Pendulum(prompt);
        Console.WriteLine(pendulum);
    }
}