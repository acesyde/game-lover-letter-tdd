using GameLoveLetter.Cards;
using System;
using System.Collections.Generic;

namespace GameLoveLetter
{
	public class Player
	{
		public List<ICard> Cards { get; set; } 
		public Dictionary<Player, Type> CardInformations { get; set; }
		public bool IsEliminated { get; set; }

		public Player()
		{
			Cards = new List<ICard>();
			IsEliminated = false;
		}

		public void Initialization(List<Player> players)
		{
			CardInformations = new Dictionary<Player, Type>();

			foreach (var player in players)
			{
				CardInformations.Add(player, null);
			}
		}

		public void DrawACard(ICard cardDrawn)
		{
			Cards.Add(cardDrawn);
		}

		public void UpdateCardInformation(Player designatedPlayer, Type cardType)
		{
			if (!CardInformations.ContainsKey(designatedPlayer))
			{
				throw new UnknownPlayerException();
			}

			CardInformations[designatedPlayer] = cardType;
		}

		public bool HasCard(Type cardType)
		{
			if (Cards.Count <= 0)
			{
				throw new Exception("Player hasn't card in his hand.");
			}

			return Cards[0].GetType() == cardType;
		}

		public void PlayCard()
		{
			if (Cards.Count <= 0)
			{
				throw new Exception("Player hasn't card in his hand.");
			}

			ICard chosenCard = ChooseCard();
			PlayCard(chosenCard);
		}

		public void PlayCard(ICard card)
		{
			Cards.Remove(card);
			card.Effect();
		}

		private ICard ChooseCard()
		{
			return Cards[0];
		}

		public Type GetCardInformation(Player designatedPlayer)
		{
			return CardInformations[designatedPlayer];
		}
	}
}