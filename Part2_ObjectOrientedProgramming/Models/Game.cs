using Part2_ObjectOrientedProgramming.Models.Enums;

namespace Part2_ObjectOrientedProgramming.Models;

public class Game
{
    private readonly GameBoard _board;
    public int Moves { get; private set; }

    public Game()
    {
        _board = new GameBoard();
        _board.Shuffle();
        Moves = 0;
    }

    public int GetTileAt(int row, int col)
    {
        return _board.GetTile(row, col);
    }

    public bool IsWon()
    {
        return _board.IsSolved();
    }

    public void Move(Direction direction)
    {
        if (_board.TryMove(direction)) Moves++;
    }
}