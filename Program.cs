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
            
            Console.S dowHeight);
            

            Deck deck = new Deck();
            deck.ResetDeck();
            
            foreach (Card c in deck.Cards)
            {
                foreach (string s in c.lines)
                {
                    Console.WriteLine(s);
                }
            }
            

            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine(Console.WindowWidth + "  " + Console.WindowHeight);
                //ConsoleHelper.SetCurrentFont("Consolas", 40);
            }
            
            
        }
    }
}
