﻿using System.Text;

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

    public static void Run()
    {
        // This exercise uses the ArrowP class, built with Properties instead of Fields
        Console.OutputEncoding = Encoding.UTF8;

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

        ArrowP arrow = new ArrowP(arrowhead, fletching, shaftLength);

        float totalCost = arrow.GetCost();
        Console.WriteLine($"Your arrow costs {totalCost} gold. 💰");

        Console.WriteLine($"Arrowhead: {arrow.Arrowhead.ToString().ToLower()} - {arrow.GetArrowheadPrice()} gold.");
        Console.WriteLine($"Fletching: {arrow.Fletching.ToString().ToLower()} - {arrow.GetFletchingPrice()} gold.");
        Console.WriteLine($"Shaft: {arrow.ShaftLength.ToString()} cm - {arrow.GetShaftPrice()} gold.");
    }
}