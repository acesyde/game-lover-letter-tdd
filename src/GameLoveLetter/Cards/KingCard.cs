namespace GameLoveLetter.Cards
{
	public class KingCard : ICard<KingCardData>
	{
		public int Strength { get; set; }
		public KingCardData Data { get; set; }

		public KingCard()
		{
			Strength = 6;
		}

		public void Effect()
		{
			ICard currentPlayerCard = Data.CurrentPlayer.Cards[0];
			Data.CurrentPlayer.Cards[0] = Data.DesignatedPlayer.Cards[0];
			Data.DesignatedPlayer.Cards[0] = currentPlayerCard;
		}
	}
}
