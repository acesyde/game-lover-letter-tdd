using GameLoveLetter.Cards;
using System.Collections.Generic;

namespace GameLoveLetter
{
	public class CardDeck
	{
		public Queue<ICard> Cards { get; private set; }
		
		public CardDeck()
		{
			Create();
			Shuffle();
		}

		private void Create()
		{
			Cards = new Queue<ICard>();
			Cards.Enqueue(new GuardCard());
			Cards.Enqueue(new GuardCard());
			Cards.Enqueue(new GuardCard());
			Cards.Enqueue(new GuardCard());
			Cards.Enqueue(new GuardCard());
			Cards.Enqueue(new PriestCard());
			Cards.Enqueue(new PriestCard());
			Cards.Enqueue(new BaronCard());
			Cards.Enqueue(new BaronCard());
			Cards.Enqueue(new HandmaidCard());
			Cards.Enqueue(new HandmaidCard());
			Cards.Enqueue(new PrinceCard());
			Cards.Enqueue(new PrinceCard());
			Cards.Enqueue(new KingCard());
			Cards.Enqueue(new CountessCard());
			Cards.Enqueue(new PrincessCard());
		}

		private void Shuffle()
		{
			Cards.Shuffle();
		}

		public void DiscardCard()
		{
			Cards.Dequeue();
		}

		public ICard DrawACard()
		{
			return Cards.Dequeue();
		}
	}
}
