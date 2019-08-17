namespace GameLoveLetter.Cards
{
	public class CountessCard : ICard<CountessCardData>
	{
		public CountessCardData Data { get; set; }
		public int Strength { get; set; }

		public CountessCard() 
		{
			Strength = 7;
		}

		public void Effect()
		{
			throw new System.NotImplementedException();
		}
	}
}
