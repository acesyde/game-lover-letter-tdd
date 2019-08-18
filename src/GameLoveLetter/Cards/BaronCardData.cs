namespace GameLoveLetter.Cards
{
	public class BaronCardData : CardData
	{
		/// <summary>
		/// Current player who played the guard card
		/// </summary>
		public Player CurrentPlayer { get; set; }

		/// <summary>
		/// Player who has been designated by the current player
		/// </summary>
		public Player DesignatedPlayer { get; set; }

		public BaronCardData(Player currentPlayer, Player designatedPlayer)
		{
			CurrentPlayer = currentPlayer;
			DesignatedPlayer = designatedPlayer;
		}
	}
}