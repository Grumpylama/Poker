using System;
using System.Collections.Generic;
using HoldemHand;



namespace poker
{
    public class Game
    {
        CardCollection communityCards = new CardCollection();
        Deck deck = new Deck();

        public CardCollection CommunityC()
        {
            for(int i = 0; i < 5; i++)
            {
                communityCards.addCard(deck.DrawCard());

            }

            return communityCards;
        }

        //Represents just one round, which basically is the whole game
        //Just repeat this
        public void GameRound(List<Player> players)
        {
            //Cards are dealt
            //3 community cards on table
            //Start at random player (raise, call, fold)
            //Repeat until all people who havent folded have called the big blind
            //

        }

        //Decides who won the round (is decided immediately after the deck is instantiated and cards dealt to players)
        public List<Player> Winners(List<Player> players)
        {
            List<Player> list = new List<Player>();
            HoldemHand.Hand h = HandPoints(players[0]);

            for (int i = 1; i < players.Count; i++)
            {
                if (HandPoints(players[i]) > h)
                {
                    h = HandPoints(players[i]);
                }
            }

            for (int i = 0; i < players.Count; i++)
            {
                if(HandPoints(players[i]) == h)
                {
                    list.Add(players[i]);
                }
            }

            return players;
        }

        //Who has the better hand 
        //Could potentially use helping functions for different hands
        public HoldemHand.Hand HandPoints(Player player)
        {
            CardCollection c = CommunityC();
            HoldemHand.Hand hand = new HoldemHand.Hand(player.hand.getValues(), c.getValues());

            return hand;
        }

        public void PlayerTurn(Player player)
        {
            //Raise
            //Call
            //Fold

            
        }
    }
}