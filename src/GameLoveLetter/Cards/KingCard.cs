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
			throw new System.NotImplementedException();
		}
	}
}
