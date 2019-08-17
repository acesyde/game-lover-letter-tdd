namespace GameLoveLetter.Cards
{
	public class KingCard : ICard<KingCardData>
	{
		public KingCardData Data { get; set; }
		public int Strength { get; set; }

		public KingCard()
		{
			Strength = 6;
		}

		public void Effect()
		{
			throw new System.NotImplementedException();
		}
	}
}
