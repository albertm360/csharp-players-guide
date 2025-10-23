namespace Part1_TheBasics;

public class Level11_TheMagicCannon
{
    static string BlastType(int turn)
    {
        string normal = "Normal";
        string special = "Special";
        string fire = "Fire";
        string electric = "Electric";

        if (turn % 5 == 0 && turn % 3 == 0)
        {
            return special;
        } 
        
        if (turn % 3 == 0)
        {
            return fire;
        }
        
        if (turn % 5 == 0)
        {
            return electric;
        } 
        
        return normal;
    }
    
    static void SetConsoleForegroundColor (string blastType)
    {
        switch (blastType)
        {
            case "Fire":
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case "Electric":
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case "Special":
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }
    }
    
    public static void Run()
    {
        int turn = 1;
        do
        {
            string blastType = BlastType(turn);
            SetConsoleForegroundColor(blastType);
            Console.WriteLine($"{turn}: {blastType}");
            Console.ResetColor();
            turn++;
        } while (turn <= 100);
    }
}