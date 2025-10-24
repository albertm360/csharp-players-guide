using Part1_TheBasics;

while (true)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\nSelect an exercise to run (or type 'exit' to quit):");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("01. Level 03: Hello, World!");
    Console.WriteLine("02. Level 03: What Comes Next");
    Console.WriteLine("03. Level 03: The Makings of a Programmer");
    Console.WriteLine("04. Level 03: Consolas and Telim");
    Console.WriteLine("05. Level 04: The Thing Namer 3000");
    Console.WriteLine("06. Level 06: The Variable Shop");
    Console.WriteLine("07. Level 06: The Variable Shop Returns");
    Console.WriteLine("08. Level 07: The Triangle Farmer");
    Console.WriteLine("09. Level 07: The Four Sisters and the Duckbear");
    Console.WriteLine("10. Level 07: The Dominion Of Kings");
    Console.WriteLine("11. Level 08: The Defense of Consolas");
    Console.WriteLine("12. Level 09: Repairing the Clocktower");
    Console.WriteLine("13. Level 09: Watchtower");
    Console.WriteLine("14. Level 10: Buying Inventory");
    Console.WriteLine("15. Level 10: Discounted Inventory");
    Console.WriteLine("16. Level 11: The Prototype");
    Console.WriteLine("17. Level 11: The Magic Cannon");
    Console.WriteLine("18. Level 12: The Replicator of D'To");

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
            case "11":
                Console.ResetColor();
                Level08_DefenseOfConsolas.Run();
                break;
            case "12":
                Console.ResetColor();
                Level09_RepairingTheClocktower.Run();
                break;
            case "13":
                Console.ResetColor();
                Level09_Watchtower.Run();
                break;
            case "14":
                Console.ResetColor();
                Level10_BuyingInventory.Run();
                break;
            case "15":
                Console.ResetColor();
                Level10_DiscountedInventory.Run();
                break;
            case "16":
                Console.ResetColor();
                Level11_ThePrototype.Run();
                break;
            case "17":
                Console.ResetColor();
                Level11_TheMagicCannon.Run();
                break;
            case "18":
                Console.ResetColor();
                Level12_ReplicatorOfDTo.Run();
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