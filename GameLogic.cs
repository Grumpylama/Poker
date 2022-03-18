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
        Graphics graphics = new Graphics();
        //deck.ResetDeck();

        public GameLogic(List<Player> players, Deck Deck)
        {
            playerList = players;
            deckCards = Deck;
        }

        public void StartGame()
        {
            bool t = true;
            communityCards.DrawNewCard(deckCards);
            communityCards.DrawNewCard(deckCards);
            communityCards.DrawNewCard(deckCards);

            while (t)
            {
                GameRound();
                if (playerList.Count <= 1)
                {
                    t = false;
                }
                communityCards.DrawNewCard(deckCards);
                //Next Community card
                
                GameRound();
                if (playerList.Count <= 1)
                {
                    t = false;
                }
                //Last Community card
                communityCards.DrawNewCard(deckCards);
                GameRound();
                if (playerList.Count <= 1)
                {
                    t = false;
                }
            }
            //Announces winners and gives money
            Winners();
            ResetGame();
        }

        //Represents one full betting round 
        //Just repeat this until all
        //Community Cards are on the table
        //and then go for end screen
        public void GameRound()
        {
            b.setBlind(playerList[0]);
            for(int i = 0; i < playerList.Count; i++)
            {
                InstantiateHand(playerList[i]);
            }

            //Betting round
            int temp = playerList[0].money;
            int called = 1;
            int temp1 = playerList[0].money;
            while(called != 0)
            {
                int count = 0;
                for(int i = 0; i < playerList.Count; i++)
                {
                    //Everyone folds
                    if (playerList.Count <= 1)
                    {
                        break;
                    }
                    //Everybody calls big blind
                    if (temp != 0)
                    {
                        //Takes value of temp1
                        temp = temp1;
                        //Takes value of next players money
                        if(i > 0) temp1 = playerList[i - 1].money;
                    }
                    else if (temp == 0) count++;
                    else if (playerList[i].money <= 0) playerList.RemoveAt(i);

                    temp -= playerList[i].money;
                    PlayerTurn(playerList[i]);
                }

                if (playerList.Count <= 1) break;
                //everyone calls
                if (count == playerList.Count - 1) called = 0;
            }

            b.RoundEnd();

        }

        //Print pool value 
        public void PlayerTurn(Player player)
        {
            int action = graphics.askForInput(player, communityCards, "Raise", "Call", "Fold");

            switch(action)
            {
                case 0:
                    int temp = 0;
                    while (true)
                    {
                        try
                        {
                            temp = Int32.Parse(Console.ReadLine());
                        }
                        catch { }
                        break;
                    }
                    
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

        public void CommunityC()
        {
            for(int i = 0; i < 5; i++)
            {
                communityCards.addCard(deckCards.DrawCard());

            }

           
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

            //If the rest fold then the one left is winner
            if (playerList.Count <= 1)
            {
                list.Add(playerList[0]);
                Console.WriteLine("Congratulaions " + playerList[0].name + ", for being the winner of this round!");
                b.WinningPrize(list);
                return list;
            }

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
            
            HoldemHand.Hand hand = new HoldemHand.Hand(player.hand.getValues(), communityCards.getValues());

            return hand;
        }

        //Resets all cards
        public void ResetGame()
        {
            //Reset deck
            deckCards.ResetDeck();
            //Reset hands
            foreach(Player player in playerList)
            {
                for(int i = 0; i < 2; i++) player.hand.Cards.RemoveAt(i);
            }
        }
        
    }
}