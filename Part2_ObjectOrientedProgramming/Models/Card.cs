using Part2_ObjectOrientedProgramming.Models.Enums;

namespace Part2_ObjectOrientedProgramming.Models;

public class Card
{
    public CardColor CardColor { get; }
    public CardRank CardRank { get; }
    public CardType CardType { get; }

    public Card(CardColor cardColor, CardRank cardRank)
    {
        CardColor = cardColor;
        CardRank = cardRank;
        CardType = SetCardType();
    }

    private CardType SetCardType()
    {
        if (CardRank == CardRank.Ampersand || CardRank == CardRank.Caret ||
            CardRank == CardRank.DollarSign || CardRank == CardRank.Percent)
        {
            return CardType.Symbol;
        }

        return CardType.Numbered;
    }
}