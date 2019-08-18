using GameLoveLetter.Cards;
using System;
using System.Linq;
using Xunit;

namespace GameLoveLetter.Tests
{
	public class GameTest
	{
		#region A game should contain between 2 and 4 players
		[Fact]
		public void NumberOfPlayers_AtLeastTwoPlayers_BadNumberOfPlayersExceptionIsThrown()
		{
			// A
			int nbPlayer = 1;

			// A
			var exception = Assert.Throws<BadNumberOfPlayersException>(() => new Game(nbPlayer));

			// A
			Assert.NotNull(exception);
			Assert.Equal("A game should contains between 2 and 4 players.", exception.Message);
		}

		[Fact]
		public void NumberOfPlayers_AtMostFourPlayers_BadNumberOfPlayersExceptionIsThrown()
		{
			// A
			int nbPlayer = 5;

			// A
			var exception = Assert.Throws<BadNumberOfPlayersException>(() => new Game(nbPlayer));

			// A
			Assert.NotNull(exception);
			Assert.Equal("A game should contains between 2 and 4 players.", exception.Message);
		}

		[Theory]
		[InlineData(2)]
		[InlineData(3)]
		[InlineData(4)]
		public void NumberOfPlayers_BetweenTwoAndFourPlayers_NoExceptionThrown(int nbPlayer)
		{
			// A
			
			// A
			var game = new Game(nbPlayer);

			// A
			Assert.Equal(nbPlayer, game.Players.Count);
		}
		#endregion // A game should contain between 2 and 4 players

		#region Check number of card into the deck

		[Theory]
		[InlineData(typeof(GuardCard), 5)]
		[InlineData(typeof(PriestCard), 2)]
		[InlineData(typeof(BaronCard), 2)]
		[InlineData(typeof(HandmaidCard), 2)]
		[InlineData(typeof(PrinceCard), 2)]
		[InlineData(typeof(KingCard), 1)]
		[InlineData(typeof(CountessCard), 1)]
		[InlineData(typeof(PrincessCard), 1)]
		public void CardDeck_NumberOfEachCards_DependsOfCardType(Type cardType, int nbCardsExpected)
		{
			// A
			var cardDeck = new CardDeck();

			// A
			var nbCards = cardDeck.Count(c => c.GetType() == cardType);

			// A
			Assert.Equal(nbCardsExpected, nbCards);
		}

		[Fact]
		public void CardDeck_TotalNumberOfCards_SixteenCards()
		{
			// A
			var cardDeck = new CardDeck();
			int nbCardsExpected = 16;

			// A
			int nbCards = cardDeck.Count;

			// A
			Assert.Equal(nbCardsExpected, nbCards);
		}
		#endregion // Check number of card into the deck

		#region Initialization of the game
		[Theory]
		[InlineData(2, 13)]
		[InlineData(3, 12)]
		[InlineData(4, 11)]
		public void GameInitialization_NumberOfCardsAfterInitialization_OneCardIsDiscardedAndOneCardIsDealtToEachPlayer(int nbPlayer, int nbCardsRemainingExpected)
		{
			// A
			
			// A
			var game = new Game(nbPlayer);
			int nbCards = game.CardDeck.Count;

			// A
			Assert.Equal(nbCardsRemainingExpected, nbCards);
		}

		[Fact]
		public void GameInitialization_NumberOfCardsByPlayers_OneCard()
		{
			// A
			var game = new Game(2);
			int nbCardExpected = 1;

			// A

			// A
			Assert.Equal(nbCardExpected, game.Players[0].Cards.Count);
			Assert.Equal(nbCardExpected, game.Players[1].Cards.Count);
		}
		#endregion // Initialization of the game
	}
}
