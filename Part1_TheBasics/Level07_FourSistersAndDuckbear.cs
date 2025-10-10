namespace Part1_TheBasics;

public class Level07_FourSistersAndDuckbear
{
    static int CalculateDuckbearEggs(int eggs, int sisters)
    {
        return eggs % sisters;
    }
    
    static int CalculateSistersEggs(int eggs, int sisters)
    {
        return eggs / sisters;
    }
    
    public static void Run()
    {
        int chocoEggs = 0;
        int sisters = 4;
        
        Console.WriteLine("How many chocolate eggs have been gathered today?");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out chocoEggs) && chocoEggs >= 0)
        {
            int eggsForSisters = CalculateSistersEggs(eggs: chocoEggs, sisters: sisters);
            int eggsForDuckbear = CalculateDuckbearEggs(eggs: chocoEggs, sisters: sisters);
            Console.WriteLine($"Every sister will get {eggsForSisters} chocolate eggs.");
            Console.WriteLine($"The Duckbear will get {eggsForDuckbear} chocolate eggs.");
        }
    }
}