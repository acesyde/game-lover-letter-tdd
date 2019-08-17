namespace GameLoveLetter.Cards
{
	public class HandmaidCard : ICard<HandmaidCardData>
	{
		public HandmaidCardData Data { get; set; }
		public int Strength { get; set; }

		public HandmaidCard()
		{
			Strength = 4;
		}

		public void Effect()
		{
			throw new System.NotImplementedException();
		}
	}
}
