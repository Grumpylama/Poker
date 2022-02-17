using System;
using System.Collections.Generic;

namespace poker
{
    public class Game
    {
        CardCollection communityCards = new Hand();
        public Game()
        {
 
        }

        //Represents just one round, which basically is the whole game
        //Just repeat this
        public void GameRound(List<Player> players)
        {
            


        }

        //Who has the better hand 
        //Could potentially use helping functions for different hands
        public Player HandPoints(Player player)
        {
            List<Card> combo = new List<Card>();
            for(int i = 0; i < player.hand.cards.Count; i++)
            {
                combo.Add(player.hand.cards[i]);
            }
            for (int i = 0; i < player.hand.cards.Count; i++)
            {
                combo.Add(player.hand.cards[i]);
            }

            return player;
        }

        public void PlayerTurn(Player player)
        {
            //Raise
            //Call
            //Fold

            
        }
    }
}