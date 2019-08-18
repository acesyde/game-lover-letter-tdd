using System;
using System.Collections.Generic;
using System.Text;

namespace GameLoveLetter
{
	public class Game
	{
		public List<Player> Players { get; private set; }

		public CardDeck CardDeck { get; private set; }

		public Game(int nbPlayer)
		{
			if (nbPlayer < 2 || nbPlayer > 4)
			{
				throw new BadNumberOfPlayersException();
			}

			CardDeck = new CardDeck();

			Players = new List<Player>();
			for (int i = 0; i < nbPlayer; i++)
			{
				Players.Add(new Player());
			}
		}

		public void Initialization()
		{
			CardDeck.DiscardCard();

			foreach(var player in Players)
			{
				player.Initialization(Players);
				player.DrawACard(CardDeck.DrawACard());
			}
		}
	}
}
