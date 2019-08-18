namespace GameLoveLetter.Cards
{
	public class CountessCard : ICard<CountessCardData>
	{
		public int Strength { get; set; }
		public CountessCardData Data { get; set; }

		public CountessCard() 
		{
			Strength = 7;
		}

		public void Effect()
		{
		}
	}
}
