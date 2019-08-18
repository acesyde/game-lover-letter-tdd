using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLoveLetter
{
	public static class EnumerableExtensions
	{
		public static IEnumerable<T> ShuffleExtension<T>(this IEnumerable<T> enumerable)
		{
			var r = new Random();
			return enumerable.OrderBy(x => r.Next()).ToList();
		}

	}
}
