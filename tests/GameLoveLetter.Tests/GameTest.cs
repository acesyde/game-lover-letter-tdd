using Xunit;

namespace GameLoveLetter.Tests
{
	public class GameTest
	{
		#region Game Should Contain between 2 and 4 players
		[Fact]
		public void AGameShouldContainAtLeastTwoPlayer()
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
		public void AGameShouldContainAtMostFourPlayer()
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
		public void AGameShouldContainBetweenTwoAndFourPlayer(int nbPlayer)
		{
			// A
	
			// A
			var game = new Game(nbPlayer);

			// A
			Assert.Equal(nbPlayer, game.Players.Count);
		}
		#endregion // Game Should Contain between 2 and 4 players

		#region Initialization of the game
		[Fact]
		public void AtTheBeginningThereIsSixteenCardIntoTheDeck()
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
		public void AtInitializationOneCardIsDiscardedAndOneCardIsDealtToEachPlayer(int nbPlayer, int nbCardsRemainingExpected)
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
		public void AfterInitializationEachPlayerHasOneCard()
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
			Assert.Equal(nbCardExpected, playerOne.Cards.Count);
		}
		#endregion // Initialization of the game
	}
}
