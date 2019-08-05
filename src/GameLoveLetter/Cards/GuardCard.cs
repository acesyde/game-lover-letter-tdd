using System;

namespace GameLoveLetter
{
	public class GuardCard : Card
	{
		public GuardCard() 
			: base(1)
		{
		}

		public bool Effect(Type type, Card card)
		{
			if (type == typeof(GuardCard))
			{
				throw new GuardCardCannotAcceptGuard();
			}

			return (type == card.GetType());
		}
	}
}
