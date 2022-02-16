using System;
using System.Collections.Generic;

namespace poker
{

    public class Deck
    {
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

        public List<Card> Cards;


    }
    public class Card 
    {
        public Card(int number)
        {
            this.number = number;
        }
        int number;

        public void Draw()
        {

        }
    }

    public class HCard : Card 
    {
        public HCard(int value) : base(value) { }
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



