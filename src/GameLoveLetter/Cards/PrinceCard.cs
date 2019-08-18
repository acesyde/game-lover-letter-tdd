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
			throw new System.NotImplementedException();
		}
	}
}
