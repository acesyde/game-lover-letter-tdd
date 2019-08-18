namespace GameLoveLetter.Cards
{
	public class HandmaidCard : ICard<HandmaidCardData>
	{
		public int Strength { get; set; }
		public HandmaidCardData Data { get; set; }

		public HandmaidCard()
		{
			Strength = 4;
		}

		public void Effect()
		{
			Data.CurrentPlayer.IsProtected = true;
		}
	}
}
