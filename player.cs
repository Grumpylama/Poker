using System;
using System.Collections.Generic;

namespace poker
{
    public class Player
    {
        int money { get; set; }
        Hand hand { get; }
        Deck deck { get; }

        public Player(int Money, Hand Hand, Deck Deck)
        {
            money = Money;
            hand = Hand;
            deck = Deck;
        }

    }

    public class Hand
    {
        public List<Card> cards;
        public Hand()
        {
            
        }
        public void removeCard(Card c)
        {
            
        }
        public void addCard(Card c)
        {
            cards.Add(c);
        }
    }
}