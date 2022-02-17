using System;

namespace poker
{
	public class BettingLogic
	{
		Player player;

		//The total sum of money that is set on the table
		private int Pool { get; set; }

		//The amount people are willing to bet during said round
		private int betMoney = 0;
		int bigBlind;

		public BettingLogic(Player Player, int SmallBlind)
		{
			player = Player;
			bigBlind = SmallBlind;

		}

		//Match the amount of bigBlind
		public void Call()
		{
			betMoney += bigBlind;
		}

		//Increase the bet within player money limits
		public void Raise(int amount)
        {
			//Set amount to how much more than the bigBlind you want to pay
			amount += bigBlind;
			//Increase the betMoney
			betMoney += amount;
			//Decrease the player money
			player.money -= amount;
        }

		//Throw the hand away, skip the round
		//Rendered not able to play for rest of the round.
		public void Fold()
        {

        }

		public void RoundEnd()
        {
			Pool += betMoney;
        }

		public void Win(int winners)
        {
			//This algorithm is unchecked and probably doesnt work
			int share = Pool / winners;
			player.money += share;
        }
	}
}
