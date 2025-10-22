using System.Diagnostics;

namespace Part1_TheBasics;

public class Level10_BuyingInventory
{
    static string PrintMenu()
    {
        const string menu = """
                            1 - Rope
                            2 - Torches
                            3 - Climbing Equipment
                            4 - Clean Water
                            5 - Machete
                            6 - Canoe
                            7 - Food Supplies
                            """;
        return menu;
    }

    static string GetSelection()
    {
        do
        {
            string prompt = "What number do you want to see the price of? ";
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int selection) && selection > 0 && selection <= 7)
            {
                return selection switch
                {
                    1 => "A Rope costs 10 gold.",
                    2 => "Torches cost 15 gold.",
                    3 => "Climbing Equipment cost 25 gold.",
                    4 => "Clean Water costs 1 gold.",
                    5 => "A Machete costs 20 gold.",
                    6 => "A Canoe costs 200 gold.",
                    7 => "Food Supplies cost 1 gold.",
                    _ => "Error: Unexpected selection value"
                };
            }

            Console.WriteLine("Wrong input, try again.");

        } while (true);
    }
    public static void Run()
    {
        Console.WriteLine("The following items are available:");
        Console.WriteLine(PrintMenu());

        Console.WriteLine(GetSelection());
    }
}