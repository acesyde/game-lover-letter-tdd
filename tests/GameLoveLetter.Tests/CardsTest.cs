using Xunit;

namespace GameLoveLetter.Tests
{
	public class CardsTest
	{
		#region Test name/strength of all cards

		[Fact]
		public void CardGuardHasANameOfGuardAndAValueOfOne()
		{
			//A
			var cardGuard = new Guard();
			var cardName = "Guard";
			var cardStrength = 1;

			//A
			var badCardNameException1 = Assert.Throws<BadCardNameException>(string.Equals(cardGuard.Name, cardName);
			var badStrengthNameException1 = Assert.Throws<BadStrengthNameException>(string.Equals(cardGuard.Strength, cardStrength);

			var badCardNameException2 = Assert.Throws<BadCardNameException>(string.Equals(cardGuard.Name, "Bad name");
			var badStrengthNameException2 = Assert.Throws<BadStrengthNameException>(string.Equals(cardGuard.Strength, 0);

			//A
			Assert.Null(badCardNameException1);
			Assert.Null(badStrengthNameException1);

			Assert.NotNull(badCardNameException2);
			Assert.Equals("The card has the wrong name.", badCardNameException2.Message);

			Assert.NotNull(badStrengthNameException2);
			Assert.Equals("The card has the wrong strength.", badStrengthNameException2.Message);
		}

		[Fact]
		public void CardPriestHasANameOfPriestAndAValueOfTwo()
		{
			//A
			var cardGuard = new Priest();
			var cardName = "Priest";
			var cardStrength = 2;

			//A
			var badCardNameException1 = Assert.Throws<BadCardNameException>(string.Equals(cardGuard.Name, cardName);
			var badStrengthNameException1 = Assert.Throws<BadStrengthNameException>(string.Equals(cardGuard.Strength, cardStrength);

			var badCardNameException2 = Assert.Throws<BadCardNameException>(string.Equals(cardGuard.Name, "Bad name");
			var badStrengthNameException2 = Assert.Throws<BadStrengthNameException>(string.Equals(cardGuard.Strength, 0);

			//A
			Assert.Null(badCardNameException1);
			Assert.Null(badStrengthNameException1);

			Assert.NotNull(badCardNameException2);
			Assert.Equals("The card has the wrong name.", badCardNameException2.Message);

			Assert.NotNull(badStrengthNameException2);
			Assert.Equals("The card has the wrong strength.", badStrengthNameException2.Message);
		}

		[Fact]
		public void CardBaronHasANameOfBaronAndAValueOfThree()
		{
			//A
			var cardGuard = new Baron();
			var cardName = "Baron";
			var cardStrength = 3;

			//A
			var badCardNameException1 = Assert.Throws<BadCardNameException>(string.Equals(cardGuard.Name, cardName);
			var badStrengthNameException1 = Assert.Throws<BadStrengthNameException>(string.Equals(cardGuard.Strength, cardStrength);

			var badCardNameException2 = Assert.Throws<BadCardNameException>(string.Equals(cardGuard.Name, "Bad name");
			var badStrengthNameException2 = Assert.Throws<BadStrengthNameException>(string.Equals(cardGuard.Strength, 0);

			//A
			Assert.Null(badCardNameException1);
			Assert.Null(badStrengthNameException1);

			Assert.NotNull(badCardNameException2);
			Assert.Equals("The card has the wrong name.", badCardNameException2.Message);

			Assert.NotNull(badStrengthNameException2);
			Assert.Equals("The card has the wrong strength.", badStrengthNameException2.Message);
		}

		[Fact]
		public void CardHandmaidHasANameOfHandmaidAndAValueOfFour()
		{
			//A
			var cardGuard = new Handmaid();
			var cardName = "Handmaid";
			var cardStrength = 4;

			//A
			var badCardNameException1 = Assert.Throws<BadCardNameException>(string.Equals(cardGuard.Name, cardName);
			var badStrengthNameException1 = Assert.Throws<BadStrengthNameException>(string.Equals(cardGuard.Strength, cardStrength);

			var badCardNameException2 = Assert.Throws<BadCardNameException>(string.Equals(cardGuard.Name, "Bad name");
			var badStrengthNameException2 = Assert.Throws<BadStrengthNameException>(string.Equals(cardGuard.Strength, 0);

			//A
			Assert.Null(badCardNameException1);
			Assert.Null(badStrengthNameException1);

			Assert.NotNull(badCardNameException2);
			Assert.Equals("The card has the wrong name.", badCardNameException2.Message);

			Assert.NotNull(badStrengthNameException2);
			Assert.Equals("The card has the wrong strength.", badStrengthNameException2.Message);
		}

		[Fact]
		public void CardPrinceHasANameOfPrinceAndAValueOfFive()
		{
			//A
			var cardGuard = new Prince();
			var cardName = "Prince";
			var cardStrength = 5;

			//A
			var badCardNameException1 = Assert.Throws<BadCardNameException>(string.Equals(cardGuard.Name, cardName);
			var badStrengthNameException1 = Assert.Throws<BadStrengthNameException>(string.Equals(cardGuard.Strength, cardStrength);

			var badCardNameException2 = Assert.Throws<BadCardNameException>(string.Equals(cardGuard.Name, "Bad name");
			var badStrengthNameException2 = Assert.Throws<BadStrengthNameException>(string.Equals(cardGuard.Strength, 0);

			//A
			Assert.Null(badCardNameException1);
			Assert.Null(badStrengthNameException1);

			Assert.NotNull(badCardNameException2);
			Assert.Equals("The card has the wrong name.", badCardNameException2.Message);

			Assert.NotNull(badStrengthNameException2);
			Assert.Equals("The card has the wrong strength.", badStrengthNameException2.Message);
		}

		[Fact]
		public void CardKingHasANameOfKingAndAValueOfSix()
		{
			//A
			var cardGuard = new King();
			var cardName = "King";
			var cardStrength = 6;

			//A
			var badCardNameException1 = Assert.Throws<BadCardNameException>(string.Equals(cardGuard.Name, cardName);
			var badStrengthNameException1 = Assert.Throws<BadStrengthNameException>(string.Equals(cardGuard.Strength, cardStrength);

			var badCardNameException2 = Assert.Throws<BadCardNameException>(string.Equals(cardGuard.Name, "Bad name");
			var badStrengthNameException2 = Assert.Throws<BadStrengthNameException>(string.Equals(cardGuard.Strength, 0);

			//A
			Assert.Null(badCardNameException1);
			Assert.Null(badStrengthNameException1);

			Assert.NotNull(badCardNameException2);
			Assert.Equals("The card has the wrong name.", badCardNameException2.Message);

			Assert.NotNull(badStrengthNameException2);
			Assert.Equals("The card has the wrong strength.", badStrengthNameException2.Message);
		}

		[Fact]
		public void CardCountessHasANameOfCountessAndAValueOfSeven()
		{
			//A
			var cardGuard = new Countess();
			var cardName = "Countess";
			var cardStrength = 7;

			//A
			var badCardNameException1 = Assert.Throws<BadCardNameException>(string.Equals(cardGuard.Name, cardName);
			var badStrengthNameException1 = Assert.Throws<BadStrengthNameException>(string.Equals(cardGuard.Strength, cardStrength);

			var badCardNameException2 = Assert.Throws<BadCardNameException>(string.Equals(cardGuard.Name, "Bad name");
			var badStrengthNameException2 = Assert.Throws<BadStrengthNameException>(string.Equals(cardGuard.Strength, 0);

			//A
			Assert.Null(badCardNameException1);
			Assert.Null(badStrengthNameException1);

			Assert.NotNull(badCardNameException2);
			Assert.Equals("The card has the wrong name.", badCardNameException2.Message);

			Assert.NotNull(badStrengthNameException2);
			Assert.Equals("The card has the wrong strength.", badStrengthNameException2.Message);
		}

		[Fact]
		public void CardPrincessHasANameOfPrincessAndAValueOfEight()
		{
			//A
			var cardGuard = new Princess();
			var cardName = "Princess";
			var cardStrength = 8;

			//A
			var badCardNameException1 = Assert.Throws<BadCardNameException>(string.Equals(cardGuard.Name, cardName);
			var badStrengthNameException1 = Assert.Throws<BadStrengthNameException>(string.Equals(cardGuard.Strength, cardStrength);

			var badCardNameException2 = Assert.Throws<BadCardNameException>(string.Equals(cardGuard.Name, "Bad name");
			var badStrengthNameException2 = Assert.Throws<BadStrengthNameException>(string.Equals(cardGuard.Strength, 0);

			//A
			Assert.Null(badCardNameException1);
			Assert.Null(badStrengthNameException1);

			Assert.NotNull(badCardNameException2);
			Assert.Equals("The card has the wrong name.", badCardNameException2.Message);

			Assert.NotNull(badStrengthNameException2);
			Assert.Equals("The card has the wrong strength.", badStrengthNameException2.Message);
		}

		#endregion // Test name/strength of all cards
	}
}
