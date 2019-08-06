using System;
using System.Collections.Generic;

namespace GameLoveLetter
{
	public class Player
	{
		public List<Card> Cards { get; private set; } 

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
	}
}