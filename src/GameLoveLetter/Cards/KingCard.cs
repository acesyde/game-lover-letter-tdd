namespace GameLoveLetter.Cards
{
	public class KingCard : ICard<KingCardData>
	{
		public int Strength { get; set; } = 6;
		public KingCardData Data { get; set; }

		public KingCard()
		{}

		public void Effect()
		{
			ICard currentPlayerCard = Data.CurrentPlayer.Cards[0];
			Data.CurrentPlayer.Cards[0] = Data.DesignatedPlayer.Cards[0];
			Data.DesignatedPlayer.Cards[0] = currentPlayerCard;
		}
	}
}
