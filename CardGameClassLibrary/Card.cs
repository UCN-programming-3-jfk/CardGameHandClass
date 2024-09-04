using System;

namespace CardGameClassLibrary;
public enum Suit { Empty, Hearts, Spades, Clubs, Diamonds }
public class Card : IComparable<Card>
{
    public Suit Suit { get; set; }
    public int Value { get; set; }

    public Card(int value, Suit suit)
    {
        Value = value;
        Suit = suit;
    }

    public override string ToString()
    {
        string valueString = Value switch
        {
            1 => "Ace",
            11 => "Jack",
            12 => "Queen",
            13 => "King",
            _ => Value.ToString()
        };
        return $"{valueString} of {Suit}";
    }

    public int CompareTo(Card other)
    {
        return Value.CompareTo(other.Value);
    }
}