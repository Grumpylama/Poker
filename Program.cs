using System;
using System.Collections.Generic;

namespace poker
{
    class Program
    { 
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.ResetDeck();
            foreach (Card c in deck.Cards)
            {
                foreach (string s in c.lines)
                {
                    Console.WriteLine(s);
                }
            }
            
        }
    }
}
