namespace GameLoveLetter.Cards
{
	public class KingCardData : CardData
	{
		/// <summary>
		/// Current player who played the card
		/// </summary>
		public Player CurrentPlayer { get; set; }

		/// <summary>
		/// Player named by the current player
		/// </summary>
		public Player DesignatedPlayer { get; set; }

		public KingCardData(Player currentPlayer, Player designatedPlayer)
		{
			this.CurrentPlayer = currentPlayer;
			this.DesignatedPlayer = designatedPlayer;
		}
	}
}