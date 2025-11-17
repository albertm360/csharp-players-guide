using Part2_ObjectOrientedProgramming.Models.Enums;

namespace Part2_ObjectOrientedProgramming.Models;

public class GameBoard
{
    private int[,] _tiles;
    private int _emptyTileRow;
    private int _emptyTileCol;

    private Random _random = new Random();

    public GameBoard()
    {
        // Initialize a solved 15-puzzle board
        _tiles = new int[4, 4];
        int number = 1;

        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                if (row == 3 && col == 3)
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
    /// Method <c>Shuffle</c> shuffles the board with valid movements.
    /// </summary>
    public void Shuffle()
    {
        for (int i = 0; i < 100; i++)
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
            if (newRow >= 0 && newRow < 4 && newCol >= 0 && newCol < 4)
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
    /// Method <c>TryMove</c> attempts to move the empty tile in the specified direction.
    /// </summary>
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
        if (targetRow < 0 || targetRow > 3 || targetCol < 0 || targetCol > 3)
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
    /// Method <c>IsSolved</c> checks if the puzzle is solved.
    /// </summary>
    public bool IsSolved()
    {
        int expectedNumber = 1;

        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                // If we're at the last tile, it must be 0
                if (row == 3 && col == 3)
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
}