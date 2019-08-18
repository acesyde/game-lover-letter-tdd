using System;

namespace GameLoveLetter
{
	public class GuardCardCannotAcceptGuardCardException : Exception
	{

		public GuardCardCannotAcceptGuardCardException() 
			: base("The guard card effect can not accept a guard type.")
		{
		}
	}
}