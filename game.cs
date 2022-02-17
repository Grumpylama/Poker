using System;
using System.Collections.Generic;

namespace poker
{
    public class Game
    {
        int moneyPool;

        //Represents just one round, which basically is the whole game
        //Just repeat this
        public void GameRound(List<Player> players)
        {
            


        }

        //Who has the better hand 
        //Could potentially use helping functions for different hands
        public Player BetterHand(List<Player> players)
        {


            return players[0];
        }

        public void PlayerTurn(Player player)
        {
            //Raise
            //Call
            //Fold
        }
    }
}