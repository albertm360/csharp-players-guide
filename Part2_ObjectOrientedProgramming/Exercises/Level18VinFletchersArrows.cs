using Part2_ObjectOrientedProgramming.Models;
using Part2_ObjectOrientedProgramming.Models.Enums;

namespace Part2_ObjectOrientedProgramming.Exercises;

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
        /*
         * This file covers exercise "Vin Fletcher's Arrows" and "Vin's Trouble",
         * since the objectives of the latter, besides making the fields private,
         * were already included on lesson 18.
         */

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
        float totalCost = arrow.GetCost();
        Console.WriteLine($"Your arrow costs {totalCost} gold.");
    }
}