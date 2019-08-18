namespace GameLoveLetter.Cards
{
	public class PriestCardData
	{
		/// <summary>
		/// Current player who played the guard card
		/// </summary>
		public Player CurrentPlayer { get; set; }

		/// <summary>
		/// Player who has been designated by the current player
		/// </summary>
		public Player DesignatedPlayer { get; set; }

		public PriestCardData(Player currentPlayer, Player designatedPlayer)
		{
			this.CurrentPlayer = currentPlayer;
			this.DesignatedPlayer = designatedPlayer;
		}
	}
}