namespace GameLoveLetter.Cards
{
	public class PrinceCard : ICard<PrinceCardData>
	{
		public int Strength { get; set; }
		public PrinceCardData Data { get; set; }

		public PrinceCard()
		{
			Strength = 5;
		}

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
