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
            GameLogic gl = new GameLogic(new List<Player>(), new Deck());
            
            g.MainMenu(gl);
                

        }
    }
}
