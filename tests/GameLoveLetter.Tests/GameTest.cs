using Xunit;

namespace GameLoveLetter.Tests
{
	public class GameTest
	{
		[Fact]
		public void AGameShouldContainAtLeastTwoPlayer()
		{
			// A
			int nbPlayer = 1;

			// A
			var exception = Assert.Throws<BadNumberOfPlayersException>(() => new Game(nbPlayer));

			// A
			Assert.NotNull(exception);
			Assert.Equal("A game should contain between 2 and 4 players.", exception.Message);
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
			Assert.Equal("A game should contain between 2 and 4 players.", exception.Message);
		}
	}
}
