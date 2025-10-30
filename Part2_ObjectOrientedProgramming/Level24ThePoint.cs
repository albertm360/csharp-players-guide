namespace Part2_ObjectOrientedProgramming;

public class Level24ThePoint
{
    public static void Run()
    {
        Point point1 = new Point(2, 3);
        Point point2 = new Point(-4, 0);

        string point1Prompt = $"{nameof(point1)}: ({point1.XCoordinate}, {point1.YCoordinate})";
        string point2Prompt = $"{nameof(point2)}: ({point2.XCoordinate}, {point2.YCoordinate})";

        Console.WriteLine(point1Prompt);
        Console.WriteLine(point2Prompt);
    }
}