namespace GameLoveLetter.Cards
{
	public class HandmaidCard : ICard<HandmaidCardData>
	{
		public int Strength { get; set; } = 4;
		public HandmaidCardData Data { get; set; }

		public HandmaidCard()
		{}

		public void Effect()
		{
			Data.CurrentPlayer.IsProtected = true;
		}
	}
}
