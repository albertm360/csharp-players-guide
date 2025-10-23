namespace Part1_TheBasics;

public class Item
{
    public int Number {get;}
    public string Name {get;}
    public int Price {get;}

    public Item(int number, string name, int price)
    {
        Number = number;
        Name = name;
        Price = price;
    }
}

public class Level10_DiscountedInventory
{
    private const string member = "albert";
    static Item rope = new Item(1, "Rope", 10);
    static Item torches = new Item(2, "Torches", 15);
    static Item climbingEquipment = new Item(3, "Climbing Equipment", 25);
    static Item cleanWater = new Item(4, "Clean Water", 1);
    static Item machete = new Item(5, "Machete", 20);
    static Item canoe = new Item(6, "Canoe", 200);
    static Item foodSupplies = new Item(7, "Food Supplies", 1);

    static List<Item> items = new List<Item>();

    static bool GetMembership()
    {
        do
        {
            Console.WriteLine("Hello and welcome to our store! What's your name?");
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && input.ToLower() == member)
            {
                Console.WriteLine($"Welcome {input}!");
                return true;
            }

            if (!string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine($"Welcome {input}!");
                return false;
            }
        } while (true);
    }
    
    static Item GetSelection()
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
                    1 => rope,
                    2 => torches,
                    3 => climbingEquipment,
                    4 => cleanWater,
                    5 => machete,
                    6 => canoe,
                    7 => foodSupplies,
                    _ => new Item(0, "Unknown selection.", 0)
                };
            }

            Console.WriteLine("Wrong input, try again.");

        } while (true);
    }
    
    public static void Run()
    {
        items.Add(rope);
        items.Add(torches);
        items.Add(climbingEquipment);
        items.Add(cleanWater);
        items.Add(machete);
        items.Add(canoe);
        items.Add(foodSupplies);

        bool isMember = false;
        
        isMember = GetMembership();

        Console.WriteLine("The following items are available:");

        foreach (Item item in items)
        {
            Console.WriteLine($"{item.Number} - {item.Name}");
        }
        
        Item selectedItem = GetSelection();
        Console.WriteLine($"{selectedItem.Name} costs {selectedItem.Price} gold.");

        if (isMember)
        {
            Console.WriteLine($"Since you have a membership, the price is reduced to {selectedItem.Price/2} gold.");
        }
    }
}