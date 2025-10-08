using Part1_TheBasics;

while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\nSelect an exercise to run (or type 'exit' to quit):");
    
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("1. Level 3: Hello, World!");
    Console.WriteLine("2. Level 3: What Comes Next");
    Console.WriteLine("3. Level 3: The Makings of a Programmer");
    
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
                Level03_HelloWorld.Run();
                break;
            case "2":
                Console.ResetColor();
                Level03_WhatComesNext.Run();
                break;
            case "3":
                Console.ResetColor();
                Level03_MakingsProgrammer.Run();
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