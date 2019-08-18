namespace GameLoveLetter.Cards
{
	public class PrinceCard : ICard<PrinceCardData>
	{
		public int Strength { get; set; } = 5;
		public PrinceCardData Data { get; set; }

		public PrinceCard()
		{}

		public void Effect()
		{
			if (Data.DesignatedPlayer.Cards[0].GetType() == typeof(PrincessCard))
			{
				Data.DesignatedPlayer.IsEliminated = true;
			}

			Data.DesignatedPlayer.DiscardCard();
			Data.DesignatedPlayer.DrawACard();
		}
	}
}
