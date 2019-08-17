namespace GameLoveLetter.Cards
{
	public class PrincessCard : ICard<PrincessCardData>
	{
		public PrincessCardData Data { get; set; }
		public int Strength { get; set; }

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
