namespace GameLoveLetter.Cards
{
	public interface ICard
	{
		/// <summary>
		/// Strength of the card
		/// </summary>
		int Strength { get; set; }

		/// <summary>
		/// Effect of the card when the card is played.
		/// </summary>
		void Effect();
	}

	public interface ICard<CardData> : ICard
	{
		CardData Data { get; set; }
	}
}