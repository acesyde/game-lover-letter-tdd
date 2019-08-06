using System;
using System.Collections.Generic;
using System.Text;

namespace GameLoveLetter
{
	public class CardDeck
	{
		public Queue<Card> Cards { get; private set; }
		
		public CardDeck()
		{
			Create();
			Shuffle();
		}

		private void Create()
		{
			Cards = new Queue<Card>();
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

		public Card DrawACard()
		{
			return Cards.Dequeue();
		}
	}
}
