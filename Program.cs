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
<<<<<<< HEAD
            
=======




>>>>>>> 790187fdee911e915e4aed48371e5c1655aa84c1
            Deck deck = new Deck();
            deck.ResetDeck();

            Console.WriteLine(deck.getValues());

            //foreach (Card c in deck.Cards)
            //{
            //    foreach (string s in c.lines)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
            //String[] strings = new string[] { null, "hello" };

            //Graphics g = new Graphics();
            //g.askForInput(new Player(123, new Hand(), new Deck()), new Hand(), " ", " ", "");


        }
    }
}
