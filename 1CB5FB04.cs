using System;

public static class _1CB5FB04
{
	private static uint[] _1B1FF806;

	public unsafe static uint _9A199933(IntPtr FDB89D91, uint _22A7A110)
	{
		while (true)
		{
			uint num = 3221624964u;
			uint num2 = 0u;
			num += 3376059905u;
			if (2778392733u < num)
			{
				continue;
			}
			num = 1562387336 % num;
			void* intPtr = FDB89D91.ToPointer();
			num ^= 0x910E8B1Eu;
			byte* ptr = (byte*)intPtr;
			while (true)
			{
				num &= 0x4237E222;
				int num3 = (int)(num ^ 0x4026A002);
				if (3921109018u >= num)
				{
				}
				while (true)
				{
					int num4 = num3;
					num *= 814691478;
					long num5 = num4;
					num /= 4154482615u;
					if (num5 < _22A7A110)
					{
						num = 1965376809u;
						if ((num ^ 0x6584BF26) == 0)
						{
							break;
						}
						uint[] array = _1B1FF806;
						num = 1099899293 - num;
						byte* num6 = ptr + num3;
						num = 2290122413u * num;
						byte num7 = *num6;
						uint num8 = num2;
						num <<= 22;
						uint num9 = num7 ^ num8;
						num = 0x53AE1995 | num;
						int num10 = (int)num - -609347434;
						num &= 0xC1260EABu;
						uint num11 = array[num9 & (uint)num10];
						num *= 3979115674u;
						uint num12 = num2;
						int num13 = (int)num - -2144626286;
						num = 3644522769u >> (int)num;
						uint num14 = num12 >> num13;
						num = 1319983773 * num;
						num2 = num11 ^ num14;
						num -= 3971510168u;
						if (-358074481 + (int)num == 0)
						{
							goto end_IL_0033;
						}
						int num15 = num3;
						int num16 = (int)num ^ -1411863161;
						num -= 847694517;
						num3 = num15 + num16;
						num ^= 0x397742D3;
						continue;
					}
					num -= 3146453413u;
					return ~num2;
				}
				continue;
				end_IL_0033:
				break;
			}
		}
	}

	static _1CB5FB04()
	{
		while (true)
		{
			uint num = 2460891658u;
			int num2 = (int)num ^ -1834075382;
			num = 0x3999900 & num;
			uint[] array = new uint[num2];
			num -= 4220014855u;
			_1B1FF806 = array;
			while (true)
			{
				IL_0027:
				uint num3 = num - 117425913;
				num /= 1495734024;
				int num4 = (int)num3;
				if (-1430376185 + (int)num == 0)
				{
					break;
				}
				while (num << 31 == 0)
				{
					int num5 = num4;
					uint[] array2 = _1B1FF806;
					num = 2978806837u >> (int)num;
					if (num5 < array2.Length)
					{
						num = 2349129016u;
						int num6 = num4;
						num |= 0x1E03BEB3;
						uint num7 = (uint)num6;
						num %= 303532954;
						uint num8 = num ^ 0xD4BA2EB;
						num |= 0xA020F53Fu;
						int num9 = (int)num8;
						if (1771500989 > num)
						{
							break;
						}
						while (true)
						{
							if (num9 < (int)num - -1385433097)
							{
								uint num10 = num7 & 1;
								num = 2763649037u;
								if (num10 == num + 1531318260)
								{
									if (num << 29 == 0)
									{
										goto IL_0027;
									}
									uint num11 = num7;
									num += 2343750018u;
									uint num12 = num11 >> (int)(num - 812431758);
									int num13 = (int)num + -1119106671;
									num = 0xB31C7DA6u & num;
									num7 = num12 ^ (uint)num13;
									if (3861169467u < num)
									{
										break;
									}
								}
								else
								{
									num7 >>= (int)num - -1531318260;
									num += 2337425785u;
								}
								int num14 = num9;
								num = 4147126704u + num;
								uint num15 = num ^ 0x273C5B37;
								num = 0x40972539 & num;
								int num16 = num14 + (int)num15;
								num >>= 21;
								num9 = num16;
								num ^= 0xAD6BF7FFu;
								continue;
							}
							uint[] array3 = _1B1FF806;
							num = 1369941924u >> (int)num;
							int num17 = num4;
							num = 3535087754u - num;
							uint num18 = num7;
							num = 614947210 + num;
							array3[num17] = num18;
							int num19 = num4;
							num = 1085523976 / num;
							int num20 = num19 + (int)(num + 1);
							num = (uint)(-1490100035 << (int)num);
							num4 = num20;
							num ^= 0xA72EE0BDu;
							break;
						}
						continue;
					}
					if (num != 2989164462u)
					{
						return;
					}
					goto IL_0027;
				}
				break;
			}
		}
	}
}
