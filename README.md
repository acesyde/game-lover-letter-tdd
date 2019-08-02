# Love Letter

## Goal
- A party can have one or more turns
- Turn is winning by the last player alive or by the player who has the highest card score

## Cards

|Card|Number in deck|Strength|Effects|
|-|-|-|-|
|Guard|5|1|Player designates another player and names a type of card. If that player's hand matches the type of card specified, that player is eliminated from the round. However, Guard cannot be named as the type of card|
|Priest|2|2|Player is allowed to see another player's hand|
|Baron|2|3|Player will choose another player and privately compare hands. The player with the lower-strength hand is eliminated from the round|
|Handmaid|2|4|Player cannot be affected by any other play's card until the next turn|
|Prince|2|5|Player can choose any player (including themself) to discard their hand and draw a new one. If the discarded card is the Princess, the discarding player is eliminated|
|King|1|6|Player trades hands with any other player|
|Countess|1|7|If a player holds both this card and either the King or Prince card, this card must be played immediately|
|Princess|1|8|If a player plays this card for any reason, they are eliminated from the turn|

## Rules

### Players

- Party can have at least two players
- Party can have at most four players

### Party

- One card is discarded face-down
- One card is dealt to each player
- Rest of cards are desposited face-down into a deck in the middle of players
- The game ends when one player has won a predetermined number of turns

### Turn

- Each player's turn he or she draws one card from the deck and plays either that card or the card they already had
- After processing the effect described on the discarded card the next player gets a turn

## Howto

- Create a new branch from master branch named `{yourname}`
- Develop the game with Test Driven Development method

## Links

- [Wikipedia](https://en.wikipedia.org/wiki/Love_Letter_(card_game))
- [TDD](https://putaindecode.io/articles/se-lancer-dans-le-tdd/)
- [xUnit](https://docs.microsoft.com/fr-fr/dotnet/core/testing/unit-testing-with-dotnet-test)
