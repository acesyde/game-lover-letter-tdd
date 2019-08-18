using GameLoveLetter.Cards;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameLoveLetter
{
	public class Player
	{
		public List<ICard> Cards { get; set; } 
		public Dictionary<Player, Type> CardInformations { get; set; }
		public bool IsEliminated { get; set; }
		public bool IsProtected { get; set; }

		public delegate ICard DrawACardDelegate();
		private DrawACardDelegate _drawACardDelegate;

		public void DiscardCard()
		{
			Cards.RemoveAt(0);
		}

		public Player()
		{
			Cards = new List<ICard>();
			IsEliminated = false;
			IsProtected = false;
		}

		public void Initialization(List<Player> players, DrawACardDelegate drawACardDelegate)
		{
			Initialization(players);
			Initialization(drawACardDelegate);
		}

		public void Initialization(List<Player> players)
		{
			CardInformations = new Dictionary<Player, Type>();

			foreach (var player in players)
			{
				if (player != this)
				{
					CardInformations.Add(player, null);
				}
			}
		}

		public void Initialization(DrawACardDelegate drawACardDelegate)
		{
			_drawACardDelegate = drawACardDelegate;
		}

		public void DrawACard()
		{
			if (_drawACardDelegate == null)
			{
				throw new Exception("No delegate 'DrawACard' has been defined.");
			}

			DrawACard(_drawACardDelegate());
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
				throw new Exception("Player doesn't have card in his hand.");
			}

			return Cards[0].GetType() == cardType;
		}

		public void PlayCard()
		{
			if (Cards.Count <= 0)
			{
				throw new Exception("Player doesn't have card in his hand.");
			}

			ICard chosenCard = ChooseCard();
			PlayCard(chosenCard);
		}

		public void PlayCard(ICard card)
		{
			if (!Cards.Contains(card))
			{
				throw new Exception($"Player doesn't {card.GetType().Name} in his hand.");
			}
			Cards.Remove(card);
			card.Effect();
		}

		private ICard ChooseCard()
		{ 
			if (Cards.Any(c => c.GetType() == typeof(CountessCard))
				&& (Cards.Any(c => c.GetType() == typeof(KingCard))
					|| Cards.Any(c => c.GetType() == typeof(PrinceCard))))
			{
				return Cards.Find(c => c.GetType() == typeof(CountessCard));
			}

			return Cards[0];
		}

		public Type GetCardInformation(Player designatedPlayer)
		{
			return CardInformations[designatedPlayer];
		}
	}
}