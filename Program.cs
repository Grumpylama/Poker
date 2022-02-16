using System;
using System.Collections.Generic;

namespace poker
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("♠, ♦, ♥, ♣");
            List<string> lines = new List<string>();
            lines.Add("┌─────────┐");
            lines.Add("│3░░░░░░░░│");
            lines.Add("│░░░░░░░░░│");
            lines.Add("│░░░░♠░░░░│");
            lines.Add("│░░░░░░░░░│");
            lines.Add("│░░░░░░░░3│");
            lines.Add("└─────────┘");

            List<string> line = new List<string>();
            line.Add("┌─────────┐");
            line.Add("│3        │");
            line.Add("│         │");
            line.Add("│         │");
            line.Add("│         │");
            line.Add("│        3│");
            line.Add("└─────────┘");
            foreach (string lin in lines)
            {
                Console.WriteLine(lin);
            }
            Console.WriteLine();
            foreach (string liness in line)
            {
                Console.WriteLine(liness);
            }
        }
    }
}
