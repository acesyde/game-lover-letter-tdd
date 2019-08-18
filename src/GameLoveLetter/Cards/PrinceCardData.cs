namespace GameLoveLetter.Cards
{
	public class PrinceCardData : CardData
	{
		/// <summary>
		/// Player named by the current player
		/// </summary>
		public Player DesignatedPlayer { get; set; }

		public PrinceCardData(Player currentPlayer)
		{
			this.DesignatedPlayer = currentPlayer;
		}
	}
}