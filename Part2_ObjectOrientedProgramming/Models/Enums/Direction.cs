namespace Part2_ObjectOrientedProgramming.Models.Enums;

/// <summary>
/// Represents the four cardinal directions used for movement within the 15-Puzzle game grid.
/// </summary>
public enum Direction
{
    /// <summary>
    /// Represents moving the empty tile upwards (decreasing the row index).
    /// </summary>
    Up,

    /// <summary>
    /// Represents moving the empty tile downwards (increasing the row index).
    /// </summary>
    Down,

    /// <summary>
    /// Represents moving the empty tile to the left (decreasing the column index).
    /// </summary>
    Left,

    /// <summary>
    /// Represents moving the empty tile to the right (increasing the column index).
    /// </summary>
    Right
}