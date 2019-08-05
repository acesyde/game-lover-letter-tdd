using System;

namespace GameLoveLetter
{
	public class BadNumberOfPlayersException : Exception
	{
		public BadNumberOfPlayersException()
			: base("A game should contains between 2 and 4 players.")
		{
		}
	}
}