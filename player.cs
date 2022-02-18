using System;
using System.Collections.Generic;

namespace poker
{
    public class Player
    {
        public int money { get; set; }
        public Hand hand { get; private set; }
        public string name { get; private set; }

        public Player(int Money, Hand Hand, string name)
        {
            money = Money;
            this.hand = Hand;
            this.name = name;
            
        }

    }

    public class Hand : CardCollection
    {
        
        public Hand()
        {
            
        }
        public void removeCard(Card c)
        {
            
        }
        
    }
}