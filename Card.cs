using System;
using System.Collections.Generic;

namespace poker
{
    public class CardCollection 
    {
        public List<Card> Cards = new List<Card>();
        public void addCard(Card card) 
        {
            Cards.Add(card);
        }

        public string getValues()
        {
            string s = "";
            foreach (Card c in Cards)
            {
                s = s + c.compareValue + " ";
            }
            return s.Trim(' ');
        }


    }

    public class Deck : CardCollection
    {

        public Deck()
        {
            
        }
        public void ResetDeck()
        {
            ResetDeck(1);
        }
        public void ResetDeck(int amount)
        {

            Cards.Clear();
            for(int y = 1; y <= amount; y++)
            {
                for (int i = 2; i <= 14; i++)
                {
                    Cards.Add(new HCard(i));
                }
                for (int i = 2; i <= 14; i++)
                {
                    Cards.Add(new CCard(i));
                }
                for (int i = 2; i <= 14; i++)
                {
                    Cards.Add(new SCard(i));
                }
                for (int i = 2; i <= 14; i++)
                {
                    Cards.Add(new DCard(i));
                }
            }
        }

       
        //Vi kanske kan göra så att den tar en card som parameter
        // och sen ritar upp det kortet?
        public Card DrawCard()
        {
            Random random = new Random();
            int i = random.Next(Cards.Count - 1);
            Card pickedCard = Cards[i];
            Cards.RemoveAt(i);
            return pickedCard;

        }
        
    }
    public class Card
    {
        public Card(int value)
        {
            this.value = value;  
        }

        public string compareValue;
        public int value;
        public int displaynumber;
        public List<String> lines = new List<string>();
        protected string GetUpperValueRow()
        {
            switch (value)
            {
                case < 10:
                    return String.Format("│ {0}       │", value);
                case 10:
                    return "│ 10      │";
                case 11:
                    return "│ Kn      │";
                case 12:
                    return "│ Q       │";
                case 13:
                    return "│ Ki      │";
                case 14:
                    return "│ A       │";
            }
            throw new Exception("Invalid Card creation");
        }
        protected string GetLowerValueRow()
        {
            switch (value)
            {
                case < 10:
                    return String.Format("│       {0} │", value);
                case 10:
                    return "│      10 │";
                case 11:
                    return "│      Kn │";
                case 12:
                    return "│       Q │";
                case 13:
                    return "│      Ki │";
                case 14:
                    return "│       A │";
            }
            throw new Exception("Invalid Card creation");
        }

    }

    public class HCard : Card 
    {
        
        public HCard(int value) : base(value) 
        {
            
            switch (value)
            {
                case < 11:
                    compareValue = String.Format("{0}h", value);
                    break;
                case 11:
                    compareValue = "jh";                   
                    break;
                case 12:
                    compareValue = "qh";
                    break;
                case 13:
                    compareValue = "kh";
                    break;
                case 14:
                    compareValue = "ah";
                    break;
            }

            lines.Add("┌─────────┐");
            lines.Add(GetUpperValueRow());
            lines.Add("│         │");
            lines.Add("│    ♥    │");
            lines.Add("│         │");
            lines.Add(GetLowerValueRow());
            lines.Add("└─────────┘");

        }
    }

    public class CCard : Card
    {
        
        public CCard(int value) : base(value) 
        {

            switch (value)
            {
                case < 11:
                    compareValue = String.Format("{0}c", value);
                    break;
                case 11:
                    compareValue = "jc";
                    break;
                case 12:
                    compareValue = "qc";
                    break;
                case 13:
                    compareValue = "kc";
                    break;
                case 14:
                    compareValue = "ac";
                    break;
            }

            lines.Add("┌─────────┐");
            lines.Add(GetUpperValueRow());
            lines.Add("│         │");
            lines.Add("│    ♣    │");
            lines.Add("│         │");
            lines.Add(GetLowerValueRow());
            lines.Add("└─────────┘");
        }
    }

    public class SCard : Card
    {
        
        public SCard(int value) : base(value) 
        {
            switch (value)
            {
                case < 11:
                    compareValue = String.Format("{0}s", value);
                    break;
                case 11:
                    compareValue = "js";
                    break;
                case 12:
                    compareValue = "qs";
                    break;
                case 13:
                    compareValue = "ks";
                    break;
                case 14:
                    compareValue = "as";
                    break;
            }

            lines.Add("┌─────────┐");
            lines.Add(GetUpperValueRow());
            lines.Add("│         │");
            lines.Add("│    ♠    │");
            lines.Add("│         │");
            lines.Add(GetLowerValueRow());
            lines.Add("└─────────┘");
        }
    }
    
    public class DCard : Card
    {
        
        public DCard(int value) : base(value) 
        {
            switch (value)
            {
                case < 11:
                    compareValue = String.Format("{0}d", value);
                    break;
                case 11:
                    compareValue = "jd";
                    break;
                case 12:
                    compareValue = "qd";
                    break;
                case 13:
                    compareValue = "kd";
                    break;
                case 14:
                    compareValue = "ad";
                    break;
            }

            lines.Add("┌─────────┐");
            lines.Add(GetUpperValueRow());
            lines.Add("│         │");
            lines.Add("│    ♦    │");
            lines.Add("│         │");
            lines.Add(GetLowerValueRow());
            lines.Add("└─────────┘");
        }
    }
}



