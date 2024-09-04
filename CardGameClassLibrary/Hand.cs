using System.Collections.Generic;
using System.Linq;

namespace CardGameClassLibrary;
public class Hand
{
    #region Properties
    private List<Card> _cards = new List<Card>();
    public int MaxCards { get; private set; }
    #endregion

    #region Constructor
    public Hand(int maxCards = 7)
    {
        MaxCards = maxCards;
    }
    #endregion

    #region HelperMethods

    public void Add(Card card)
    {
        _cards.Add(card);
        while (_cards.Count > MaxCards)
        {
            //remove the lowest card
            //using the IComparable implementation in the Card class
            //and the linq Min method
            _cards.Remove(_cards.Min());
        }
    }
    public void Remove(Card card) { _cards.Remove(card); }
    public void RemoveCardAt(int index) { _cards.RemoveAt(index); }
    public void Clear() { _cards.Clear(); }
    public IEnumerable<Card> GetAllCards() { return new List<Card>(_cards); }
    public Card GetCardAtPosition(int index) { return _cards[index]; }
    public Card this[int index]
    {
        get { return _cards[index]; }
        set { _cards[index] = value; }
    }
    #endregion
}