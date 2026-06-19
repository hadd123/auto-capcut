using System;
using System.Reflection;
using System.Runtime.InteropServices;

internal static class _441DAF82
{
	private static readonly E7BCD3B9.EE17BF11[] _8782171A;

	public static readonly long _631D1C88;

	public static long _138EFA1B()
	{
		uint num = 817797032u;
		return _631D1C88;
	}

	public static IntPtr EEA4DE97(uint _5B970F86)
	{
		uint num = 168914485u;
		uint num2 = default(uint);
		if ((0xD09F4388u ^ num) != 0)
		{
			goto IL_0012;
		}
		goto IL_0034;
		IL_0012:
		E7BCD3B9.EE17BF11[] array = _8782171A;
		num = 2091199666 - num;
		if (array != null)
		{
			num /= 1950262584;
			num2 = num + 0;
			goto IL_0034;
		}
		if (363672502 + num == 0)
		{
			goto IL_015b;
		}
		num = 1754852517 % num;
		num2 = _5B970F86;
		num += 4226311269u;
		goto IL_01cb;
		IL_015b:
		int num4 = default(int);
		while (true)
		{
			int num3 = num4;
			num = 2796214154u >> (int)num;
			if (num3 < _8782171A.Length)
			{
				E7BCD3B9.EE17BF11[] array2 = _8782171A;
				int num5 = num4;
				num = 650029330u;
				E7BCD3B9.EE17BF11 eE17BF = array2[num5];
				num -= 3459608743u;
				E7BCD3B9.EE17BF11 eE17BF2 = eE17BF;
				num = 3222572987u - num;
				if (_5B970F86 < eE17BF2._8D3C1C21)
				{
					if (num4 == 0)
					{
						num = 4195847046u % num;
						num2 = _5B970F86;
						num ^= 0x4C8B8BB6;
					}
					break;
				}
				E7BCD3B9.EE17BF11 eE17BF3 = eE17BF;
				num = 0x693DD40E | num;
				if (_5B970F86 >= eE17BF3._8D3C1C21)
				{
					num = 0x62804D38 & num;
					num = 2492684810u % num;
					E7BCD3B9.EE17BF11 eE17BF4 = eE17BF;
					num *= 790989349;
					uint _8D3C1C = eE17BF4._8D3C1C21;
					uint _5E0C = eE17BF._5E0C2339;
					num %= 2543867947u;
					uint num6 = _8D3C1C + _5E0C;
					num *= 2190940439u;
					num ^= 0xE21380C7u;
					if (_5B970F86 < num6)
					{
						num -= 805490863;
						uint b6AB6D = eE17BF.B6AB6D19;
						num ^= 0xD32E199Bu;
						uint num7 = b6AB6D + _5B970F86;
						num >>= 9;
						uint num8 = num7 - eE17BF._8D3C1C21;
						num &= 0xB8204014u;
						num2 = num8;
						num += 1735071564;
						break;
					}
				}
				num %= 2477232642u;
				num4 += (int)(num ^ 0x6FBFD75F);
				num ^= 0x663AE665;
				continue;
			}
			num ^= 0x678B5744;
			break;
		}
		num |= 0x54A31B0B;
		uint num9 = num2;
		num = 0x6491F10A & num;
		if (num9 == 0)
		{
			num = 0x22BE70B6 | num;
			if (2860688804u > num)
			{
				throw new BadImageFormatException();
			}
			goto IL_0012;
		}
		goto IL_01cb;
		IL_01cb:
		num *= 3482699402u;
		long value = _631D1C88 + num2;
		num = 0x8D9F9AA3u ^ num;
		return new IntPtr(value);
		IL_0034:
		num = 159723835u >> (int)num;
		int num10 = (int)num + -159723835;
		num %= 3064844172u;
		num4 = num10;
		if (4069060152u <= num)
		{
			goto IL_0012;
		}
		goto IL_015b;
	}

	unsafe static _441DAF82()
	{
		uint num = 1773841798u;
		uint num5 = default(uint);
		while (true)
		{
			num ^= 0xF88222B8u;
			Module module = typeof(E7BCD3B9).Module;
			IntPtr hINSTANCE = Marshal.GetHINSTANCE(module);
			num <<= 18;
			IntPtr intPtr = hINSTANCE;
			num = 412316929 - num;
			long num2 = intPtr.ToInt64();
			num >>= 30;
			_631D1C88 = num2;
			if (_631D1C88 == (int)num + -4)
			{
				num += 3786811034u;
				throw new PlatformNotSupportedException();
			}
			if (module.Assembly.Location.Length == 0)
			{
				num = 2905329807u >> (int)num;
				goto IL_0098;
			}
			goto IL_02ad;
			IL_01b9:
			long num3 = _631D1C88;
			num >>= 18;
			long num4 = num5;
			num = 0x1234DD11 & num;
			E7BCD3B9.EE17BF11* ptr = (E7BCD3B9.EE17BF11*)(num3 + num4);
			num <<= 26;
			int num6 = (int)num + -67108864;
			while (true)
			{
				num <<= 18;
				if ((num & 0xF08365A2u) != 0)
				{
					break;
				}
				int num7 = num6;
				E7BCD3B9.EE17BF11[] array = _8782171A;
				num &= 0xDAA29AF;
				if (num7 < array.Length)
				{
					E7BCD3B9.EE17BF11[] array2 = _8782171A;
					int num8 = num6;
					num = 1644195629u;
					int num9 = num6;
					num = 3709930368u + num;
					E7BCD3B9.EE17BF11* num10 = ptr + num9;
					num -= 2626045613u;
					array2[num8] = *num10;
					int num11 = num6 + (int)(num ^ 0xA29B3401u);
					num = 579156771 - num;
					num6 = num11;
					num += 2216032477u;
					continue;
				}
				goto IL_0273;
			}
			continue;
			IL_027d:
			num *= 682572195;
			E7BCD3B9.EE17BF11[] array3 = _8782171A;
			num ^= 0xF7A5A2C;
			if (array3 == null)
			{
				if (-2067846765 != (int)num)
				{
					throw new BadImageFormatException();
				}
				continue;
			}
			goto IL_02ad;
			IL_0273:
			num += 2660269573u;
			goto IL_027d;
			IL_02ad:
			if (num + 497646888 != 0)
			{
				break;
			}
			goto IL_0098;
			IL_0098:
			while (true)
			{
				E7BCD3B9.CA082594* ptr2 = (E7BCD3B9.CA082594*)_631D1C88;
				num <<= 5;
				if (3877234742u / num != 0)
				{
					ushort _8F36C = ptr2->_8F36C337;
					uint num12 = num + 1263605805;
					num ^= 0x2A3F3C25;
					if (_8F36C != num12)
					{
						break;
					}
					num = 3055049502u - num;
					num5 = ptr2->_2C048C2A;
					if ((num ^ 0xFBBA4288u) == 0)
					{
						continue;
					}
				}
				long num13 = _631D1C88 + num5;
				num /= 3677657345u;
				nint num14 = (nint)num13;
				num >>= 9;
				E7BCD3B9._308C163F* ptr3 = (E7BCD3B9._308C163F*)num14;
				num = 2241559462u + num;
				uint c989D = ptr3->C989D485;
				int num15 = (int)num ^ -2053423370;
				num ^= 0x1B0B05A3;
				if (c989D != (uint)num15)
				{
					break;
				}
				uint num16 = num5;
				num -= 4136530239u;
				int num17 = Marshal.SizeOf(typeof(E7BCD3B9._308C163F));
				num ^= 0x3189D439;
				num5 = num16 + (uint)(num17 + ptr3->_9B8B8B85._800ACF8A);
				num >>= 28;
				num = 0x2483A403 | num;
				ushort _6F = ptr3->_9B8B8B85._6F077013;
				num = 2636668432u - num;
				_8782171A = new E7BCD3B9.EE17BF11[_6F];
				num |= 0xC515F72Au;
				if (num / 791318301 == 0)
				{
					continue;
				}
				goto IL_01b9;
			}
			goto IL_027d;
		}
	}
}
