using System.Text;
using Part2_ObjectOrientedProgramming.Exercises;

while (true)
{
    Console.OutputEncoding = Encoding.UTF8;
    Console.Title = "Object Oriented Programming";
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\nSelect an exercise to run (or type 'exit' to quit):");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("01. Level 16: Simula's Test");
    Console.WriteLine("02. Level 17: Simula's Soup");
    Console.WriteLine("03. Level 18/19: Vin Fletcher's Arrows / Vin's Trouble");
    Console.WriteLine("04. Level 20/21: The Properties of Arrows / Arrow Factories");
    Console.WriteLine("05. Level 24: The Point");
    Console.WriteLine("06. Level 24: The Color");
    Console.WriteLine("07. Level 24: The Card");
    Console.WriteLine("08. Level 24: The Locked Door");
    Console.WriteLine("09. Level 24: The Password Validator");
    Console.WriteLine("10. Level 24: Rock-Paper-Scissors");
    Console.WriteLine("11. Level 24: 15-Puzzle");

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
            case "4":
                Console.ResetColor();
                Level20PropertiesOfArrows.Run();
                break;
            case "5":
                Console.ResetColor();
                Level24ThePoint.Run();
                break;
            case "6":
                Console.ResetColor();
                Level24TheColor.Run();
                break;
            case "7":
                Console.ResetColor();
                Level24TheCard.Run();
                break;
            case "8":
                Console.ResetColor();
                Level24TheLockedDoor exercise = new Level24TheLockedDoor();
                exercise.Run();
                break;
            case "9":
                Console.ResetColor();
                Level24ThePasswordValidator pwdValidator = new Level24ThePasswordValidator();
                pwdValidator.Run();
                break;
            case "10":
                Console.ResetColor();
                Level24RockPaperScissors rps = new Level24RockPaperScissors();
                rps.Run();
                break;
            case "11":
                Console.ResetColor();
                Level24FifteenPuzzle puzzle = new Level24FifteenPuzzle();
                puzzle.Run();
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