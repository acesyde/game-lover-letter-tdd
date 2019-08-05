using System;

namespace GameLoveLetter
{
	public class BadNumberOfPlayersException : Exception
	{
		public BadNumberOfPlayersException()
			: base("A game should contain between 2 and 4 players.")
		{
		}
	}
}