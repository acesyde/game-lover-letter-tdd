using System;
using System.Collections.Generic;
using System.Text;

namespace GameLoveLetter
{
	public class Game
	{
		public List<Player> Players { get; set; }
		public List<Card> Cards { get; set; }

		public Game(int nbPlayer)
		{
			if (nbPlayer < 2 || nbPlayer > 4)
			{
				throw new BadNumberOfPlayersException();
			}

			Cards = new List<Card>()
			{
				new Guard(), new Guard(), new Guard(), new Guard(), new Guard(),
				new Priest(), new Priest(),
				new Baron(), new Baron(),
				new Handmaid(), new Handmaid(),
				new Prince(), new Prince(),
				new King(),
				new Countess(),
				new Princess(),
			};

			Players = new List<Player>();
			for (int i = 0; i < nbPlayer; i++)
			{
				Players.Add(new Player());
			}
		}

		public void Initialization()
		{
			Cards.RemoveAt(0);

			foreach(var player in Players)
			{
				Cards.RemoveAt(0);
			}
		}
	}
}
