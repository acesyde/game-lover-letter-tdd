namespace GameLoveLetter.Cards
{
	public class BaronCardData : CardData
	{
		/// <summary>
		/// Current player who played the card
		/// </summary>
		public Player CurrentPlayer { get; set; }

		/// <summary>
		/// Player named by the current player
		/// </summary>
		public Player DesignatedPlayer { get; set; }

		public BaronCardData(Player currentPlayer, Player designatedPlayer)
		{
			CurrentPlayer = currentPlayer;
			DesignatedPlayer = designatedPlayer;
		}
	}
}