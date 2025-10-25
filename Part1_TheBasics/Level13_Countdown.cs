namespace Part1_TheBasics;

public class Level13_Countdown
{
    static void Countdown(int number)
    {
        if (number == 0) return;
        Console.WriteLine(number);
        Countdown(number - 1);
    }

    public static void Run()
    {
        Countdown(10);
    }
}