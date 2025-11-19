using Part2_ObjectOrientedProgramming.Models;
using Part2_ObjectOrientedProgramming.Models.Enums;

namespace Part2_ObjectOrientedProgramming.Exercises;

public class Level24FifteenPuzzle
{
    private void DrawBoard(Game game)
    {
        ConsoleColor gridColor = ConsoleColor.DarkGray;
        ConsoleColor numberColor = ConsoleColor.Cyan;
        const string DoubleSpace = "  ";
        const string RowSeparator = "+----+----+----+----+";

        Console.ForegroundColor = gridColor;
        Console.WriteLine(RowSeparator);

        for (int row = 0; row < GameBoard.BoardSize; row++)
        {
            Console.ForegroundColor = gridColor;
            Console.Write("|");

            for (int col = 0; col < GameBoard.BoardSize; col++)
            {
                int number = game.GetTileAt(row, col);

                string display = (number == 0) ? DoubleSpace : number.ToString();
                Console.ForegroundColor = numberColor;
                Console.Write($" {display,2} ");

                Console.ForegroundColor = gridColor;
                Console.Write("|");
            }

            Console.WriteLine();
            Console.WriteLine(RowSeparator);
        }

        Console.ResetColor();
    }

    public void Run()
    {
        Console.Title = "Fifteen Puzzle Game";
        const string directionPrompt =
            "Enter direction to move the empty space (either arrows or WASD) or 'q' to exit.";
        Game game = new Game();

        while (!game.IsWon())
        {
            DrawBoard(game);
            Direction? direction = Utils.GetValidDirection(directionPrompt);

            if (direction == null) return;

            game.Move(direction.Value);
            Console.Clear();
        }

        DrawBoard(game);
        string congratulationsMessage = $"Congratulations! You solved the puzzle in {game.Moves} moves.";
        Console.WriteLine(congratulationsMessage);
    }
}