using System.Runtime.InteropServices;

public static class _54AB9010
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _9A145A14();

	public static object[] F3A26AB3;

	internal static bool _9C8C2DB1(byte[] F431BF8E)
	{
		for (int i = 0; i < F431BF8E.Length; i++)
		{
			if (i + 3 < F431BF8E.Length && F431BF8E[i] == 81 && F431BF8E[i + 1] == 69 && F431BF8E[i + 2] == 77 && F431BF8E[i + 3] == 85)
			{
				return true;
			}
			if (i + 8 < F431BF8E.Length && F431BF8E[i] == 77 && F431BF8E[i + 1] == 105 && F431BF8E[i + 2] == 99 && F431BF8E[i + 3] == 114 && F431BF8E[i + 4] == 111 && F431BF8E[i + 5] == 115 && F431BF8E[i + 6] == 111 && F431BF8E[i + 7] == 102 && F431BF8E[i + 8] == 116)
			{
				return true;
			}
			if (i + 6 < F431BF8E.Length && F431BF8E[i] == 105 && F431BF8E[i + 1] == 110 && F431BF8E[i + 2] == 110 && F431BF8E[i + 3] == 111 && F431BF8E[i + 4] == 116 && F431BF8E[i + 5] == 101 && F431BF8E[i + 6] == 107)
			{
				return true;
			}
			if (i + 9 < F431BF8E.Length && F431BF8E[i] == 86 && F431BF8E[i + 1] == 105 && F431BF8E[i + 2] == 114 && F431BF8E[i + 3] == 116 && F431BF8E[i + 4] == 117 && F431BF8E[i + 5] == 97 && F431BF8E[i + 6] == 108 && F431BF8E[i + 7] == 66 && F431BF8E[i + 8] == 111 && F431BF8E[i + 9] == 120)
			{
				return true;
			}
			if (i + 5 < F431BF8E.Length && F431BF8E[i] == 86 && F431BF8E[i + 1] == 77 && F431BF8E[i + 2] == 119 && F431BF8E[i + 3] == 97 && F431BF8E[i + 4] == 114 && F431BF8E[i + 5] == 101)
			{
				return true;
			}
			if (i + 8 < F431BF8E.Length && F431BF8E[i] == 80 && F431BF8E[i + 1] == 97 && F431BF8E[i + 2] == 114 && F431BF8E[i + 3] == 97 && F431BF8E[i + 4] == 108 && F431BF8E[i + 5] == 108 && F431BF8E[i + 6] == 101 && F431BF8E[i + 7] == 108 && F431BF8E[i + 8] == 115)
			{
				return true;
			}
		}
		return false;
	}
}
