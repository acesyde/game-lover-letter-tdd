using System;

namespace GameLoveLetter.Cards
{
	public class PriestCard : ICard<PriestCardData>
	{
		public int Strength { get; set; } = 2;
		public PriestCardData Data { get; set; }

		public PriestCard()
		{}

		public void Effect()
		{
			Data.CurrentPlayer.UpdateCardInformation(Data.DesignatedPlayer, Data.DesignatedPlayer.Cards[0].GetType());
		}
	}
}
