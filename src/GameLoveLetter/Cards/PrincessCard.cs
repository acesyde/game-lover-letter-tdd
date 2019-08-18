namespace GameLoveLetter.Cards
{
	public class PrincessCard : ICard<PrincessCardData>
	{
		public int Strength { get; set; } = 8;
		public PrincessCardData Data { get; set; }

		public PrincessCard()
		{}

		public void Effect()
		{
			Data.CurrentPlayer.IsEliminated = true;
		}
	}
}
