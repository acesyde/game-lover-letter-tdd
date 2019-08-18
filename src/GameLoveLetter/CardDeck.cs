using GameLoveLetter.Cards;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameLoveLetter
{
	public class CardDeck
	{
		public List<ICard> Cards { get; private set; }

		public CardDeck()
		{
			Create();
			Shuffle();
		}

		private void Create()
		{
			Cards = new List<ICard>()
			{
				// 5 Guard cards
				new GuardCard(),
				new GuardCard(),
				new GuardCard(),
				new GuardCard(),
				new GuardCard(),

				// 2 Priest cards
				new PriestCard(),
				new PriestCard(),

				// 2 baron cards
				new BaronCard(),
				new BaronCard(),

				// 2 handmaid cards
				new HandmaidCard(),
				new HandmaidCard(),

				// 2 Prince cards
				new PrinceCard(),
				new PrinceCard(),

				// 1 King card
				new KingCard(),

				// 1 Countess card
				new CountessCard(),

				// 1 Princess card
				new PrincessCard()
			};
		}

		private void Shuffle()
		{
			Cards.Shuffle();
		}

		public void DiscardCard()
		{
			DiscardCard(Cards[0]);
		}

		private void DiscardCard(ICard card)
		{
			Cards.Remove(card);
		}
		public ICard DrawACard()
		{
			ICard cardDrawn = Cards[0];
			DiscardCard(Cards[0]);
			return cardDrawn;
		}

		public ICard DrawACard(Type cardType)
		{
			ICard card = Cards.Find(c => c.GetType() == cardType);

			if (card == null)
			{
				throw new Exception($"{cardType.Name} is not in the deck.");
			}

			DiscardCard(card);
			return card;
		}
	}
}
