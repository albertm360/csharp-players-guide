using Part1_TheBasics;

while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\nSelect an exercise to run (or type 'exit' to quit):");
    
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("01. Level 3: Hello, World!");
    Console.WriteLine("02. Level 3: What Comes Next");
    Console.WriteLine("03. Level 3: The Makings of a Programmer");
    Console.WriteLine("04. Level 3: Consolas and Telim");
    Console.WriteLine("05. Level 4: The Thing Namer 3000");
    Console.WriteLine("06. Level 6: The Variable Shop");
    Console.WriteLine("07. Level 6: The Variable Shop Returns");
    Console.WriteLine("08. Level 7: The Triangle Farmer");
    Console.WriteLine("09. Level 7: The Four Sisters and the Duckbear");
    Console.WriteLine("10. Level 7: The Dominion Of Kings");
    
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
            case "4":
                Console.ResetColor();
                Level03_ConsolasAndTelim.Run();
                break;
            case "5":
                Console.ResetColor();
                Level04_TheThingNamer3000.Run();
                break;
            case "6":
                Console.ResetColor();
                Level06_TheVariableShop.Run();
                break;
            case "7":
                Console.ResetColor();
                Level06_VariableShopReturns.Run();
                break;
            case "8":
                Console.ResetColor();
                Level07_TheTriangleFarmer.Run();
                break;
            case "9":
                Console.ResetColor();
                Level07_FourSistersAndDuckbear.Run();
                break;
            case "10":
                Console.ResetColor();
                Level07_TheDominionOfKings.Run();
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