using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GameLoveLetter.Tests
{
	public class CardTest
	{
		#region Test number of cards and their strengths
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
			var nbCards = game.CardDesk.Cards.Count(c => c.GetType().Name == name);
			
			// A
			Assert.Equal(nbCardsExpected, nbCards);
		}

		[Theory]
		[InlineData(typeof(GuardCard), 1)]
		[InlineData(typeof(PriestCard), 2)]
		[InlineData(typeof(BaronCard), 3)]
		[InlineData(typeof(HandmaidCard), 4)]
		[InlineData(typeof(PrinceCard), 5)]
		[InlineData(typeof(KingCard), 6)]
		[InlineData(typeof(CountessCard), 7)]
		[InlineData(typeof(PrincessCard), 8)]
		public void CheckStrengthOfCards(Type type, int expectedStrength)
		{
			// A
			var card = (Card)Activator.CreateInstance(type);

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedStrength, cardStrength);
		}
		#endregion // Test number of cards and their strengths

		#region Test card effect
		[Fact]
		public void CardEffect_GuardCardEffectCannotAcceptTheGuardCardType()
		{
			// A
			var guardCard = new GuardCard();
			var priestCard = new PriestCard();
			Type typeGuardCard = typeof(GuardCard);

			// A
			var exception = Assert.Throws<GuardCardCannotAcceptGuardException>(() => guardCard.Effect(typeGuardCard, priestCard));

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
			bool match = guardCard.Effect(typePriestCard, priestCard);

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

		[Theory]
		[InlineData(typeof(GuardCard), typeof(GuardCard.Data))]
		[InlineData(typeof(PriestCard), typeof(PriestCard.Data))]
		[InlineData(typeof(BaronCard), typeof(BaronCard.Data))]
		[InlineData(typeof(HandmaidCard), typeof(HandmaidCard.Data))]
		[InlineData(typeof(PrinceCard), typeof(PrinceCard.Data))]
		[InlineData(typeof(KingCard), typeof(KingCard.Data))]
		[InlineData(typeof(CountessCard), typeof(CountessCard.Data))]
		[InlineData(typeof(PrincessCard), typeof(PrincessCard.Data))]
		public void PlayCardReturnCardDataAssociated(Type cardType, Type cardDataTypeExpected)
		{
			// A
			Player player = new Player(null);
			player.Cards = new List<Card>() { (Card)Activator.CreateInstance(cardType) };

			// A
			var cardData = player.PlayCard();

			// A
			Assert.Equal(cardDataTypeExpected, cardData.GetType());
		}
	}
}
