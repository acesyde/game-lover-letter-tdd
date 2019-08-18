namespace GameLoveLetter.Cards
{
	public class PriestCardData : CardData
	{
		/// <summary>
		/// Current player who played the card
		/// </summary>
		public Player CurrentPlayer { get; set; }

		/// <summary>
		/// Player named by the current player
		/// </summary>
		public Player DesignatedPlayer { get; set; }

		public PriestCardData(Player currentPlayer, Player designatedPlayer)
		{
			this.CurrentPlayer = currentPlayer;
			this.DesignatedPlayer = designatedPlayer;
		}
	}
}