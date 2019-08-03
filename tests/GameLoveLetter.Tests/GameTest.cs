using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace GameLoveLetter.Tests
{
	public class CardsData : IEnumerable<object[]>
	{
		private readonly List<object[]> _data = new List<object[]>
		{
			new object[] { new Guard() },
			new object[] { new Priest() },
			new object[] { new Baron() },
			new object[] { new Handmaid() },
			new object[] { new Prince() },
			new object[] { new King() },
			new object[] { new Countess() },
			new object[] { new Princess() }
		};

		public IEnumerator<object[]> GetEnumerator()
		{
			return ((IEnumerable<object[]>)this._data).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<object[]>)this._data).GetEnumerator();
		}
	}

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

		[Fact]
		public void AGameHasSixteenCards()
		{
			// A
			var game = new Game(2);
			var nbCards = 16;

			// A
			var exception = Assert.Throws<UncorrectNumberOfCardsException>(() => game.Cards.Count == nbCards);

			// A
			Assert.Null(exception);
		}

		[Fact]
		public void AGameHasSixteenCards2()
		{
			// A
			var game = new Game(2);
			var nbCards = 16;

			game.Cards.Add(new Card());

			// A
			var exception = Assert.Throws<UncorrectNumberOfCardsException>(() => game.Cards.Count == nbCards);

			// A
			Assert.Null(exception);
			Assert.Equal("A game must have 16 cards.", exception);
		}

		[Fact]
		public void AGameHasFiveGuardsTwoPriestsTwoBaronsTwoHandmaidsTwoPrincesOneKingOneCountessAndOnePrincess()
		{
			// A
			var game = new Game(2);

			int nbGuards = 5;
			int nbPriests = 2;
			int nbBarons = 2;
			int nbHandMaids = 2;
			int nbPrinces = 2;
			int nbKings = 1;
			int nbCountesses = 1;
			int nbPrincesses = 1;
			int nbOthersCards = 0;

			// A
			foreach (var card in game.Cards)
			{
				switch (card.Name)
				{
					case "Guard":
						nbGuards--;
						break;
					case "Priest":
						nbPriests--;
						break;
					case "Baron":
						nbBarons--;
						break;
					case "HandMaid":
						nbHandMaids--;
						break;
					case "Prince":
						nbPrinces--;
						break;
					case "King":
						nbKings--;
						break;
					case "Countess":
						nbCountesses--;
						break;
					case "Princess":
						nbPrincesses--;
						break;
					default:
						nbOthersCards--;
						break;
				}
			}

			var badNumberOfGuardsException = Assert.Throws<BadNumberOfGuardsException>(() => nbGuards != 0);
			var badNumberOfPriestsException = Assert.Throws<BadNumberOfPriestsException>(() => nbPriests != 0);
			var badNumberOfBaronsException = Assert.Throws<BadNumberOfBaronsException>(() => nbBarons != 0);
			var badNumberOfHandMaidsException = Assert.Throws<BadNumberOfHandMaidsException>(() => nbHandMaids != 0);
			var badNumberOfPrincesException = Assert.Throws<BadNumberOfPrincesException>(() => nbPrinces != 0);
			var badNumberOfKingsException = Assert.Throws<BadNumberOfKingsException>(() => nbKings != 0);
			var badNumberOfCountessesException = Assert.Throws<BadNumberOfCountessesException>(() => nbCountesses != 0);
			var badNumberOfPrincessesException = Assert.Throws<BadNumberOfPrincessesException>(() => nbPrincesses != 0);
			var unknownCardsException = Assert.Throws<UnknownCardsException>(() => nbOthersCards != 0);

			// A
			Assert.Null(badNumberOfGuardsException);
			Assert.Null(badNumberOfPriestsException);
			Assert.Null(badNumberOfBaronsException);
			Assert.Null(badNumberOfHandMaidsException);
			Assert.Null(badNumberOfPrincesException);
			Assert.Null(badNumberOfKingsException);
			Assert.Null(badNumberOfCountessesException);
			Assert.Null(badNumberOfPrincessesException);
			Assert.Null(unknownCardsException);
		}

		[Theory]
		[ClassData(typeof(CardsData))]
		public void AGameHasFiveGuardsTwoPriestsTwoBaronsTwoHandmaidsTwoPrincesOneKingOneCountessAndOnePrincess2(Card newCard)
		{
			// A
			var game = new Game(2);

			int nbGuards = 5;
			int nbPriests = 2;
			int nbBarons = 2;
			int nbHandMaids = 2;
			int nbPrinces = 2;
			int nbKings = 1;
			int nbCountesses = 1;
			int nbPrincesses = 1;
			int nbOthersCards = 0;

			game.Cards.Add(newCard);

			// A
			foreach (var card in game.Cards)
			{
				switch (card.Name)
				{
					case "Guard":
						nbGuards--;
						break;
					case "Priest":
						nbPriests--;
						break;
					case "Baron":
						nbBarons--;
						break;
					case "HandMaid":
						nbHandMaids--;
						break;
					case "Prince":
						nbPrinces--;
						break;
					case "King":
						nbKings--;
						break;
					case "Countess":
						nbCountesses--;
						break;
					case "Princess":
						nbPrincesses--;
						break;
					default:
						nbOthersCards--;
						break;
				}
			}

			var badNumberOfGuardsException = Assert.Throws<BadNumberOfGuardsException>(() => nbGuards != 0);
			var badNumberOfPriestsException = Assert.Throws<BadNumberOfPriestsException>(() => nbPriests != 0);
			var badNumberOfBaronsException = Assert.Throws<BadNumberOfBaronsException>(() => nbBarons != 0);
			var badNumberOfHandMaidsException = Assert.Throws<BadNumberOfHandMaidsException>(() => nbHandMaids != 0);
			var badNumberOfPrincesException = Assert.Throws<BadNumberOfPrincesException>(() => nbPrinces != 0);
			var badNumberOfKingsException = Assert.Throws<BadNumberOfKingsException>(() => nbKings != 0);
			var badNumberOfCountessesException = Assert.Throws<BadNumberOfCountessesException>(() => nbCountesses != 0);
			var badNumberOfPrincessesException = Assert.Throws<BadNumberOfPrincessesException>(() => nbPrincesses != 0);
			var unknownCardsException = Assert.Throws<UnknownCardsException>(() => nbOthersCards != 0);

			// A
			Assert.NotNull(badNumberOfGuardsException);
			Assert.Equal("Bad number of Guards.", badNumberOfGuardsException.Message);

			Assert.NotNull(badNumberOfPriestsException);
			Assert.Equal("Bad number of Priests.", badNumberOfPriestsException.Message);

			Assert.NotNull(badNumberOfBaronsException);
			Assert.Equal("Bad number of Barons.", badNumberOfBaronsException.Message);

			Assert.NotNull(badNumberOfHandMaidsException);
			Assert.Equal("Bad number of HandMaids.", badNumberOfHandMaidsException.Message);

			Assert.NotNull(badNumberOfPrincesException);
			Assert.Equal("Bad number of Princes.", badNumberOfPrincesException.Message);

			Assert.NotNull(badNumberOfKingsException);
			Assert.Equal("Bad number of Kings.", badNumberOfKingsException.Message);

			Assert.NotNull(badNumberOfCountessesException);
			Assert.Equal("Bad number of Countesses.", badNumberOfCountessesException.Message);

			Assert.NotNull(badNumberOfPrincessesException);
			Assert.Equal("Bad number of Princesse.", badNumberOfPrincessesException.Message);

			Assert.NotNull(unknownCardsException);
			Assert.Equal("There is unknown cards.", unknownCardsException.Message);
		}
	}
}
