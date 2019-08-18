using System;

namespace GameLoveLetter.Cards
{
	public class GuardCard : ICard<GuardCardData>
	{
		public int Strength { get; set; } = 1;
		public GuardCardData Data { get; set; }

		public GuardCard()
		{}

		public void Effect()
		{
			if (Data.CardType == typeof(GuardCard))
			{
				throw new GuardCardCannotAcceptGuardCardException();
			}

			bool playerHasDesignedCard = Data.DesignatedPlayer.HasCard(Data.CardType);
			if (playerHasDesignedCard)
			{
				Data.DesignatedPlayer.IsEliminated = true;
			}
		}
	}
}
