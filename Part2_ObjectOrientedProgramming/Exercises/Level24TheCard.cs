using Part2_ObjectOrientedProgramming.Models;
using Part2_ObjectOrientedProgramming.Models.Enums;

namespace Part2_ObjectOrientedProgramming.Exercises;

public class Level24TheCard
{
    public static void Run()
    {
        List<Card> cards = new List<Card>();
        foreach (CardColor cardColor in Enum.GetValues(typeof(CardColor)))
        {
            foreach (CardRank cardRank in Enum.GetValues(typeof(CardRank)))
            {
                Card card = new Card(cardColor, cardRank);
                cards.Add(card);
            }
        }

        foreach (Card card in cards)
        {
            Console.WriteLine($"The {card.CardColor} {card.CardRank} is a {card.CardType} card.");
        }
    }
}