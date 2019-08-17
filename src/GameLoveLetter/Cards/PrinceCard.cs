namespace GameLoveLetter.Cards
{
	public class PrinceCard : ICard<PrinceCardData>
	{
		public PrinceCardData Data { get; set; }
		public int Strength { get; set; }

		public PrinceCard()
		{
			Strength = 5;
		}

		public void Effect()
		{
			throw new System.NotImplementedException();
		}
	}
}
