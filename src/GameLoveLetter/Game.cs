using System;
using System.Collections.Generic;
using System.Text;

namespace GameLoveLetter
{
	public class Game
	{
		public List<Player> Players { get; private set; }

		public CardDeck CardDesk { get; private set; }

		public Game(int nbPlayer)
		{
			if (nbPlayer < 2 || nbPlayer > 4)
			{
				throw new BadNumberOfPlayersException();
			}

			CardDesk = new CardDeck();

			Players = new List<Player>();
			for (int i = 0; i < nbPlayer; i++)
			{
				Players.Add(new Player());
			}
		}

		public void Initialization()
		{
			CardDesk.DiscardCard();

			foreach(var player in Players)
			{
				player.DrawACard(CardDesk.DrawACard());
			}
		}
	}
}
