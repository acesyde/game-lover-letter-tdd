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

		#region Check strength of cards
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
		#endregion // Check strength of cards

		#region Test card effect
		[Fact]
		public void CardEffect_GuardCardEffectCannotAcceptTheGuardCardType()
		{
			// A
			var guardCard = new GuardCard();
			var priestCard = new PriestCard();
			Type typeGuardCard = typeof(GuardCard);

			// A
			var exception = Assert.Throws<GuardCardCannotAcceptGuard>(() => guardCard.Effect(typeGuardCard, priestCard));

			// A
			Assert.NotNull(exception);
			Assert.Equal("The guard card effect can not accept a guard type.", exception.Message);
		}

		[Fact]
		public void CardEffect_GuardCardEffectReturnTrueIfCardMatchesTheTypeOfCardSpecified()
		{
			// A
			var guardCard = new GuardCard();
			var priestCard = new PriestCard();
			Type typePriestCard = typeof(PriestCard);

			// A
			bool match = guardCard.Effect(typeof(PriestCard), priestCard);

			// A
			Assert.True(match);
		}

		[Fact]
		public void CardEffect_GuardCardEffectReturnFalseIfCardDoesNotMatchTheTypeOfCardSpecified()
		{
			// A
			var guardCard = new GuardCard();
			var priestCard = new PriestCard();
			Type typeBaronCard = typeof(BaronCard);

			// A
			bool match = guardCard.Effect(typeBaronCard, priestCard);

			// A
			Assert.False(match);
		}

		[Fact]
		public void CardEffect_PriestCardEffectReturnTheCardType()
		{
			// A
			var priestCard = new PriestCard();
			var guardCard = new GuardCard();
			var typeExpected = typeof(GuardCard);

			// A
			Type type = priestCard.Effect(guardCard);

			// A
			Assert.Equal(typeExpected, type);
		}

		[Fact]
		public void CardEffect_BaronCardEffectReturnZeroIfCardsAreEquals()
		{
			// A
			var baronCard = new BaronCard();
			var card1 = new GuardCard();
			var card2 = new GuardCard();
			int expectedResult = 0;

			// A
			int result = baronCard.Effect(card1, card2);

			// A
			Assert.Equal(expectedResult, result);
		}

		[Fact]
		public void CardEffect_BaronCardEffectReturnOneIfTheFirstCardIsStrongerThanTheSecondCard()
		{
			// A
			var baronCard = new BaronCard();
			var card1 = new PrinceCard();
			var card2 = new GuardCard();
			int expectedResult = 1;

			// A
			int result = baronCard.Effect(card1, card2);

			// A
			Assert.Equal(expectedResult, result);
		}

		[Fact]
		public void CardEffect_BaronCardEffectReturnMinusOneIfTheFirstCardIsWeakerThanTheSecondCard()
		{
			// A
			var baronCard = new BaronCard();
			var card1 = new GuardCard();
			var card2 = new PrinceCard();
			int expectedResult = -1;

			// A
			int result = baronCard.Effect(card1, card2);

			// A
			Assert.Equal(expectedResult, result);
		}
		#endregion // Test card effect

	}
}
