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

		#region Initialization of the game
		[Theory]
		[InlineData(typeof(GuardCard), 5)]
		[InlineData(typeof(PriestCard), 2)]
		[InlineData(typeof(BaronCard), 2)]
		[InlineData(typeof(HandmaidCard), 2)]
		[InlineData(typeof(PrinceCard), 2)]
		[InlineData(typeof(KingCard), 1)]
		[InlineData(typeof(CountessCard), 1)]
		[InlineData(typeof(PrincessCard), 1)]
		public void GameInitialization_NumberOfCards(Type cardType, int nbCardsExpected)
		{
			// A
			var game = new Game(2);

			// A
			var nbCards = game.CardDesk.Cards.Count(c => c.GetType() == cardType);

			// A
			Assert.Equal(nbCardsExpected, nbCards);
		}

		[Fact]
		public void GameInitialization_NumberOfCardsIntoTheDeck_SixteenCards()
		{
			// A
			var game = new Game(2);
			int nbCardsExpected = 16;

			// A
			int nbCards = game.CardDesk.Cards.Count;

			// A
			Assert.Equal(nbCardsExpected, nbCards);
		}

		[Theory]
		[InlineData(2, 13)]
		[InlineData(3, 12)]
		[InlineData(4, 11)]
		public void GameInitialization_NumberOfCardsAfterInitialization_OneCardIsDiscardedAndOneCardIsDealtToEachPlayer(int nbPlayer, int nbCardsRemainingExpected)
		{
			// A
			var game = new Game(nbPlayer);
			
			// A
			game.Initialization();
			int nbCards = game.CardDesk.Cards.Count;

			// A
			Assert.Equal(nbCardsRemainingExpected, nbCards);
		}

		[Fact]
		public void GameInitialization_NumberOfCardsByPlayers_OneCard()
		{
			// A
			var game = new Game(2);
			Player playerOne = game.Players[0];
			Player playerTwo = game.Players[1];
			int nbCardExpected = 1;

			// A
			game.Initialization();

			// A
			Assert.Equal(nbCardExpected, playerOne.Cards.Count);
			Assert.Equal(nbCardExpected, playerTwo.Cards.Count);
		}
		#endregion // Initialization of the game
	}
}
