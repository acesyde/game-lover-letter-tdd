using System;

namespace GameLoveLetter.Cards
{
	public class GuardCardData : CardData
	{
		/// <summary>
		/// Current player who played the guard card
		/// </summary>
		public Player CurrentPlayer { get; set; }

		/// <summary>
		/// Player who has been designated by the current player
		/// </summary>
		public Player DesignatedPlayer { get; set; }

		/// <summary>
		/// Type of card choose by the current player
		/// </summary>
		public Type CardType { get; set; }

		public GuardCardData (Player currentPlayer, Player designatedPlayer, Type cardType)
		{
			CurrentPlayer = currentPlayer;
			DesignatedPlayer = designatedPlayer;
			CardType = cardType;
		}
	}
}