using Part2_ObjectOrientedProgramming.Models.Enums;

namespace Part2_ObjectOrientedProgramming.Models;

/// <summary>
/// Represents the grid of tiles for the 15-Puzzle game.
/// Handles tile movement, randomization (shuffling), and checking for the solved state.
/// </summary>
public class GameBoard
{
    private readonly int[,] _tiles;
    private int _emptyTileRow;
    private int _emptyTileCol;

    /// <summary>
    /// The size of the board (width and height). A value of 4 creates a 4x4 grid (15-Puzzle).
    /// </summary>
    public const int BoardSize = 4;

    private readonly Random _random = new Random();

    /// <summary>
    /// Initializes a new instance of the <see cref="GameBoard"/> class.
    /// The board is created in a solved state with tiles numbered sequentially and the empty space at the bottom-right.
    /// </summary>
    public GameBoard()
    {
        // Initialize a solved 15-puzzle board
        _tiles = new int[BoardSize, BoardSize];
        int number = 1;

        for (int row = 0; row < BoardSize; row++)
        {
            for (int col = 0; col < BoardSize; col++)
            {
                if (row == BoardSize - 1 && col == BoardSize - 1)
                {
                    _tiles[row, col] = 0; // Empty tile
                    _emptyTileRow = row;
                    _emptyTileCol = col;
                }
                else
                {
                    _tiles[row, col] = number++;
                }
            }
        }
    }

    /// <summary>
    /// Randomizes the board by performing a series of valid random moves.
    /// This ensures the resulting puzzle state is always solvable.
    /// </summary>
    public void Shuffle()
    {
        const int shuffleMoves = 100;
        for (int i = 0; i < shuffleMoves; i++)
        {
            // Pick a random direction: 0=Up, 1=Down, 2=Left, 3=Right
            int randomDirection = _random.Next(4);

            int newRow = _emptyTileRow;
            int newCol = _emptyTileCol;

            // Calculate new position based on direction
            if (randomDirection == 0) newRow--; // Up
            else if (randomDirection == 1) newRow++; // Down
            else if (randomDirection == 2) newCol--; // Left
            else if (randomDirection == 3) newCol++; // Right

            // Check if the new position is inside the 4x4 grid
            if (newRow >= 0 && newRow < BoardSize && newCol >= 0 && newCol < BoardSize)
            {
                // It's a valid move, so perform the swap
                _tiles[_emptyTileRow, _emptyTileCol] = _tiles[newRow, newCol];
                _tiles[newRow, newCol] = 0; // Move the empty space

                // Update the empty tile's location
                _emptyTileRow = newRow;
                _emptyTileCol = newCol;
            }
        }
    }

    /// <summary>
    /// Attempts to move the empty tile in the specified direction.
    /// If the move would go out of bounds, it is ignored.
    /// </summary>
    /// <param name="direction">The direction to move the empty tile (Up, Down, Left, Right).</param>
    /// <returns><c>true</c> if the move was valid and performed; otherwise, <c>false</c>.</returns>
    public bool TryMove(Direction direction)
    {
        // Get the actual position of the empty tile
        int targetRow = _emptyTileRow;
        int targetCol = _emptyTileCol;

        // Determine the target position based on the direction
        if (direction == Direction.Up) targetRow--;
        if (direction == Direction.Down) targetRow++;
        if (direction == Direction.Left) targetCol--;
        if (direction == Direction.Right) targetCol++;

        // Check if the target position is within bounds
        if (targetRow < 0 || targetRow >= BoardSize || targetCol < 0 || targetCol >= BoardSize)
        {
            return false; // Invalid move (off the board)
        }

        // Perform the swap
        _tiles[_emptyTileRow, _emptyTileCol] = _tiles[targetRow, targetCol];
        _tiles[targetRow, targetCol] = 0; // Move the empty space

        // Update the empty tile's location
        _emptyTileRow = targetRow;
        _emptyTileCol = targetCol;

        return true;
    }

    /// <summary>
    /// Checks if the puzzle is currently in the solved state.
    /// </summary>
    /// <returns><c>true</c> if all tiles are in order with the empty space last; otherwise, <c>false</c>.</returns>
    public bool IsSolved()
    {
        int expectedNumber = 1;

        for (int row = 0; row < BoardSize; row++)
        {
            for (int col = 0; col < BoardSize; col++)
            {
                // If we're at the last tile, it must be 0
                if (row == BoardSize - 1 && col == BoardSize - 1)
                {
                    return _tiles[row, col] == 0;
                }

                // Otherwise, check if the tile matches the expected number
                if (_tiles[row, col] != expectedNumber)
                {
                    return false; // Found a tile out of order
                }

                expectedNumber++; // Move to the next expected number
            }
        }

        return true;
    }

    /// <summary>
    /// Retrieves the numeric value of the tile at the specified grid coordinates.
    /// </summary>
    /// <param name="row">The row index of the tile.</param>
    /// <param name="col">The column index of the tile.</param>
    /// <returns>The number displayed on the tile at that location.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the row or column is outside the board's bounds.</exception>
    public int GetTile(int row, int col)
    {
        if (row < 0 || row >= BoardSize)
            throw new ArgumentOutOfRangeException(nameof(row),
                $"Row index {row} is out of bounds. Must be between 0 and {BoardSize - 1}.");
        if (col < 0 || col >= BoardSize)
            throw new ArgumentOutOfRangeException(nameof(col),
                $"Column index {col} is out of bounds. Must be between 0 and {BoardSize - 1}.");
        return _tiles[row, col];
    }
}