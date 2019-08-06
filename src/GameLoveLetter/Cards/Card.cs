namespace GameLoveLetter
{
	public abstract class Card
	{
		public int Strength { get; private set; }

		public Card(int strength)
		{
			this.Strength = strength;
		}
	}
}