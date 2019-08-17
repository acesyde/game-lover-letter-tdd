using GameLoveLetter.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GameLoveLetter.Tests
{
	public class CardTest
	{
		#region Test cards strength
		[Fact]
		public void CardStrenght_GuardCard_StrengthOfOne()
		{
			// A
			var card = new GuardCard();
			int expectedStrength = 1;

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedStrength, cardStrength);
		}

		[Fact]
		public void CardStrenght_PriestCard_StrengthOfTwo()
		{
			// A
			var card = new PriestCard();
			int expectedStrength = 2;

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedStrength, cardStrength);
		}

		[Fact]
		public void CardStrenght_BaronCard_StrengthOfThree()
		{
			// A
			var card = new BaronCard();
			int expectedStrength = 3;

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedStrength, cardStrength);
		}

		[Fact]
		public void CardStrenght_HandmaidCard_StrengthOfFour()
		{
			// A
			var card = new HandmaidCard();
			int expectedStrength = 4;

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedStrength, cardStrength);
		}

		[Fact]
		public void CardStrenght_PrinceCard_StrengthOfFive()
		{
			// A
			var card = new PrinceCard();
			int expectedStrength = 5;

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedStrength, cardStrength);
		}

		[Fact]
		public void CardStrenght_KingCard_StrengthOfSix()
		{
			// A
			var card = new KingCard();
			int expectedStrength = 6;

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedStrength, cardStrength);
		}

		[Fact]
		public void CardStrenght_CountessCard_StrengthOfSeven()
		{
			// A
			var card = new CountessCard();
			int expectedStrength = 7;

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedStrength, cardStrength);
		}

		[Fact]
		public void CardStrenght_PrincessCard_StrengthOfHeight()
		{
			// A
			var card = new PrincessCard();
			int expectedStrength = 8;

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedStrength, cardStrength);
		}

		#endregion // Test cards strength
	}
}
