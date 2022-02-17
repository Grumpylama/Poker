using System;
using System.Collections.Generic;
using System.Threading;

namespace poker
{
    public class Graphics
    {


        public static void DrawBoard( Player p, Hand cC)
        {
            int height = Console.WindowHeight;
            int width = Console.WindowWidth;
            Console.Clear();
            Console.WriteLine();

            
        }

        public int askForInput(Player p, Hand cC, string o1, string o2, string o3)
        {
            int state = 0;
            bool CurrentVisible = true;
           

            while (true)
            {
                for(int i = 0; i < 15; i++)
                {
                    if (Console.KeyAvailable)
                    {
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.Enter:
                                return state;
                            case ConsoleKey.DownArrow:
                                if (state != 0)
                                {
                                    state--;
                                }
                                break;
                            case ConsoleKey.UpArrow:
                                if (state != 2)
                                {
                                    state++;
                                }
                                break;
                        }
                    }
                    
                    Thread.Sleep(16);

                }
                CurrentVisible = !CurrentVisible;
                DrawBoard(p, cC);
            }
            
            
        }
        public int askForInput(Player p, Hand cC, string o1, string o2)
        {
            return 1;
        }
        

    }
        

        

}