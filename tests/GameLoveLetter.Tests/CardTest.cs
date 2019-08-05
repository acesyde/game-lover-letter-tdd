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

		[Fact]
		public void CheckStrengthOfGuardCard()
		{
			// A
			var card = new Guard();
			int expectedCardStrength = 1;

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedCardStrength, cardStrength);
		}

		[Fact]
		public void CheckStrengthOfPriestCard()
		{
			// A
			var card = new Priest();
			int expectedCardStrength = 2;

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedCardStrength, cardStrength);
		}

		[Fact]
		public void CheckStrengthOfBaronCard()
		{
			// A
			var card = new Baron();
			int expectedCardStrength = 3;

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedCardStrength, cardStrength);
		}

		[Fact]
		public void CheckStrengthOfHandmaidCard()
		{
			// A
			var card = new Handmaid();
			int expectedCardStrength = 4;

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedCardStrength, cardStrength);
		}

		[Fact]
		public void CheckStrengthOfPrinceCard()
		{
			// A
			var card = new Prince();
			int expectedCardStrength = 5;

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedCardStrength, cardStrength);
		}

		[Fact]
		public void CheckStrengthOfKingCard()
		{
			// A
			var card = new King();
			int expectedCardStrength = 6;

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedCardStrength, cardStrength);
		}

		[Fact]
		public void CheckStrengthOfCountessCard()
		{
			// A
			var card = new Countess();
			int expectedCardStrength = 7;

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedCardStrength, cardStrength);
		}

		[Fact]
		public void CheckStrengthOfPrincessCard()
		{
			// A
			var card = new Princess();
			int expectedCardStrength = 8;

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedCardStrength, cardStrength);
		}
	}
}
