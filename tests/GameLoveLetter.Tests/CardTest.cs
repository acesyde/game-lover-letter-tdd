using System;
using System.Linq;
using Xunit;

namespace GameLoveLetter.Tests
{
	public class CardTest
	{
		[Theory]
		[InlineData("GuardCard", 5)]
		[InlineData("PriestCard", 2)]
		[InlineData("BaronCard", 2)]
		[InlineData("HandmaidCard", 2)]
		[InlineData("PrinceCard", 2)]
		[InlineData("KingCard", 1)]
		[InlineData("CountessCard", 1)]
		[InlineData("PrincessCard", 1)]
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
			var card = new GuardCard();
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
			var card = new PriestCard();
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
			var card = new BaronCard();
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
			var card = new HandmaidCard();
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
			var card = new PrinceCard();
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
			var card = new KingCard();
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
			var card = new CountessCard();
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
			var card = new PrincessCard();
			int expectedCardStrength = 8;

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedCardStrength, cardStrength);
		}

		[Fact]
		public void GuardEffectReturnTrueIfCardMatchesTheTypeOfCardSpecified()
		{
			// A
			var guardCard = new GuardCard();
			var priestCard = new PriestCard();

			// A
			bool match = guardCard.Effect(typeof(PriestCard), priestCard);

			// A
			Assert.True(match);
		}

		[Fact]
		public void GuardEffectReturnFalseIfCardDoesNotMatchTheTypeOfCardSpecified()
		{
			// A
			var guardCard = new GuardCard();
			var priestCard = new PriestCard();

			// A
			bool match = guardCard.Effect(typeof(BaronCard), priestCard);

			// A
			Assert.False(match);
		}

		[Fact]
		public void GuardEffectCannotAcceptTheGuardCardType()
		{
			// A
			var guardCard = new GuardCard();
			var priestCard = new GuardCard();

			// A
			var exception = Assert.Throws<GuardCardCannotAcceptGuard>(() => guardCard.Effect(typeof(GuardCard), priestCard));

			// A
			Assert.NotNull(exception);
			Assert.Equal("The guard card effect can not accept a guard type.", exception.Message);
		}
	}
}
