namespace GameLoveLetter.Cards
{
	public class GuardCard : ICard<GuardCardData>
	{
		public GuardCardData Data { get; set; }
		public int Strength { get; set; }

		public GuardCard()
		{
			Strength = 1;
		}

		public void Effect()
		{
			throw new System.NotImplementedException();
		}
	}
}
