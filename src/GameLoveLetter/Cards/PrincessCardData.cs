namespace GameLoveLetter.Cards
{
	public class PrincessCardData : CardData
	{
		/// <summary>
		/// Current player who played the card
		/// </summary>
		public Player CurrentPlayer { get; set; }

		public PrincessCardData(Player currentPlayer)
		{
			this.CurrentPlayer = currentPlayer;
		}
	}
}