namespace Part2_ObjectOrientedProgramming;

public class ArrowP
{
    // ArrowP is the Arrow Class but using Properties instead of Fields
    public Arrowhead Arrowhead { get; init; }
    public Fletching Fletching { get; init; }
    public int ShaftLength { get; init; }

    public ArrowP(Arrowhead arrowhead, Fletching fletching, int shaftLength)
    {
        if (shaftLength < 60 || shaftLength > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(shaftLength), "Shaft length must be between 60 and 100 cm.");
        }

        Arrowhead = arrowhead;
        Fletching = fletching;
        ShaftLength = shaftLength;
    }

    public int GetArrowheadPrice()
    {
        switch (Arrowhead)
        {
            case Arrowhead.Steel:
                return 10;
            case Arrowhead.Wood:
                return 3;
            case Arrowhead.Obsidian:
                return 5;
        }

        throw new ArgumentOutOfRangeException(nameof(Arrowhead), "Unexpected arrowhead material.");
    }

    public int GetFletchingPrice()
    {
        switch (Fletching)
        {
            case Fletching.Plastic:
                return 10;
            case Fletching.TurkeyFeathers:
                return 5;
            case Fletching.GooseFeathers:
                return 3;
        }

        throw new ArgumentOutOfRangeException(nameof(Fletching), "Unexpected fletching material.");
    }

    public float GetShaftPrice()
    {
        return ShaftLength * 0.05f;
    }

    public float GetCost()
    {
        float totalCost = 0.0f;
        totalCost += GetArrowheadPrice();
        totalCost += GetFletchingPrice();
        totalCost += GetShaftPrice();
        return totalCost;
    }
}