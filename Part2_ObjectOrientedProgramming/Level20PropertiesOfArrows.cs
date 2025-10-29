using System.Text;

namespace Part2_ObjectOrientedProgramming;

public class Level20PropertiesOfArrows
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

    static void PrintStandardMenu()
    {
        string menu = """
                      1 - Elite Arrow
                      2 - Beginner Arrow
                      3 - Marksman Arrow
                      """;
        Console.WriteLine(menu);
    }

    static ArrowP GetStandardArrow(int choice)
    {
        switch (choice)
        {
            case 1:
                return ArrowP.CreateEliteArrow();
            case 2:
                return ArrowP.CreateBeginnerArrow();
            case 3:
                return ArrowP.CreateMarksmanArrow();
        }

        throw new ArgumentOutOfRangeException(nameof(choice), "Unexpected arrow selection.");
    }

    public static void Run()
    {
        // This exercise uses the ArrowP class, built with Properties instead of Fields
        // Also has been modified implementing exercise Arrow Factories from Lesson 21
        Console.OutputEncoding = Encoding.UTF8;

        const string FactoryPrompt =
            "Choose 1 if you want to select a standard arrow, and 2 if you prefer a custom arrow: ";
        const string StandardArrowPrompt = "Which kind of arrow do you want? ";
        const string ArrowheadPrompt = "Choose the arrowhead material: ";
        const string FletchingPrompt = "Choose the fletching material: ";
        const string ShaftPrompt = "Choose the length of the shaft: ";
        const int ShaftMinLength = 60;
        const int ShaftMaxLength = 100;
        ArrowP? arrow;

        int factorySelection = Utils.GetValidChoice(FactoryPrompt, 2);
        if (factorySelection == 1)
        {
            PrintStandardMenu();
            int standardArrowSelection = Utils.GetValidChoice(StandardArrowPrompt, 3);
            arrow = GetStandardArrow(standardArrowSelection);
        }
        else
        {
            int totalArrowheadItems = Utils.PrintEnumValues<Arrowhead>();
            int arrowheadMenu = Utils.GetValidChoice(ArrowheadPrompt, totalArrowheadItems);
            Arrowhead arrowhead = SelectedArrowhead(arrowheadMenu);

            int totalFletchingItems = Utils.PrintEnumValues<Fletching>();
            int fletchingMenu = Utils.GetValidChoice(FletchingPrompt, totalFletchingItems);
            Fletching fletching = SelectedFletching(fletchingMenu);

            int shaftLength = Utils.GetValidChoiceInRange(ShaftPrompt, ShaftMinLength, ShaftMaxLength);

            arrow = new ArrowP(arrowhead, fletching, shaftLength);
        }

        float totalCost = arrow.GetCost();

        Console.WriteLine($"Your arrow costs {totalCost} gold. 💰");

        Console.WriteLine($"Arrowhead: {arrow.Arrowhead.ToString().ToLower()} - {arrow.GetArrowheadPrice()} gold.");
        Console.WriteLine($"Fletching: {arrow.Fletching.ToString().ToLower()} - {arrow.GetFletchingPrice()} gold.");
        Console.WriteLine($"Shaft: {arrow.ShaftLength.ToString()} cm - {arrow.GetShaftPrice()} gold.");
    }
}