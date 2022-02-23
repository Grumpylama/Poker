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
            Graphics g = new Graphics();
            List<Player> pl = new List<Player>();
            pl.Add(new Player(100, "Carl"));
            pl.Add(new Player(100, "Mike"));
            pl.Add(new Player(100, "Bike"));
            Deck d = new Deck();
            d.ResetDeck();
            GameLogic gl = new GameLogic(pl, d);
            
            g.MainMenu(gl);
                

        }
    }
}
