namespace GameLoveLetter.Cards
{
	public class BaronCard : ICard<BaronCardData>
	{
		public int Strength { get; set; }
		public BaronCardData Data { get; set; }

		public BaronCard()
		{
			Strength = 3;
		}

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
