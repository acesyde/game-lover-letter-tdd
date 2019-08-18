using System;

namespace GameLoveLetter.Cards
{
	public class PriestCard : ICard<PriestCardData>
	{
		public int Strength { get; set; }
		public PriestCardData Data { get; set; }

		public PriestCard()
		{
			Strength = 2;
		}

		public void Effect()
		{
			Data.CurrentPlayer.UpdateCardInformation(Data.DesignatedPlayer, Data.DesignatedPlayer.Cards[0].GetType());
		}
	}
}
