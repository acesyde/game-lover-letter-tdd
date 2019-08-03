using Xunit;

namespace GameLoveLetter.Tests
{
	public class GameTest
	{
		[Theory]
		[InlineData(1)]
		[InlineData(2)]
		[InlineData(3)]
		[InlineData(4)]
		[InlineData(5)]
		public void GameHasTwoToFourPlayers(int nbPlayer)
		{
			// A

			// A
			var exception = Assert.Throws<UncorrectNumberOfPlayersException>(() => new Game(nbPlayer));

			// A
			if (2 <= nbPlayer && nbPlayer <= 4)
			{
				Assert.Null(exception);
			}
			else
			{
				Assert.NotNull(exception);
				Assert.Equal("A game must contain at least 2 players and less than 4 players.", exception.Message);
			}
		}
	}
}
