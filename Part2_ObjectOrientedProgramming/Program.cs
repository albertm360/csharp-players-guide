using Part2_ObjectOrientedProgramming;

while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\nSelect an exercise to run (or type 'exit' to quit):");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("01. Level 16: Simula's Test");
    Console.WriteLine("02. Level 17: Simula's Soup");
    Console.WriteLine("03. Level 18/19: Vin Fletcher's Arrows / Vin's Trouble");

    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("\nEnter your choice: ");
    string? choice = Console.ReadLine();

    if (choice?.ToLower() == "exit")
    {
        break;
    }

    try
    {
        switch (choice)
        {
            case "1":
                Console.ResetColor();
                Level16SimulasTest.Run();
                break;
            case "2":
                Console.ResetColor();
                Level17SimulasSoup.Run();
                break;
            case "3":
                Console.ResetColor();
                Level18VinFletchersArrows.Run();
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid selection. Please try again.");
                Console.ResetColor();
                break;
        }
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"An error occurred: {ex.Message}");
        Console.ResetColor();
    }

    Console.WriteLine("\nPress any key to return to the menu...");
    Console.ReadKey();
}