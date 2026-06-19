using System;
using System.Collections.Generic;
using System.Reflection;

public class _3DABB71E
{
	private readonly Dictionary<string, uint> F7ACCAAD;

	private _281AFA8B _682A4184;

	private Assembly A09400AD(object _7408B2AB, ResolveEventArgs _04921F30)
	{
		return (Assembly)new _02B4022E()._1CBB33BE(new object[3] { this, _7408B2AB, _04921F30 }, 1051901);
	}

	private void _74AFA1BA(ref byte[] _30047731, uint B2AF6DBF)
	{
		while (true)
		{
			int num = 0;
			while (true)
			{
				uint num2 = 1872293819u;
				if (num2 < 813870382)
				{
					break;
				}
				int num3 = num;
				num2 = 1136025743 * num2;
				num2 = 3719154465u % num2;
				byte[] obj = _30047731;
				num2 = 2887324814u % num2;
				int num4 = obj.Length;
				num2 >>= 11;
				if (num3 < num4)
				{
					num2 = 1326912824u;
					if ((int)num2 + -1994504062 == 0)
					{
						break;
					}
					num2 = 0xE727650Fu ^ num2;
					byte[] obj2 = _30047731;
					num2 >>= 9;
					int num5 = num;
					num2 = 1872486193 / num2;
					byte[] obj3 = _30047731;
					int num6 = num;
					num2 *= 1992293027;
					byte num7 = obj3[num6];
					num2 = 4256035076u - num2;
					long num8 = num7;
					num2 = (uint)(1563468307 << (int)num2);
					num2 += 4088551983u;
					long num9 = _84186B01.D8272B81(B2AF6DBF, num);
					int num10 = num;
					num2 = 0x3B45B24 ^ num2;
					long num11 = num10;
					num2 >>= 22;
					byte num12 = (byte)(num8 ^ (num9 + num11));
					num2 = 0xEE0FDF21u | num2;
					obj2[num5] = num12;
					if ((num2 & 0x1C3E49BC) == 0)
					{
						break;
					}
					int num13 = num;
					num2 ^= 0xF888C539u;
					uint num14 = num2 - 377952979;
					num2 >>= 4;
					num = num13 + (int)num14;
					continue;
				}
				return;
			}
		}
	}

	public _3DABB71E()
	{
		new _02B4022E()._1CBB33BE(new object[1] { this }, 1149729);
	}
}
