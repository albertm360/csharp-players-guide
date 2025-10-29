namespace Part2_ObjectOrientedProgramming;

public class Arrow
{
    private Arrowhead _arrowhead;
    private Fletching _fletching;
    private int _shaft;

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