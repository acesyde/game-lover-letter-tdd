using System;
using System.Linq;
using Xunit;

namespace GameLoveLetter.Tests
{
	public class CardTest
	{
		[Theory]
		[InlineData("Guard", 5)]
		[InlineData("Priest", 2)]
		[InlineData("Baron", 2)]
		[InlineData("Handmaid", 2)]
		[InlineData("Prince", 2)]
		[InlineData("King", 1)]
		[InlineData("Countess", 1)]
		[InlineData("Princess", 1)]
		public void CheckNumberOfCardsbyType(string name, int nbCardsExpected)
		{
			// A
			var game = new Game(2);

			// A
			var nbCards = game.Cards.Count(c => c.GetType().Name == name);
			
			// A
			Assert.Equal(nbCardsExpected, nbCards);
		}
	}
}
