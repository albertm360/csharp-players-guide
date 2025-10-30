namespace Part2_ObjectOrientedProgramming;

public class Color
{
    public int RedLight { get; init; }
    public int GreenLight { get; init; }
    public int BlueLight { get; init; }

    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);
    public static Color Red { get; } = new Color(255, 0, 0);
    public static Color Orange { get; } = new Color(255, 165, 0);
    public static Color Yellow { get; } = new Color(255, 255, 0);
    public static Color Green { get; } = new Color(0, 128, 0);
    public static Color Blue { get; } = new Color(0, 0, 255);
    public static Color Purple { get; } = new Color(128, 0, 128);

    public Color()
    {
        RedLight = 0;
        GreenLight = 0;
        BlueLight = 0;
    }

    public Color(int redLight, int greenLight, int blueLight)
    {
        if (redLight < 0 || redLight > 255)
        {
            throw new ArgumentOutOfRangeException(nameof(redLight), redLight, @"Red must be between 0 and 255");
        }

        if (greenLight < 0 || greenLight > 255)
        {
            throw new ArgumentOutOfRangeException(nameof(greenLight), greenLight, @"Green must be between 0 and 255");
        }

        if (blueLight < 0 || blueLight > 255)
        {
            throw new ArgumentOutOfRangeException(nameof(blueLight), blueLight, @"Blue must be between 0 and 255");
        }

        RedLight = redLight;
        GreenLight = greenLight;
        BlueLight = blueLight;
    }
}