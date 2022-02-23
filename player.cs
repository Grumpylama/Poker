using System;
using System.Collections.Generic;

namespace poker
{
    public class Player
    {
        public int money { get; set; }
        public Hand hand = new Hand();
        public string name { get; private set; }

        public Player(int money, string name)
        {
            this.money = money;
            this.name = name;         
        }

    }

    public class Hand : CardCollection
    {  
        public Hand()
        {
            
        } 
    }
}