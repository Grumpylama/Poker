using System;
using System.Collections.Generic;

namespace poker
{

    public class Deck
    {
        public List<Card> Cards;
        public void ResetDeck(int amount)
        {

            Cards.Clear();
            for(int y = 1; y <= amount; y++)
            {
                for (int i = 1; i <= 13; i++)
                {
                    Cards.Add(new HCard(i));
                }
                for (int i = 1; i <= 13; i++)
                {
                    Cards.Add(new CCard(i));
                }
                for (int i = 1; i <= 13; i++)
                {
                    Cards.Add(new SCard(i));
                }
                for (int i = 1; i <= 13; i++)
                {
                    Cards.Add(new DCard(i));
                }
            }

        }

       

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
            if (value < 10)
            {
                this.displaynumber = value + 1;
            }

        }
        
        public int value;
        public int displaynumber;
        public List<String> lines;
        
    }

    public class HCard : Card 
    {
        public HCard(int value) : base(value,) 
        {
            

        }
    }

    public class CCard : Card
    {
        public CCard(int value) : base(value) { }
    }

    public class SCard : Card
    {
        public SCard(int value) : base(value) { }
    }
    
    public class DCard : Card
    {
        public DCard(int value) : base(value) { }
    }
}



