using System;
using System.Runtime.CompilerServices;

[Serializable]
internal struct _82133D85
{
	private readonly int DC91A414;

	private readonly uint[] _27960D3D;

	private static readonly _82133D85 _17062C95 = new _82133D85(-1, new uint[1] { 2147483648u });

	private static readonly _82133D85 _731B833B = new _82133D85(1);

	private static readonly _82133D85 _68BBDD0C = new _82133D85(0);

	private static readonly _82133D85 B9AE0215 = new _82133D85(-1);

	private int FE1E5707 => (DC91A414 >> 31) - (-DC91A414 >> 31);

	internal uint[] _2013C916 => _27960D3D;

	private bool _43BE07B9
	{
		get
		{
			if (_27960D3D != null)
			{
				return (_27960D3D[0] & 1) == 0;
			}
			return (DC91A414 & 1) == 0;
		}
	}

	internal int _1E0F9132 => DC91A414;

	private static _82133D85 _8701B016 => _731B833B;

	internal _82133D85(byte[] F915611A)
	{
		if (F915611A == null)
		{
			throw new ArgumentNullException("value");
		}
		int num = F915611A.Length;
		bool flag = num > 0 && (F915611A[num - 1] & 0x80) == 128;
		while (num > 0 && F915611A[num - 1] == 0)
		{
			num--;
		}
		if (num == 0)
		{
			DC91A414 = 0;
			_27960D3D = null;
			return;
		}
		if (num <= 4)
		{
			if (flag)
			{
				DC91A414 = -1;
			}
			else
			{
				DC91A414 = 0;
			}
			for (int num2 = num - 1; num2 >= 0; num2--)
			{
				DC91A414 <<= 8;
				DC91A414 |= F915611A[num2];
			}
			_27960D3D = null;
			if (DC91A414 < 0 && !flag)
			{
				_27960D3D = new uint[1];
				_27960D3D[0] = (uint)DC91A414;
				DC91A414 = 1;
			}
			if (DC91A414 == int.MinValue)
			{
				this = _17062C95;
			}
			return;
		}
		int num3 = num % 4;
		int num4 = num / 4 + ((num3 != 0) ? 1 : 0);
		bool flag2 = true;
		uint[] array = new uint[num4];
		int num5 = 3;
		int i;
		for (i = 0; i < num4 - ((num3 != 0) ? 1 : 0); i++)
		{
			for (int j = 0; j < 4; j++)
			{
				if (F915611A[num5] != 0)
				{
					flag2 = false;
				}
				array[i] <<= 8;
				array[i] |= F915611A[num5];
				num5--;
			}
			num5 += 8;
		}
		if (num3 != 0)
		{
			if (flag)
			{
				array[num4 - 1] = uint.MaxValue;
			}
			for (num5 = num - 1; num5 >= num - num3; num5--)
			{
				if (F915611A[num5] != 0)
				{
					flag2 = false;
				}
				array[i] <<= 8;
				array[i] |= F915611A[num5];
			}
		}
		if (flag2)
		{
			this = _68BBDD0C;
		}
		else if (flag)
		{
			_4725A184._0DAF2AB7(array);
			int num6 = array.Length;
			while (num6 > 0 && array[num6 - 1] == 0)
			{
				num6--;
			}
			if (num6 == 1 && (int)array[0] > 0)
			{
				if (array[0] == 1)
				{
					this = B9AE0215;
					return;
				}
				if (array[0] == 2147483648u)
				{
					this = _17062C95;
					return;
				}
				DC91A414 = -1 * (int)array[0];
				_27960D3D = null;
			}
			else if (num6 != array.Length)
			{
				DC91A414 = -1;
				_27960D3D = new uint[num6];
				Array.Copy(array, _27960D3D, num6);
			}
			else
			{
				DC91A414 = -1;
				_27960D3D = array;
			}
		}
		else
		{
			DC91A414 = 1;
			_27960D3D = array;
		}
	}

	private static int _6A0D04A4(uint[] DA8D6C00, uint[] _66A8CFA2, int _19189807)
	{
		int num = _19189807;
		while (--num >= 0)
		{
			if (DA8D6C00[num] != _66A8CFA2[num])
			{
				return num + 1;
			}
		}
		return 0;
	}

	public override bool Equals(object A3BA6D2D)
	{
		if (!(A3BA6D2D is _82133D85))
		{
			return false;
		}
		return Equals((_82133D85)A3BA6D2D);
	}

	private static void _281925BA(ref _66981889 _262F3FB0, ref _66981889 ACB5DD9E, ref _66981889 _2A9CB726, ref _66981889 C4182DAB)
	{
		_4725A184.B635478F(ref _262F3FB0, ref C4182DAB);
		_262F3FB0._6186ED31(ref C4182DAB, ref ACB5DD9E);
		_262F3FB0._922BFA12(ref _2A9CB726);
	}

	private static void _94299913(uint D515FD22, ref _66981889 D70A5AB7, ref _66981889 C9B8921A, ref _66981889 _7E270029, ref _66981889 B50D751C)
	{
		for (int i = 0; i < 32; i++)
		{
			if ((D515FD22 & 1) == 1)
			{
				_281925BA(ref D70A5AB7, ref C9B8921A, ref _7E270029, ref B50D751C);
			}
			_632C8208(ref C9B8921A, ref _7E270029, ref B50D751C);
			D515FD22 >>= 1;
		}
	}

	[SpecialName]
	public static bool _4CBD90B5(_82133D85 A0251E92, _82133D85 _001A3B86)
	{
		return A0251E92._9BBD6C0C(_001A3B86) <= 0;
	}

	[SpecialName]
	public static bool D7A8869C(_82133D85 B202061A, _82133D85 _1E2A4B8F)
	{
		return B202061A.Equals(_1E2A4B8F);
	}

	[SpecialName]
	public static bool _491C5403(_82133D85 _9BA461BD, _82133D85 _829A3691)
	{
		return _9BA461BD._9BBD6C0C(_829A3691) < 0;
	}

	[SpecialName]
	public static bool B9A49D9C(_82133D85 _38926091, _82133D85 _310F3409)
	{
		return !_38926091.Equals(_310F3409);
	}

	internal static _82133D85 _26111CB6(_82133D85 _78B50023, _82133D85 F024B9B3, _82133D85 _24027523)
	{
		if (F024B9B3.FE1E5707 < 0)
		{
			throw new ArgumentOutOfRangeException("exponent", "ArgumentOutOfRange must be non negative");
		}
		int C389348A = 1;
		int C389348A2 = 1;
		int C389348A3 = 1;
		bool flag = F024B9B3._43BE07B9;
		_66981889 D70A5AB = new _66981889(_8701B016, ref C389348A);
		_66981889 C9B8921A = new _66981889(_78B50023, ref C389348A2);
		_66981889 _4A380A = new _66981889(_24027523, ref C389348A3);
		_66981889 B50D751C = new _66981889(C9B8921A._2D9E50A0);
		D70A5AB._922BFA12(ref _4A380A);
		if (F024B9B3._27960D3D == null)
		{
			DD010885((uint)F024B9B3.DC91A414, ref D70A5AB, ref C9B8921A, ref _4A380A, ref B50D751C);
		}
		else
		{
			int num = _5D16F794(F024B9B3._27960D3D);
			for (int i = 0; i < num - 1; i++)
			{
				_94299913(F024B9B3._27960D3D[i], ref D70A5AB, ref C9B8921A, ref _4A380A, ref B50D751C);
			}
			DD010885(F024B9B3._27960D3D[num - 1], ref D70A5AB, ref C9B8921A, ref _4A380A, ref B50D751C);
		}
		return D70A5AB.A800CFBB((_78B50023.DC91A414 > 0) ? 1 : (flag ? 1 : (-1)));
	}

	private static void DD010885(uint _1ABA3610, ref _66981889 _3D89B725, ref _66981889 _112AEC1D, ref _66981889 _02B92939, ref _66981889 _4F19EA9F)
	{
		while (_1ABA3610 != 0)
		{
			if ((_1ABA3610 & 1) == 1)
			{
				_281925BA(ref _3D89B725, ref _112AEC1D, ref _02B92939, ref _4F19EA9F);
			}
			if (_1ABA3610 != 1)
			{
				_632C8208(ref _112AEC1D, ref _02B92939, ref _4F19EA9F);
				_1ABA3610 >>= 1;
				continue;
			}
			break;
		}
	}

	private static void _632C8208(ref _66981889 _8E1A659C, ref _66981889 _181C278A, ref _66981889 _1A9D2584)
	{
		_4725A184.B635478F(ref _8E1A659C, ref _1A9D2584);
		_8E1A659C._6186ED31(ref _1A9D2584, ref _1A9D2584);
		_8E1A659C._922BFA12(ref _181C278A);
	}

	internal _82133D85(int CEAABB90, uint[] E52B4D05)
	{
		DC91A414 = CEAABB90;
		_27960D3D = E52B4D05;
	}

	private _82133D85(int E1A73881)
	{
		if (E1A73881 == int.MinValue)
		{
			this = _17062C95;
			return;
		}
		DC91A414 = E1A73881;
		_27960D3D = null;
	}

	internal byte[] _2117A72A()
	{
		if (_27960D3D == null && DC91A414 == 0)
		{
			return new byte[1];
		}
		uint[] array;
		byte b;
		if (_27960D3D == null)
		{
			array = new uint[1] { (uint)DC91A414 };
			b = (byte)((DC91A414 < 0) ? 255u : 0u);
		}
		else if (DC91A414 == -1)
		{
			array = (uint[])_27960D3D.Clone();
			_4725A184._0DAF2AB7(array);
			b = byte.MaxValue;
		}
		else
		{
			array = _27960D3D;
			b = 0;
		}
		byte[] array2 = new byte[checked(4 * array.Length)];
		int num = 0;
		uint[] array3 = array;
		for (int i = 0; i < array3.Length; i++)
		{
			uint num2 = array3[i];
			for (int j = 0; j < 4; j++)
			{
				array2[num++] = (byte)(num2 & 0xFF);
				num2 >>= 8;
			}
		}
		if ((array2[array2.Length - 1] & 0x80) == (b & 0x80))
		{
			return array2;
		}
		byte[] array4 = new byte[array2.Length + 1];
		Array.Copy(array2, array4, array2.Length);
		array4[array4.Length - 1] = b;
		return array4;
	}

	private static int _5D16F794(uint[] ADA0141C)
	{
		int num = ADA0141C.Length;
		if (ADA0141C[num - 1] != 0)
		{
			return num;
		}
		return num - 1;
	}

	public override int GetHashCode()
	{
		if (_27960D3D == null)
		{
			return DC91A414;
		}
		int num = DC91A414;
		int num2 = _5D16F794(_27960D3D);
		while (--num2 >= 0)
		{
			num = _4725A184.BDBD7899(num, (int)_27960D3D[num2]);
		}
		return num;
	}

	[SpecialName]
	public static bool _7A25A8AC(_82133D85 _629C26AD, _82133D85 D99C5112)
	{
		return _629C26AD._9BBD6C0C(D99C5112) > 0;
	}

	[SpecialName]
	public static bool _62080421(_82133D85 _34039CB9, _82133D85 _3611E188)
	{
		return _34039CB9._9BBD6C0C(_3611E188) >= 0;
	}

	private int _9BBD6C0C(_82133D85 DEBDFAA4)
	{
		if ((DC91A414 ^ DEBDFAA4.DC91A414) < 0)
		{
			if (DC91A414 >= 0)
			{
				return 1;
			}
			return -1;
		}
		if (_27960D3D == null)
		{
			if (DEBDFAA4._27960D3D == null)
			{
				if (DC91A414 >= DEBDFAA4.DC91A414)
				{
					if (DC91A414 <= DEBDFAA4.DC91A414)
					{
						return 0;
					}
					return 1;
				}
				return -1;
			}
			return -DEBDFAA4.DC91A414;
		}
		int num;
		int num2;
		if (DEBDFAA4._27960D3D == null || (num = _5D16F794(_27960D3D)) > (num2 = _5D16F794(DEBDFAA4._27960D3D)))
		{
			return DC91A414;
		}
		if (num < num2)
		{
			return -DC91A414;
		}
		int num3 = _6A0D04A4(_27960D3D, DEBDFAA4._27960D3D, num);
		if (num3 == 0)
		{
			return 0;
		}
		if (_27960D3D[num3 - 1] >= DEBDFAA4._27960D3D[num3 - 1])
		{
			return DC91A414;
		}
		return -DC91A414;
	}

	private void _8281FC32()
	{
		if (_27960D3D != null)
		{
			_5D16F794(_27960D3D);
			_ = 1;
		}
	}
}
