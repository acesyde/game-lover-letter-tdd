namespace GameLoveLetter.Cards
{
	public class HandmaidCardData : CardData
	{
		/// <summary>
		/// Current player who played the card
		/// </summary>
		public Player CurrentPlayer { get; set; }

		public HandmaidCardData(Player currentPlayer)
		{
			CurrentPlayer = currentPlayer;
		}
	}
}