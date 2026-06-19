using System;

internal struct _66981889
{
	private int F9190936;

	private uint _48138433;

	private uint[] _048A673E;

	private bool AA03930F;

	private int _15B1B306
	{
		get
		{
			int num = 0;
			for (int num2 = F9190936; num2 >= 0; num2--)
			{
				if (_048A673E[num2] != 0)
				{
					num++;
				}
			}
			return num;
		}
	}

	internal int _2D9E50A0 => F9190936 + 1;

	private void F9B67914(int _0B182528)
	{
		if (_0B182528 <= 1)
		{
			F9190936 = 0;
			_48138433 = 0u;
			return;
		}
		if (!AA03930F || _048A673E.Length < _0B182528)
		{
			_048A673E = new uint[_0B182528];
			AA03930F = true;
		}
		else
		{
			Array.Clear(_048A673E, 0, _0B182528);
		}
		F9190936 = _0B182528 - 1;
	}

	private static uint C6084193(ref _66981889 _059A1FA3, uint C4BD7FB6)
	{
		if (C4BD7FB6 == 1)
		{
			return 0u;
		}
		if (_059A1FA3.F9190936 == 0)
		{
			return _059A1FA3._48138433 % C4BD7FB6;
		}
		ulong num = 0uL;
		for (int num2 = _059A1FA3.F9190936; num2 >= 0; num2--)
		{
			num = _4725A184._4C94CF1E((uint)num, _059A1FA3._048A673E[num2]);
			num %= C4BD7FB6;
		}
		return (uint)num;
	}

	internal _66981889(int _0F9837B6)
	{
		F9190936 = 0;
		_48138433 = 0u;
		if (_0F9837B6 > 1)
		{
			_048A673E = new uint[_0F9837B6];
			AA03930F = true;
		}
		else
		{
			_048A673E = null;
			AA03930F = false;
		}
	}

	internal void _922BFA12(ref _66981889 _4A380A19)
	{
		if (_4A380A19.F9190936 == 0)
		{
			AE137A10(C6084193(ref this, _4A380A19._48138433));
		}
		else if (F9190936 != 0)
		{
			_66981889 DEB7910B = default(_66981889);
			_14B0BB11(ref this, ref _4A380A19, _23932091: false, ref DEB7910B);
		}
	}

	private void _6912C691(int C6B2D635)
	{
		if (C6B2D635 <= 1)
		{
			F9190936 = 0;
			return;
		}
		if (!AA03930F || _048A673E.Length < C6B2D635)
		{
			_048A673E = new uint[C6B2D635];
			AA03930F = true;
		}
		F9190936 = C6B2D635 - 1;
	}

	private static uint _33261AAB(ref uint _6B07CD04, uint C70CD495, uint _7F1D78A3)
	{
		ulong num = (ulong)((long)_6B07CD04 * (long)C70CD495 + _7F1D78A3);
		_6B07CD04 = (uint)num;
		return (uint)(num >> 32);
	}

	private void AE137A10(uint _740BF40D)
	{
		_48138433 = _740BF40D;
		F9190936 = 0;
	}

	internal _82133D85 A800CFBB(int C738EF24)
	{
		_001BB02A(C738EF24, out C738EF24, out var D497FB);
		return new _82133D85(C738EF24, D497FB);
	}

	private void _9001FFA0(uint _653BBA97)
	{
		switch (_653BBA97)
		{
		case 0u:
			AE137A10(0u);
			return;
		case 1u:
			return;
		}
		if (F9190936 == 0)
		{
			_15BB7838((ulong)_48138433 * (ulong)_653BBA97);
			return;
		}
		_168390A6(1);
		uint num = 0u;
		for (int i = 0; i <= F9190936; i++)
		{
			num = _33261AAB(ref _048A673E[i], _653BBA97, num);
		}
		if (num != 0)
		{
			_130D7035(F9190936 + 2, 0);
			_048A673E[F9190936] = num;
		}
	}

	private void _130D7035(int _6FB2EE84, int _7BB46A24)
	{
		if (_6FB2EE84 <= 1)
		{
			if (F9190936 > 0)
			{
				_48138433 = _048A673E[0];
			}
			F9190936 = 0;
			return;
		}
		if (!AA03930F || _048A673E.Length < _6FB2EE84)
		{
			uint[] array = new uint[_6FB2EE84 + _7BB46A24];
			if (F9190936 == 0)
			{
				array[0] = _48138433;
			}
			else
			{
				Array.Copy(_048A673E, array, Math.Min(_6FB2EE84, F9190936 + 1));
			}
			_048A673E = array;
			AA03930F = true;
		}
		else if (F9190936 + 1 < _6FB2EE84)
		{
			Array.Clear(_048A673E, F9190936 + 1, _6FB2EE84 - F9190936 - 1);
			if (F9190936 == 0)
			{
				_048A673E[0] = _48138433;
			}
		}
		F9190936 = _6FB2EE84 - 1;
	}

	private void _15BB7838(ulong _32ABDCA8)
	{
		uint num = _4725A184._03070C21(_32ABDCA8);
		if (num == 0)
		{
			_48138433 = _4725A184._1D95250E(_32ABDCA8);
			F9190936 = 0;
		}
		else
		{
			_6912C691(2);
			_048A673E[0] = (uint)_32ABDCA8;
			_048A673E[1] = num;
		}
	}

	private void _001BB02A(int _93101C24, out int _9AB9ACBD, out uint[] D497FB26)
	{
		if (F9190936 == 0)
		{
			if (_48138433 <= int.MaxValue)
			{
				_9AB9ACBD = _93101C24 * (int)_48138433;
				D497FB26 = null;
				return;
			}
			if (_048A673E == null)
			{
				_048A673E = new uint[1] { _48138433 };
			}
			else if (AA03930F)
			{
				_048A673E[0] = _48138433;
			}
			else if (_048A673E[0] != _48138433)
			{
				_048A673E = new uint[1] { _48138433 };
			}
		}
		_9AB9ACBD = _93101C24;
		int num = _048A673E.Length - F9190936 - 1;
		if (num <= 1)
		{
			if (num == 0 || _048A673E[F9190936 + 1] == 0)
			{
				AA03930F = false;
				D497FB26 = _048A673E;
				return;
			}
			if (AA03930F)
			{
				_048A673E[F9190936 + 1] = 0u;
				AA03930F = false;
				D497FB26 = _048A673E;
				return;
			}
		}
		D497FB26 = _048A673E;
		Array.Resize(ref D497FB26, F9190936 + 1);
		if (!AA03930F)
		{
			_048A673E = D497FB26;
		}
	}

	private void F3234ABB(ref _66981889 E20EEEAC, int A7339C33)
	{
		if (E20EEEAC.F9190936 == 0)
		{
			_48138433 = E20EEEAC._48138433;
			F9190936 = 0;
			return;
		}
		if (!AA03930F || _048A673E.Length <= E20EEEAC.F9190936)
		{
			_048A673E = new uint[E20EEEAC.F9190936 + 1 + A7339C33];
			AA03930F = true;
		}
		F9190936 = E20EEEAC.F9190936;
		Array.Copy(E20EEEAC._048A673E, _048A673E, F9190936 + 1);
	}

	private static void _14B0BB11(ref _66981889 _7934F512, ref _66981889 _41847B22, bool _23932091, ref _66981889 DEB7910B)
	{
		DEB7910B.AE137A10(0u);
		if (_7934F512.F9190936 < _41847B22.F9190936)
		{
			return;
		}
		int num = _41847B22.F9190936 + 1;
		int num2 = _7934F512.F9190936 - _41847B22.F9190936;
		int num3 = num2;
		int num4 = _7934F512.F9190936;
		while (true)
		{
			if (num4 < num2)
			{
				num3++;
				break;
			}
			if (_41847B22._048A673E[num4 - num2] != _7934F512._048A673E[num4])
			{
				if (_41847B22._048A673E[num4 - num2] < _7934F512._048A673E[num4])
				{
					num3++;
				}
				break;
			}
			num4--;
		}
		if (num3 == 0)
		{
			return;
		}
		if (_23932091)
		{
			DEB7910B._6912C691(num3);
		}
		uint num5 = _41847B22._048A673E[num - 1];
		uint num6 = _41847B22._048A673E[num - 2];
		int num7 = _4725A184._492AF193(num5);
		int num8 = 32 - num7;
		if (num7 > 0)
		{
			num5 = (num5 << num7) | (num6 >> num8);
			num6 <<= num7;
			if (num > 2)
			{
				num6 |= _41847B22._048A673E[num - 3] >> num8;
			}
		}
		_7934F512._168390A6();
		int num9 = num3;
		while (--num9 >= 0)
		{
			uint num10 = ((num9 + num <= _7934F512.F9190936) ? _7934F512._048A673E[num9 + num] : 0u);
			ulong num11 = _4725A184._4C94CF1E(num10, _7934F512._048A673E[num9 + num - 1]);
			uint num12 = _7934F512._048A673E[num9 + num - 2];
			if (num7 > 0)
			{
				num11 = (num11 << num7) | (num12 >> num8);
				num12 <<= num7;
				if (num9 + num >= 3)
				{
					num12 |= _7934F512._048A673E[num9 + num - 3] >> num8;
				}
			}
			ulong num13 = num11 / num5;
			ulong num14 = (uint)(num11 % num5);
			if (num13 > uint.MaxValue)
			{
				num14 += num5 * (num13 - uint.MaxValue);
				num13 = 4294967295uL;
			}
			for (; num14 <= uint.MaxValue && num13 * num6 > _4725A184._4C94CF1E((uint)num14, num12); num14 += num5)
			{
				num13--;
			}
			if (num13 != 0)
			{
				ulong num15 = 0uL;
				for (int i = 0; i < num; i++)
				{
					num15 += _41847B22._048A673E[i] * num13;
					uint num16 = (uint)num15;
					num15 >>= 32;
					if (_7934F512._048A673E[num9 + i] < num16)
					{
						num15++;
					}
					_7934F512._048A673E[num9 + i] -= num16;
				}
				if (num10 < num15)
				{
					uint c51C2ABA = 0u;
					for (int j = 0; j < num; j++)
					{
						c51C2ABA = _5C0CAFBC(ref _7934F512._048A673E[num9 + j], _41847B22._048A673E[j], c51C2ABA);
					}
					num13--;
				}
				_7934F512.F9190936 = num9 + num - 1;
			}
			if (_23932091)
			{
				if (num3 == 1)
				{
					DEB7910B._48138433 = (uint)num13;
				}
				else
				{
					DEB7910B._048A673E[num9] = (uint)num13;
				}
			}
		}
		_7934F512.F9190936 = num - 1;
		_7934F512._989C5D23();
	}

	private static uint _63166DBF(ref uint BE1D4BAE, uint _8D37119E, uint _9EA3508D, uint A28642B1)
	{
		ulong num = (ulong)((long)_8D37119E * (long)_9EA3508D + BE1D4BAE + A28642B1);
		BE1D4BAE = (uint)num;
		return (uint)(num >> 32);
	}

	private void _168390A6(int _969BB734 = 0)
	{
		if (!AA03930F)
		{
			uint[] destinationArray = new uint[F9190936 + 1 + _969BB734];
			Array.Copy(_048A673E, destinationArray, F9190936 + 1);
			_048A673E = destinationArray;
			AA03930F = true;
		}
	}

	private static uint _5C0CAFBC(ref uint CD31779D, uint _95A37CB7, uint C51C2ABA)
	{
		ulong num = (ulong)((long)CD31779D + (long)_95A37CB7 + C51C2ABA);
		CD31779D = (uint)num;
		return (uint)(num >> 32);
	}

	internal void _6186ED31(ref _66981889 EA0CFFB2, ref _66981889 A0973704)
	{
		if (EA0CFFB2.F9190936 == 0)
		{
			if (A0973704.F9190936 == 0)
			{
				_15BB7838((ulong)EA0CFFB2._48138433 * (ulong)A0973704._48138433);
				return;
			}
			F3234ABB(ref A0973704, 1);
			_9001FFA0(EA0CFFB2._48138433);
			return;
		}
		if (A0973704.F9190936 == 0)
		{
			F3234ABB(ref EA0CFFB2, 1);
			_9001FFA0(A0973704._48138433);
			return;
		}
		F9B67914(EA0CFFB2.F9190936 + A0973704.F9190936 + 2);
		uint[] array;
		int num;
		uint[] array2;
		int num2;
		if (EA0CFFB2._15B1B306 <= A0973704._15B1B306)
		{
			array = EA0CFFB2._048A673E;
			num = EA0CFFB2.F9190936 + 1;
			array2 = A0973704._048A673E;
			num2 = A0973704.F9190936 + 1;
		}
		else
		{
			array = A0973704._048A673E;
			num = A0973704.F9190936 + 1;
			array2 = EA0CFFB2._048A673E;
			num2 = EA0CFFB2.F9190936 + 1;
		}
		for (int i = 0; i < num; i++)
		{
			uint num3 = array[i];
			if (num3 != 0)
			{
				uint num4 = 0u;
				int num5 = i;
				int num6 = 0;
				while (num6 < num2)
				{
					num4 = _63166DBF(ref _048A673E[num5], num3, array2[num6], num4);
					num6++;
					num5++;
				}
				while (num4 != 0)
				{
					num4 = _5C0CAFBC(ref _048A673E[num5++], 0u, num4);
				}
			}
		}
		_989C5D23();
	}

	private void _989C5D23()
	{
		if (F9190936 > 0 && _048A673E[F9190936] == 0)
		{
			_48138433 = _048A673E[0];
			while (--F9190936 > 0 && _048A673E[F9190936] == 0)
			{
			}
		}
	}

	internal _66981889(_82133D85 _2438072B, ref int C389348A)
	{
		AA03930F = false;
		_048A673E = _2438072B._2013C916;
		int num = _2438072B._1E0F9132;
		int num2 = num >> 31;
		C389348A = (C389348A ^ num2) - num2;
		if (_048A673E == null)
		{
			F9190936 = 0;
			_48138433 = (uint)((num ^ num2) - num2);
			return;
		}
		F9190936 = _048A673E.Length - 1;
		_48138433 = _048A673E[0];
		while (F9190936 > 0 && _048A673E[F9190936] == 0)
		{
			F9190936--;
		}
	}

	private void F7BFB316(bool _988CEF83)
	{
		_ = F9190936;
		_ = 0;
	}
}
