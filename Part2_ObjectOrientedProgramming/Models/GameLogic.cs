using Part2_ObjectOrientedProgramming.Models.Enums;

namespace Part2_ObjectOrientedProgramming.Models;

public class GameLogic(Player player1, Player player2)
{
    private Player Player1 { get; } = player1;
    private Player Player2 { get; } = player2;

    public void PlayRound(HandGesture choice1, HandGesture choice2)
    {
        CompareChoices(choice1, choice2);
        PrintTotalScore();
    }

    private void CompareChoices(HandGesture choice1, HandGesture choice2)
    {
        if (choice1 == choice2)
        {
            Console.WriteLine("It's a tie!");
            return;
        }

        bool player1Wins = (choice1 == HandGesture.Rock && choice2 == HandGesture.Scissors) ||
                           (choice1 == HandGesture.Paper && choice2 == HandGesture.Rock) ||
                           (choice1 == HandGesture.Scissors && choice2 == HandGesture.Paper);

        if (player1Wins)
        {
            Console.WriteLine($"{Player1.Name} wins this round!");
            Player1.IncrementScore();
        }
        else
        {
            Console.WriteLine($"{Player2.Name} wins this round!");
            Player2.IncrementScore();
        }
    }

    private void PrintTotalScore()
    {
        string totalScore = $"{Player1.Name} - {Player1.Score} | {Player2.Name} - {Player2.Score}";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(totalScore);
        Console.ResetColor();
    }
}