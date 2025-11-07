using Part2_ObjectOrientedProgramming.Models;
using Part2_ObjectOrientedProgramming.Models.Enums;

namespace Part2_ObjectOrientedProgramming.Exercises;

public class Level24RockPaperScissors
{
    private const string Rock = "🪨";
    private const string Paper = "📄";
    private const string Scissors = "✂️";

    private const string Player1NamePrompt = "Player 1, enter your name: ";
    private const string Player2NamePrompt = "Player 2, enter your name: ";

    private void DisplayChoices()
    {
        Console.WriteLine("Choices:");
        Console.WriteLine($"1. {Rock} - {HandGesture.Rock}");
        Console.WriteLine($"2. {Paper} - {HandGesture.Paper}");
        Console.WriteLine($"3. {Scissors} - {HandGesture.Scissors}");
    }

    private bool PlayAgain()
    {
        const string Yes = "yes";
        const string No = "no";
        const string PlayAgainPrompt = "Do you want to play again? (yes/no): ";

        do
        {
            string input = Utils.GetValidString(PlayAgainPrompt).ToLower();

            if (input == Yes) return true;
            if (input == No) return false;

            Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
        } while (true);
    }

    private HandGesture GetPlayerChoice(Player player)
    {
        DisplayChoices();
        string choicePrompt = $"{player.Name}, enter your choice (1-3): ";
        int choice = Utils.GetValidChoiceInRange(choicePrompt, 1, 3);
        Console.Clear();

        return choice switch
        {
            1 => HandGesture.Rock,
            2 => HandGesture.Paper,
            3 => HandGesture.Scissors,
            _ => throw new ArgumentOutOfRangeException(nameof(choice), choice, "Invalid choice value")
        };
    }

    public void Run()
    {
        Console.Clear();
        Console.Title = "Rock, Paper, Scissors Game";

        string player1Name = Utils.GetValidString(Player1NamePrompt);
        string player2Name = Utils.GetValidString(Player2NamePrompt);

        Console.Clear();

        Player player1 = new Player(player1Name);
        Player player2 = new Player(player2Name);

        GameLogic game = new GameLogic(player1, player2);

        bool playAgain = true;

        while (playAgain)
        {
            HandGesture player1Choice = GetPlayerChoice(player1);
            HandGesture player2Choice = GetPlayerChoice(player2);

            game.PlayRound(player1Choice, player2Choice);

            playAgain = PlayAgain();
            Console.Clear();
        }
    }
}