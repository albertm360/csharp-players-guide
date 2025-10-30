namespace Part2_ObjectOrientedProgramming.Models;

public class Point
{
    public int XCoordinate { get; }
    public int YCoordinate { get; }

    public Point()
    {
        XCoordinate = 0;
        YCoordinate = 0;
    }

    public Point(int xCoordinate, int yCoordinate)
    {
        XCoordinate = xCoordinate;
        YCoordinate = yCoordinate;
    }
}