using System;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.InteropServices;

namespace poker
{
    class Program
    {
        
        static void Main(string[] args)
        {

            ConsoleHelper.SetCurrentFont("Consolas", 40);


            Deck deck = new Deck();
            deck.ResetDeck();

            Console.WriteLine(deck.getValues());

            foreach (Card c in deck.Cards)
            {
                foreach (string s in c.lines)
                {
                    Console.WriteLine(s);
                }
            }
            String[] strings = new string[] { null, "hello" };

            Graphics g = new Graphics();
            CardCollection  cc = new CardCollection();
            cc.addCard(deck.DrawCard());
            cc.addCard(deck.DrawCard());
            cc.addCard(deck.DrawCard());
            Hand hand = new Hand();
            hand.addCard(deck.DrawCard());
            hand.addCard(deck.DrawCard());
            g.askForInput(new Player(123, hand, "alfred"), cc, " ", " ", "");


        }
    }
}
