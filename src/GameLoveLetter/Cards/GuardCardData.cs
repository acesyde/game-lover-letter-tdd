using System;

namespace GameLoveLetter.Cards
{
	public class GuardCardData : CardData
	{
		/// <summary>
		/// Current player who played the card
		/// </summary>
		public Player CurrentPlayer { get; set; }

		/// <summary>
		/// Player named by the current player
		/// </summary>
		public Player DesignatedPlayer { get; set; }

		/// <summary>
		/// Type of card choose by the current player
		/// </summary>
		public Type CardType { get; set; }

		public GuardCardData (Player currentPlayer, Player designatedPlayer, Type cardType)
		{
			this.CurrentPlayer = currentPlayer;
			this.DesignatedPlayer = designatedPlayer;
			this.CardType = cardType;
		}
	}
}