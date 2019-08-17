using System;
using System.Collections.Generic;

namespace GameLoveLetter
{
	public class Player
	{
		public List<Card> Cards { get; set; } 

		public delegate Card DrawACardDelegate();
		private DrawACardDelegate _drawACardDelegate;

		public Player(DrawACardDelegate drawACardDelegate)
		{
			_drawACardDelegate = drawACardDelegate;
			Cards = new List<Card>();
		}

		public void DrawACard()
		{
			Cards.Add(_drawACardDelegate());
		}

		public Card PlayCard()
		{
			if (Cards.Count <= 0)
			{
				throw new Exception("Player hasn't card in his hand.");
			}

			Card chosenCard = ChooseCard();
			Cards.Remove(chosenCard);
			FillData(chosenCard);

			return chosenCard;
		}

		private void FillData(Card chosenCard)
		{
			if (chosenCard.GetType() == typeof(GuardCard))
			{
				chosenCard.Datas = PlayGuardCard();
			}
			else
			{
				chosenCard.Datas = PlayPriestCard();
			}
		}

		private Card ChooseCard()
		{
			return Cards[0];
		}

		public Card.Data PlayGuardCard()
		{
			return new GuardCard.Data(new Player(null), typeof(GuardCard));
		}

		public  Pri
	}
}