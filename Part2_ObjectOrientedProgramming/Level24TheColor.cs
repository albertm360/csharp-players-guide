namespace Part2_ObjectOrientedProgramming;

public class Level24TheColor
{
    public static void Run()
    {
        Color pistachioGreen = new Color(189, 235, 52);
        Color orange = Color.Orange;

        Console.WriteLine(
            $"{nameof(pistachioGreen)}: {pistachioGreen.RedLight}, {pistachioGreen.GreenLight}, {pistachioGreen.BlueLight}");
        Console.WriteLine($"{nameof(orange)}: {orange.RedLight}, {orange.GreenLight}, {orange.BlueLight}");
    }
}