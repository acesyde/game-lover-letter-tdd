namespace GameLoveLetter.Cards
{
	public class PrincessCard : ICard<PrincessCardData>
	{
		public int Strength { get; set; }
		public PrincessCardData Data { get; set; }

		public PrincessCard()
		{
			Strength = 8;
		}

		public void Effect()
		{
			throw new System.NotImplementedException();
		}
	}
}
