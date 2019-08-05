using System;

namespace GameLoveLetter
{
	public class PriestCard : Card
	{
		public PriestCard() 
			: base(2)
		{
		}

		public Type Effect(Card card)
		{
			return card.GetType();
		}
	}
}
