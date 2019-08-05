namespace GameLoveLetter
{
	public class Card
	{
		public int Strength { get; private set; }

		public Card(int strength)
		{
			this.Strength = strength;
		}
	}
}