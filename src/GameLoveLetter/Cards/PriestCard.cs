namespace GameLoveLetter.Cards
{
	public class PriestCard : ICard<PriestCardData>
	{
		public PriestCardData Data { get; set; }
		public int Strength { get; set; }

		public PriestCard()
		{
			Strength = 2;
		}

		public void Effect()
		{
			throw new System.NotImplementedException();
		}
	}
}
