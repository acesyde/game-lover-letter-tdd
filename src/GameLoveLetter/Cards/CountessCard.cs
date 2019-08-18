namespace GameLoveLetter.Cards
{
	public class CountessCard : ICard<CountessCardData>
	{
		public int Strength { get; set; } = 7;
		public CountessCardData Data { get; set; }

		public CountessCard() 
		{}

		public void Effect()
		{
		}
	}
}
