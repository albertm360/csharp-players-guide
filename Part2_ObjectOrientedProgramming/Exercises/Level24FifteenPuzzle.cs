using Part2_ObjectOrientedProgramming.Models;
using Part2_ObjectOrientedProgramming.Models.Enums;

namespace Part2_ObjectOrientedProgramming.Exercises;

/// <summary>
/// Represents the runner for the "15-Puzzle" exercise (Level 24).
/// Handles the user interface, rendering the game board, and the main game loop.
/// </summary>
public class Level24FifteenPuzzle
{
    /// <summary>
    /// Renders the current state of the game board to the console.
    /// Uses specific colors for the grid lines and numbers, and handles alignment for single/double digits.
    /// </summary>
    /// <param name="game">The game instance containing the board data to display.</param>
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

    /// <summary>
    /// Starts the 15-Puzzle game.
    /// Initializes the game engine, enters the game loop, processes user input for movement, and detects the win condition.
    /// </summary>
    public void Run()
    {
        Console.Title = "Fifteen Puzzle Game";
        Console.Clear();
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