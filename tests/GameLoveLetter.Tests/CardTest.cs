using GameLoveLetter.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GameLoveLetter.Tests
{
	public class CardTest
	{
		#region Cards strength
		[Fact]
		public void CardStrength_GuardCard_StrengthOfOne()
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
		public void CardStrength_PriestCard_StrengthOfTwo()
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
		public void CardStrength_BaronCard_StrengthOfThree()
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
		public void CardStrength_HandmaidCard_StrengthOfFour()
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
		public void CardStrength_PrinceCard_StrengthOfFive()
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
		public void CardStrength_KingCard_StrengthOfSix()
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
		public void CardStrength_CountessCard_StrengthOfSeven()
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
		public void CardStrength_PrincessCard_StrengthOfHeight()
		{
			// A
			var card = new PrincessCard();
			int expectedStrength = 8;

			// A
			var cardStrength = card.Strength;

			// A
			Assert.Equal(expectedStrength, cardStrength);
		}

		#endregion // Cards strength

		#region Cards effect

		#region Guard card effect
		[Fact]
		public void GuardCardEffect_NameGuardCard_ThrowException()
		{
			// A
			Player currentPlayer = new Player();
			Player designatedPlayer = new Player();
			GuardCard currentPlayerCard = new GuardCard();
			GuardCard designatedPlayerCard = new GuardCard();
			currentPlayer.DrawACard(currentPlayerCard);

			// A
			designatedPlayer.DrawACard(designatedPlayerCard);
			currentPlayerCard.Data = new GuardCardData(currentPlayer, designatedPlayer, designatedPlayerCard.GetType());
			var exception = Assert.Throws<GuardCardCannotAcceptGuardCardException>(() => currentPlayerCard.Effect());

			// A
			Assert.NotNull(exception);
			Assert.Equal("The guard card effect can not accept a guard type.", exception.Message);
		}

		[Fact]
		public void GuardCardEffect_NameRightCard_PlayerIsEliminated()
		{
			// A
			bool isEliminated = true;

			Player currentPlayer = new Player();
			Player designatedPlayer = new Player();
			GuardCard currentPlayerCard = new GuardCard();
			PriestCard designatedPlayerCard = new PriestCard();

			List<Player> players = new List<Player>() { currentPlayer, designatedPlayer };
			currentPlayer.Initialization(players);
			designatedPlayer.Initialization(players);

			// A
			currentPlayer.DrawACard(currentPlayerCard);
			designatedPlayer.DrawACard(designatedPlayerCard);
			currentPlayerCard.Data = new GuardCardData(currentPlayer, designatedPlayer, designatedPlayerCard.GetType());
			currentPlayerCard.Effect();

			// A
			Assert.Equal(isEliminated, designatedPlayer.IsEliminated);
		}

		[Fact]
		public void GuardCardEffect_NameWrongCard_PlayerIsNotEliminated()
		{
			// A
			bool isEliminated = false;

			Player currentPlayer = new Player();
			Player designatedPlayer = new Player();
			GuardCard currentPlayerCard = new GuardCard();
			PriestCard designatedPlayerCard = new PriestCard();

			List<Player> players = new List<Player>() { currentPlayer, designatedPlayer };
			currentPlayer.Initialization(players);
			designatedPlayer.Initialization(players);

			// A
			currentPlayer.DrawACard(currentPlayerCard);
			designatedPlayer.DrawACard(designatedPlayerCard);
			currentPlayerCard.Data = new GuardCardData(currentPlayer, designatedPlayer, designatedPlayerCard.GetType());
			currentPlayerCard.Effect();

			// A
			Assert.Equal(isEliminated, currentPlayer.IsEliminated);
		}
		#endregion // Guard card effect

		#region Priest card effect
		[Fact]
		public void PriestCardEffect_GetsCardPlayerInformation()
		{
			// A
			Player currentPlayer = new Player();
			Player designatedPlayer = new Player();
			List<Player> players = new List<Player>() { currentPlayer, designatedPlayer };
			PriestCard currentPlayerCard = new PriestCard();
			GuardCard designatedPlayerCard = new GuardCard();

			currentPlayer.Initialization(players);
			designatedPlayer.Initialization(players);

			// A
			currentPlayer.DrawACard(currentPlayerCard);
			designatedPlayer.DrawACard(designatedPlayerCard);
			currentPlayerCard.Data = new PriestCardData(currentPlayer, designatedPlayer);
			currentPlayerCard.Effect();

			// A
			Assert.Equal(designatedPlayerCard.GetType(), currentPlayer.GetCardInformation(designatedPlayer));
		}
		#endregion // Priest card effect

		#endregion // Cards effect
	}
}
