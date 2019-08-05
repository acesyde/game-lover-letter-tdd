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
				new GuardCard(), new GuardCard(), new GuardCard(), new GuardCard(), new GuardCard(),
				new PriestCard(), new PriestCard(),
				new BaronCard(), new BaronCard(),
				new HandmaidCard(), new HandmaidCard(),
				new PrinceCard(), new PrinceCard(),
				new KingCard(),
				new CountessCard(),
				new PrincessCard(),
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
