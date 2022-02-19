using System;
using System.Collections.Generic;
using System.Threading;

namespace poker
{
    public class Graphics
    {
        int cardWitdh = 11;
        int cardHeight = 7;

        public void DrawBoard( Player p, CardCollection cC, string o1, string o2, string o3, int state)
        {
            int height = Console.WindowHeight;
            int width = Console.WindowWidth;
            Console.Clear();
            string[] sa = new string[3];
            sa[0] = "  " + o1;
            sa[1] = "  " + o2;
            sa[2] = "  " + o3;
            string stateString = "";
            switch (state)
            {
                case 0:
                    stateString = "* " + o1 + " *";                    
                    break;
                case 1:
                    stateString = "* " + o2 + " *";
                    break;
                case 2:
                    stateString = "* " + o3 + " *";
                    break;
            }
            sa[state] = stateString;
            Console.WriteLine();
            
            int InitalHandWritingPoint = width / 2 - cardWitdh - 5;
            string handspaces = "";
            for(int i = 0; i < InitalHandWritingPoint + 5; i++)
            {
                handspaces += " ";
            }

            //Prepares spaces between name and money
            string namespaces = "";
            for(int i = width - p.name.Length - 10 ; i > 0; i--)
            {
                namespaces += " ";
            }

            //Prepaes spaces for cCs
            string cCSpaces = "";
            for(int i = 0; i < (width / 2) - (2 * cardWitdh) + 4; i++)
            {
                cCSpaces += " ";
            }
            Console.WriteLine();
            Console.WriteLine("   " + p.name + namespaces + p.money);
            
            // Writes gap between name + money and cCs
            for(int i = 0; i < (height / 2) - (cardHeight + 4); i++)
            {
                Console.WriteLine();
               
            }

            // Displays cCs
            switch (cC.Cards.Count)
            {
                case 3:
                    for (int i = 0; i < cardHeight; i++)
                    {
                        Console.WriteLine(
                        cCSpaces
                        + cC.Cards[0].lines[i]
                        + "  " + cC.Cards[1].lines[i]
                        + "  " + cC.Cards[2].lines[i]
                        );

                    }
                    break;
                case 4:
                    for (int i = 0; i < cardHeight; i++)
                    {
                        Console.WriteLine(
                        cCSpaces
                        + cC.Cards[0].lines[i]
                        + "  " + cC.Cards[1].lines[i]
                        + "  " + cC.Cards[2].lines[i]
                        + "  " + cC.Cards[3].lines[i]
                        );

                    }
                    break;
                case 5:
                    for (int i = 0; i < cardHeight; i++)
                    {
                        Console.WriteLine(
                        cCSpaces
                        + cC.Cards[0].lines[i]
                        + "  " + cC.Cards[1].lines[i]
                        + "  " + cC.Cards[2].lines[i]
                        + "  " + cC.Cards[3].lines[i]
                        + "  " + cC.Cards[4].lines[i]
                        );

                    }
                    break;
            }
           
            

            for(int i = 0; i < cardHeight / 2; i++)
            {
                Console.WriteLine();
            }

            for(int i = 0; i < cardHeight; i++)
            {
                if (i == 1) Console.WriteLine(handspaces + p.hand.Cards[0].lines[i] + "  " + p.hand.Cards[1].lines[i] + "    " + sa[0]);
                else if (i == 3) Console.WriteLine(handspaces + p.hand.Cards[0].lines[i] + "  " + p.hand.Cards[1].lines[i] + "    " + sa[1]);
                else if(i == 5) Console.WriteLine(handspaces + p.hand.Cards[0].lines[i] + "  " + p.hand.Cards[1].lines[i] + "    " + sa[2]);                                  
                else Console.WriteLine(handspaces + p.hand.Cards[0].lines[i] + "  " + p.hand.Cards[1].lines[i]);
            }
        }

        public int askForInput(Player p, CardCollection cC, string o1, string o2, string o3)
        {
            int state = 0;
            DrawBoard(p, cC, o1, o2, o3, state);

            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Enter:
                        return state;
                    case ConsoleKey.DownArrow:
                        if (state != 2)
                        {
                            state++;
                            DrawBoard(p, cC, o1, o2, o3, state);
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (state != 0)
                        {
                            state--;
                            DrawBoard(p, cC, o1, o2, o3, state);
                        }
                        break;
                }
                
                
            }
            
            
        }
        
        

    }
        

        

}