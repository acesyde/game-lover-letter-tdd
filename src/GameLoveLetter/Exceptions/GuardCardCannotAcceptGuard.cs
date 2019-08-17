using System;
using System.Runtime.Serialization;

namespace GameLoveLetter
{
	public class GuardCardCannotAcceptGuardException : Exception
	{

		public GuardCardCannotAcceptGuardException() 
			: base("The guard card effect can not accept a guard type.")
		{
		}
	}
}