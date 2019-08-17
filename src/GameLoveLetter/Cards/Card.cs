namespace GameLoveLetter.Cards
{
	public abstract class Card<CardData> where CardData : class
	{
		public int Strength { get; set; }
		public CardData Data { get; set; }

		public Card(int strength)
		{
			Strength = strength;
		}
	}
}