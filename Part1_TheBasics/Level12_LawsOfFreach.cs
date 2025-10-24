namespace Part1_TheBasics;

public class Level12_LawsOfFreach
{
    static int CalculateSmallest(int[] array)
    {
        int currentSmallest = int.MaxValue;

        foreach (int value in array)
        {
            if (value < currentSmallest)
            {
                currentSmallest = value;
            }
        }

        return currentSmallest;
    }

    static float CalculateAverage(int[] array)
    {
        int total = 0;
        foreach (int value in array)
        {
            total += value;
        }

        float average = (float)total / array.Length;
        return average;
    }

    public static void Run()
    {
        int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

        Console.WriteLine($"The smallest number is: {CalculateSmallest(array)}");
        Console.WriteLine($"The average number is: {CalculateAverage(array)}");
    }
}