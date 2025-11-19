using Part2_ObjectOrientedProgramming.Models.Enums;

namespace Part2_ObjectOrientedProgramming.Models;

/// <summary>
/// Represents the game engine for the 15-Puzzle, managing the game board state and move history.
/// </summary>
public class Game
{
    private readonly GameBoard _board;

    /// <summary>
    /// Gets the total number of valid moves performed by the player since the game started.
    /// </summary>
    public int Moves { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Game"/> class.
    /// Creates a new board, shuffles it, and resets the move counter to zero.
    /// </summary>
    public Game()
    {
        _board = new GameBoard();
        _board.Shuffle();
        Moves = 0;
    }

    /// <summary>
    /// Retrieves the numeric value of the tile at the specified grid coordinates.
    /// </summary>
    /// <param name="row">The row index (0-based).</param>
    /// <param name="col">The column index (0-based).</param>
    /// <returns>The number on the tile, or 0 if it is the empty space.</returns>
    public int GetTileAt(int row, int col)
    {
        return _board.GetTile(row, col);
    }

    /// <summary>
    /// Determines whether the puzzle has been solved.
    /// </summary>
    /// <returns><c>true</c> if the tiles are in sequential order with the empty space in the last position; otherwise, <c>false</c>.</returns>
    public bool IsWon()
    {
        return _board.IsSolved();
    }

    /// <summary>
    /// Attempts to move the empty tile in the specified direction.
    /// Increments the <see cref="Moves"/> counter only if the move is valid.
    /// </summary>
    /// <param name="direction">The direction to move the empty tile.</param>
    public void Move(Direction direction)
    {
        if (_board.TryMove(direction)) Moves++;
    }
}