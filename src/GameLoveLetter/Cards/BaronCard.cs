using System;

namespace GameLoveLetter
{
	public class BaronCard : Card
	{
		public BaronCard() 
			: base(3)
		{
		}

		public int Effect(Card card1, Card card2)
		{
			if (card1.Strength > card2.Strength)
			{
				return 1;
			} 
			else if (card1.Strength < card2.Strength)
			{
				return -1;
			}
			else
			{
				return 0;
			}
		}
	}
}
