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
			designatedPlayer.DrawACard(designatedPlayerCard);

			// A
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
			Player currentPlayer = new Player();
			Player designatedPlayer = new Player();
			GuardCard currentPlayerCard = new GuardCard();
			PriestCard designatedPlayerCard = new PriestCard();

			currentPlayer.DrawACard(currentPlayerCard);
			designatedPlayer.DrawACard(designatedPlayerCard);

			// A
			currentPlayerCard.Data = new GuardCardData(currentPlayer, designatedPlayer, designatedPlayerCard.GetType());
			currentPlayerCard.Effect();

			// A
			Assert.True(designatedPlayer.IsEliminated);
		}

		[Fact]
		public void GuardCardEffect_NameWrongCard_PlayerIsNotEliminated()
		{
			// A
			Player currentPlayer = new Player();
			Player designatedPlayer = new Player();
			GuardCard currentPlayerCard = new GuardCard();
			PriestCard designatedPlayerCard = new PriestCard();

			currentPlayer.DrawACard(currentPlayerCard);
			designatedPlayer.DrawACard(designatedPlayerCard);

			// A
			currentPlayerCard.Data = new GuardCardData(currentPlayer, designatedPlayer, designatedPlayerCard.GetType());
			currentPlayerCard.Effect();

			// A
			Assert.False(currentPlayer.IsEliminated);
		}
		#endregion // Guard card effect

		#region Priest card effect
		[Fact]
		public void PriestCardEffect_GetsCardPlayerInformation()
		{
			// A
			Player currentPlayer = new Player();
			Player designatedPlayer = new Player();
			PriestCard currentPlayerCard = new PriestCard();
			GuardCard designatedPlayerCard = new GuardCard();

			List<Player> players = new List<Player>() { currentPlayer, designatedPlayer };
			currentPlayer.Initialization(players);
			designatedPlayer.Initialization(players);

			currentPlayer.DrawACard(currentPlayerCard);
			designatedPlayer.DrawACard(designatedPlayerCard);

			// A
			currentPlayerCard.Data = new PriestCardData(currentPlayer, designatedPlayer);
			currentPlayerCard.Effect();

			// A
			Assert.Equal(designatedPlayerCard.GetType(), currentPlayer.GetCardInformation(designatedPlayer));
		}
		#endregion // Priest card effect

		#region Baron card effect
		[Fact]
		public void BaronCardEffect_CurrentPlayerHasAStrongerCard_DesignatedPlayerIsEliminated()
		{
			// A
			Player currentPlayer = new Player();
			Player designatedPlayer = new Player();
			BaronCard currentPlayerCard = new BaronCard();

			currentPlayer.DrawACard(currentPlayerCard);
			currentPlayer.DrawACard(new PrincessCard());
			designatedPlayer.DrawACard(new GuardCard());

			// A
			currentPlayerCard.Data = new BaronCardData(currentPlayer, designatedPlayer);
			currentPlayer.PlayCard(currentPlayerCard);

			// A
			Assert.False(currentPlayer.IsEliminated);
			Assert.True(designatedPlayer.IsEliminated);
		}

		[Fact]
		public void BaronCardEffect_DesignatedPlayerHasAStrongerCard_CurrentPlayerIsEliminated()
		{
			// A
			Player currentPlayer = new Player();
			Player designatedPlayer = new Player();
			BaronCard currentPlayerCard = new BaronCard();

			currentPlayer.DrawACard(currentPlayerCard);
			currentPlayer.DrawACard(new GuardCard());
			designatedPlayer.DrawACard(new PrincessCard());

			// A
			currentPlayerCard.Data = new BaronCardData(currentPlayer, designatedPlayer);
			currentPlayer.PlayCard(currentPlayerCard);

			// A
			Assert.True(currentPlayer.IsEliminated);
			Assert.False(designatedPlayer.IsEliminated);
		}

		[Fact]
		public void BaronCardEffect_PlayersHasSameCARD_NoOneIsEliminated()
		{
			// A
			Player currentPlayer = new Player();
			Player designatedPlayer = new Player();
			BaronCard currentPlayerCard = new BaronCard();

			currentPlayer.DrawACard(currentPlayerCard);
			currentPlayer.DrawACard(new GuardCard());
			designatedPlayer.DrawACard(new GuardCard());

			// A
			currentPlayerCard.Data = new BaronCardData(currentPlayer, designatedPlayer);
			currentPlayer.PlayCard(currentPlayerCard);

			// A
			Assert.False(currentPlayer.IsEliminated);
			Assert.False(designatedPlayer.IsEliminated);
		}
		#endregion // Baron card effect

		#region Handmaid card Effect
		[Fact]
		public void HandmaidCardEffect_CurrentPlayerIsProtected()
		{
			// A
			Player currentPlayer = new Player();
			HandmaidCard currentPlayerCard = new HandmaidCard();

			currentPlayer.DrawACard(currentPlayerCard);

			// A
			currentPlayerCard.Data = new HandmaidCardData(currentPlayer);
			currentPlayer.PlayCard(currentPlayerCard);

			// A
			Assert.True(currentPlayer.IsProtected);
		}
		#endregion // Handmaid card Effect

		#region Prince card Effect
		[Fact]
		public void PrinceCardEffect_UseCardOnCurrentPlayer_CurrentPlayerDiscardsHisCardAndDrawsAnother()
		{
			// A
			Player currentPlayer = new Player();
			CardDeck cardDeck = new CardDeck();
			PrinceCard currentPlayerCard = (PrinceCard) cardDeck.DrawACard(typeof(PrinceCard));

			currentPlayer.Initialization(cardDeck.DrawACard);

			currentPlayer.DrawACard(currentPlayerCard);
			currentPlayer.DrawACard();

			// A
			currentPlayerCard.Data = new PrinceCardData(currentPlayer);
			currentPlayer.PlayCard(currentPlayerCard);

			// A
			Assert.Equal(13, cardDeck.Count);
		}

		[Fact]
		public void PrinceCardEffect_CurrentPlayerHasPrincessCard_CurrentPlayerIsEliminated()
		{
			// A
			Player currentPlayer = new Player();
			CardDeck cardDeck = new CardDeck();
			PrincessCard currentPlayerCard = (PrincessCard)cardDeck.DrawACard(typeof(PrincessCard));

			currentPlayer.Initialization(cardDeck.DrawACard);

			currentPlayer.DrawACard(currentPlayerCard);
			currentPlayer.DrawACard();

			// A
			currentPlayerCard.Data = new PrincessCardData(currentPlayer);
			currentPlayer.PlayCard(currentPlayerCard);

			// A
			Assert.True(currentPlayer.IsEliminated);
		}
		#endregion // Prince card Effect

		#region King card Effect
		[Fact]
		public void KingCardEffect_CurrentPlayerTradesHandWithDesignatedPlayer()
		{
			// A
			Player currentPlayer = new Player();
			Player designatedPlayer = new Player();
			KingCard currentPlayerCard = new KingCard();

			currentPlayer.DrawACard(currentPlayerCard);
			currentPlayer.DrawACard(new GuardCard());
			designatedPlayer.DrawACard(new HandmaidCard());

			// A
			currentPlayerCard.Data = new KingCardData(currentPlayer, designatedPlayer);
			currentPlayer.PlayCard(currentPlayerCard);

			// A
			Assert.Equal(typeof(HandmaidCard), currentPlayer.Cards[0].GetType());
			Assert.Equal(typeof(GuardCard), designatedPlayer.Cards[0].GetType());
		}
		#endregion // King card Effect

		#region Countess card Effect
		[Fact]
		public void CountessCardEffect_PlayerHasKingCard_CountessCardIsPlayedImmediately()
		{
			// A
			Player currentPlayer = new Player();
			CountessCard currentPlayerCard = new CountessCard();

			currentPlayer.DrawACard(currentPlayerCard);
			currentPlayer.DrawACard(new KingCard());

			// A
			currentPlayer.PlayCard();

			// A
			Assert.Equal(typeof(KingCard), currentPlayer.Cards[0].GetType());
		}

		[Fact]
		public void CountessCardEffect_PlayerHasPrinceCard_CountessCardIsPlayedImmediately()
		{
			// A
			Player currentPlayer = new Player();
			CountessCard currentPlayerCard = new CountessCard();

			currentPlayer.DrawACard(currentPlayerCard);
			currentPlayer.DrawACard(new PrinceCard());

			// A
			currentPlayer.PlayCard();

			// A
			Assert.Equal(typeof(PrinceCard), currentPlayer.Cards[0].GetType());
		}
		#endregion // Countess card Effect

		#region Princess card Effect
		[Fact]
		public void PrincessCardEffect_CurrentPlayerPlaysPrincessCard_CurrentPlayerIsEliminated()
		{
			// A
			Player currentPlayer = new Player();
			PrincessCard currentPlayerCard = new PrincessCard();

			currentPlayer.DrawACard(currentPlayerCard);

			// A
			currentPlayerCard.Data = new PrincessCardData(currentPlayer);
			currentPlayer.PlayCard(currentPlayerCard);

			// A
			Assert.True(currentPlayer.IsEliminated);
		}
		#endregion // Princess card Effect

		#endregion // Cards effect
	}
}
