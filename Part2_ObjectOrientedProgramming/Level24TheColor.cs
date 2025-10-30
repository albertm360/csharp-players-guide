namespace Part2_ObjectOrientedProgramming;

public class Level24TheColor
{
    public static void Run()
    {
        Color pistaccioGreen = new Color(189, 235, 52);
        Color orange = Color.Orange;

        Console.WriteLine(
            $"{nameof(pistaccioGreen)}: {pistaccioGreen.RedLight}, {pistaccioGreen.GreenLight}, {pistaccioGreen.BlueLight}");
        Console.WriteLine($"{nameof(orange)}: {orange.RedLight}, {orange.GreenLight}, {orange.BlueLight}");
    }
}