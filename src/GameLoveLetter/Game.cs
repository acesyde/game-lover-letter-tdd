using System;
using System.Collections.Generic;
using System.Text;

namespace GameLoveLetter
{
	public class Game
	{
		public Game(int nbPlayer)
		{
			if (nbPlayer < 2 || nbPlayer > 4)
			{
				throw new BadNumberOfPlayersException();
			}
		}
	}
}
