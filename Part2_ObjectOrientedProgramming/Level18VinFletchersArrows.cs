namespace Part2_ObjectOrientedProgramming;

public class Utils
{
    public static int PrintEnumValues<TEnum>() where TEnum : Enum
    {
        Type enumType = typeof(TEnum);

        var enumValues = Enum.GetValues(enumType);

        Console.WriteLine($"--- {enumType.Name} Options ---");
        for (int i = 0; i < enumValues.Length; i++)
        {
            var enumValue = enumValues.GetValue(i);
            Console.WriteLine($"{i + 1} - {enumValue}");
        }

        return enumValues.Length;
    }

    public static int GetValidChoice(string prompt, int totalItems)
    {
        do
        {
            Console.WriteLine(prompt);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice > 0 && choice <= totalItems) return choice;

            Console.WriteLine("Wrong input, enter the number of the item...");
        } while (true);
    }

    public static int GetValidChoiceInRange(string prompt, int min, int max)
    {
        do
        {
            Console.WriteLine(prompt);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= min && number <= max) return number;

            Console.WriteLine($"Wrong input, enter a number between {min} and {max}...");
        } while (true);
    }
}

public class Arrow
{
    Arrowhead _arrowhead;
    Fletching _fletching;
    int _shaft;

    public Arrow(Arrowhead arrowhead, Fletching fletching, int shaft)
    {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _shaft = shaft;
    }

    public Arrowhead GetArrowhead()
    {
        return _arrowhead;
    }

    public Fletching GetFletching()
    {
        return _fletching;
    }

    public int GetShaftLength()
    {
        return _shaft;
    }

    public void SetArrowhead(Arrowhead arrowhead)
    {
        _arrowhead = arrowhead;
    }

    public void SetFletching(Fletching fletching)
    {
        _fletching = fletching;
    }

    public void SetShaft(int length)
    {
        _shaft = length;
    }

    private static int GetArrowheadPrice(Arrowhead arrowhead)
    {
        switch (arrowhead)
        {
            case Arrowhead.Steel:
                return 10;
            case Arrowhead.Wood:
                return 3;
            case Arrowhead.Obsidian:
                return 5;
        }

        throw new ArgumentOutOfRangeException(nameof(arrowhead), "Unexpected arrowhead material.");
    }

    private static int GetFletchingPrice(Fletching fletching)
    {
        switch (fletching)
        {
            case Fletching.Plastic:
                return 10;
            case Fletching.TurkeyFeathers:
                return 5;
            case Fletching.GooseFeathers:
                return 3;
        }

        throw new ArgumentOutOfRangeException(nameof(fletching), "Unexpected fletching material.");
    }

    private static float GetShaftPrice(int shaft)
    {
        return shaft * 0.05f;
    }

    public float GetCost()
    {
        float totalCost = 0.0f;
        totalCost += GetArrowheadPrice(_arrowhead);
        totalCost += GetFletchingPrice(_fletching);
        totalCost += GetShaftPrice(_shaft);
        return totalCost;
    }
}

public class Level18VinFletchersArrows
{
    static Arrowhead SelectedArrowhead(int choice)
    {
        switch (choice)
        {
            case 1:
                return Arrowhead.Steel;
            case 2:
                return Arrowhead.Wood;
            case 3:
                return Arrowhead.Obsidian;
        }

        throw new ArgumentOutOfRangeException(nameof(choice), "Unexpected arrowhead material.");
    }

    static Fletching SelectedFletching(int choice)
    {
        switch (choice)
        {
            case 1:
                return Fletching.Plastic;
            case 2:
                return Fletching.TurkeyFeathers;
            case 3:
                return Fletching.GooseFeathers;
        }

        throw new ArgumentOutOfRangeException(nameof(choice), "Unexpected fletching material.");
    }

    public static void Run()
    {
        const string ArrowheadPrompt = "Choose the arrowhead material: ";
        const string FletchingPrompt = "Choose the fletching material: ";
        const string ShaftPrompt = "Choose the length of the shaft: ";
        const int ShaftMinLength = 60;
        const int ShaftMaxLength = 100;

        int totalArrowheadItems = Utils.PrintEnumValues<Arrowhead>();
        int arrowheadMenu = Utils.GetValidChoice(ArrowheadPrompt, totalArrowheadItems);
        Arrowhead arrowhead = SelectedArrowhead(arrowheadMenu);

        int totalFletchingItems = Utils.PrintEnumValues<Fletching>();
        int fletchingMenu = Utils.GetValidChoice(FletchingPrompt, totalFletchingItems);
        Fletching fletching = SelectedFletching(fletchingMenu);

        int shaftLength = Utils.GetValidChoiceInRange(ShaftPrompt, ShaftMinLength, ShaftMaxLength);

        Arrow arrow = new Arrow(arrowhead, fletching, shaftLength);
        double totalCost = arrow.GetCost();
        Console.WriteLine($"Your arrow costs {totalCost} gold.");
    }
}