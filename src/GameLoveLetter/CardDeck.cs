using GameLoveLetter.Cards;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameLoveLetter
{
	public class CardDeck : List<ICard>
	{
		public CardDeck()
		{
			Create();
			Shuffle();
		}

		private void Create()
		{
			AddRange(new List<ICard>()
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
				});
		}

		private void Shuffle()
		{
			this.ShuffleExtension();
		}

		public void DiscardCard()
		{
			DiscardCard(this[0]);
		}

		private void DiscardCard(ICard card)
		{
			Remove(card);
		}
		public ICard DrawACard()
		{
			ICard cardDrawn = this[0];
			DiscardCard(this[0]);
			return cardDrawn;
		}

		public ICard DrawACard(Type cardType)
		{
			ICard card = Find(c => c.GetType() == cardType);

			if (card == null)
			{
				throw new Exception($"{cardType.Name} is not in the deck.");
			}

			DiscardCard(card);
			return card;
		}
	}
}
