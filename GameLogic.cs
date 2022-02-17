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
<<<<<<< HEAD
                communityCards.AddCard(deck.DrawCard());
=======
                //communityCards.Add(deck.DrawCard());
>>>>>>> 15759e14ad4cb21cd658edc4fb8502647ba0a444
            }

            return communityCards;
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
            for (int i = 0; i < communityCards.Cards.Count; i++)
            {
                combo.Add(communityCards.Cards[i]);
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