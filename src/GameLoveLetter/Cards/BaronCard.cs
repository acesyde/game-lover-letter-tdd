namespace GameLoveLetter.Cards
{
	public class BaronCard : ICard<BaronCardData>
	{
		public int Strength { get; set; } = 3;
		public BaronCardData Data { get; set; }

		public BaronCard()
		{}

		public void Effect()
		{
			if (Data.CurrentPlayer.Cards[0].Strength > Data.DesignatedPlayer.Cards[0].Strength)
			{
				Data.DesignatedPlayer.IsEliminated = true;
			}
			else if (Data.DesignatedPlayer.Cards[0].Strength > Data.CurrentPlayer.Cards[0].Strength)
			{
				Data.CurrentPlayer.IsEliminated = true;
			}
		}
	}
}
