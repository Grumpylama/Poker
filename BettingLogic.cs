using System;
using System.Collections.Generic;

namespace poker
{
	public class BettingLogic
	{

		//The total sum of money that is set on the table
		private int Pool { get; set; }

		//The amount people are willing to bet during said round
		private int betMoney = 0;
		int bigBlind = 10;

		public void setBlind(Player player)
        {
			player.money -= bigBlind;
			betMoney += bigBlind;
        }
		//Match the amount of bigBlind
		public void Call(Player player)
		{
			betMoney += bigBlind;
			player.money -= bigBlind;
			if(player.money < 0)
            {
				betMoney -= bigBlind;
				player.money += bigBlind;
            }
		}

		//Increase the bet within player money limits
		public void Raise(int amount, Player player)
        {
			int temp = bigBlind;
			//Set amount to how much more than the bigBlind you want to pay
			amount += bigBlind;
			//Increase the betMoney
			betMoney += amount;
			//Decrease the player money
			player.money -= amount;
			//Update bigBlind
			bigBlind = amount;
			//Not let player money go under 0
			if(player.money < 0)
            {
				player.money += amount;
				betMoney -= amount;
				bigBlind = temp;
            }
        }

		public void RoundEnd()
        {
			Pool += betMoney;
        }

		public void WinningPrize(List<Player> winners)
        {
			//This algorithm is unchecked and probably doesnt work
			int share;
			if (winners.Count == 1) share = Pool;
			else share = Pool / winners.Count;

			for(int i = 0; i < winners.Count; i++)
            {
				winners[i].money += share;
			}
        }
	}
}
