namespace GameLoveLetter.Cards
{
	public class BaronCard : ICard<BaronCardData>
	{
		public int Strength { get; set; }
		public BaronCardData Data { get; set; }

		public BaronCard()
		{
			Strength = 3;
		}

		public void Effect()
		{
			throw new System.NotImplementedException();
		}
	}
}
