using System;
using System.Collections.Generic;
using HoldemHand;



namespace poker
{
    public class GameLogic
    {
        BettingLogic b = new BettingLogic();
        CardCollection communityCards = new CardCollection();
        Deck deckCards = new Deck();
        List<Player> playerList = new List<Player>();
        //deck.ResetDeck();

        public GameLogic(List<Player> players, Deck Deck)
        {
            playerList = players;
            deckCards = Deck;
        }

        public void StartGame()
        {
            GameRound();
            //Next Community card
            GameRound();
            //Last Community card
            GameRound();
            //Announces winners of the round
            Winners();
        }

        //Represents one full betting round 
        //Just repeat this until all
        //Community Cards are on the table
        //and then go for end screen
        public void GameRound()
        {
            for(int i = 0; i < playerList.Count; i++)
            {
                InstantiateHand(playerList[i]);
            }

            //Betting round
            int temp = playerList[0].money;
            int called = 1;
            int allFold = 0;
            int temp1 = playerList[1].money;
            while(called != 0)
            {
                int count = 0;
                for(int i = 0; i < playerList.Count; i++)
                {
                    PlayerTurn(playerList[i]);
                    temp -= playerList[i].money;

                    //Everyone folds
                    if (playerList.Count == 0)
                    {
                        allFold++;
                        break;
                    }

                    if(temp != 0)
                    {
                        temp = temp1;
                        temp1 = playerList[i + 1].money;
                    }
                    else if(temp == 0) count++;
                }

                if (allFold != 0) break;
                //everyone calls
                if (count == playerList.Count - 1) called = 0;
            }

            b.RoundEnd();

        }

        public void PlayerTurn(Player player)
        {
            Graphics graphics = new Graphics();
            int action = graphics.askForInput(player, communityCards, "Raise", "Call", "Fold");

            switch(action)
            {
                case 0:
                    int temp = Int32.Parse(Console.ReadLine());
                    b.Raise(temp, player);
                    break;
                case 1:
                    b.Call(player);
                    break;
                case 2:
                    playerList.Remove(player);
                    break;
            }


        }

        public CardCollection CommunityC()
        {
            for(int i = 0; i < 5; i++)
            {
                communityCards.addCard(deckCards.DrawCard());

            }

            return communityCards;
        }

        public void InstantiateHand(Player player)
        {
            for (int i = 0; i < 2; i++)
            {
                player.hand.addCard(deckCards.DrawCard());
            }
        }

        //Decides who won the round (is decided immediately after the deck is instantiated and cards dealt to players)
        public List<Player> Winners()
        {
            List<Player> list = new List<Player>();
            HoldemHand.Hand h = HandPoints(playerList[0]);

            //Checks how many points the best hand has
            for (int i = 1; i < playerList.Count; i++)
            {
                if (HandPoints(playerList[i]) > h)
                {
                    h = HandPoints(playerList[i]);
                }
            }
            //Lists the players whomst hand matches
            //the points of the highest hand
            for (int i = 0; i < playerList.Count; i++)
            {
                if(HandPoints(playerList[i]) == h)
                {
                    list.Add(playerList[i]);
                }
            }

            Console.Write("Congratulations ");
            for(int i = 0;i < playerList.Count; i++)
            {
                Console.Write(list[i].name + ", ");
            }
            Console.Write("for being the winners of this round!");

            b.WinningPrize(list);
            return list;
        }

        //Who has the better hand 
        //Is used in Winners()
        //Combines Ccards and each players hand to give overall handScore
        private HoldemHand.Hand HandPoints(Player player)
        {
            CardCollection c = CommunityC();
            HoldemHand.Hand hand = new HoldemHand.Hand(player.hand.getValues(), c.getValues());

            return hand;
        }

        //Takes a deck and shuffles it
        //Returns a shuffled copy of the deck
        
    }
}