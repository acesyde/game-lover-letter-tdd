using System;
using System.Runtime.Serialization;

namespace GameLoveLetter
{
	public class GuardCardCannotAcceptGuard : Exception
	{

		public GuardCardCannotAcceptGuard() 
			: base("The guard card effect can not accept a guard type.")
		{
		}
	}
}