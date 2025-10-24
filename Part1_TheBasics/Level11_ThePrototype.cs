namespace Part1_TheBasics;

public class Level11_ThePrototype
{
    static int ValidateNumber()
    {
        do
        {
            Console.Write("Enter a number between 0 and 100: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= 0 && number <= 100)
            {
                return number;
            }

            Console.WriteLine("Invalid number. Please try again.");
        } while (true);
    }

    public static void Run()
    {
        int pilotNumber;
        int hunterGuess;
        bool hunterGuessed = false;

        const string pilotPrompt = "Hello, Pilot. it's your turn.";
        const string hunterPrompt = "Now, hunter, it's your time to guess: ";

        Console.WriteLine(pilotPrompt);
        pilotNumber = ValidateNumber();

        Console.Clear();

        while (!hunterGuessed)
        {
            Console.WriteLine(hunterPrompt);
            hunterGuess = ValidateNumber();

            if (pilotNumber == hunterGuess)
            {
                hunterGuessed = true;
                Console.WriteLine("You guessed the number!");
            }
            else if (pilotNumber > hunterGuess)
            {
                Console.WriteLine($"{hunterGuess} is too low.");
            }
            else if (pilotNumber < hunterGuess)
            {
                Console.WriteLine($"{hunterGuess} is too high.");
            }
        }
    }
}