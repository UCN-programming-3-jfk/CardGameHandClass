using CardGameClassLibrary;
namespace CardGameConsoleTester;
internal class Program
{
    static void Main(string[] args)
    {

        IEnumerable<Card> _cards = new List<Card>
        {
            new Card(13, Suit.Diamonds),
            new Card(4, Suit.Spades),
            new Card(8, Suit.Hearts),
            new Card(7, Suit.Clubs),
            new Card(1, Suit.Hearts),
            new Card(11, Suit.Diamonds),
            new Card(12, Suit.Spades)
        };

        Console.WriteLine("Creating hand with max 5 cards in it");
        Console.WriteLine();
        Hand hand = new Hand(5);
        Console.WriteLine("Adding cards:");
        foreach (var card in _cards)
        {
            Console.WriteLine($"  adding {card}");
            hand.Add(card);
        }
        Console.WriteLine();

        Console.WriteLine($"Here are the {hand.GetAllCards().Count()} cards in the hand:");
        foreach (var card in hand.GetAllCards())
        {
            Console.WriteLine($" - {card}");
        }
        Console.WriteLine();

        //Using the GetCardAtPosition method
        Console.WriteLine("First card: " + hand.GetCardAtPosition(0));
        Console.WriteLine();

        //Using the indexer
        Console.WriteLine("Second card: " + hand[1]);
        Console.WriteLine();


    }
}