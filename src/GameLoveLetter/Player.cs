using GameLoveLetter.Cards;
using System;
using System.Collections.Generic;

namespace GameLoveLetter
{
	public class Player
	{
		public List<ICard> Cards { get; set; } 

		public delegate ICard DrawACardDelegate();
		private DrawACardDelegate _drawACardDelegate;

		public Player(DrawACardDelegate drawACardDelegate)
		{
			_drawACardDelegate = drawACardDelegate;
			Cards = new List<ICard>();
		}

		public void DrawACard()
		{
			Cards.Add(_drawACardDelegate());
		}

		public ICard PlayCard()
		{
			if (Cards.Count <= 0)
			{
				throw new Exception("Player hasn't card in his hand.");
			}

			ICard chosenCard = ChooseCard();
			Cards.Remove(chosenCard);

			return chosenCard;
		}

		private ICard ChooseCard()
		{
			return Cards[0];
		}
	}
}