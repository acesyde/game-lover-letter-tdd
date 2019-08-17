using System.Collections.Generic;
using Xunit;

namespace GameLoveLetter.Tests
{
	public class PlayerTest
	{
		[Theory]
		[InlineData(0)]
		[InlineData(1)]
		[InlineData(2)]
		[InlineData(3)]
		public void WhenAPlayerDrawCardsHeGetsAdditionalCardInHisHand(int nbDraws)
		{
			// A
			CardDeck cardDeck = new CardDeck();
			Player player = new Player(cardDeck.DrawACard);

			// A
			for (int i = 0; i < nbDraws; i++)
			{
				player.DrawACard();
			}

			// A
			Assert.Equal(nbDraws, player.Cards.Count);
		}

		[Fact]
		public void WhenAPlayerPlayACardHeLosesACardFromHisHand()
		{
			// A
			CardDeck cardDeck = new CardDeck();
			Player player = new Player(cardDeck.DrawACard);
			player.DrawACard();

			// A
			player.PlayCard();

			// A
			Assert.Empty(player.Cards);
		}
	}
}
