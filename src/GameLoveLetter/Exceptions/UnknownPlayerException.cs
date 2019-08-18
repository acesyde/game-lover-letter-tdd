using System;

namespace GameLoveLetter
{
	internal class UnknownPlayerException : Exception
	{
		public UnknownPlayerException()
			: base("Unknows player.")
		{
		}
	}
}