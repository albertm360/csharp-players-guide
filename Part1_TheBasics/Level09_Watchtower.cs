namespace Part1_TheBasics;

public class Level09_Watchtower
{
    static int GetPosition(string prompt)
    {
        do
        {
            int position;
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out position))
            {
                return position;
            }
            
            Console.WriteLine("Invalid number. Try again.");
        } while (true);
    }

    static string Enemy(int x, int y)
    {
        const string here = "The enemy is here!";
        const string northWest = "The enemy is to the northwest!";
        const string north = "The enemy is to the north!";
        const string northEast = "The enemy is to the northeast!";
        const string east = "The enemy is to the east!";
        const string southEast = "The enemy is to the southeast!";
        const string south = "The enemy is to the south!";
        const string southWest = "The enemy is to the southwest!";
        const string west = "The enemy is to the west!";

        if (x == 0 && y > 0) return north;
        if (x == 0 && y == 0) return here;
        if (x == 0 && y < 0) return south;
        if (x > 0 && y > 0) return northEast;
        if (x > 0 && y == 0) return east;
        if (x > 0 && y < 0) return southEast;
        if (x < 0 && y > 0) return northWest;
        if (x < 0 && y == 0) return west;
        if (x < 0 && y < 0) return southWest;
        
        return "Unknown location";
    }
    
    public static void Run()
    {
        string xPosPrompt = "Introduce the 'x' coordinate: ";
        string yPosPrompt = "Introduce the 'y' coordinate: ";
        
        int xPos = GetPosition(xPosPrompt);
        int yPos = GetPosition(yPosPrompt);

        Console.WriteLine(Enemy(x: xPos, y: yPos));
    }
}