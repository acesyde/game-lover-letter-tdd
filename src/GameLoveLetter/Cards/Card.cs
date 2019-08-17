namespace GameLoveLetter.Cards
{
	public interface ICard
	{
		int Strength { get; set; }
		void Effect();
	}

	public interface ICard<CardData> : ICard
	{
		CardData Data { get; set; }
	}
}