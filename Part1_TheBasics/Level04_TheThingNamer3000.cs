namespace Part1_TheBasics;

public class Level04_TheThingNamer3000
{
    public static void Run()
    {
        Console.WriteLine("What kind of thing are we talking about?"); 
        // Ask the user what thing:
        string? thingInput = Console.ReadLine();
        string thingName = string.IsNullOrWhiteSpace(thingInput) ? "thing" : thingInput;
        
        Console.WriteLine("How would you describe it? Big? Azure? Tattered?"); 
        /* Ask the user how is the thing: */
        string? descriptionInput = Console.ReadLine();
        string description = string.IsNullOrWhiteSpace(descriptionInput) ? "description" : descriptionInput;
        string ofDoom = "of Doom"; 
        string threeKay = "3000"; 
        Console.WriteLine($"The {description} {thingName} {ofDoom} {threeKay}!");
    }
}