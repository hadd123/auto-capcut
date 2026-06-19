using System;

internal static class _4725A184
{
	internal static int _492AF193(uint _81AA830E)
	{
		if (_81AA830E == 0)
		{
			return 32;
		}
		int num = 0;
		if ((_81AA830E & 0xFFFF0000u) == 0)
		{
			num += 16;
			_81AA830E <<= 16;
		}
		if ((_81AA830E & 0xFF000000u) == 0)
		{
			num += 8;
			_81AA830E <<= 8;
		}
		if ((_81AA830E & 0xF0000000u) == 0)
		{
			num += 4;
			_81AA830E <<= 4;
		}
		if ((_81AA830E & 0xC0000000u) == 0)
		{
			num += 2;
			_81AA830E <<= 2;
		}
		if ((_81AA830E & 0x80000000u) == 0)
		{
			num++;
		}
		return num;
	}

	internal static int BDBD7899(int C103A92E, int EC23E5BE)
	{
		return (int)_5D9723BB((uint)C103A92E, (uint)EC23E5BE);
	}

	internal static uint _03070C21(ulong _1C8554B7)
	{
		return (uint)(_1C8554B7 >> 32);
	}

	internal static ulong _4C94CF1E(uint _319055A0, uint _7F886129)
	{
		return ((ulong)_319055A0 << 32) | _7F886129;
	}

	internal static void B635478F<_08A2FF8A>(ref _08A2FF8A _913636A8, ref _08A2FF8A _6AADDAB7)
	{
		_08A2FF8A val = _913636A8;
		_913636A8 = _6AADDAB7;
		_6AADDAB7 = val;
	}

	internal static uint _1D95250E(ulong _62230E29)
	{
		return (uint)_62230E29;
	}

	private static uint[] _4210FC02(uint[] _4534022F, int _18B02D29)
	{
		if (_4534022F.Length == _18B02D29)
		{
			return _4534022F;
		}
		uint[] array = new uint[_18B02D29];
		int num = Math.Min(_4534022F.Length, _18B02D29);
		for (int i = 0; i < num; i++)
		{
			array[i] = _4534022F[i];
		}
		return array;
	}

	private static uint _5D9723BB(uint _6FB04436, uint E51C7BBD)
	{
		return ((_6FB04436 << 7) | (_6FB04436 >> 25)) ^ E51C7BBD;
	}

	internal static void _0DAF2AB7(uint[] F4075588)
	{
		int i = 0;
		uint num = 0u;
		for (; i < F4075588.Length; i++)
		{
			num = (F4075588[i] = ~F4075588[i] + 1);
			if (num != 0)
			{
				i++;
				break;
			}
		}
		if (num != 0)
		{
			for (; i < F4075588.Length; i++)
			{
				F4075588[i] = ~F4075588[i];
			}
		}
		else
		{
			F4075588 = _4210FC02(F4075588, F4075588.Length + 1);
			F4075588[F4075588.Length - 1] = 1u;
		}
	}
}
