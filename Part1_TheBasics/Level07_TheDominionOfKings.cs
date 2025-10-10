namespace Part1_TheBasics;

public class Level07_TheDominionOfKings
{
    static int GetNonNegativeInt(string prompt)
    {
        int number;
        
        do
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out number) && number >= 0)
            {
                return number;
            }
            
            Console.WriteLine("Invalid input. Please enter a non-negative number.");
        } while (true);
    }
    
    public static void Run()
    {
        const int provincePoints = 6;
        const int duchyPoints = 3;
        const int estatePoints = 1;
        
        int provinceCount = GetNonNegativeInt(prompt: "How many provinces do you own? ");
        int duchyCount = GetNonNegativeInt(prompt: "How many duchies do you own? ");
        int estateCount = GetNonNegativeInt(prompt: "how many estates do you own? ");
        
        int totalPoints = provinceCount * provincePoints + 
                          duchyCount * duchyPoints +
                          estateCount * estatePoints;
        
        Console.WriteLine($"You have {totalPoints} total points!");
    }
}