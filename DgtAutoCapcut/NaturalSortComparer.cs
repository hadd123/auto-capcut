using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DgtAutoCapcut;

public class NaturalSortComparer : IComparer<string>
{
	public int Compare(string x, string y)
	{
		if (x == null && y == null)
		{
			return 0;
		}
		if (x == null)
		{
			return -1;
		}
		if (y == null)
		{
			return 1;
		}
		string[] array = Regex.Split(x, "(\\d+)");
		string[] array2 = Regex.Split(y, "(\\d+)");
		for (int i = 0; i < Math.Min(array.Length, array2.Length); i++)
		{
			int result;
			int result2;
			int num = ((!int.TryParse(array[i], out result) || !int.TryParse(array2[i], out result2)) ? string.Compare(array[i], array2[i], StringComparison.OrdinalIgnoreCase) : result.CompareTo(result2));
			if (num != 0)
			{
				return num;
			}
		}
		return array.Length.CompareTo(array2.Length);
	}
}
