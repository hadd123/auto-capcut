using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;

public class _02B4022E
{
	private sealed class _1BB8DC36 : _128A201A
	{
		private D3B95303 _7826E681;

		private FieldInfo _77B13096;

		public override object _9F320096()
		{
			uint num = 436461492u;
			return _7826E681.DDAAAA0B(_77B13096);
		}

		public override Type D293A3AF()
		{
			FieldInfo fieldInfo = _77B13096;
			uint num = 3400323247u;
			return fieldInfo.FieldType;
		}

		public override D3B95303 _5C36403F()
		{
			uint num = 2460509490u;
			num &= 0x79A2AB39;
			FieldInfo aA1EC59F = _77B13096;
			num = 1419795877 % num;
			num = 0xAF9C40A6u ^ num;
			return new _1BB8DC36(aA1EC59F, _7826E681);
		}

		public override void DE8C17B9(object C2B3ED30)
		{
			D3B95303 d3B = _7826E681;
			FieldInfo _1484D = _77B13096;
			uint num = 4121204750u;
			d3B._45971A1D(_1484D, C2B3ED30);
		}

		public _1BB8DC36(FieldInfo AA1EC59F, D3B95303 _2332CF34)
		{
			while (true)
			{
				uint num = 2520178598u;
				num >>= 18;
				num = 2200474940u + num;
				_77B13096 = AA1EC59F;
				if (num / 2058311102 != 0)
				{
					num <<= 15;
					num = (uint)(-14540522 << (int)num);
					_7826E681 = _2332CF34;
					if (-652241524 != (int)num)
					{
						break;
					}
				}
			}
		}
	}

	private sealed class _3C352A26 : D3B95303
	{
		private short F51129A9;

		public override B7078183 A883CB02()
		{
			return new B7035AA0(_6527EC0E());
		}

		public override byte _6E94D6A9()
		{
			uint num = 1000769453u;
			short f51129A = F51129A9;
			num -= 1067203714;
			return (byte)f51129A;
		}

		public override sbyte _6C14C0B7()
		{
			uint num = 2721176713u;
			short f51129A = F51129A9;
			num %= 2164329649u;
			return (sbyte)f51129A;
		}

		public override object _9F320096()
		{
			uint num = 3904107937u;
			short f51129A = F51129A9;
			num ^= 0x1700AA0D;
			return f51129A;
		}

		public static D3B95303 _1E334C1A(D3B95303 C7AB3632)
		{
			ulong num3;
			int num6;
			uint num;
			do
			{
				IL_0000:
				D3B95303 d3B = C7AB3632;
				num = 824032903u;
				ulong num2 = d3B._588AFCB3();
				num -= 2797582139u;
				num3 = num2;
				num = 27526674 % num;
				if (num > 53987625)
				{
					goto IL_0000;
				}
				int num4 = C7AB3632._6E0A913C();
				num %= 2518439810u;
				uint num5 = num - 27526658;
				num = (uint)(-259549657 << (int)num);
				bool flag = ((uint)num4 & num5) > (num ^ 0x589C0000);
				num6 = (int)(num ^ 0x589C0000);
				num = (uint)(-1584003964 << (int)num);
				if (1873648790 >= num)
				{
					goto IL_0000;
				}
				uint num7 = num + 1584036731;
				num -= 1468894724;
				long num8 = (int)num7;
				num /= 1144934273;
				if (num3 > (ulong)num8)
				{
					goto IL_00dd;
				}
				num *= 2350559406u;
				if ((num ^ 0xBC16979Eu) == 0)
				{
					goto IL_0000;
				}
				num &= 0x7FAA30B4;
				if (!flag)
				{
					num = 0x3928CE29 ^ num;
					short num9 = (short)num3;
					int num10 = (int)num ^ -891453811;
					num ^= 0x3928CE29;
					if (num9 < num10)
					{
						num += 4092972893u;
						goto IL_00dd;
					}
				}
				goto IL_00ff;
				IL_00dd:
				int num11 = num6;
				uint num12 = num ^ 9;
				num = 4161026848u / num;
				int num13 = num11 | (int)num12;
				num *= 2644759102u;
				num6 = num13;
				num += 1025744612;
				goto IL_00ff;
				IL_00ff:
				num = 294760207 - num;
			}
			while ((int)num - -1430887663 == 0);
			num += 3959671594u;
			short _1B2FFB = (short)num3;
			num = 0x1092AB18 & num;
			B7035AA0 b7035AA = new B7035AA0(_1B2FFB);
			num /= 882082710;
			C7AB3632 = b7035AA;
			D3B95303 d3B2 = C7AB3632;
			int _6B1C = num6;
			num = 0xABA5638 ^ num;
			d3B2._82A5D1BE(_6B1C);
			num = 3196919351u / num;
			return C7AB3632;
		}

		public override ushort AD1962B2()
		{
			uint num = 2829991486u;
			return (ushort)F51129A9;
		}

		public override short E39CE9A9()
		{
			return F51129A9;
		}

		public override D3B95303 _5C36403F()
		{
			uint num = 3557245354u;
			return new _3C352A26(F51129A9);
		}

		public override uint _3503DA1F()
		{
			uint num = 1326217106u;
			return (uint)F51129A9;
		}

		public override Type D293A3AF()
		{
			uint num = 2092050818u;
			num = 916416786 - num;
			return typeof(short);
		}

		public override void DE8C17B9(object _521BCAAF)
		{
			uint num = 3583263647u;
			if (num >= 412409533)
			{
				F51129A9 = Convert.ToInt16(_521BCAAF);
			}
		}

		public override int _6527EC0E()
		{
			return F51129A9;
		}

		public _3C352A26(short _2CBFE428)
		{
			uint num;
			do
			{
				num = 2492944016u;
				if (num - 532043691 != 0)
				{
					num += 3457019695u;
					num = (uint)(563088058 << (int)num);
					F51129A9 = _2CBFE428;
					continue;
				}
				break;
			}
			while (num >= 3105239552u);
		}
	}

	private abstract class B7078183 : D3B95303
	{
		protected B7078183()
		{
			uint num = 1832310154u;
			do
			{
			}
			while ((0xF39A669Eu ^ num) == 0);
		}

		public override B7078183 A883CB02()
		{
			return this;
		}
	}

	internal delegate void A93EA20B();

	private sealed class _85140483 : D3B95303
	{
		private uint _3DBF2190;

		public override B7078183 A883CB02()
		{
			uint num = 2903469986u;
			return new B7035AA0(_6527EC0E());
		}

		public override byte _6E94D6A9()
		{
			uint num = _3DBF2190;
			uint num2 = 2486824222u;
			return (byte)num;
		}

		public override sbyte _6C14C0B7()
		{
			uint num = 4231329313u;
			return (sbyte)_3DBF2190;
		}

		public override object _9F320096()
		{
			uint num = 2335374521u;
			return _3DBF2190;
		}

		public override uint _3503DA1F()
		{
			uint num = 1980012215u;
			return _3DBF2190;
		}

		public override short E39CE9A9()
		{
			uint num = 2678018609u;
			num = 0x5FB78039 & num;
			uint num2 = _3DBF2190;
			num ^= 0xE434343Cu;
			return (short)num2;
		}

		public override ushort AD1962B2()
		{
			uint num = 951061781u;
			return (ushort)_3DBF2190;
		}

		public override void DE8C17B9(object _9D1F21AC)
		{
			uint num = 2460672179u;
			if (num - 2343425294u != 0)
			{
				_3DBF2190 = Convert.ToUInt32(_9D1F21AC);
			}
		}

		public static D3B95303 A333E7A5(D3B95303 _12A8FFA5)
		{
			uint num = 4087342228u;
			ulong num3;
			int num9;
			while (true)
			{
				ulong num2 = _12A8FFA5._588AFCB3();
				num /= 2444155710u;
				num3 = num2;
				if (-1157186500 >>> (int)num == 0)
				{
					continue;
				}
				int num4 = _12A8FFA5._6E0A913C();
				num = (uint)(-1533351930 << (int)num);
				int num5 = num4 & (int)(num - 1228263420);
				uint num6 = num - 1228263436;
				num = 2594640515u / num;
				bool num7 = (uint)num5 > num6;
				num = 3506491800u / num;
				uint num8 = num - 1753245900;
				num %= 2961722881u;
				num9 = (int)num8;
				num = 2340935614u % num;
				if (num7)
				{
					if (1736596509 << (int)num == 0)
					{
						continue;
					}
					goto IL_008b;
				}
				uint num10 = num + 1559793933;
				num += 4256122117u;
				long num11 = (int)num10;
				num ^= 0x10A57E27;
				if (num3 > (ulong)num11)
				{
					if (num == 750284333)
					{
						goto IL_008b;
					}
					num9 |= (int)(num ^ 0x3013CDD8);
					num ^= 0;
				}
				goto IL_010e;
				IL_008b:
				long num12 = (uint)((int)num + -587689715);
				num = 3783531560u * num;
				if (num3 > (ulong)num12)
				{
					num = 3649654949u / num;
					if (num != 3039905466u)
					{
						int num13 = num9 | (int)(num ^ 0xC);
						num = 254978457 - num;
						num9 = num13;
						num += 551625787;
					}
				}
				goto IL_010e;
				IL_010e:
				num *= 3937294746u;
				if (num >= 2805923002u)
				{
					break;
				}
				goto IL_008b;
			}
			_12A8FFA5 = new B7035AA0((int)num3);
			D3B95303 d3B = _12A8FFA5;
			int _6B1C = num9;
			num = 0xFD892683u | num;
			d3B._82A5D1BE(_6B1C);
			return _12A8FFA5;
		}

		public override int _6527EC0E()
		{
			uint num = 253418371u;
			return (int)_3DBF2190;
		}

		public override D3B95303 _5C36403F()
		{
			uint num = 1219266871u;
			return new _85140483(_3DBF2190);
		}

		public override Type D293A3AF()
		{
			uint num = 235955353u;
			num |= 0x1A2F6000;
			return typeof(uint);
		}

		public _85140483(uint _2F9E0289)
		{
			uint num = 3777227278u;
			num = 2837089038u % num;
			if ((0x95AFC32Eu ^ num) != 0)
			{
				do
				{
					num = 3550568111u * num;
					num = 3549600818u - num;
					_3DBF2190 = _2F9E0289;
				}
				while (num >= 3634389122u);
			}
		}
	}

	private sealed class _64267A02 : B7078183
	{
		private object _5AB5DD0F;

		public override object _9F320096()
		{
			uint num = 4154544257u;
			return _5AB5DD0F;
		}

		public override void DE8C17B9(object _538D48B9)
		{
			if (_538D48B9 != null)
			{
				while (true)
				{
					uint num = 1630199483u;
					ValueType obj = _538D48B9 as ValueType;
					num = 0x3A905D86 & num;
					if (obj != null)
					{
						break;
					}
					num = 1856820383 - num;
					if (num != 2097789462)
					{
						throw new ArgumentException();
					}
				}
			}
			_5AB5DD0F = _538D48B9;
		}

		public override D3B95303 _5C36403F()
		{
			object obj2;
			while (true)
			{
				uint num = 4270318096u;
				object obj = _5AB5DD0F;
				num |= 0xEA066393u;
				if (obj == null)
				{
					num >>= 22;
					obj2 = null;
					break;
				}
				num = (uint)(1368284847 << (int)num);
				if (num == 739669815)
				{
					continue;
				}
				Type type = _5AB5DD0F.GetType();
				num = 2073077514 * num;
				num ^= 0xF5A02991u;
				uint bindingAttr = num ^ 0x2B1029A5;
				num |= 0xC43F709Du;
				FieldInfo[] fields = type.GetFields((BindingFlags)bindingAttr);
				num = 3104916883u - num;
				obj2 = Activator.CreateInstance(type);
				num ^= 0x826DC10;
				FieldInfo[] array = fields;
				num = 0x3A29E026 & num;
				int num2 = (int)(num ^ 0x210026);
				while (true)
				{
					int num3 = num2;
					IntPtr intPtr = (nint)array.LongLength;
					num = (uint)(353166597 << (int)num);
					int num4 = (int)(nint)intPtr;
					num /= 1119587981;
					if (num3 < num4)
					{
						FieldInfo fieldInfo = array[num2];
						num = 1587875368u;
						if (num <= 1032834367)
						{
							break;
						}
						num = 1227132852u >> (int)num;
						fieldInfo.SetValue(obj2, fieldInfo.GetValue(_5AB5DD0F));
						int num5 = num2;
						num &= 0x98F2A1D;
						int num6 = num5 + (int)(num - 598028);
						num += 3736508473u;
						num2 = num6;
						num += 560023520;
						continue;
					}
					num ^= 0x3FB;
					break;
				}
				break;
			}
			return new _64267A02(obj2);
		}

		public override Type D293A3AF()
		{
			uint num = 1974134840u;
			num /= 2793944495u;
			return typeof(ValueType);
		}

		public _64267A02(object D4108A8B)
		{
			uint num = 3853181707u;
			if (num != 1287241919)
			{
				num ^= 0x81B5E116u;
				if (D4108A8B != null)
				{
					num = 2130812810 / num;
					num >>= 6;
					ValueType obj = D4108A8B as ValueType;
					num /= 2400429981u;
					num ^= 0x641F021D;
					if (obj == null)
					{
						num = 0xB308C981u & num;
						throw new ArgumentException();
					}
				}
			}
			if (num >= 286557963)
			{
				num = 4103049873u - num;
				num = 3190710703u - num;
				_5AB5DD0F = D4108A8B;
			}
		}
	}

	private abstract class _128A201A : B7078183
	{
		protected _128A201A()
		{
			uint num;
			do
			{
				num = 1436435889u;
			}
			while (-324424404 == (int)num);
		}

		public override bool _4C0EC108()
		{
			uint num = 3543047860u;
			return (byte)(num + 751919437) != 0;
		}
	}

	private sealed class _8CB2849D : B7078183
	{
		private D3B95303 B4ACFD08;

		public override void DE8C17B9(object AA3C5702)
		{
			uint num = 3508547860u;
			Thread.MemoryBarrier();
			if (num > 1107379109)
			{
				num %= 3199241492u;
				D3B95303 b4ACFD = B4ACFD08;
				num = 462867519 * num;
				b4ACFD.DE8C17B9(AA3C5702);
			}
		}

		public override short E39CE9A9()
		{
			uint num = 1335915050u;
			short result = B4ACFD08.E39CE9A9();
			num <<= 9;
			Thread.MemoryBarrier();
			return result;
		}

		public override bool C9093688()
		{
			uint num = 1981393809u;
			bool result = B4ACFD08.C9093688();
			num %= 2025601445;
			Thread.MemoryBarrier();
			return result;
		}

		public override sbyte _6C14C0B7()
		{
			sbyte result = B4ACFD08._6C14C0B7();
			uint num = 3684665009u;
			Thread.MemoryBarrier();
			return result;
		}

		public override uint _3503DA1F()
		{
			uint num = 3440105914u;
			uint result = B4ACFD08._3503DA1F();
			num ^= 0xDF3E9082u;
			Thread.MemoryBarrier();
			return result;
		}

		public override double DB900D19()
		{
			uint num = 3392623154u;
			D3B95303 b4ACFD = B4ACFD08;
			num ^= 0x2901B78C;
			double result = b4ACFD.DB900D19();
			num /= 4060517791u;
			Thread.MemoryBarrier();
			return result;
		}

		public override Type D293A3AF()
		{
			uint num = 2970784025u;
			D3B95303 b4ACFD = B4ACFD08;
			num /= 2576972948u;
			return b4ACFD.D293A3AF();
		}

		public override float DEAE8E8E()
		{
			uint num = 413673503u;
			float result = B4ACFD08.DEAE8E8E();
			Thread.MemoryBarrier();
			return result;
		}

		public override long _249CC8BD()
		{
			uint num = 2014945935u;
			D3B95303 b4ACFD = B4ACFD08;
			num %= 121141934;
			long result = b4ACFD._249CC8BD();
			Thread.MemoryBarrier();
			return result;
		}

		public override int _6527EC0E()
		{
			uint num = 3139377966u;
			int result = B4ACFD08._6527EC0E();
			Thread.MemoryBarrier();
			return result;
		}

		public override ulong _588AFCB3()
		{
			uint num = 3004532621u;
			num %= 975244555;
			D3B95303 b4ACFD = B4ACFD08;
			num <<= 13;
			ulong result = b4ACFD._588AFCB3();
			Thread.MemoryBarrier();
			return result;
		}

		public override void _45971A1D(FieldInfo _66A42DA8, object _70AEC99A)
		{
			Thread.MemoryBarrier();
			uint num = 3230314300u;
			if (num >= 1312179233)
			{
				B4ACFD08._45971A1D(_66A42DA8, _70AEC99A);
			}
		}

		public override byte _6E94D6A9()
		{
			byte result = B4ACFD08._6E94D6A9();
			uint num = 4103395712u;
			Thread.MemoryBarrier();
			return result;
		}

		public override bool _4C0EC108()
		{
			return B4ACFD08._4C0EC108();
		}

		public override D3B95303 _5C36403F()
		{
			uint num = 1351399061u;
			throw new InvalidOperationException();
		}

		public override ushort AD1962B2()
		{
			uint num = 842032918u;
			num *= 3123261856u;
			ushort result = B4ACFD08.AD1962B2();
			Thread.MemoryBarrier();
			return result;
		}

		public override object DDAAAA0B(FieldInfo BE9325AD)
		{
			D3B95303 b4ACFD = B4ACFD08;
			uint num = 454902155u;
			object result = b4ACFD.DDAAAA0B(BE9325AD);
			num = 1829260676u >> (int)num;
			Thread.MemoryBarrier();
			return result;
		}

		public override object _9F320096()
		{
			uint num = 1124815287u;
			num = 0xB1957A1Du ^ num;
			D3B95303 b4ACFD = B4ACFD08;
			num += 4079622456u;
			object result = b4ACFD._9F320096();
			Thread.MemoryBarrier();
			return result;
		}

		public _8CB2849D(D3B95303 _5F88A32D)
		{
			uint num = 2318855600u;
			do
			{
				num -= 1513361937;
			}
			while (3080858005u % num == 0);
			B4ACFD08 = _5F88A32D;
		}
	}

	private sealed class _20AC20B8 : D3B95303
	{
		private Type _9B16672D;

		private object _7981291C;

		public override Type D293A3AF()
		{
			return _9B16672D;
		}

		public override object _9F320096()
		{
			uint num = 3594047109u;
			num = 3188977701u * num;
			return _7981291C;
		}

		public override void DE8C17B9(object _2BA3C93E)
		{
			uint num = 1186206877u;
			_7981291C = _2BA3C93E;
		}

		public override D3B95303 _5C36403F()
		{
			uint num = 3182780083u;
			num ^= 0xA99A84BFu;
			object f1A9B = _7981291C;
			num = (uint)(747994557 << (int)num);
			return new _20AC20B8(f1A9B, _9B16672D);
		}

		public unsafe override B7078183 A883CB02()
		{
			uint num = 2327487518u;
			object obj = _7981291C;
			num = 3743204886u * num;
			IntPtr _09B;
			if (obj != null)
			{
				num %= 2586744615u;
			}
			else
			{
				num = 2098277801 * num;
				if ((num & 0xBB35A22Fu) != 0)
				{
					_09B = IntPtr.Zero;
					num += 2228187348u;
					goto IL_005f;
				}
			}
			num -= 4189125132u;
			_09B = new IntPtr(Pointer.Unbox(_7981291C));
			goto IL_005f;
			IL_005f:
			num = 3977590038u >> (int)num;
			return new _88BA7B16(_09B);
		}

		public _20AC20B8(object F1A9B706, Type _853FC333)
		{
			uint num = 1636808117u;
			num += 3585404553u;
			num *= 2586613945u;
			num = 0xEF1990B9u | num;
			num -= 448036631;
			_7981291C = F1A9B706;
			num += 632256153;
			num += 1563885569;
			_9B16672D = _853FC333;
		}
	}

	private sealed class EB1F56B8
	{
		private List<_589EC5AE> _4504310D;

		private int _6609B2A4;

		private int _9BBF70BB;

		public int _7B9F99B2()
		{
			uint num = 704662303u;
			num /= 1529796383;
			return _9BBF70BB;
		}

		public List<_589EC5AE> B51C242D()
		{
			uint num = 457017138u;
			return _4504310D;
		}

		public void _808CF914(byte _7F2E7408, int B7916BAA, int C0B6F80C)
		{
			uint num;
			do
			{
				List<_589EC5AE> list = _4504310D;
				num = 2268096566u;
				num = 129382175 - num;
				_589EC5AE item = new _589EC5AE(_7F2E7408, B7916BAA, C0B6F80C);
				num = 0xCC9B9018u & num;
				list.Add(item);
			}
			while (421061660 >= num);
		}

		public int CE8A482E()
		{
			uint num = 2411633068u;
			num /= 934427027;
			return _6609B2A4;
		}

		public int _248EBD09(EB1F56B8 D532DF24)
		{
			uint num = 2550425985u;
			if (num > 472373260)
			{
				goto IL_0011;
			}
			goto IL_0027;
			IL_0011:
			if (D532DF24 == null)
			{
				goto IL_0017;
			}
			goto IL_0027;
			IL_0027:
			ref int reference = ref _9BBF70BB;
			num = 798863397 - num;
			num -= 2351312190u;
			int num2 = reference.CompareTo(D532DF24._7B9F99B2());
			num = 0xF6BB04A3u ^ num;
			if (2719441678u <= num)
			{
				int num3 = num2;
				num = (uint)(918262424 << (int)num);
				if (num3 == 0)
				{
					num = 4228424503u + num;
					if (1824251326 == num)
					{
						goto IL_0017;
					}
					int num4 = D532DF24.CE8A482E();
					num >>= 19;
					int num5 = num4;
					num = 1756507547 * num;
					num -= 1312722620;
					int num6 = num5.CompareTo(_6609B2A4);
					num -= 1185263497;
					num2 = num6;
					num += 4000517392u;
				}
				num -= 35057567;
				if (2760624301u < num)
				{
					return num2;
				}
				goto IL_0011;
			}
			goto IL_0017;
			IL_0017:
			num = 0xA3969BB1u ^ num;
			return (int)(num ^ 0x3B92F231);
		}

		public EB1F56B8(int A631D592, int _21275538)
		{
			uint num = 815855502u;
			do
			{
				_4504310D = new List<_589EC5AE>();
				num = 4170151061u + num;
			}
			while ((0xC181ED9Eu ^ num) == 0);
			do
			{
				num <<= 29;
				num -= 817453969;
			}
			while (-803818232 == (int)num);
			num <<= 23;
			_9BBF70BB = A631D592;
			num |= 0x9412B887u;
			_6609B2A4 = _21275538;
		}
	}

	private sealed class _0A28F932 : D3B95303
	{
		private bool _990B67B9;

		public override int _6527EC0E()
		{
			uint num = 2005345047u;
			bool num2 = _990B67B9;
			num = 0xA9A567ACu | num;
			if (!num2)
			{
				return (int)num ^ -5806145;
			}
			num /= 4161493015u;
			return (int)(num ^ 0);
		}

		public override D3B95303 _5C36403F()
		{
			uint num = 1065570224u;
			num <<= 21;
			bool _42BCB11B = _990B67B9;
			num |= 0x8F1A0B9Cu;
			return new _0A28F932(_42BCB11B);
		}

		public override Type D293A3AF()
		{
			uint num = 1158666679u;
			return typeof(bool);
		}

		public override B7078183 A883CB02()
		{
			uint num = 2240195244u;
			int _1B2FFB = _6527EC0E();
			num += 170745226;
			return new B7035AA0(_1B2FFB);
		}

		public override void DE8C17B9(object _9C1F90A3)
		{
			uint num = 682704386u;
			do
			{
				num = 1128210237u >> (int)num;
				_990B67B9 = Convert.ToBoolean(_9C1F90A3);
			}
			while (-1464735699 == (int)num);
		}

		public override object _9F320096()
		{
			uint num = 1957084049u;
			num = 1301142207 + num;
			bool num2 = _990B67B9;
			num &= 0x668C55B1;
			return num2;
		}

		public _0A28F932(bool _42BCB11B)
		{
			_990B67B9 = _42BCB11B;
		}
	}

	private sealed class B7035AA0 : B7078183
	{
		private int _5A3CA516;

		public override bool C9093688()
		{
			uint num = 4043844794u;
			return (uint)_5A3CA516 > (num ^ 0xF1082CBAu);
		}

		public override double DB900D19()
		{
			return _5A3CA516;
		}

		public static D3B95303 C025E52A(D3B95303 A5A9D494, D3B95303 _0E36B110)
		{
			while (true)
			{
				uint num = 1905016629u;
				int num2 = 0;
				while (true)
				{
					int num3 = _0E36B110._6E0A913C();
					uint num4 = num ^ 0x718C3F25;
					num = 514323115 * num;
					int num5 = num3 & (int)num4;
					int num6 = (int)num - -570338713;
					num = 824246553 + num;
					uint num7;
					uint num9;
					if ((uint)num5 > (uint)num6)
					{
						if (120959037 == num)
						{
							break;
						}
						while (true)
						{
							IL_0048:
							num7 = A5A9D494._3503DA1F();
							num /= 2443602961u;
							uint num8 = _0E36B110._3503DA1F();
							num ^= 0x4C871BBC;
							num9 = num8;
							num = 1042226579u >> (int)num;
							if (num % 3918036911u == 0)
							{
								break;
							}
							while (true)
							{
								num <<= 18;
								if (num7 != num9)
								{
									break;
								}
								num >>= 17;
								if (3820959629u <= num)
								{
									goto IL_0048;
								}
								int num10 = num2;
								int num11 = (int)num + -4;
								num *= 2821210635u;
								num2 = num10 | num11;
								if (num >> 12 == 0)
								{
									continue;
								}
								goto IL_0222;
							}
							goto IL_00d7;
						}
						continue;
					}
					if (num >> 3 == 0)
					{
						continue;
					}
					int num12 = A5A9D494._6527EC0E();
					num |= 0x9FA18631u;
					int num13 = num12;
					if (3632980399u <= num)
					{
						continue;
					}
					num = 2587389843u + num;
					int num14 = _0E36B110._6527EC0E();
					num = 1562766107 % num;
					int num15 = num14;
					num = 2602409516u >> (int)num;
					num = 2670456469u + num;
					if (num13 == num15)
					{
						int num16 = num2;
						num &= 0xC4A8B6A6u;
						int num17 = (int)num ^ -2077710720;
						num |= 0xE71008ACu;
						int num18 = num16 | num17;
						num = 2820762674u % num;
						num2 = num18;
						num += 1221599248;
					}
					else
					{
						if (num + 237562515 == 0)
						{
							break;
						}
						num ^= 0x6FDA6389;
						if (num13 < num15)
						{
							num %= 2432756773u;
							int num19 = num2;
							num = 2008694923 + num;
							uint num20 = num + 676667228;
							num = 0x8A2E3A3Fu | num;
							int num21 = num19 | (int)num20;
							num *= 590969222;
							num2 = num21;
							num ^= 0x4B530AB8;
						}
					}
					goto IL_0222;
					IL_00d7:
					num += 188278842;
					if ((0xDA86B935u ^ num) == 0)
					{
						break;
					}
					num += 3853296648u;
					if (num7 < num9)
					{
						int num22 = num2;
						num *= 2508999067u;
						num2 = num22 | ((int)num - -514408974);
						num ^= 0x11A731B4;
					}
					goto IL_0222;
					IL_0222:
					int _1B2FFB = num2;
					num = 0xFF0088A0u | num;
					return new B7035AA0(_1B2FFB);
				}
			}
		}

		public static D3B95303 _44818004(D3B95303 FAB08FA7, D3B95303 BF3AC42B)
		{
			uint num = 850378300u;
			B7035AA0 b7035AA2 = default(B7035AA0);
			int num7 = default(int);
			if ((int)num - -2119198928 == 0)
			{
				goto IL_0144;
			}
			while (true)
			{
				num = 2995991303u - num;
				uint num2 = FAB08FA7._3503DA1F();
				num = 4062928548u >> (int)num;
				uint num3 = BF3AC42B._3503DA1F();
				num &= 0xF036B32;
				uint num4 = num3;
				num = 1552738048 / num;
				uint num5 = num2 + num4;
				num >>= 25;
				uint num6 = num5;
				num += 3341393178u;
				B7035AA0 b7035AA = new B7035AA0((int)num6);
				num /= 1429665185;
				b7035AA2 = b7035AA;
				num7 = (int)(num - 2);
				uint num8 = num ^ 0x80000002u;
				num |= 0x6B05778A;
				num = 0xB93E1024u | num;
				uint num9 = (num2 ^ num6) & (num4 ^ num6);
				num = 1639252740 * num;
				uint num10 = num9 & num8;
				num <<= 23;
				if (num10 != 0)
				{
					int num11 = num7;
					uint num12 = num ^ 0x5C000008;
					num = 2853330834u / num;
					int num13 = num11 | (int)num12;
					num <<= 23;
					num7 = num13;
					num += 1535115264;
				}
				num <<= 26;
				num *= 1519016195;
				uint num14 = num2 ^ ((num2 ^ num4) & (num4 ^ num6));
				num = (uint)(-980241866 << (int)num);
				if ((num14 & num8) == 0)
				{
					break;
				}
				num = 2251390270u >> (int)num;
				if (1899217154 << (int)num == 0)
				{
					continue;
				}
				goto IL_0144;
			}
			goto IL_0177;
			IL_0144:
			int num15 = num7;
			num = 0x8F0C56A3u ^ num;
			int num16 = (int)num ^ -1895017317;
			num = 4265501612u * num;
			int num17 = num15 | num16;
			num += 497526296;
			num7 = num17;
			num += 3079916922u;
			goto IL_0177;
			IL_0177:
			b7035AA2._82A5D1BE(num7);
			num = 1276744634 / num;
			return b7035AA2;
		}

		public override long _249CC8BD()
		{
			uint num = 2961875640u;
			num |= 0x6F22D339;
			return _5A3CA516;
		}

		public override int _6527EC0E()
		{
			uint num = 2075826339u;
			return _5A3CA516;
		}

		public override D3B95303 _5C36403F()
		{
			uint num = 1480336517u;
			int _1B2FFB = _5A3CA516;
			num = 832026416u >> (int)num;
			B7035AA0 b7035AA = new B7035AA0(_1B2FFB);
			num += 2584341424u;
			num = 1990032565u >> (int)num;
			num = 0x723FF106 ^ num;
			b7035AA._82A5D1BE(_6E0A913C());
			return b7035AA;
		}

		public static D3B95303 _5C220285(D3B95303 _083F5E09, D3B95303 _1F95CFAC)
		{
			uint num = 4121359532u;
			do
			{
				int num2 = _1F95CFAC._6E0A913C();
				num = 0xFF23D62Au | num;
				uint num3 = num + 5769570;
				num = 2886946747u % num;
				bool num4 = ((uint)num2 & num3) > num + 1408020549;
				num = 0x9A81250Bu | num;
				if (num4)
				{
					num *= 2518086554u;
					if (1402717582 <= num)
					{
						num = 2300627380u % num;
						uint num5 = _083F5E09._3503DA1F();
						int num6 = _1F95CFAC._6527EC0E();
						num = 0x5E2DCE9D ^ num;
						int num7 = num6;
						num = 3473126969u - num;
						num = 0x9EA55917u & num;
						int num8 = num7 & (int)(num + 1767634703);
						num &= 0xA3877A8Fu;
						return new B7035AA0((int)(num5 >> num8));
					}
				}
			}
			while (4290463899u < num);
			int num9 = _083F5E09._6527EC0E();
			num *= 4229637550u;
			num -= 345255615;
			int num10 = _1F95CFAC._6527EC0E();
			num = 766988729 * num;
			num = (uint)(2082704288 << (int)num);
			int num11 = (int)num - -518234911;
			num = 0x771BCA02 | num;
			return new B7035AA0(num9 >> (num10 & num11));
		}

		public static D3B95303 _52396EA7(D3B95303 F4A5560E, D3B95303 D5152910)
		{
			int num = F4A5560E._6527EC0E();
			uint num2 = 171033391u;
			int num3 = D5152910._6527EC0E();
			int num4 = num3 & ((int)num2 + -171033360);
			num2 %= 2803774736u;
			int _1B2FFB = num << num4;
			num2 += 2601476228u;
			return new B7035AA0(_1B2FFB);
		}

		public override byte _6E94D6A9()
		{
			uint num = 1098947759u;
			num = 842040328 * num;
			int num2 = _5A3CA516;
			num -= 3485315734u;
			return (byte)num2;
		}

		public override void DE8C17B9(object _6B8C8CA0)
		{
			uint num = 117527564u;
			if (2184159162u - num != 0)
			{
				do
				{
					num = 4245724180u % num;
					num <<= 4;
					_5A3CA516 = Convert.ToInt32(_6B8C8CA0);
				}
				while (num == 2005006626);
			}
		}

		public static D3B95303 _8631ED1D(D3B95303 _39B6162E, D3B95303 _60337DAF)
		{
			uint num = 1669952267u;
			do
			{
				int num2 = _60337DAF._6E0A913C() & (int)(num - 1669952251);
				num *= 3484727435u;
				bool num3 = (uint)num2 > (uint)((int)num - -1626513671);
				num = 855969693u >> (int)num;
				if (num3)
				{
					uint num4 = _39B6162E._3503DA1F();
					uint num5 = _60337DAF._3503DA1F();
					num >>= 29;
					uint num6 = num5;
					num = (uint)(-801828176 << (int)num);
					num = 0xA7897099u ^ num;
					return new B7035AA0((int)(num4 % num6));
				}
				num *= 1258469021;
			}
			while (1312227348 % num == 0);
			num |= 0x42078406;
			int num7 = _39B6162E._6527EC0E();
			int num8 = _60337DAF._6527EC0E();
			num &= 0x27BAB4B1;
			int num9 = num8;
			num -= 2435984920u;
			return new B7035AA0(num7 % num9);
		}

		public override IntPtr _27832122()
		{
			uint num = 1275437613u;
			num <<= 4;
			int value = _5A3CA516;
			num >>= 31;
			return new IntPtr(value);
		}

		public static D3B95303 _923FD533(D3B95303 _2ABA8497, D3B95303 _6F379681)
		{
			uint num = 373091261u;
			uint num2 = default(uint);
			uint num3 = default(uint);
			if (2820118566u >= num)
			{
				goto IL_0013;
			}
			goto IL_0028;
			IL_0013:
			num2 = _2ABA8497._3503DA1F();
			if (num * 2015666854 != 0)
			{
				goto IL_0028;
			}
			goto IL_0051;
			IL_0028:
			num &= 0x633CFC1E;
			num3 = _6F379681._3503DA1F();
			num >>= 9;
			if (3929568145u % num == 0)
			{
				goto IL_0013;
			}
			goto IL_0051;
			IL_0051:
			ulong num4 = num2 * num3;
			num += 1368207155;
			int num5 = (int)num4;
			num &= 0xB424FE20u;
			uint num6 = (uint)num5;
			num /= 1688682546;
			B7035AA0 b7035AA = new B7035AA0((int)num6);
			int num7 = (int)(num ^ 0);
			num += 1848753169;
			uint num8 = num ^ 0xEE31BC11u;
			uint num9 = num2 ^ num6;
			num &= 0x723AB39F;
			uint num10 = num3 ^ num6;
			num = 0xD62C788Fu | num;
			uint num11 = num9 & num10;
			num = 3635666183u >> (int)num;
			if ((num11 & num8) != 0)
			{
				num = 2628945538u - num;
				num7 |= (int)num - -1666021767;
				num ^= 0x9CB28680u;
			}
			num /= 2385689916u;
			uint num12 = num2;
			uint num13 = num2;
			num *= 1293078417;
			uint num14 = num13 ^ num3;
			uint num15 = num3 ^ num6;
			num = 444758158u >> (int)num;
			uint num16 = num14 & num15;
			num |= 0x1F0EE827;
			uint num17 = num12 ^ num16;
			num ^= 0xC83039A;
			num ^= 0xA7894793u;
			if ((num17 & num8) != 0)
			{
				if (num < 2584541978u)
				{
					goto IL_0013;
				}
				int num18 = num7 | ((int)num - -1266369402);
				num %= 706330676;
				num7 = num18;
				num ^= 0xB8990770u;
			}
			num = 0x6106B301 | num;
			if (((uint)_6F379681._6E0A913C() & (num + 175718505)) > num + 175718489)
			{
				num = 0x331DF90 & num;
				ulong num19 = num4;
				int num20 = (int)num + -16818049;
				num = 733099558u >> (int)num;
				ulong num21 = num19 & (uint)num20;
				num |= 0x168C15BA;
				if (num21 != 0L)
				{
					num += 1696758589;
					int num22 = num7;
					num += 1520993445;
					int num23 = num22 | (int)(num ^ 0xFF893780u);
					num >>= 9;
					num7 = num23;
					num += 1061057315;
				}
				goto IL_02b5;
			}
			if (num > 1402591151)
			{
				uint num24 = num2;
				num += 178653571;
				long num25 = (int)(num24 * num3);
				num = 0xC98E5F33u | num;
				num4 = (ulong)num25;
				num = 0xA7BD17A5u | num;
				if (2885821974u < num)
				{
					ulong num26 = num4;
					num = 1110063295 + num;
					ulong num27 = num26 >> (int)(num ^ 0x31EA1841);
					num += 1445823619;
					int num28 = (int)num ^ -2011718370;
					num = 2668145309u / num;
					uint num29 = num6 >> num28;
					num = 1814063138 - num;
					long num30 = num29;
					num ^= 0x539E5F9F;
					if (num27 != (ulong)num30)
					{
						int num31 = num7;
						uint num32 = num - 1069430710;
						num = 3230084634u / num;
						num7 = num31 | (int)num32;
						num += 1069430715;
					}
					goto IL_02b5;
				}
			}
			goto IL_0013;
			IL_02b5:
			if (1283882684 != num)
			{
				num -= 3030642967u;
				b7035AA._82A5D1BE(num7);
				if (2173876394u * num != 0)
				{
					return b7035AA;
				}
			}
			goto IL_0013;
		}

		public override char D31384B4()
		{
			uint num = 1779875468u;
			int num2 = _5A3CA516;
			num = (uint)(-139428185 << (int)num);
			return (char)num2;
		}

		public static D3B95303 _308A7609(D3B95303 _7C97E538, D3B95303 E18AE336)
		{
			uint num2;
			while (true)
			{
				int num = E18AE336._6E0A913C();
				num2 = 1485999115u;
				int num3 = num & (int)(num2 ^ 0x58928C1B);
				num2 = 2810520974u - num2;
				bool num4 = (uint)num3 > (num2 ^ 0x4EF29983);
				num2 = (uint)(1913238404 << (int)num2);
				if (num4)
				{
					if (-366884956 == (int)num2)
					{
						continue;
					}
				}
				else
				{
					num2 = 2118073616 / num2;
					if (num2 + 280984489 != 0)
					{
						break;
					}
				}
				uint num5 = _7C97E538._3503DA1F();
				num2 = (uint)(-516330470 << (int)num2);
				uint num6 = E18AE336._3503DA1F();
				num2 >>= 28;
				uint num7 = num6;
				num2 %= 4028705158u;
				return new B7035AA0((int)(num5 / num7));
			}
			num2 = 3977795600u >> (int)num2;
			int num8 = _7C97E538._6527EC0E();
			num2 = (uint)(-1440093166 << (int)num2);
			int num9 = E18AE336._6527EC0E();
			num2 = 0x328B6D24 & num2;
			int _1B2FFB = num8 / num9;
			num2 |= 0xB0BB251Fu;
			return new B7035AA0(_1B2FFB);
		}

		public override Type D293A3AF()
		{
			uint num = 4068695047u;
			return typeof(int);
		}

		public static D3B95303 D715A43D(D3B95303 _0D2A26A8)
		{
			int num4;
			bool flag = default(bool);
			uint num;
			while (true)
			{
				D3B95303 d3B = _0D2A26A8;
				num = 1143011497u;
				ulong num2 = d3B._588AFCB3();
				num ^= 0xDEA2C7B4u;
				ulong num3 = num2;
				num >>= 8;
				if (472592773 / num != 0)
				{
					goto IL_0029;
				}
				goto IL_005f;
				IL_005f:
				num /= 1169533600;
				num4 = (int)(num + 0);
				if ((int)num + -201270130 == 0)
				{
					goto IL_0029;
				}
				num &= 0x9AB245ACu;
				uint num5 = num ^ 0x7FFFFFFF;
				num -= 4128999716u;
				long num6 = (int)num5;
				num <<= 27;
				if (num3 <= (ulong)num6)
				{
					goto IL_00a1;
				}
				goto IL_00d5;
				IL_00a1:
				bool num7 = flag;
				num = 623362741 / num;
				if (!num7)
				{
					num &= 0xD721BA93u;
					int num8 = (int)num3;
					int num9 = (int)num - int.MinValue;
					num ^= 0;
					if (num8 < num9)
					{
						num ^= 0xE0000000u;
						goto IL_00d5;
					}
				}
				goto IL_00f7;
				IL_00d5:
				num = 3339069953u % num;
				int num10 = num4;
				num *= 277144853;
				num4 = num10 | (int)(num + 1885841651);
				num ^= 0x8F985715u;
				goto IL_00f7;
				IL_00f7:
				if ((0xF1357210u ^ num) != 0)
				{
					int _1B2FFB = (int)num3;
					num <<= 28;
					_0D2A26A8 = new B7035AA0(_1B2FFB);
					num = 3552012941u + num;
					if (2645687971u % num != 0)
					{
						break;
					}
					continue;
				}
				goto IL_00a1;
				IL_0029:
				D3B95303 d3B2 = _0D2A26A8;
				num = 1044053055 - num;
				int num11 = d3B2._6E0A913C() & (int)(num - 1033927152);
				uint num12 = num ^ 0x3DA07A00;
				num = 2307163834u >> (int)num;
				bool num13 = (uint)num11 > num12;
				num /= 2090875272;
				flag = num13;
				goto IL_005f;
			}
			D3B95303 d3B3 = _0D2A26A8;
			num = 3165196470u * num;
			int _6B1C = num4;
			num = 0x4A39A4A2 & num;
			d3B3._82A5D1BE(_6B1C);
			return _0D2A26A8;
		}

		public static D3B95303 _93862D8D(D3B95303 _4D8ED322, D3B95303 _73B4CE89)
		{
			while (true)
			{
				uint num = 2813822088u;
				uint num2 = _4D8ED322._3503DA1F();
				num -= 4213851812u;
				uint num3 = ~num2;
				num = 0x5BA08A1B ^ num;
				uint num4 = ~_73B4CE89._3503DA1F();
				num = 0x80AF9B38u & num;
				uint num5 = num3 & num4;
				num = 95575187 * num;
				uint num6 = num5;
				num = 0xD8051707u & num;
				while (true)
				{
					B7035AA0 b7035AA = new B7035AA0((int)num6);
					uint num7 = num ^ 0x50010100;
					num = 756874112 + num;
					int num8 = (int)num7;
					num = 2091915963 + num;
					if (num6 == 0)
					{
						int num9 = num8;
						num = (uint)(1678909359 << (int)num);
						int num10 = (int)num + -2013265918;
						num += 371535646;
						int num11 = num9 | num10;
						num = 699560996 % num;
						num8 = num11;
						if (3097040447u / num == 0)
						{
							break;
						}
					}
					else
					{
						num <<= 13;
						if (3934274704u / num == 0)
						{
							break;
						}
						num = 993009186u >> (int)num;
						uint num12 = num6 >> (int)(num - 993009155);
						num ^= 0x12826A06;
						if (num12 != 0)
						{
							num |= 0xAA953EA3u;
							if (1377771270 > num)
							{
								break;
							}
							int num13 = num8;
							uint num14 = num + 1414037853;
							num &= 0x4F864E31;
							num8 = num13 | (int)num14;
							num += 506209795;
						}
					}
					if (-658978245 != (int)num)
					{
						num = 0x28BBE123 | num;
						int _6B1C = num8;
						num -= 1286877071;
						b7035AA._82A5D1BE(_6B1C);
						return b7035AA;
					}
				}
			}
		}

		public override short E39CE9A9()
		{
			uint num = 750567467u;
			int num2 = _5A3CA516;
			num = 0xAC088C0Au ^ num;
			return (short)num2;
		}

		public override UIntPtr _1DB07EA4()
		{
			uint num = 2470432431u;
			int value = _5A3CA516;
			num = 3829094200u + num;
			return new UIntPtr((uint)value);
		}

		public override sbyte _6C14C0B7()
		{
			int num = _5A3CA516;
			uint num2 = 1259455617u;
			return (sbyte)num;
		}

		public override ulong _588AFCB3()
		{
			uint num = 1000390832u;
			return (uint)_5A3CA516;
		}

		public override uint _3503DA1F()
		{
			uint num = 1762887219u;
			return (uint)_5A3CA516;
		}

		public override object _9F320096()
		{
			uint num = 890700460u;
			num = 3029197726u - num;
			int num2 = _5A3CA516;
			num |= 0x74B44516;
			return num2;
		}

		public override float DEAE8E8E()
		{
			uint num = 3692540477u;
			num = 2005422849u >> (int)num;
			int num2 = _5A3CA516;
			num >>= 2;
			return num2;
		}

		public static D3B95303 _668C7D8D(D3B95303 D92E27A2, D3B95303 _541C328A)
		{
			uint num = 2267751086u;
			while (true)
			{
				num = 68002743u >> (int)num;
				uint num2 = ~D92E27A2._3503DA1F();
				num -= 2182697746u;
				num &= 0xAA262224u;
				uint num3 = ~_541C328A._3503DA1F();
				num = 0xEA1D9E80u | num;
				uint num4 = num2 | num3;
				num /= 3283516803u;
				uint num5 = num4;
				while (true)
				{
					B7035AA0 b7035AA = new B7035AA0((int)num5);
					num = 1589424268 + num;
					B7035AA0 b7035AA2 = b7035AA;
					int num6 = (int)num + -1589424269;
					num *= 218962723;
					int num7 = num6;
					num = 1283855247 * num;
					if (num % 1958249499 != 0)
					{
						num ^= 0xD3BCA38Bu;
						if (num5 == 0)
						{
							num = 411336726 + num;
							if (2385619001u < num)
							{
								break;
							}
							num7 |= (int)(num ^ 0x242A93A);
						}
						else
						{
							if (-1094813518 + (int)num == 0)
							{
								break;
							}
							uint num8 = num5 >> (int)num - -373413629;
							num -= 3338887691u;
							num += 3750224417u;
							if (num8 != 0)
							{
								int num9 = num7;
								num = 0x4313ED1B | num;
								num7 = num9 | (int)(num - 1129573687);
								num ^= 0x41114403;
							}
						}
						if (1862642871 < num)
						{
							continue;
						}
						num &= 0x29BD5E3F;
						b7035AA2._82A5D1BE(num7);
						if (4166937 <= num)
						{
							continue;
						}
					}
					return b7035AA2;
				}
			}
		}

		public override ushort AD1962B2()
		{
			uint num = 2478211466u;
			num *= 933173155;
			int num2 = _5A3CA516;
			num %= 85030837;
			return (ushort)num2;
		}

		public B7035AA0(int _1B2FFB93)
		{
			uint num = 3516880412u;
			_5A3CA516 = _1B2FFB93;
		}
	}

	private sealed class B1A0179E : B7078183
	{
		private object _1BAC0586;

		public override void DE8C17B9(object _52A0D598)
		{
			uint num = 103253643u;
			if (3649222181u * num != 0)
			{
				do
				{
					num = 0x87B73C89u & num;
					_1BAC0586 = _52A0D598;
				}
				while (num >= 2979949616u);
			}
		}

		public override object _9F320096()
		{
			uint num = 1496752063u;
			return _1BAC0586;
		}

		public static D3B95303 EDBACC86(D3B95303 _9E9DEDBE, D3B95303 A186DD12)
		{
			int num2 = default(int);
			uint num;
			while (true)
			{
				num = 3521839u;
				object obj = _9E9DEDBE._9F320096();
				num = 2595972127u >> (int)num;
				object obj2 = obj;
				num = 0x988C9F88u & num;
				if (663039873 > num)
				{
					while (true)
					{
						object obj3 = A186DD12._9F320096();
						num |= 0x77A08A0F;
						object obj4 = obj3;
						num2 = (int)(num ^ 0x77A09F0F);
						num = (uint)(1830087332 << (int)num);
						num = 748273932 - num;
						if (obj2 != obj4)
						{
							break;
						}
						num = 0xB21D040Fu ^ num;
						int num3 = num2;
						num = 0x2E36451D | num;
						int num4 = num3 | (int)(num - 796837149);
						num = 0x603032B1 ^ num;
						num2 = num4;
						if (809387780 < num)
						{
							goto end_IL_0000;
						}
					}
					num += 2550609570u;
					if (obj2 != null)
					{
						break;
					}
					if (1469186850 / num == 0)
					{
						continue;
					}
				}
				int num5 = num2 | (int)(num ^ 0x4F4EF7AA);
				num &= 0xA2AE1889u;
				num2 = num5;
				num += 1296099110;
				break;
				continue;
				end_IL_0000:
				break;
			}
			num /= 1243816727;
			int _1B2FFB = num2;
			num *= 789607178;
			return new B7035AA0(_1B2FFB);
		}

		public override Type D293A3AF()
		{
			uint num = 453671567u;
			return typeof(object);
		}

		public override D3B95303 _5C36403F()
		{
			uint num = 3624157704u;
			object _04B76AB = _1BAC0586;
			num |= 0xE305CA33u;
			return new B1A0179E(_04B76AB);
		}

		public B1A0179E(object _04B76AB0)
		{
			uint num = 783481377u;
			if ((0x5681C726 & num) != 0)
			{
				num >>= 24;
			}
			do
			{
				num /= 2729493648u;
				_1BAC0586 = _04B76AB0;
			}
			while (1871063716 << (int)num == 0);
		}
	}

	private sealed class _15343925 : D3B95303
	{
		private sbyte _50BC27AC;

		public override D3B95303 _5C36403F()
		{
			uint num = 1782194866u;
			return new _15343925(_50BC27AC);
		}

		public static D3B95303 CA976A91(D3B95303 _38B3B019)
		{
			while (true)
			{
				D3B95303 d3B = _38B3B019;
				uint num = 1547115287u;
				ulong num2 = d3B._588AFCB3();
				num ^= 0xC595CC1Au;
				while (true)
				{
					int num3 = _38B3B019._6E0A913C();
					int num4 = (int)num ^ -1717381347;
					num = 540810302 % num;
					int num5 = num3 & num4;
					uint num6 = num ^ 0x203C1C3E;
					num &= 0xC53BF69Cu;
					bool flag = (uint)num5 > num6;
					uint num7 = num ^ 0x38141C;
					num |= 0xE1AE2824u;
					int num8 = (int)num7;
					if (1275475726 >= num)
					{
						break;
					}
					num = 2743222942u + num;
					int num9 = (int)num ^ -2059370843;
					num /= 809116295;
					long num10 = num9;
					num += 2291849779u;
					if (num2 > (ulong)num10)
					{
						goto IL_00c5;
					}
					num |= 0xC8207524u;
					if (3290137397u > num)
					{
						continue;
					}
					if (!flag)
					{
						num /= 178749847;
						sbyte num11 = (sbyte)num2;
						int num12 = (int)num + -146;
						num ^= 0xD4ADC389u;
						num += 4094507930u;
						if (num11 < num12)
						{
							num ^= 0x40202500;
							goto IL_00c5;
						}
					}
					goto IL_00ef;
					IL_00ef:
					num = 2997217920u >> (int)num;
					B7035AA0 b7035AA = new B7035AA0((sbyte)num2);
					num *= 3935161019u;
					_38B3B019 = b7035AA;
					D3B95303 d3B2 = _38B3B019;
					int _6B1C = num8;
					num /= 2233826103u;
					d3B2._82A5D1BE(_6B1C);
					return _38B3B019;
					IL_00c5:
					num = 3962127120u - num;
					int num13 = num8;
					uint num14 = num ^ 0x638E68D3;
					num <<= 20;
					int num15 = num13 | (int)num14;
					num = 973780627 / num;
					num8 = num15;
					num += 3367698229u;
					goto IL_00ef;
				}
			}
		}

		public override byte _6E94D6A9()
		{
			sbyte num = _50BC27AC;
			uint num2 = 26518462u;
			return (byte)num;
		}

		public override object _9F320096()
		{
			return _50BC27AC;
		}

		public override void DE8C17B9(object C58C1889)
		{
			uint num = 280529304u;
			do
			{
				num -= 210997165;
				_50BC27AC = Convert.ToSByte(C58C1889);
			}
			while ((num ^ 0xEDBFB314u) == 0);
		}

		public override sbyte _6C14C0B7()
		{
			uint num = 958262073u;
			return _50BC27AC;
		}

		public override short E39CE9A9()
		{
			uint num = 1268972463u;
			num = 1228361905u >> (int)num;
			return _50BC27AC;
		}

		public override uint _3503DA1F()
		{
			uint num = 2635828765u;
			return (uint)_50BC27AC;
		}

		public override ushort AD1962B2()
		{
			uint num = 1521061644u;
			num /= 663735174;
			sbyte num2 = _50BC27AC;
			num = 0x24A60D9F | num;
			return (ushort)num2;
		}

		public override Type D293A3AF()
		{
			uint num = 302252219u;
			return typeof(sbyte);
		}

		public override int _6527EC0E()
		{
			uint num = 135447451u;
			return _50BC27AC;
		}

		public override B7078183 A883CB02()
		{
			int _1B2FFB = _6527EC0E();
			uint num = 2452323753u;
			return new B7035AA0(_1B2FFB);
		}

		public _15343925(sbyte A12BAD3B)
		{
			uint num = 3784748722u;
			num = 707604625 + num;
			_50BC27AC = A12BAD3B;
		}
	}

	private sealed class A19A9A2F
	{
		private Type _072746AD;

		private uint _4C8CF73A;

		private Type[] C308B280;

		private AA9D8630 _481B631D;

		public bool A1806235
		{
			get
			{
				uint num = 3532967047u;
				AA9D8630 num2 = _481B631D;
				int num3 = (int)num ^ -762000248;
				num = 4105611945u * num;
				AA9D8630 aA9D = (AA9D8630)((int)num2 & num3);
				while (true)
				{
					switch (aA9D)
					{
					default:
						goto IL_0053;
					case AA9D8630._4826AB98:
					case AA9D8630.C88800B3:
					case AA9D8630.A79BB7B8:
					case AA9D8630._2D041329:
					case AA9D8630._9223419A:
					case AA9D8630.AA930EB0:
					case AA9D8630.FA955504:
					case AA9D8630._3E851F9F:
						num = 1653228469 - num;
						return (byte)(num - 2055444629) != 0;
					case AA9D8630.D5A17F88:
					case AA9D8630.A837D686:
					case AA9D8630._991D3628:
					case AA9D8630._55A7608E:
						break;
					}
					break;
					IL_0053:
					if (2853587512u <= num)
					{
						num += 0;
						break;
					}
				}
				return (byte)(num - 3892751135u) != 0;
			}
		}

		public CallingConvention _8939B299
		{
			get
			{
				uint num = 3072811789u;
				AA9D8630 num2 = _481B631D;
				num = 2030143777 % num;
				int num3 = (int)num2 & (int)(num ^ 0x7901892E);
				num = 0x60AAE225 | num;
				AA9D8630 aA9D = (AA9D8630)num3;
				num *= 1093179152;
				switch (aA9D - ((int)num + -624526671))
				{
				case AA9D8630._4826AB98:
					return (CallingConvention)(num ^ 0x25398552);
				case AA9D8630.C88800B3:
					return (CallingConvention)((int)num + -624526669);
				case AA9D8630.A79BB7B8:
					num ^= 0x8C11A8B5u;
					return (CallingConvention)(num + 1456984607);
				case AA9D8630._2D041329:
					return (CallingConvention)(num ^ 0x25398555);
				default:
					num ^= 0x13289632;
					return (CallingConvention)(num ^ 0x36111363);
				}
			}
		}

		public Type _5F8F8080
		{
			get
			{
				uint num = 763432739u;
				return _072746AD;
			}
		}

		public A19A9A2F()
		{
			uint num = 3149713414u;
			num /= 2199142934u;
		}

		public void DAA1F320(byte[] _93B75EBB, Module _6DBA06A9)
		{
			uint num = 1108978834u;
			while (true)
			{
				IL_0006:
				_3900AE97 _3900AE98 = new _3900AE97(_93B75EBB);
				if (-1659850494 << (int)num != 0)
				{
					goto IL_0020;
				}
				goto IL_0064;
				IL_0064:
				num = 0x22BDDD9E ^ num;
				num /= 3976575663u;
				_4C8CF73A = _3900AE98._4917C10A();
				num += 771751936;
				goto IL_0089;
				IL_0089:
				num %= 3155959300u;
				AA9D8630 num2 = _481B631D;
				num += 590038788;
				AA9D8630 aA9D = (AA9D8630)((int)num2 & ((int)num + -1361790709));
				num = 1880880311u >> (int)num;
				switch (aA9D)
				{
				case AA9D8630._4826AB98:
				case AA9D8630.C88800B3:
				case AA9D8630.A79BB7B8:
				case AA9D8630._2D041329:
				case AA9D8630._9223419A:
				case AA9D8630.AA930EB0:
				case AA9D8630._991D3628:
				case AA9D8630.FA955504:
				case AA9D8630._3E851F9F:
					goto IL_00fd;
				case AA9D8630.D5A17F88:
					goto IL_01f8;
				case AA9D8630.A837D686:
				case AA9D8630._55A7608E:
					goto IL_0222;
				}
				if (num - 681234737 != 0)
				{
					if ((0x41B0DD1C ^ num) != 0)
					{
						break;
					}
					continue;
				}
				goto IL_0043;
				IL_0222:
				num = 3910684831u >> (int)num;
				uint num3 = _3900AE98._4917C10A();
				num %= 2644372779u;
				uint num4 = num3;
				num = (uint)(113139761 << (int)num);
				num -= 3148619166u;
				Type[] c308B = new Type[num4];
				num &= 0xB12BABB1u;
				C308B280 = c308B;
				num = 0xAEB0123Du | num;
				int num5 = (int)(num + 1078939075);
				while (591018130u >> (int)num != 0)
				{
					int num6 = num5;
					num = 739759266 * num;
					long num7 = num6;
					num *= 599739149;
					num &= 0x27BF18A8;
					long num8 = num4;
					num += 1502168970;
					if (num7 < num8)
					{
						num = 4027033770u;
						num = 4004814210u * num;
						Type[] c308B2 = C308B280;
						num *= 3912101010u;
						int num9 = num5;
						num = 3357046835u - num;
						Type type = _3900AE98.C1228F92(_6DBA06A9);
						num = 0x7315BABC | num;
						c308B2[num9] = type;
						if (1771357862 - num == 0)
						{
							goto IL_0006;
						}
						int num10 = num5;
						int num11 = (int)num ^ -205669634;
						num -= 2955365180u;
						int num12 = num10 + num11;
						num /= 3927060253u;
						num5 = num12;
						num ^= 0xBFB0B23Du;
						continue;
					}
					if (num % 4105661246u == 0)
					{
						break;
					}
					return;
				}
				goto IL_0020;
				IL_0043:
				num = (uint)(1018737966 << (int)num);
				if (((uint)_481B631D & (uint)((int)num + -771751920)) != 0)
				{
					goto IL_0064;
				}
				goto IL_0089;
				IL_01f8:
				if (num < 3827446838u)
				{
					num = 2384129425u / num;
					Type type2 = _3900AE98.C1228F92(_6DBA06A9);
					num -= 2131084091;
					_072746AD = type2;
					return;
				}
				continue;
				IL_0020:
				num <<= 6;
				_481B631D = (AA9D8630)_3900AE98._56117B96();
				num = (uint)(1503934520 << (int)num);
				goto IL_0043;
				IL_00fd:
				num = 993754886u >> (int)num;
				uint num13 = _3900AE98._4917C10A();
				num = 169243411u >> (int)num;
				uint num14 = num13;
				num = 235834901 / num;
				num = 1510749207 / num;
				num = 0xB485E3A2u | num;
				Type type3 = _3900AE98.C1228F92(_6DBA06A9);
				num = 0xF93A3C1Bu | num;
				_072746AD = type3;
				num = (uint)(-2110619201 << (int)num);
				C308B280 = new Type[num14];
				num ^= 0x9102D027u;
				int num15 = (int)(num - 1761792039);
				while (true)
				{
					num = 1235551933 * num;
					if (num15 < num14)
					{
						num = 2579029896u;
						if (num << 30 != 0)
						{
							break;
						}
						Type[] c308B3 = C308B280;
						num += 3248862627u;
						int num16 = num15;
						num = 0x46B32C21 | num;
						num &= 0xE7328A0Du;
						Type type4 = _3900AE98.C1228F92(_6DBA06A9);
						num |= 0x4E015399;
						c308B3[num16] = type4;
						if ((0x7A9A670B ^ num) != 0)
						{
							int num17 = num15;
							int num18 = (int)num + -1328798616;
							num /= 310768010;
							num15 = num17 + num18;
							num ^= 0x6902D023;
							continue;
						}
						goto IL_0043;
					}
					return;
				}
				goto IL_0020;
			}
			uint errorCode = num + 2031178478;
			num >>= 14;
			throw new COMException(null, (int)errorCode);
		}

		public Type[] _1E8FD139()
		{
			uint num = 4001473072u;
			num = (uint)(2058444548 << (int)num);
			return C308B280;
		}
	}

	private sealed class _3112BC99 : _128A201A
	{
		private Type B01C56A6;

		private IntPtr CAA72EA0;

		public override Type D293A3AF()
		{
			uint num = 4131257250u;
			return typeof(Pointer);
		}

		public override uint _3503DA1F()
		{
			uint num = 2080500012u;
			return (uint)Marshal.ReadInt32(CAA72EA0);
		}

		public override ushort AD1962B2()
		{
			uint num = 1127938818u;
			return (ushort)Marshal.ReadInt16(CAA72EA0);
		}

		public override char D31384B4()
		{
			uint num = 3548589876u;
			IntPtr cAA72EA = CAA72EA0;
			num = 4079202840u >> (int)num;
			return (char)Marshal.ReadInt16(cAA72EA);
		}

		public override IntPtr _27832122()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 2609449124u;
				if (size != 4)
				{
					if (797906109 << (int)num != 0)
					{
						IntPtr cAA72EA = CAA72EA0;
						num &= 0x8631C3B6u;
						value = Marshal.ReadInt64(cAA72EA);
						break;
					}
					continue;
				}
				num = 0x131AA41D | num;
				int num2 = Marshal.ReadInt32(CAA72EA0);
				num = 3164013495u % num;
				value = num2;
				num += 1627761066;
				break;
			}
			return new IntPtr(value);
		}

		public override short E39CE9A9()
		{
			IntPtr cAA72EA = CAA72EA0;
			uint num = 3666760383u;
			return Marshal.ReadInt16(cAA72EA);
		}

		public override object _9F320096()
		{
			uint num;
			do
			{
				IL_0000:
				if (!B01C56A6.IsValueType)
				{
					while (true)
					{
						num = 1361908401u;
						TypeCode typeCode = Type.GetTypeCode(B01C56A6);
						num /= 2343818119u;
						while (true)
						{
							int num2 = (int)typeCode - (int)(num ^ 4);
							num += 4230956040u;
							switch (num2)
							{
							case 1:
							{
								IntPtr cAA72EA3 = CAA72EA0;
								num |= 0xE3AD5C06u;
								sbyte num3 = (sbyte)Marshal.ReadByte(cAA72EA3);
								num -= 629942076;
								return num3;
							}
							case 2:
								break;
							case 0:
								goto end_IL_0030;
							case 3:
								num -= 740082219;
								return Marshal.ReadInt16(CAA72EA0);
							case 4:
							{
								short num5 = Marshal.ReadInt16(CAA72EA0);
								num = 0xF3038B01u ^ num;
								ushort num6 = (ushort)num5;
								num /= 1160234391;
								return num6;
							}
							case 5:
							{
								num = 0x832FEBADu ^ num;
								IntPtr cAA72EA4 = CAA72EA0;
								num += 1790783884;
								int num4 = Marshal.ReadInt32(cAA72EA4);
								num = 3020390671u * num;
								return num4;
							}
							case 6:
								goto IL_017a;
							case 7:
								goto IL_01a7;
							case 8:
							{
								num ^= 0xF9834A33u;
								if (num > 2583800606u)
								{
									continue;
								}
								IntPtr cAA72EA2 = CAA72EA0;
								num = 2670572091u >> (int)num;
								return (ulong)Marshal.ReadInt64(cAA72EA2);
							}
							case 9:
							{
								num /= 2745111682u;
								IntPtr cAA72EA = CAA72EA0;
								num <<= 1;
								byte[] bytes2 = BitConverter.GetBytes(Marshal.ReadInt32(cAA72EA));
								num = 4138385580u / num;
								uint startIndex = num - 2069192790;
								num = 1116030132 % num;
								return BitConverter.ToSingle(bytes2, (int)startIndex);
							}
							case 10:
							{
								num = (uint)(747431956 << (int)num);
								num = 201578783 % num;
								byte[] bytes = BitConverter.GetBytes(Marshal.ReadInt64(CAA72EA0));
								num = 3766897316u + num;
								return BitConverter.ToDouble(bytes, (int)num ^ -326491197);
							}
							default:
								goto IL_027f;
							}
							break;
						}
						num >>= 3;
						if (num >> 13 != 0)
						{
							num *= 3792338879u;
							byte num7 = Marshal.ReadByte(CAA72EA0);
							num <<= 1;
							return num7;
						}
						continue;
						end_IL_0030:
						break;
					}
					if ((0x7E339DBD ^ num) != 0)
					{
						short num8 = Marshal.ReadInt16(CAA72EA0);
						num >>= 27;
						ushort num9 = (ushort)num8;
						num ^= 0xE3846EB7u;
						return (char)num9;
					}
				}
				IntPtr cAA72EA5 = CAA72EA0;
				num = 1251219729u;
				Type b01C56A = B01C56A6;
				num = 0xD1178028u ^ num;
				return Marshal.PtrToStructure(cAA72EA5, b01C56A);
				IL_017a:
				num = 0x73044206 | num;
				if (3485130380u + num != 0)
				{
					num >>= 14;
					return (uint)Marshal.ReadInt32(CAA72EA0);
				}
				goto IL_0000;
				IL_027f:
				num >>= 27;
				continue;
				IL_01a7:
				if (2712882319u < num)
				{
					long num10 = Marshal.ReadInt64(CAA72EA0);
					num = 545766024 + num;
					return num10;
				}
				goto IL_0000;
			}
			while ((int)num + -108904010 == 0);
			throw new ArgumentException();
		}

		public override int _6527EC0E()
		{
			uint num = 1770161050u;
			return Marshal.ReadInt32(CAA72EA0);
		}

		public override D3B95303 _5C36403F()
		{
			IntPtr cAA72EA = CAA72EA0;
			uint num = 2854589239u;
			return new _3112BC99(cAA72EA, B01C56A6);
		}

		public override long _249CC8BD()
		{
			uint num = 1066269489u;
			return Marshal.ReadInt64(CAA72EA0);
		}

		public override void DE8C17B9(object F3913715)
		{
			uint num = 1854205328u;
			if (2065068972u >> (int)num != 0)
			{
				while (F3913715 != null || num <= 397950223)
				{
					while (true)
					{
						num = 0x250E1CB8 | num;
						Type b01C56A = B01C56A6;
						num *= 3191445931u;
						if (b01C56A.IsValueType)
						{
							num = 732789150 * num;
							num >>= 18;
							IntPtr cAA72EA = CAA72EA0;
							uint fDeleteOld = num ^ 0x161A;
							num &= 0x1FAC342D;
							Marshal.StructureToPtr(F3913715, cAA72EA, (byte)fDeleteOld != 0);
							return;
						}
						num = (uint)(-2086617170 << (int)num);
						if (822943797 / num != 0)
						{
							break;
						}
						Type type = F3913715.GetType();
						num = 3514896447u % num;
						TypeCode typeCode = Type.GetTypeCode(type);
						num = 3141091117u / num;
						while (true)
						{
							num = 0x94BFC29Au | num;
							int num2 = (int)typeCode - (int)(num ^ 0x94BFC29Fu);
							num -= 3147419962u;
							switch (num2)
							{
							case 1:
								break;
							case 2:
								goto IL_0137;
							case 0:
							{
								num %= 2165977735u;
								IntPtr cAA72EA4 = CAA72EA0;
								num <<= 13;
								num >>= 25;
								Marshal.WriteInt16(cAA72EA4, Convert.ToChar(F3913715));
								return;
							}
							case 3:
								goto IL_019a;
							case 4:
								goto IL_01bf;
							case 5:
								goto IL_01f6;
							case 6:
								goto IL_0223;
							case 7:
							{
								if (-368690004 * (int)num == 0)
								{
									continue;
								}
								IntPtr cAA72EA3 = CAA72EA0;
								num = 0x8D357D88u ^ num;
								num >>= 18;
								long val2 = Convert.ToInt64(F3913715);
								num >>= 24;
								Marshal.WriteInt64(cAA72EA3, val2);
								return;
							}
							case 8:
							{
								IntPtr cAA72EA2 = CAA72EA0;
								num = 1647868981 - num;
								ulong val = Convert.ToUInt64(F3913715);
								num %= 260690694;
								Marshal.WriteInt64(cAA72EA2, (long)val);
								return;
							}
							case 9:
								goto IL_02bd;
							case 10:
								goto IL_0315;
							default:
								goto IL_0368;
							}
							break;
						}
						num = 0x82B28603u | num;
						IntPtr cAA72EA5 = CAA72EA0;
						num = 0xD0946583u & num;
						num = 2868920735u + num;
						Marshal.WriteByte(cAA72EA5, (byte)Convert.ToSByte(F3913715));
						if (num + 2005192383 != 0)
						{
							return;
						}
						continue;
						IL_01f6:
						if (num < 3784092315u)
						{
							num = 520765074 + num;
							IntPtr cAA72EA6 = CAA72EA0;
							num = 1135602695 * num;
							Marshal.WriteInt32(cAA72EA6, Convert.ToInt32(F3913715));
							return;
						}
						continue;
						IL_0137:
						num = (uint)(-1341657305 << (int)num);
						IntPtr cAA72EA7 = CAA72EA0;
						byte val3 = Convert.ToByte(F3913715);
						num = (uint)(1627512466 << (int)num);
						Marshal.WriteByte(cAA72EA7, val3);
						if (-1526432087 == (int)num)
						{
							break;
						}
						return;
					}
					break;
					IL_01bf:
					num += 448578224;
					num = 0x82302596u ^ num;
					IntPtr cAA72EA8 = CAA72EA0;
					short val4 = (short)Convert.ToUInt16(F3913715);
					num = 0x50A4AC01 | num;
					Marshal.WriteInt16(cAA72EA8, val4);
					if (num - 314233503 != 0)
					{
						return;
					}
					continue;
					IL_02bd:
					num = 236772510u >> (int)num;
					if (num * 2114114616 != 0)
					{
						num <<= 22;
						IntPtr cAA72EA9 = CAA72EA0;
						float value = Convert.ToSingle(F3913715);
						num |= 0xC9A3E36;
						Marshal.WriteInt32(cAA72EA9, BitConverter.ToInt32(BitConverter.GetBytes(value), (int)(num + 1613087178)));
						if (1111429810 <= num)
						{
							return;
						}
					}
					continue;
					IL_0368:
					num ^= 0x86D0A6;
					if (3097411757u < num)
					{
						throw new ArgumentException();
					}
					continue;
					IL_0223:
					num = 2587732378u >> (int)num;
					if (2098680982 << (int)num != 0)
					{
						num = 1110040604 - num;
						IntPtr cAA72EA10 = CAA72EA0;
						num -= 1025731980;
						Marshal.WriteInt32(cAA72EA10, (int)Convert.ToUInt32(F3913715));
						return;
					}
					continue;
					IL_0315:
					if (num / 2142211643 == 0)
					{
						break;
					}
					IntPtr cAA72EA11 = CAA72EA0;
					double value2 = Convert.ToDouble(F3913715);
					num = 0x9D91FD98u | num;
					byte[] bytes = BitConverter.GetBytes(value2);
					int startIndex = (int)num ^ -575275527;
					num %= 2022458273;
					long val5 = BitConverter.ToInt64(bytes, startIndex);
					num = 0xB697B522u ^ num;
					Marshal.WriteInt64(cAA72EA11, val5);
					if ((0x90B24A15u ^ num) != 0)
					{
						return;
					}
					continue;
					IL_019a:
					num = 3325513989u * num;
					Marshal.WriteInt16(CAA72EA0, Convert.ToInt16(F3913715));
					if (num > 471590039)
					{
						return;
					}
				}
			}
			throw new ArgumentException();
		}

		public override double DB900D19()
		{
			long value = Marshal.ReadInt64(CAA72EA0);
			uint num = 2265237643u;
			byte[] bytes = BitConverter.GetBytes(value);
			num = 4077894168u + num;
			int startIndex = (int)num + -2048164515;
			num <<= 18;
			return BitConverter.ToDouble(bytes, startIndex);
		}

		public override sbyte _6C14C0B7()
		{
			uint num = 3867529115u;
			IntPtr cAA72EA = CAA72EA0;
			num = 0x531EB12C | num;
			return (sbyte)Marshal.ReadByte(cAA72EA);
		}

		public override UIntPtr _1DB07EA4()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 2182139684u;
				int num2 = (int)num ^ -2112827616;
				num = 2235116830u >> (int)num;
				if (size != num2)
				{
					num -= 8987796;
					num = 0x7AA22334 | num;
					value = Marshal.ReadInt64(CAA72EA0);
					break;
				}
				num = 3406755241u >> (int)num;
				if (2198276384u / num != 0)
				{
					int num3 = Marshal.ReadInt32(CAA72EA0);
					num = 2460152747u - num;
					value = (uint)num3;
					num += 3980910873u;
					break;
				}
			}
			return new UIntPtr((ulong)value);
		}

		public override ulong _588AFCB3()
		{
			uint num = 1074066735u;
			IntPtr cAA72EA = CAA72EA0;
			num = 0xAF86703Bu | num;
			return (ulong)Marshal.ReadInt64(cAA72EA);
		}

		public override byte _6E94D6A9()
		{
			uint num = 654386562u;
			num = 3550610461u + num;
			IntPtr cAA72EA = CAA72EA0;
			num = 2007435561 + num;
			return Marshal.ReadByte(cAA72EA);
		}

		public override float DEAE8E8E()
		{
			uint num = 1494188733u;
			int value = Marshal.ReadInt32(CAA72EA0);
			num = 3483916570u % num;
			byte[] bytes = BitConverter.GetBytes(value);
			num = 430008743 / num;
			uint startIndex = num ^ 0;
			num *= 3325644704u;
			return BitConverter.ToSingle(bytes, (int)startIndex);
		}

		public _3112BC99(IntPtr _7604EA85, Type _9D2C98A9)
		{
			uint num = 153920652u;
			do
			{
				num *= 464580145;
				num = 0x85362C81u & num;
				if (num != 1982874933)
				{
					num &= 0xA629A980u;
					CAA72EA0 = _7604EA85;
				}
				B01C56A6 = _9D2C98A9;
			}
			while (598597425 / num == 0);
		}
	}

	private sealed class _88BA7B16 : B7078183
	{
		private D3B95303 _0A1589BA;

		private IntPtr _66ADE891;

		public override bool C9093688()
		{
			IntPtr intPtr = _66ADE891;
			IntPtr zero = IntPtr.Zero;
			uint num = 2813783938u;
			return intPtr != zero;
		}

		public override float DEAE8E8E()
		{
			uint num = 1203677712u;
			D3B95303 d3B = _0A1589BA;
			num <<= 22;
			return d3B.DEAE8E8E();
		}

		public static D3B95303 _3E1D40A2(D3B95303 _5735211D, D3B95303 _2E2D090B)
		{
			uint num = 4264353176u;
			int size = IntPtr.Size;
			num = 2971352068u * num;
			if (size != (int)num - -206891428)
			{
				num = 1955487247 / num;
			}
			else
			{
				num /= 1369483786;
				if ((num & 0x2289FD14) == 0)
				{
					num *= 185863995;
					num = 3398997552u % num;
					return B7035AA0._923FD533(_5735211D, _2E2D090B);
				}
			}
			num = 294993541u >> (int)num;
			return D51696A5._31051F05(_5735211D, _2E2D090B);
		}

		public static D3B95303 AB230425(D3B95303 C6B665BB, D3B95303 B82EA5A4)
		{
			uint num = 4212669584u;
			if (1930174996 < num)
			{
				int size = IntPtr.Size;
				num = 1493401356 % num;
				if (size == (int)(num - 1493401352) && -1870122069 != (int)num)
				{
					return B7035AA0._8631ED1D(C6B665BB, B82EA5A4);
				}
			}
			num *= 3162956727u;
			num = 1237110843 % num;
			return D51696A5.FFA08636(C6B665BB, B82EA5A4);
		}

		public override uint _3503DA1F()
		{
			uint num = 2669492630u;
			return _0A1589BA._3503DA1F();
		}

		public override short E39CE9A9()
		{
			uint num = 462201357u;
			num /= 213641110;
			return _0A1589BA.E39CE9A9();
		}

		public override sbyte _6C14C0B7()
		{
			uint num = 1437043077u;
			num -= 3634243097u;
			return _0A1589BA._6C14C0B7();
		}

		public override D3B95303 _5C36403F()
		{
			uint num = 2318047287u;
			return new _88BA7B16(_66ADE891);
		}

		public static D3B95303 _6A122385(D3B95303 BB2F481E, D3B95303 BB829081)
		{
			uint num = 1872601261u;
			if (num <= 4229918724u)
			{
				int size = IntPtr.Size;
				num -= 4010116541u;
				if (size == (int)(num ^ 0x80981AF4u))
				{
					return B7035AA0.C025E52A(BB2F481E, BB829081);
				}
			}
			num = 0x9F3E0FABu & num;
			return D51696A5.C534C01C(BB2F481E, BB829081);
		}

		public override byte _6E94D6A9()
		{
			uint num = 1262123270u;
			D3B95303 d3B = _0A1589BA;
			num = (uint)(-1465610596 << (int)num);
			return d3B._6E94D6A9();
		}

		public override int _6527EC0E()
		{
			uint num = 126941983u;
			return _0A1589BA._6527EC0E();
		}

		public static D3B95303 AB1F9D3A(D3B95303 _072090BA, D3B95303 _690ADCA3)
		{
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 4281053198u;
				if (size == (int)(num ^ 0xFF2BB00Au))
				{
					break;
				}
				if (87646735 <= num)
				{
					return D51696A5._9F01DB27(_072090BA, _690ADCA3);
				}
			}
			num = 3658150193u - num;
			num = 4213740457u >> (int)num;
			return B7035AA0._93862D8D(_072090BA, _690ADCA3);
		}

		public override UIntPtr _1DB07EA4()
		{
			D3B95303 d3B = _0A1589BA;
			uint num = 1485431593u;
			return d3B._1DB07EA4();
		}

		public override void DE8C17B9(object A8B077BD)
		{
			uint num;
			do
			{
				_66ADE891 = (IntPtr)A8B077BD;
				num = 1930891568u;
				num = 1200562603 % num;
				IntPtr d886EEA = _66ADE891;
				num *= 453985966;
				D3B95303 d3B = _1B1091AE(d886EEA);
				num = 0xD70C1DB8u ^ num;
				_0A1589BA = d3B;
			}
			while (2769622297u <= num);
		}

		public override IntPtr _27832122()
		{
			return _66ADE891;
		}

		public override object _9F320096()
		{
			uint num = 1125022604u;
			IntPtr intPtr = _66ADE891;
			num = 0xC7053C31u ^ num;
			return intPtr;
		}

		public static D3B95303 F73B6736(D3B95303 _80AF9609, D3B95303 BC980035)
		{
			int size = IntPtr.Size;
			uint num = 3792665263u;
			int num2 = (int)num ^ -502302037;
			num = 2534246665u >> (int)num;
			if (size != num2)
			{
				num |= 0xFB373EAEu;
			}
			else
			{
				num >>= 1;
				if (num <= 3515217805u)
				{
					num &= 0x1BAE2314;
					return B7035AA0._668C7D8D(_80AF9609, BC980035);
				}
			}
			num = (uint)(1627985182 << (int)num);
			return D51696A5._4CAC8707(_80AF9609, BC980035);
		}

		private static D3B95303 _1B1091AE(IntPtr D886EEA1)
		{
			uint num = 2386214328u;
			int size = IntPtr.Size;
			int num2 = (int)num ^ -1908752964;
			num = 4248035849u >> (int)num;
			if (size == num2)
			{
				num &= 0xDAE5926;
				int _1B2FFB = D886EEA1.ToInt32();
				num *= 1160939672;
				return new B7035AA0(_1B2FFB);
			}
			num = 0xF235DBB9u & num;
			long _390BF = D886EEA1.ToInt64();
			num = 2503550381u + num;
			return new D51696A5(_390BF);
		}

		public static D3B95303 C708CC27(D3B95303 _111C7386)
		{
			uint num;
			do
			{
				int size = IntPtr.Size;
				num = 1527307576u;
				uint num2 = num - 1527307572;
				num = 3140238738u / num;
				if (size != (int)num2)
				{
					num = 0x6967EAF | num;
					if ((0xB386963Au ^ num) != 0)
					{
						num = 1379389749 - num;
						return D51696A5._28A6C113(_111C7386);
					}
				}
			}
			while (3750276888u < num);
			return B7035AA0.D715A43D(_111C7386);
		}

		public override ushort AD1962B2()
		{
			uint num = 2734813354u;
			return _0A1589BA.AD1962B2();
		}

		public override ulong _588AFCB3()
		{
			uint num = 3140206638u;
			num = 1577863096 - num;
			return _0A1589BA._588AFCB3();
		}

		public override double DB900D19()
		{
			uint num = 3985393413u;
			num &= 0xCC06519Au;
			return _0A1589BA.DB900D19();
		}

		public static D3B95303 BF82C39A(D3B95303 _7B2A85B0, D3B95303 _559EFA23)
		{
			uint num;
			while (IntPtr.Size != 4)
			{
				num = 277135507u;
				if ((num & 0x1F21C711) != 0)
				{
					return D51696A5._0C1AAC0A(_7B2A85B0, _559EFA23);
				}
			}
			num = 1201400110u;
			return B7035AA0._308A7609(_7B2A85B0, _559EFA23);
		}

		public static D3B95303 _1105CE02(D3B95303 _6A93D122, D3B95303 EFAC540B)
		{
			int size = IntPtr.Size;
			uint num = 4136242958u;
			if (size != 4)
			{
				num = 196010669 + num;
				num |= 0x981B7C87u;
				return D51696A5.CD0D5192(_6A93D122, EFAC540B);
			}
			num %= 908834599;
			num = 4088985501u - num;
			return B7035AA0._52396EA7(_6A93D122, EFAC540B);
		}

		public static D3B95303 _57319600(D3B95303 _02B9AB9D, D3B95303 _6A96B5A2)
		{
			int size = IntPtr.Size;
			uint num = 2402020892u;
			uint num2 = num + 1892946408;
			num = 3602722848u + num;
			if (size != (int)num2)
			{
				return D51696A5._8AB24197(_02B9AB9D, _6A96B5A2);
			}
			num |= 0x908D3793u;
			num = (uint)(95957025 << (int)num);
			return B7035AA0._5C220285(_02B9AB9D, _6A96B5A2);
		}

		public override long _249CC8BD()
		{
			return _0A1589BA._249CC8BD();
		}

		public static D3B95303 D23D7BA5(D3B95303 FB08F9BB, D3B95303 _8A03C0AB)
		{
			while (true)
			{
				if (IntPtr.Size != 4)
				{
					uint num = 4061360647u;
					if (num != 3274004402u)
					{
						return D51696A5._638C5E8D(FB08F9BB, _8A03C0AB);
					}
				}
				else
				{
					uint num = 1921925386u;
					if (num <= 3290800528u)
					{
						break;
					}
				}
			}
			return B7035AA0._44818004(FB08F9BB, _8A03C0AB);
		}

		public override Type D293A3AF()
		{
			return typeof(IntPtr);
		}

		public _88BA7B16(IntPtr _09B27790)
		{
			uint num;
			do
			{
				num = 515742262u;
				num += 3812051258u;
				if ((0x3F96BAAA & num) != 0)
				{
					_66ADE891 = _09B27790;
					num &= 0xBF875603u;
					if (num % 1002290977 == 0)
					{
						break;
					}
				}
				num = 0xB0BB0E3Cu ^ num;
				IntPtr d886EEA = _66ADE891;
				num = 3911411625u * num;
				_0A1589BA = _1B1091AE(d886EEA);
			}
			while (num > 3793682946u);
		}
	}

	private sealed class _3BA48917 : B7078183
	{
		private D3B95303 _0819F9A8;

		private Enum D7BB0309;

		public override ushort AD1962B2()
		{
			D3B95303 d3B = _0819F9A8;
			uint num = 2402110512u;
			return d3B.AD1962B2();
		}

		public override long _249CC8BD()
		{
			uint num = 932004146u;
			num = 0x3C02B001 & num;
			return _0819F9A8._249CC8BD();
		}

		public override float DEAE8E8E()
		{
			uint num = 1847397439u;
			num %= 3266652072u;
			D3B95303 d3B = _0819F9A8;
			num = 3064859945u + num;
			return d3B.DEAE8E8E();
		}

		public override IntPtr _27832122()
		{
			int size = IntPtr.Size;
			uint num = 2300227263u;
			long value;
			if (size != (int)(num ^ 0x891AAEBBu))
			{
				num = 759160850 * num;
				value = _249CC8BD();
			}
			else
			{
				int num2 = _6527EC0E();
				num = 0x19161382 & num;
				value = num2;
				num ^= 0x99DA6BECu;
			}
			return new IntPtr(value);
		}

		public override Type D293A3AF()
		{
			uint num = 2847574296u;
			return D7BB0309.GetType();
		}

		public override object _9F320096()
		{
			uint num = 2592308906u;
			return D7BB0309;
		}

		public override sbyte _6C14C0B7()
		{
			uint num = 2391876375u;
			num = 672288524 * num;
			return _0819F9A8._6C14C0B7();
		}

		public override int _6527EC0E()
		{
			uint num = 303230216u;
			num %= 2788192002u;
			D3B95303 d3B = _0819F9A8;
			num <<= 5;
			return d3B._6527EC0E();
		}

		private static D3B95303 E08051AE(Enum _5C00BB8F)
		{
			TypeCode typeCode = _5C00BB8F.GetTypeCode();
			uint num;
			do
			{
				num = 3727661110u;
				int num2 = (int)num ^ -567306189;
				num -= 991644092;
				TypeCode num3 = typeCode - num2;
				num |= 0x7B33181F;
				switch (num3)
				{
				case TypeCode.Object:
				case TypeCode.Boolean:
				case TypeCode.SByte:
					num = 0x90C291A ^ num;
					num >>= 31;
					return new B7035AA0((int)Convert.ToUInt32(_5C00BB8F));
				case TypeCode.Empty:
				case TypeCode.DBNull:
				case TypeCode.Char:
					num = 1018954404 / num;
					if ((num & 0x8C1BFC13u) == 0)
					{
						return new B7035AA0(Convert.ToInt32(_5C00BB8F));
					}
					break;
				case TypeCode.Int16:
					break;
				case TypeCode.Byte:
					return new D51696A5(Convert.ToInt64(_5C00BB8F));
				default:
					num += 387508643;
					throw new InvalidOperationException();
				}
			}
			while (1906257809 > num);
			ulong _390BF = Convert.ToUInt64(_5C00BB8F);
			num ^= 0xBC91FD37u;
			return new D51696A5((long)_390BF);
		}

		public override byte _6E94D6A9()
		{
			D3B95303 d3B = _0819F9A8;
			uint num = 2695088166u;
			return d3B._6E94D6A9();
		}

		public override uint _3503DA1F()
		{
			return _0819F9A8._3503DA1F();
		}

		public override ulong _588AFCB3()
		{
			D3B95303 d3B = _0819F9A8;
			uint num = 3164666787u;
			return d3B._588AFCB3();
		}

		public override double DB900D19()
		{
			uint num = 2443577109u;
			num |= 0xE01359A1u;
			D3B95303 d3B = _0819F9A8;
			num = 4038042135u + num;
			return d3B.DB900D19();
		}

		public override D3B95303 _5C36403F()
		{
			uint num = 1108520633u;
			Enum d7BB = D7BB0309;
			num = 0xD2B43B7 ^ num;
			return new _3BA48917(d7BB);
		}

		public override short E39CE9A9()
		{
			uint num = 2544797612u;
			D3B95303 d3B = _0819F9A8;
			num &= 0x14242796;
			return d3B.E39CE9A9();
		}

		public override void DE8C17B9(object BC178C8C)
		{
			uint num;
			do
			{
				num = 2964916157u;
				if (BC178C8C == null)
				{
					num <<= 30;
					throw new ArgumentException();
				}
				num = 0xC117CD9Fu | num;
				num = 0x8AA2E3B6u & num;
				Enum d7BB = (Enum)BC178C8C;
				num <<= 1;
				D7BB0309 = d7BB;
				num &= 0x4A135525;
			}
			while (num > 1958192441);
			do
			{
				num &= 0x5E2FFB91;
				num = 1579542558 / num;
				_0819F9A8 = E08051AE(D7BB0309);
			}
			while ((0xA48B7C8Fu ^ num) == 0);
		}

		public override UIntPtr _1DB07EA4()
		{
			uint num = 3726401710u;
			long value;
			if (num / 2100502404 == 0 || (IntPtr.Size != (int)(num ^ 0xDE1C60AAu) && num << 31 == 0))
			{
				num = 632383032 * num;
				value = (long)_588AFCB3();
			}
			else
			{
				num = 3976452890u % num;
				num = 3568078500u >> (int)num;
				uint num2 = _3503DA1F();
				num = 4001881912u >> (int)num;
				value = num2;
				num ^= 0xE3E6FDCFu;
			}
			num |= 0xC8A61306u;
			return new UIntPtr((ulong)value);
		}

		public _3BA48917(Enum _70A60129)
		{
			uint num;
			do
			{
				num = 2302536465u;
				if (num != 495182347)
				{
					while (true)
					{
						if (_70A60129 == null)
						{
							num %= 2955995937u;
							if ((num ^ 0x2D9E4DB0) != 0)
							{
								break;
							}
							continue;
						}
						num ^= 0x2B883183;
						if (3105352251u % num == 0)
						{
							continue;
						}
						goto IL_004b;
					}
				}
				throw new ArgumentException();
				IL_004b:
				num += 2889804722u;
				num = 0xE73302B4u & num;
				D7BB0309 = _70A60129;
				_0819F9A8 = E08051AE(D7BB0309);
			}
			while (4113954231u < num);
		}
	}

	private sealed class _37B6A08E : D3B95303
	{
		private ulong _982864A4;

		public override Type D293A3AF()
		{
			uint num = 331070129u;
			return typeof(ulong);
		}

		public override ulong _588AFCB3()
		{
			uint num = 689007269u;
			return _982864A4;
		}

		public override ushort AD1962B2()
		{
			uint num = 144905140u;
			ulong num2 = _982864A4;
			num = (uint)(-836971882 << (int)num);
			return (ushort)num2;
		}

		public override long _249CC8BD()
		{
			uint num = 3107308589u;
			return (long)_982864A4;
		}

		public override void DE8C17B9(object FBA43E2B)
		{
			uint num = 4080348553u;
			if (num > 1555782181)
			{
				ulong num2 = Convert.ToUInt64(FBA43E2B);
				num &= 0xD30219F;
				_982864A4 = num2;
			}
		}

		public override D3B95303 _5C36403F()
		{
			ulong _3C29118D = _982864A4;
			uint num = 3977175856u;
			return new _37B6A08E(_3C29118D);
		}

		public static D3B95303 _9EB4EABC(D3B95303 E035EA37)
		{
			while (true)
			{
				ulong num = E035EA37._588AFCB3();
				uint num2 = 4144138172u;
				while (true)
				{
					D3B95303 d3B = E035EA37;
					num2 <<= 27;
					int num3 = d3B._6E0A913C();
					int num4 = (int)num2 ^ -536870896;
					num2 /= 1002407469;
					int num5 = num3 & num4;
					uint num6 = num2 ^ 3;
					num2 = 513510288 / num2;
					bool num7 = (uint)num5 > num6;
					uint num8 = num2 - 171170096;
					num2 /= 3617781270u;
					int num9 = (int)num8;
					if (!num7)
					{
						num2 -= 2243143976u;
						if (3896362160u >= num2)
						{
							goto IL_0064;
						}
						goto IL_0091;
					}
					goto IL_00ab;
					IL_0064:
					num2 = 2342454429u >> (int)num2;
					num2 ^= 0x8B;
					if (num > long.MaxValue)
					{
						num2 = 2183841835u - num2;
						goto IL_0091;
					}
					goto IL_00ab;
					IL_00ab:
					num2 &= 0x593183A9;
					if (4095911196u <= num2)
					{
						break;
					}
					D51696A5 d51696A = new D51696A5((long)num);
					num2 ^= 0x4EBE1429;
					E035EA37 = d51696A;
					num2 = 361907128 - num2;
					if (num2 < 2711252282u)
					{
						continue;
					}
					D3B95303 d3B2 = E035EA37;
					num2 = 2039521031 * num2;
					int _6B1C = num9;
					num2 ^= 0xD694FE0Fu;
					d3B2._82A5D1BE(_6B1C);
					num2 = 1856008118 - num2;
					if (num2 / 3661271469u == 0)
					{
						return E035EA37;
					}
					goto IL_0064;
					IL_0091:
					int num10 = num9 | ((int)num2 - -2111125469);
					num2 >>= 3;
					num9 = num10;
					num2 += 4021987067u;
					goto IL_00ab;
				}
			}
		}

		public override sbyte _6C14C0B7()
		{
			uint num = 3054703745u;
			num &= 0xEDB6EA90u;
			ulong num2 = _982864A4;
			num = 3675342236u - num;
			return (sbyte)num2;
		}

		public override B7078183 A883CB02()
		{
			uint num = 71276307u;
			return new D51696A5(_249CC8BD());
		}

		public override uint _3503DA1F()
		{
			uint num = 671103794u;
			ulong num2 = _982864A4;
			num = (uint)(-2054178376 << (int)num);
			return (uint)num2;
		}

		public override byte _6E94D6A9()
		{
			uint num = 3860871040u;
			num /= 2728018315u;
			return (byte)_982864A4;
		}

		public override object _9F320096()
		{
			uint num = 3862645529u;
			return _982864A4;
		}

		public override int _6527EC0E()
		{
			uint num = 3769182891u;
			ulong num2 = _982864A4;
			num = 926827407u >> (int)num;
			return (int)num2;
		}

		public override short E39CE9A9()
		{
			uint num = 3070328369u;
			num >>= 0;
			return (short)_982864A4;
		}

		public _37B6A08E(ulong _3C29118D)
		{
			uint num = 4128286341u;
			if ((num ^ 0xA693C702u) != 0)
			{
				do
				{
					num -= 3708274592u;
					_982864A4 = _3C29118D;
				}
				while (363309203 >= num);
			}
		}
	}

	private sealed class _3209E1AD : _0A94A53A
	{
		private Stack<int> F48B6538;

		private List<EB1F56B8> _783D23B7;

		public override void EB3F1497(int _372A1A13)
		{
			uint num = 53347126u;
			int num2 = 0;
			while (true)
			{
				if ((0xC8B2CA3Fu ^ num) != 0)
				{
					int num3 = num2;
					num <<= 16;
					List<EB1F56B8> list = _783D23B7;
					num = 4163064253u % num;
					int count = list.Count;
					num = 1763756463 - num;
					if (num3 >= count)
					{
						break;
					}
				}
				List<EB1F56B8> list2 = _783D23B7;
				num = 2872976828u;
				if (list2[num2]._7B9F99B2() == _372A1A13 && num >= 361654311)
				{
					Stack<int> f48B = F48B6538;
					int item = num2;
					num -= 3600991796u;
					f48B.Push(item);
					num += 3600991796u;
				}
				num <<= 31;
				int num4 = num2;
				uint num5 = num ^ 1;
				num = (uint)(397896724 << (int)num);
				num2 = num4 + (int)num5;
				num ^= 0x14996F22;
			}
		}

		public int _610B25B5()
		{
			uint num = 126256044u;
			num = 0x88A981A3u & num;
			return F48B6538.Count;
		}

		public EB1F56B8 _4781133B()
		{
			uint num = 3665924122u;
			List<EB1F56B8> list = _783D23B7;
			num = 3316738057u >> (int)num;
			Stack<int> f48B = F48B6538;
			num = 0xE491DC3Cu & num;
			return list[f48B.Pop()];
		}

		public override int _6188C297()
		{
			return 0;
		}

		public _3209E1AD()
		{
			uint num;
			do
			{
				_783D23B7 = new List<EB1F56B8>();
				num = 3265801022u;
				F48B6538 = new Stack<int>();
				num = 0xA28A3A95u ^ num;
			}
			while (1579162275 % num == 0);
			num <<= 22;
		}

		public EB1F56B8 _149F651B()
		{
			uint num = 1888265111u;
			List<EB1F56B8> list = _783D23B7;
			Stack<int> f48B = F48B6538;
			num = 0xFDB16DBDu & num;
			int index = f48B.Peek();
			num >>= 6;
			return list[index];
		}

		public void E82F463E(int C30618A4, int AABCEDA9, byte EA2E949D, int _511746B0, int ABA42A80)
		{
			uint num = 2914426006u;
			EB1F56B8 eB1F56B2 = default(EB1F56B8);
			while (true)
			{
				num -= 2468245428u;
				EB1F56B8 eB1F56B = null;
				while (true)
				{
					IL_0013:
					int num2 = (int)(num ^ 0x1A982CE2);
					while (true)
					{
						int num3 = num2;
						num = (uint)(2039471626 << (int)num);
						List<EB1F56B8> list = _783D23B7;
						num = (uint)(2014808206 << (int)num);
						if (num3 < list.Count)
						{
							num = 3491080117u;
							List<EB1F56B8> list2 = _783D23B7;
							num %= 2468998846u;
							eB1F56B2 = list2[num2];
							num = 0xEE9677B9u ^ num;
							if (num <= 45822468)
							{
								break;
							}
							int num4 = eB1F56B2._7B9F99B2();
							num /= 2793590187u;
							if (num4 == C30618A4)
							{
								if (948521254 / num == 0)
								{
									break;
								}
								goto IL_007a;
							}
							goto IL_00b7;
						}
						num ^= 0x6BA15A7;
						goto IL_0128;
						IL_0128:
						bool flag;
						int num7;
						if (eB1F56B == null)
						{
							uint num5 = num ^ 0x11329BA7;
							num = 2468902966u / num;
							flag = (byte)num5 != 0;
							num -= 3567104826u;
							if (num >> 2 == 0)
							{
								break;
							}
							eB1F56B = new EB1F56B8(C30618A4, AABCEDA9);
							int num6 = (int)num + -727862478;
							num -= 2332954914u;
							num7 = num6;
							if ((num & 0x85290B82u) != 0)
							{
								while (true)
								{
									num &= 0x330FB2BE;
									if (num > 2484680249u)
									{
										break;
									}
									int num8 = num7;
									num = 0xD3AC69D | num;
									int count = _783D23B7.Count;
									num ^= 0x15BDA496;
									if (num8 < count)
									{
										num = 3398582070u;
										if (246985769 >= num)
										{
											break;
										}
										num /= 2861693471u;
										EB1F56B8 eB1F56B3 = _783D23B7[num7];
										num >>= 13;
										EB1F56B8 d532DF = eB1F56B3;
										num = 1168538152 - num;
										EB1F56B8 eB1F56B4 = eB1F56B;
										num /= 1906475952;
										int num9 = eB1F56B4._248EBD09(d532DF);
										uint num10 = num ^ 0;
										num <<= 28;
										if (num9 >= (int)num10)
										{
											int num11 = num7;
											int num12 = (int)num - -1;
											num = 0x528A8B37 ^ num;
											int num13 = num11 + num12;
											num = 4279639346u / num;
											num7 = num13;
											num += 2689874857u;
											continue;
										}
										goto IL_01ed;
									}
									goto IL_02ca;
								}
								break;
							}
							goto IL_0013;
						}
						goto IL_0328;
						IL_0328:
						num = 3450280482u * num;
						EB1F56B8 eB1F56B5 = eB1F56B;
						num = 0x6A1D7D2C & num;
						num = 2293019442u / num;
						eB1F56B5._808CF914(EA2E949D, _511746B0, ABA42A80);
						if (3199409293u < num)
						{
							continue;
						}
						return;
						IL_02d4:
						if ((num & 0x2CB1749F) == 0)
						{
							goto IL_0013;
						}
						bool num14 = flag;
						num &= 0x503E3B8F;
						num ^= 0x113889A7;
						if (!num14)
						{
							if (num >> 9 == 0)
							{
								goto IL_007a;
							}
							num %= 1772861855;
							_783D23B7.Add(eB1F56B);
							num += 0;
						}
						goto IL_0328;
						IL_00b7:
						num = 0x9D2B95B2u ^ num;
						int num15 = num2;
						num = 0x81926812u & num;
						int num16 = (int)num - -2130575343;
						num = 0xA82F1A86u & num;
						num2 = num15 + num16;
						num ^= 0x9A9A2CE0u;
						continue;
						IL_007a:
						EB1F56B8 eB1F56B6 = eB1F56B2;
						num = 0xA8848721u | num;
						int num17 = eB1F56B6.CE8A482E();
						num ^= 0xA8848720u;
						if (num17 != AABCEDA9)
						{
							goto IL_00b7;
						}
						num += 288529318;
						if (num == 3902726182u)
						{
							break;
						}
						eB1F56B = eB1F56B2;
						goto IL_0128;
						IL_02ca:
						num += 3603415109u;
						goto IL_02d4;
						IL_01ed:
						num = (uint)(-750829905 << (int)num);
						if (-1004687687 >>> (int)num == 0)
						{
							break;
						}
						num /= 2084462108;
						List<EB1F56B8> list3 = _783D23B7;
						num -= 3551861258u;
						int index = num7;
						EB1F56B8 item = eB1F56B;
						num &= 0x9202672Cu;
						list3.Insert(index, item);
						num = 4105250575u >> (int)num;
						flag = (byte)(num ^ 0xF4B1271) != 0;
						if ((0x7A98A925 ^ num) == 0)
						{
							continue;
						}
						goto IL_02d4;
					}
					break;
				}
			}
		}
	}

	private sealed class _47B891B7 : D3B95303
	{
		private byte _77233005;

		public static D3B95303 _8E3E80A7(D3B95303 _031E5803)
		{
			while (true)
			{
				ulong num = _031E5803._588AFCB3();
				int num2 = _031E5803._6E0A913C();
				uint num3 = 2973504417u;
				bool num4 = (uint)(num2 & 0x10) > (uint)((int)num3 - -1321462879);
				num3 = 1194568593 + num3;
				int num5 = (int)num3 - -126894286;
				num3 = 1972732289 - num3;
				int num6 = num5;
				num3 = 4127263290u * num3;
				if (num4)
				{
					if (num3 < 3767662754u)
					{
						goto IL_0052;
					}
				}
				else
				{
					num3 = 1789360029u >> (int)num3;
					if (num3 == 3627577011u)
					{
						goto IL_0052;
					}
					num3 = 1720789507 + num3;
					long num7 = (int)num3 + -1748748130;
					num3 /= 3331107635u;
					num3 ^= 0x1462DE2;
					if (num > (ulong)num7)
					{
						num3 = 2500343086u >> (int)num3;
						if ((int)num3 - -1669125755 == 0)
						{
							goto IL_0076;
						}
						num6 |= (int)num3 + -625085763;
						num3 += 3691258007u;
					}
				}
				goto IL_0108;
				IL_0108:
				if (num3 + 2352491194u != 0)
				{
					byte _1B2FFB = (byte)num;
					num3 >>= 12;
					_031E5803 = new B7035AA0(_1B2FFB);
					num3 += 1989437878;
					D3B95303 d3B = _031E5803;
					num3 %= 2484970910u;
					d3B._82A5D1BE(num6);
					num3 = 3674520235u + num3;
					if (3173977621u > num3)
					{
						break;
					}
				}
				continue;
				IL_0076:
				int num8 = num6;
				num3 = 0x721BE313 & num3;
				int num9 = num8 | (int)(num3 ^ 0x72038319);
				num3 -= 1723396609;
				num6 = num9;
				num3 ^= 0xA0CBCF2;
				goto IL_0108;
				IL_0052:
				num3 = 1368094855u >> (int)num3;
				if (num > (ulong)((int)num3 + -21376227))
				{
					num3 -= 2266928781u;
					goto IL_0076;
				}
				goto IL_0108;
			}
			return _031E5803;
		}

		public override D3B95303 _5C36403F()
		{
			uint num = 1034863160u;
			return new _47B891B7(_77233005);
		}

		public override Type D293A3AF()
		{
			uint num = 708541837u;
			num = 4289278491u * num;
			return typeof(byte);
		}

		public override void DE8C17B9(object _54AFB0A1)
		{
			uint num = 1655787190u;
			num = 0x788F5182 | num;
			_77233005 = Convert.ToByte(_54AFB0A1);
		}

		public override byte _6E94D6A9()
		{
			uint num = 4069025166u;
			return _77233005;
		}

		public override int _6527EC0E()
		{
			uint num = 1605957130u;
			return _77233005;
		}

		public override ushort AD1962B2()
		{
			uint num = 3306629004u;
			num = 1605906104 - num;
			return _77233005;
		}

		public override short E39CE9A9()
		{
			uint num = 1728076346u;
			return _77233005;
		}

		public override uint _3503DA1F()
		{
			return _77233005;
		}

		public override B7078183 A883CB02()
		{
			uint num = 564531341u;
			return new B7035AA0(_6527EC0E());
		}

		public override object _9F320096()
		{
			uint num = 2098817062u;
			return _77233005;
		}

		public override sbyte _6C14C0B7()
		{
			uint num = 461754028u;
			byte num2 = _77233005;
			num = (uint)(285588641 << (int)num);
			return (sbyte)num2;
		}

		public _47B891B7(byte _872E3B27)
		{
			uint num = 3474122031u;
			if (num / 1998583204 != 0)
			{
				if (num <= 1117632129)
				{
					return;
				}
			}
			num = 0xF60C010Cu ^ num;
			_77233005 = _872E3B27;
		}
	}

	private abstract class _0A94A53A
	{
		protected _0A94A53A()
		{
			uint num;
			do
			{
				num = 1090537995u;
			}
			while (num >= 1728616885);
		}

		public abstract void EB3F1497(int _92B48007);

		public abstract int _6188C297();
	}

	private sealed class _589EC5AE
	{
		private int CE3D803D;

		private int B4137822;

		private byte C4A869B0;

		public int _210F149B()
		{
			return CE3D803D;
		}

		public int _923D8C35()
		{
			uint num = 859306003u;
			num <<= 15;
			return B4137822;
		}

		public byte _1EB6C302()
		{
			uint num = 1806385167u;
			return C4A869B0;
		}

		public _589EC5AE(byte _19946C8B, int C7B4242A, int _4006AD94)
		{
			uint num = 1158957320u;
			C4A869B0 = _19946C8B;
			num = (uint)(470923438 << (int)num);
			num = (uint)(-1843902032 << (int)num);
			B4137822 = C7B4242A;
			num = 0xFB99A3AEu ^ num;
			if (num * 3198326423u != 0)
			{
				do
				{
					num = 2411167006u - num;
					num = 1141060490 % num;
					CE3D803D = _4006AD94;
				}
				while (num >= 1713409210);
			}
		}
	}

	private sealed class C1BF430A : _0A94A53A
	{
		private uint _818B87BC;

		private Stack<int> B08B8112;

		private uint B932B19B;

		public unsafe short _5F10D3B8()
		{
			uint num = 1024774044u;
			ushort num3 = default(ushort);
			if (num % 1569936063 != 0)
			{
				do
				{
					num = 1755775909 % num;
					uint _5B970F = _818B87BC;
					num += 775624863;
					ushort num2 = *(ushort*)(void*)_441DAF82.EEA4DE97(_5B970F);
					num |= 0x42215A92;
					num3 = num2;
					num = (uint)(-2052755957 << (int)num);
				}
				while (966202657 <= num);
			}
			do
			{
				num /= 2888120747u;
				num = 0x2AAD8383 ^ num;
				uint num4 = _818B87BC;
				num |= 0x96A38692u;
				int num5 = (int)num ^ -1095792751;
				num += 605003067;
				_818B87BC = num4 + (uint)num5;
			}
			while ((num ^ 0xDB0DEB00u) == 0);
			ushort num6 = num3;
			num /= 599415447;
			num %= 3610734883u;
			uint b932B19B = B932B19B;
			num ^= 0xAB1A5815u;
			num3 = (ushort)(num6 ^ b932B19B);
			num = 423474826 - num;
			ushort num7 = num3;
			uint num8 = num ^ 0x6E23486D;
			num &= 0xBEB2219Fu;
			uint num9 = num7 - num8;
			num = 1636447521 - num;
			uint num10 = num ^ 0x33686F39;
			num = 2166753962u + num;
			uint num11 = num9 ^ num10;
			num /= 1479582757;
			num3 = (ushort)(0 - num11 - (num - 1));
			ushort num12 = num3;
			uint num13 = num - 1;
			num = 1159260845 + num;
			int num14 = num12 << (int)num13;
			ushort num15 = num3;
			uint num16 = num ^ 0x4518EAA0;
			num -= 2148878646u;
			int num17 = num15 >>> (int)num16;
			num = 3172926765u % num;
			num3 = (ushort)(num14 | num17);
			num -= 3986511138u;
			num = 3887499142u * num;
			uint b932B19B2 = B932B19B;
			num >>= 21;
			ushort num18 = num3;
			num = 0x5E15201F | num;
			uint b932B19B3 = b932B19B2 ^ num18;
			num <<= 30;
			B932B19B = b932B19B3;
			return (short)num3;
		}

		public void _05903409(int _1130EF07)
		{
			uint num;
			do
			{
				num = 4012709685u;
				Stack<int> b08B = B08B8112;
				num = 3037682688u % num;
				b08B.Push(_1130EF07);
			}
			while ((num & 0x739DF7BA) == 0);
		}

		public void F2BA751B()
		{
			uint num = 624431766u;
			if (num != 1530315918)
			{
				do
				{
					Stack<int> b08B = B08B8112;
					num -= 3862510230u;
					b08B.Clear();
				}
				while (-1415177580 == (int)num);
			}
			num >>= 6;
			B932B19B = num ^ 0xFBFB60;
			num = 4289242276u + num;
			uint num2 = num ^ 0xA4A004;
			num = 0x33133F28 | num;
			_818B87BC = num2;
		}

		public unsafe byte _1799AE0F()
		{
			while (true)
			{
				uint num = 3172311301u;
				IntPtr intPtr = _441DAF82.EEA4DE97(_818B87BC);
				num += 2461902503u;
				byte num2 = *(byte*)(void*)intPtr;
				num = (uint)(933809581 << (int)num);
				byte b = num2;
				num >>= 28;
				if (num >= 4127454339u)
				{
					continue;
				}
				while (true)
				{
					num = 873103124 * num;
					uint num3 = _818B87BC;
					num /= 2626740923u;
					_818B87BC = num3 + (num ^ 0);
					byte num4 = b;
					num = 3065065253u % num;
					num = 118016571 * num;
					uint b932B19B = B932B19B;
					num = 2486501160u + num;
					uint num5 = num4 ^ b932B19B;
					num -= 3548647683u;
					b = (byte)num5;
					if (1359464966 % num == 0)
					{
						break;
					}
					int num6 = b >>> (int)(num + 1062146524);
					num += 3114883237u;
					byte num7 = b;
					uint num8 = num - 2052736707;
					num %= 2560982426u;
					int num9 = num7 << (int)num8;
					num -= 3691939970u;
					int num10 = num6 | num9;
					num >>= 17;
					int num11 = num10 + (int)(num ^ 0x4FAB);
					num += 732125343;
					b = (byte)(-(~num11));
					num >>= 1;
					num -= 3482349991u;
					num = 2494661907u % num;
					uint b932B19B2 = B932B19B;
					num = 0x1EB112A1 & num;
					B932B19B = b932B19B2 ^ b;
					if (num <= 3032404386u)
					{
						return b;
					}
				}
			}
		}

		public unsafe long F7035F27()
		{
			IntPtr intPtr = _441DAF82.EEA4DE97(_818B87BC);
			uint num = 1318820397u;
			void* intPtr2 = (void*)intPtr;
			num = 2377974196u / num;
			long result = *(long*)intPtr2;
			num = 706008351 * num;
			_818B87BC += num - 706008343;
			return result;
		}

		public override void EB3F1497(int F2A9B1B3)
		{
			uint num = 1091441817u;
			if (num % 2327419806u != 0)
			{
				do
				{
					num ^= 0xA48322BBu;
					_818B87BC = (uint)F2A9B1B3;
				}
				while (900731930 == num);
			}
			do
			{
				num *= 4170063507u;
				num = (uint)(-1422436342 << (int)num);
				uint b932B19B = _818B87BC;
				num |= 0x2C87AF9D;
				B932B19B = b932B19B;
			}
			while (num / 3876194211u == 0);
		}

		public unsafe byte _3818FD20()
		{
			IntPtr intPtr = _441DAF82.EEA4DE97(_818B87BC);
			uint num = 313166235u;
			byte num2 = *(byte*)(void*)intPtr;
			num ^= 0x72AED7BC;
			byte b = num2;
			while (true)
			{
				num = 0x6C2DF1AC ^ num;
				uint num3 = _818B87BC;
				num = 1838226332 * num;
				uint num4 = num3 + (num - 1806016947);
				num = 1446558482 / num;
				_818B87BC = num4;
				byte num5 = b;
				uint b932B19B = B932B19B;
				num = (uint)(-1207737804 << (int)num);
				uint num6 = num5 ^ b932B19B;
				num = 0xDBBC5905u ^ num;
				b = (byte)num6;
				int num7 = b >>> (int)(num ^ 0x63BF3B30);
				num = 2294045489u - num;
				int num8 = num7 | (b << (int)num + -620568569);
				int num9 = (int)num + -620568523;
				num += 2554030486u;
				int num10 = num8 ^ num9;
				num >>= 12;
				int num11 = ~(num10 - ((int)num + -775047));
				uint num12 = num ^ 0xBD335;
				num %= 356090533;
				b = (byte)((uint)num11 ^ num12);
				num = 0x87A8380Bu & num;
				if (246559132 > num)
				{
					num = 697380766 - num;
					uint b932B19B2 = B932B19B;
					num &= 0xACB24E27u;
					byte num13 = b;
					num += 3736963856u;
					uint b932B19B3 = b932B19B2 ^ num13;
					num = 3886759440u * num;
					B932B19B = b932B19B3;
					if (1664608666 <= num)
					{
						break;
					}
				}
			}
			return b;
		}

		public double _5D377817()
		{
			uint num = 1874279482u;
			long value = F7035F27();
			num = 0x761D3B8A & num;
			return BitConverter.ToDouble(BitConverter.GetBytes(value), (int)(num ^ 0x6615380A));
		}

		public float B3215496()
		{
			uint num = 3350015159u;
			num ^= 0x68266F95;
			int value = _25AC239D();
			num = 1261452332 + num;
			byte[] bytes = BitConverter.GetBytes(value);
			num -= 3206845205u;
			return BitConverter.ToSingle(bytes, (int)(num ^ 0x3B96EC39));
		}

		public unsafe int _25AC239D()
		{
			uint num = 438494621u;
			uint num3 = default(uint);
			if (num <= 1200672898)
			{
				goto IL_0011;
			}
			goto IL_004b;
			IL_0011:
			num <<= 0;
			uint _5B970F = _818B87BC;
			num = 3996878604u % num;
			IntPtr intPtr = _441DAF82.EEA4DE97(_5B970F);
			num *= 463888947;
			void* intPtr2 = (void*)intPtr;
			num = 2474914477u / num;
			int num2 = *(int*)intPtr2;
			num ^= 0x8D935015u;
			num3 = (uint)num2;
			goto IL_004b;
			IL_004b:
			while (true)
			{
				num <<= 2;
				uint num4 = _818B87BC;
				num += 4203907981u;
				uint num5 = num ^ 0x30DFCBE5;
				num = 925238581 + num;
				_818B87BC = num4 + num5;
				if (884270650 == num)
				{
					break;
				}
				uint num6 = num3;
				num |= 0x7889B9AA;
				num = (uint)(338276269 << (int)num);
				num3 = num6 ^ B932B19B;
				if (3098178190u >> (int)num != 0)
				{
					uint num7 = num3;
					num /= 243529663;
					uint num8 = (num7 & (num - 16777220)) >> (int)(num ^ 0x1C);
					uint num9 = num3 & (num ^ 0xFF0004);
					num = 3517055757u / num;
					uint num10 = num ^ 0x346880CB;
					num = 2880833811u >> (int)num;
					uint num11 = num8 | (num9 >> (int)num10);
					num = 0x982A7325u | num;
					uint num12 = num3;
					num ^= 0x639EB3BF;
					uint num13 = num12 & (num ^ 0xFEE0BF98u);
					num %= 4197438520u;
					uint num14 = num13 << (int)(num - 78670936);
					num = 4170569870u - num;
					uint num15 = num11 | num14;
					num ^= 0x60266395;
					uint num16 = num3;
					uint num17 = num + 1815933252;
					num /= 10864515;
					uint num18 = num16 & num17;
					num ^= 0x8DA7E127u;
					uint num19 = num18 << (int)num - -1918377557;
					num = 0xEAB94898u & num;
					uint num20 = num15 | num19;
					num <<= 11;
					uint num21 = ~num20;
					int num22 = (int)num ^ -678410220;
					num = 0xDB033E94u | num;
					int num23 = (int)num21 + num22;
					num ^= 0xE50C4384u;
					num3 = (uint)num23;
					num |= 0x6E00BD38;
					if (1874634023 * num != 0)
					{
						uint num24 = num3;
						num = 0xBE1C0FA3u ^ num;
						uint num25 = num ^ 0x3F17F29B;
						num = 0xFEBA2793u ^ num;
						uint num26 = (num24 & num25) >> (int)(num ^ 0x3EADD510);
						uint num27 = num3;
						int num28 = (int)num + -1034867976;
						num %= 4094608265u;
						int num29 = (int)num27 & num28;
						num = 2593771147u * num;
						uint num30 = num ^ 0xB971B50;
						num >>= 28;
						int num31 = num29 >>> (int)num30;
						num *= 4154196233u;
						int num32 = (int)num26 | num31;
						num /= 3887612093u;
						uint num33 = num3 & (num + 65280);
						num = 2307161398u * num;
						uint num34 = num ^ 8;
						num = (uint)(-1398772938 << (int)num);
						int num35 = num32 | (int)(num33 << (int)num34);
						uint num36 = num3;
						num = 94192912 / num;
						int num37 = (int)num36 & ((int)num - -255);
						uint num38 = num ^ 0x18;
						num = 0x520853B & num;
						int num39 = num35 | (num37 << (int)num38);
						num = 4270280217u - num;
						uint num40 = num ^ 0x4E3EB41B;
						num ^= 0xBDB392AFu;
						int num41 = num39 - (int)num40;
						num = 3795099151u / num;
						num3 = (uint)num41;
						num = 78336822 - num;
						num += 3196075566u;
						num = 3968325034u / num;
						uint b932B19B = B932B19B;
						uint num42 = num3;
						num = 4047260710u + num;
						uint b932B19B2 = b932B19B ^ num42;
						num %= 1074036751;
						B932B19B = b932B19B2;
						num = 4179461796u >> (int)num;
					}
					return (int)num3;
				}
			}
			goto IL_0011;
		}

		public C1BF430A()
		{
			uint num;
			do
			{
				B08B8112 = new Stack<int>();
				num = 773310641u;
			}
			while (-207804282 >>> (int)num == 0);
		}

		public void _59203CB6()
		{
			uint num;
			do
			{
				num = 3601312408u;
				Stack<int> b08B = B08B8112;
				num /= 3129897271u;
				int _92B = b08B.Pop();
				num -= 3853139091u;
				EB3F1497(_92B);
			}
			while (-57051500 == (int)num);
		}

		public int F090B89A()
		{
			uint num = 1538770619u;
			num *= 2534823338u;
			Stack<int> b08B = B08B8112;
			num >>= 12;
			return b08B.Count;
		}

		public override int _6188C297()
		{
			uint num = 3114719637u;
			return (int)_818B87BC;
		}
	}

	private sealed class D51696A5 : B7078183
	{
		private long A6A05F8F;

		public override D3B95303 _5C36403F()
		{
			uint num = 2131439789u;
			num = 0xA03BD60Cu | num;
			long a6A05F8F = A6A05F8F;
			num |= 0x59285797;
			D51696A5 d51696A = new D51696A5(a6A05F8F);
			num >>= 9;
			num >>= 21;
			int _6B1C = _6E0A913C();
			num &= 0x86A1980Cu;
			d51696A._82A5D1BE(_6B1C);
			return d51696A;
		}

		public override int _6527EC0E()
		{
			uint num = 1622172803u;
			num &= 0xE015FA32u;
			long a6A05F8F = A6A05F8F;
			num /= 573013177;
			return (int)a6A05F8F;
		}

		public override short E39CE9A9()
		{
			uint num = 3878397073u;
			num /= 1739447344;
			return (short)A6A05F8F;
		}

		public static D3B95303 _9F01DB27(D3B95303 C73B1E9E, D3B95303 _9B275F35)
		{
			uint num = 3347927080u;
			ulong num7 = default(ulong);
			if (num < 3913164589u)
			{
				goto IL_0013;
			}
			goto IL_0061;
			IL_0013:
			num <<= 3;
			ulong num2 = C73B1E9E._588AFCB3();
			num >>= 26;
			ulong num3 = ~num2;
			num ^= 0x7E0C3C27;
			ulong num4 = _9B275F35._588AFCB3();
			num <<= 10;
			ulong num5 = ~num4;
			num = 0xFC28D907u & num;
			ulong num6 = num3 & num5;
			num = 0xDB7A32C & num;
			num7 = num6;
			goto IL_0061;
			IL_0061:
			while (true)
			{
				ulong _390BF = num7;
				num = 0x3EB1A035 & num;
				D51696A5 d51696A = new D51696A5((long)_390BF);
				num += 1485706647;
				D51696A5 d51696A2 = d51696A;
				uint num8 = num - 1487836567;
				num <<= 28;
				int num9 = (int)num8;
				if (-266057810 + (int)num == 0)
				{
					break;
				}
				ulong num10 = num7;
				num += 824817694;
				if (num10 == 0L)
				{
					int num11 = num9;
					int num12 = (int)num ^ -1591101412;
					num = 707099671 + num;
					num9 = num11 | num12;
					if (220508545 >= num)
					{
						break;
					}
				}
				else
				{
					num <<= 18;
					ulong num13 = num7 >> (int)(num ^ 0xE078003Fu);
					num ^= 0x2B373435;
					if (num13 != 0L)
					{
						if (num >> 5 == 0)
						{
							continue;
						}
						int num14 = num9;
						num &= 0x9DA2001Bu;
						num9 = num14 | ((int)num - -1996357619);
						num += 1112355876;
					}
				}
				d51696A2._82A5D1BE(num9);
				num = 1300611484 % num;
				if (3565172363u < num)
				{
					break;
				}
				return d51696A2;
			}
			goto IL_0013;
		}

		public static D3B95303 _31051F05(D3B95303 _7F2AB304, D3B95303 BEA27522)
		{
			while (true)
			{
				ulong num = _7F2AB304._588AFCB3();
				uint num2 = 3770335116u;
				while (true)
				{
					num2 ^= 0x50F7522;
					ulong num3 = BEA27522._588AFCB3();
					while (true)
					{
						num2 %= 3180026130u;
						ulong num4 = num * num3;
						num2 /= 2159479573u;
						D51696A5 d51696A;
						int num6;
						while (true)
						{
							num2 -= 2233719087u;
							d51696A = new D51696A5((long)num4);
							num2 = 0xD691352Bu & num2;
							uint num5 = num2 - 1385178113;
							num2 = 3853782292u + num2;
							num6 = (int)num5;
							num2 |= 0x3B9E85B3;
							uint num7 = num2 + 1143032393;
							if (-1265535607 << (int)num2 == 0)
							{
								break;
							}
							num2 %= 3558203583u;
							num2 = 4198298559u % num2;
							ulong num8 = num ^ num4;
							num2 |= 0x1D8A1217;
							num2 = 0x85A1E51Eu & num2;
							ulong num9 = num8 & (num3 ^ num4);
							num2 = 0x28862989 & num2;
							long num10 = num7;
							num2 = 1737794188 % num2;
							long num11 = (long)num9 & num10;
							num2 <<= 15;
							if (num11 != 0L)
							{
								num2 = 499107466 * num2;
								int num12 = num6 | ((int)num2 - -205783048);
								num2 = 379018657 * num2;
								num6 = num12;
								num2 ^= 0xC47A0000u;
							}
							if (num2 == 121510692)
							{
								break;
							}
							num2 = 0x223A4F02 ^ num2;
							ulong num13 = num ^ num3;
							num2 += 1345963925;
							ulong num14 = num13 & (num3 ^ num4);
							num2 = (uint)(78294072 << (int)num2);
							ulong num15 = num ^ num14;
							num2 = 933770032 - num2;
							num2 = 0xEF3DC1B0u & num2;
							if ((num15 & num7) != 0L)
							{
								num2 &= 0x4D829535;
								if (num2 == 120778385)
								{
									continue;
								}
								int num16 = num6;
								uint num17 = num2 ^ 0x9000110;
								num2 = 61148584u >> (int)num2;
								int num18 = num16 | (int)num17;
								num2 /= 657758399;
								num6 = num18;
								num2 += 187171120;
							}
							goto IL_01b1;
						}
						break;
						IL_01b1:
						num2 %= 1689102987;
						int num19 = BEA27522._6E0A913C();
						num2 = 76389392u >> (int)num2;
						int num20 = num19 & ((int)num2 + -1149);
						uint num21 = num2 - 1165;
						num2 = 0x1611F48E ^ num2;
						bool num22 = (uint)num20 > num21;
						num2 |= 0xC693BD9Cu;
						if (num22)
						{
							num2 = 2477565355u >> (int)num2;
							num2 += 2880396568u;
							long num23 = num2 ^ 0x5450A2E6;
							num2 >>= 21;
							long num24 = (long)num & num23;
							num2 = 1261094588 + num2;
							ulong num25 = (ulong)num24;
							int num26 = (int)num2 + -1261095929;
							num2 = 1840406310 * num2;
							ulong num27 = num >> num26;
							num2 = 639888185 - num2;
							ulong num28 = num27;
							uint num29 = num2 ^ 0x7255A77C;
							num2 |= 0xFC1C6D18u;
							ulong num30 = num3 & num29;
							num2 %= 2058581004;
							num2 ^= 0xF239D8ADu;
							int num31 = (int)num2 ^ -93434610;
							num2 /= 1630944168;
							ulong num32 = num3 >> num31;
							num2 *= 806107658;
							ulong num33 = num32;
							num2 = 1628476054u >> (int)num2;
							ulong num34 = num25 * num30;
							num2 = 1360626461 * num2;
							ulong num35 = num34;
							ulong num36 = num28 * num30;
							ulong num37 = num35;
							num2 -= 481430433;
							uint num38 = num2 + 552446164;
							num2 = 0xA61C5487u & num2;
							num35 = num36 + (num37 >> (int)num38);
							num2 = 3978500000u * num2;
							if ((0x27159DBB ^ num2) == 0)
							{
								goto end_IL_000e;
							}
							ulong num39 = num35;
							num2 = 3876752055u - num2;
							uint num40 = num2 - 1959111736;
							num2 /= 2416808964u;
							ulong num41 = num39 & num40;
							num2 %= 1396240034;
							ulong num42 = num35;
							num2 &= 0x77368F08;
							ulong num43 = num42 >> (int)(num2 ^ 0x20);
							num2 >>= 21;
							num2 &= 0x2B268627;
							ulong num44 = num41 + num25 * num33;
							num2 >>= 29;
							num35 = num44;
							num2 = 0xCD98A335u ^ num2;
							if (858421134 == num2)
							{
								continue;
							}
							ulong num45 = num28 * num33;
							num2 /= 186722961;
							ulong num46 = num43 + num45;
							ulong num47 = num35;
							num2 = 2919523134u - num2;
							ulong num48 = num47 >> (int)(num2 + 1375444212);
							num2 = 0x688E8994 ^ num2;
							ulong num49 = num46 + num48;
							num2 = 2006650380 % num2;
							num35 = num49;
							if (num2 == 662838160)
							{
								break;
							}
							ulong num50 = num35;
							num2 ^= 0xA108F393u;
							if (num50 != 0L)
							{
								num2 -= 3716931471u;
								if (489110401 * num2 == 0)
								{
									goto end_IL_000e;
								}
								int num51 = num6;
								num2 >>= 3;
								num6 = num51 | (int)(num2 - 522257314);
								num2 ^= 0xC9B2FE5Du;
							}
						}
						num2 = 3224720697u + num2;
						num2 |= 0xC4A6A228u;
						int _6B1C = num6;
						num2 &= 0x8F1B0B39u;
						d51696A._82A5D1BE(_6B1C);
						num2 ^= 0x2326FA29;
						if (num2 >= 1865949579)
						{
							return d51696A;
						}
					}
					continue;
					end_IL_000e:
					break;
				}
			}
		}

		public static D3B95303 _638C5E8D(D3B95303 _3E9EB832, D3B95303 _5B076C06)
		{
			uint num = 2351791293u;
			int num5 = default(int);
			D51696A5 d51696A2 = default(D51696A5);
			if (2458114862u > num)
			{
				goto IL_0011;
			}
			goto IL_0127;
			IL_0011:
			num |= 0x849D8AB4u;
			ulong num2 = _3E9EB832._588AFCB3();
			ulong num3 = _5B076C06._588AFCB3();
			num = 3945151493u >> (int)num;
			ulong num4 = num2 + num3;
			num += 2316808632u;
			D51696A5 d51696A = new D51696A5((long)num4);
			num = 1099123098 + num;
			d51696A2 = d51696A;
			num5 = (int)num ^ -879035559;
			num ^= 0x7D9ABF90;
			int num6 = (int)num + -905987273;
			num ^= 0x2E97F786;
			uint num7 = (uint)num6;
			num = (uint)(-385418691 << (int)num);
			num = 3331669924u + num;
			ulong num8 = num2 ^ num4;
			num %= 2215873169u;
			ulong num9 = num8 & (num3 ^ num4);
			num = 3601521304u * num;
			ulong num10 = num9 & num7;
			num = 1745376936 % num;
			if (num10 != 0L)
			{
				num ^= 0x422DDCAF;
				int num11 = num5;
				num &= 0x60AF3517;
				uint num12 = num ^ 0x2025000F;
				num = 3137806734u + num;
				num5 = num11 | (int)num12;
				num += 2363241747u;
			}
			num ^= 0x8A1FD300u;
			num /= 1336762159;
			num = 715773849 - num;
			ulong num13 = num2 ^ ((num2 ^ num3) & (num3 ^ num4));
			num ^= 0x273B4C3E;
			num %= 2685427477u;
			if ((num13 & num7) == 0L)
			{
				goto IL_014b;
			}
			num *= 604274448;
			if (515888410 != num)
			{
				goto IL_0127;
			}
			goto IL_0166;
			IL_0127:
			int num14 = num5;
			uint num15 = num + 955870864;
			num = 3358560442u + num;
			int num16 = num14 | (int)num15;
			num = 3341568831u * num;
			num5 = num16;
			num += 2289859955u;
			goto IL_014b;
			IL_014b:
			if (1471023906 == num)
			{
				goto IL_0011;
			}
			D51696A5 d51696A3 = d51696A2;
			int _6B1C = num5;
			num >>= 19;
			d51696A3._82A5D1BE(_6B1C);
			goto IL_0166;
			IL_0166:
			return d51696A2;
		}

		public override byte _6E94D6A9()
		{
			uint num = 2770665005u;
			return (byte)A6A05F8F;
		}

		public override uint _3503DA1F()
		{
			uint num = 4185941937u;
			num = 2543182985u / num;
			long a6A05F8F = A6A05F8F;
			num |= 0xFC2AB985u;
			return (uint)a6A05F8F;
		}

		public static D3B95303 FFA08636(D3B95303 _3A24FE92, D3B95303 _22BCAB9E)
		{
			uint num = 2559729971u;
			if (num >= 1295419018)
			{
				num = (uint)(-23404796 << (int)num);
				int num2 = _22BCAB9E._6E0A913C() & ((int)num - -132120592);
				int num3 = (int)num - -132120576;
				num += 1455116453;
				if ((uint)num2 > (uint)num3)
				{
					num <<= 15;
					ulong num4 = _3A24FE92._588AFCB3();
					ulong num5 = _22BCAB9E._588AFCB3();
					num ^= 0x1B25DEBF;
					ulong num6 = num5;
					num = 0xE82D5402u & num;
					ulong _390BF = num4 % num6;
					num = 1067141141 / num;
					return new D51696A5((long)_390BF);
				}
			}
			num = 1815542200 % num;
			long num7 = _3A24FE92._249CC8BD();
			num = 488206375u >> (int)num;
			long num8 = _22BCAB9E._249CC8BD();
			num >>= 11;
			return new D51696A5(num7 % num8);
		}

		public static D3B95303 _4CAC8707(D3B95303 _0B11B620, D3B95303 _3F06F315)
		{
			uint num = 3332049550u;
			while (true)
			{
				num ^= 0x9F98290Eu;
				ulong num2 = ~_0B11B620._588AFCB3();
				num = 3121228325u >> (int)num;
				num = 1536632497 + num;
				ulong num3 = ~_3F06F315._588AFCB3();
				num <<= 27;
				ulong num4 = num3;
				ulong num5 = num2 | num4;
				while (true)
				{
					num ^= 0x785AC1B;
					D51696A5 d51696A = new D51696A5((long)num5);
					int num6 = (int)num ^ -1215976421;
					num *= 3140865565u;
					num = 2492947623u / num;
					if (num5 == 0L)
					{
						num *= 2399595441u;
						int num7 = num6 | (int)(num ^ 2);
						num = (uint)(-1073297258 << (int)num);
						num6 = num7;
					}
					else
					{
						num ^= 0xC28E9B11u;
						if (num < 1864124034)
						{
							break;
						}
						ulong num8 = num5 >> (int)(num ^ 0xC28E9B2Eu);
						num += 4252511621u;
						if (num8 != 0L)
						{
							num = 3836829952u * num;
							if (num << 2 == 0)
							{
								break;
							}
							int num9 = num6;
							int num10 = (int)num ^ -642329084;
							num = 908242480 * num;
							num6 = num9 | num10;
							num ^= 0x43BAE896;
						}
					}
					num = 278464562 % num;
					d51696A._82A5D1BE(num6);
					if ((0x31A52BA3 ^ num) != 0)
					{
						return d51696A;
					}
				}
			}
		}

		public override void DE8C17B9(object _7D972809)
		{
			uint num;
			do
			{
				num = 2274356245u;
				A6A05F8F = Convert.ToInt64(_7D972809);
			}
			while (num < 2149337746u);
		}

		public override double DB900D19()
		{
			uint num = 1864353029u;
			return A6A05F8F;
		}

		public override IntPtr _27832122()
		{
			uint num = 3887781260u;
			if (IntPtr.Size != (int)(num + 407186040))
			{
				num = 3548939445u / num;
				if ((num ^ 0xDFBE2016u) != 0)
				{
					goto IL_002b;
				}
			}
			if ((int)num - -1633193304 == 0)
			{
				goto IL_002b;
			}
			num += 2570747266u;
			long a6A05F8F = A6A05F8F;
			num = 0xB7B209B7u & num;
			long value = (int)a6A05F8F;
			num ^= 0xF8388D0Au;
			goto IL_006a;
			IL_002b:
			num += 2022214668;
			value = A6A05F8F;
			goto IL_006a;
			IL_006a:
			return new IntPtr(value);
		}

		public override float DEAE8E8E()
		{
			uint num = 3896422965u;
			long a6A05F8F = A6A05F8F;
			num = 0xA43B81BBu & num;
			return a6A05F8F;
		}

		public override Type D293A3AF()
		{
			return typeof(long);
		}

		public static D3B95303 _8AB24197(D3B95303 B52EE33B, D3B95303 _05A79031)
		{
			uint num = 339629443u;
			num <<= 18;
			int num2 = _05A79031._6E0A913C();
			int num3 = (int)num + -1443626992;
			num ^= 0x5A99;
			if ((uint)(num2 & num3) > (num ^ 0x560C5A99) && num <= 2122371637)
			{
				num = 3113940893u % num;
				ulong num4 = B52EE33B._588AFCB3();
				num <<= 30;
				int num5 = _05A79031._6527EC0E();
				num = 0x72BDFD09 ^ num;
				int num6 = (int)num ^ -1296171722;
				num -= 3078631335u;
				int num7 = num5 & num6;
				num >>= 3;
				ulong _390BF = num4 >> num7;
				num = 0x72A8C619 & num;
				return new D51696A5((long)_390BF);
			}
			num = 127765050 + num;
			num = 3961645750u >> (int)num;
			long num8 = B52EE33B._249CC8BD();
			num >>= 6;
			num /= 3515916205u;
			int num9 = _05A79031._6527EC0E();
			num *= 2122491446;
			long _390BF2 = num8 >> (int)((uint)num9 & (num + 63));
			num &= 0xD608B5B5u;
			return new D51696A5(_390BF2);
		}

		public override ushort AD1962B2()
		{
			return (ushort)A6A05F8F;
		}

		public override UIntPtr _1DB07EA4()
		{
			long value;
			uint num;
			while (true)
			{
				int size = UIntPtr.Size;
				num = 4256579371u;
				if (size != (int)(num ^ 0xFDB63F2Fu))
				{
					value = A6A05F8F;
					break;
				}
				num = 3333184826u - num;
				if (-651521516 != (int)num)
				{
					num /= 1067376803;
					value = (uint)A6A05F8F;
					num ^= 0xFDB63F28u;
					break;
				}
			}
			num >>= 5;
			return new UIntPtr((ulong)value);
		}

		public override char D31384B4()
		{
			uint num = 4248376355u;
			long a6A05F8F = A6A05F8F;
			num = 721988116 % num;
			return (char)a6A05F8F;
		}

		public static D3B95303 CD0D5192(D3B95303 _6401AA2C, D3B95303 CF0B1813)
		{
			uint num = 655231286u;
			num |= 0x438ED9AB;
			long num2 = _6401AA2C._249CC8BD();
			int num3 = CF0B1813._6527EC0E();
			num = 528600981 * num;
			int num4 = num3 & (int)(num ^ 0xA2752D14u);
			num |= 0xBF026DA4u;
			return new D51696A5(num2 << num4);
		}

		public override ulong _588AFCB3()
		{
			uint num = 3358438299u;
			return (ulong)A6A05F8F;
		}

		public static D3B95303 _28A6C113(D3B95303 A9A6CB33)
		{
			uint num = 850203317u;
			num += 2459459869u;
			ulong _390BF = A9A6CB33._588AFCB3();
			num /= 3199386752u;
			return new D51696A5((long)_390BF);
		}

		public override long _249CC8BD()
		{
			uint num = 3996595715u;
			return A6A05F8F;
		}

		public override object _9F320096()
		{
			uint num = 3719730690u;
			long a6A05F8F = A6A05F8F;
			num = 456004623 + num;
			return a6A05F8F;
		}

		public override bool C9093688()
		{
			long a6A05F8F = A6A05F8F;
			uint num = 2771337399u;
			uint num2 = num + 1523629897;
			num = 4247058434u % num;
			long num3 = (int)num2;
			num = (uint)(-997143676 << (int)num);
			return (ulong)a6A05F8F > (ulong)num3;
		}

		public static D3B95303 C534C01C(D3B95303 _7133EFB5, D3B95303 A1A50A28)
		{
			while (true)
			{
				int num = 0;
				while (true)
				{
					IL_0002:
					uint num2 = 2241257276u;
					int num3 = A1A50A28._6E0A913C();
					uint num4 = num2 + 2053710036;
					num2 <<= 25;
					int num5 = num3 & (int)num4;
					uint num6 = num2 - 2013265920;
					num2 ^= 0x4890659A;
					ulong num7;
					ulong num8;
					if ((uint)num5 > num6)
					{
						num2 = 0x48201781 ^ num2;
						if (-1188446924 << (int)num2 == 0)
						{
							break;
						}
						while (true)
						{
							num7 = _7133EFB5._588AFCB3();
							num2 %= 4257181069u;
							if (num2 < 630580498)
							{
								break;
							}
							num8 = A1A50A28._588AFCB3();
							num2 <<= 19;
							if (1321171499 >= num2)
							{
								goto IL_0002;
							}
							if (num7 == num8)
							{
								goto IL_0099;
							}
							if (1647317308 >>> (int)num2 == 0)
							{
								continue;
							}
							goto IL_00da;
						}
						break;
					}
					num2 = 0xF0A3F309u | num2;
					num2 = 1570348807 / num2;
					long num9 = _7133EFB5._249CC8BD();
					num2 %= 607093396;
					long num10 = num9;
					if (2519120004u < num2)
					{
						break;
					}
					long num11 = A1A50A28._249CC8BD();
					num2 *= 35084077;
					num2 %= 1964067462;
					if (num10 == num11)
					{
						num2 %= 1966025350;
						int num12 = num;
						num2 = 3154584223u * num2;
						num = num12 | ((int)num2 - -2);
						if (num2 >= 2961758512u)
						{
							break;
						}
						num2 += 1247679;
					}
					else
					{
						num2 = 2042407707 - num2;
						num2 ^= 0x79AFA2A4;
						if (num10 < num11)
						{
							num2 = 1452567486 + num2;
							if (num2 % 37172786 == 0)
							{
								break;
							}
							int num13 = num;
							num2 /= 4121825924u;
							int num14 = num13 | (int)(num2 ^ 4);
							num2 = (uint)(983392790 << (int)num2);
							num = num14;
							num2 += 3312822185u;
						}
					}
					goto IL_023e;
					IL_00da:
					num2 = 389355308 + num2;
					num2 += 1476784787;
					if (num7 < num8)
					{
						num2 = 814921532u >> (int)num2;
						if (num2 >> 2 != 0)
						{
							continue;
						}
						int num15 = num;
						num2 = 437179275 + num2;
						uint num16 = num2 - 437179271;
						num2 = 0x5E2D929F & num2;
						num = num15 | (int)num16;
						if ((num2 & 0x5317928F) == 0)
						{
							break;
						}
						num2 += 3859183412u;
					}
					goto IL_023e;
					IL_023e:
					return new B7035AA0(num);
					IL_0099:
					int num17 = num;
					num2 = 319405955 % num2;
					uint num18 = num2 ^ 0x1309BF81;
					num2 >>= 8;
					int num19 = num17 | (int)num18;
					num2 %= 1209850404;
					num = num19;
					goto IL_023e;
				}
			}
		}

		public static D3B95303 _0C1AAC0A(D3B95303 _3E3A8913, D3B95303 _0B10748B)
		{
			int num = _0B10748B._6E0A913C();
			uint num2 = 2688261396u;
			int num3 = num & 0x10;
			num2 ^= 0xD6812795u;
			int num4 = (int)num2 + -1991948929;
			num2 %= 2324909605u;
			bool num5 = (uint)num3 > (uint)num4;
			num2 = 4280885041u - num2;
			long num8;
			if (num5 || (0x990E601Eu ^ num2) == 0)
			{
				ulong num6 = _3E3A8913._588AFCB3();
				ulong num7 = _0B10748B._588AFCB3();
				num2 %= 1897573525;
				num2 = 76110223 % num2;
				num8 = (long)(num6 / num7);
			}
			else
			{
				long num9 = _3E3A8913._249CC8BD();
				num2 = 1241555365 + num2;
				long num10 = _0B10748B._249CC8BD();
				num2 *= 2995957510u;
				long num11 = num10;
				num2 = 3879348498u % num2;
				long num12 = num9 / num11;
				num2 = 0x519F859C ^ num2;
				num8 = num12;
				num2 += 4147833863u;
			}
			num2 = 0x9B3C4083u ^ num2;
			long _390BF = num8;
			num2 = 0x1C829603 & num2;
			return new D51696A5(_390BF);
		}

		public override sbyte _6C14C0B7()
		{
			uint num = 3902223769u;
			return (sbyte)A6A05F8F;
		}

		public D51696A5(long _390BF101)
		{
			uint num = 462884632u;
			num = 884398117 % num;
			num |= 0xE2868F2Fu;
			A6A05F8F = _390BF101;
		}
	}

	private sealed class _56AB72BE : _0A94A53A
	{
		private int CF98DCA2;

		private List<D3B95303> _8DB40C33;

		public D3B95303 C4BFC635(int C83B8C97)
		{
			int num = C83B8C97;
			uint num2 = 3741538853u;
			if (num < 0)
			{
				goto IL_000d;
			}
			goto IL_004c;
			IL_000d:
			int num3 = C83B8C97;
			num2 = 0x7B268305 & num2;
			int count = _8DB40C33.Count;
			num2 %= 3753576373u;
			uint num4 = num2 ^ 0x5B020204;
			num2 %= 2201473664u;
			int num5 = count - (int)num4;
			num2 |= 0xF59CC607u;
			C83B8C97 = num3 + num5;
			num2 += 3747910686u;
			goto IL_004c;
			IL_004c:
			num2 = 58766655 * num2;
			if (4229573649u >> (int)num2 != 0)
			{
				List<D3B95303> list = _8DB40C33;
				num2 = 3406301722u / num2;
				return list[C83B8C97];
			}
			goto IL_000d;
		}

		public void _93061C36(D3B95303 A4344932)
		{
			uint num = 1756593421u;
			if ((0xA4963926u & num) != 0)
			{
				do
				{
					List<D3B95303> list = _8DB40C33;
					num = 3146915615u * num;
					B7078183 item = A4344932.A883CB02();
					num = 0xC8BB4717u & num;
					list.Add(item);
				}
				while ((0x9218542Fu ^ num) == 0);
			}
		}

		public D3B95303 ED374FBA()
		{
			int index;
			uint num;
			do
			{
				num = 305561139u;
				List<D3B95303> list = _8DB40C33;
				num /= 2032840864;
				int count = list.Count;
				int num2 = (int)num - -1;
				num = 0xD3A776A4u ^ num;
				int num3 = count - num2;
				num = 2140013852 + num;
				index = num3;
				num |= 0xE1B9BA0;
			}
			while (1755207179 == num);
			D3B95303 result = _8DB40C33[index];
			num -= 2106838293;
			List<D3B95303> list2 = _8DB40C33;
			num &= 0xEA7C32D;
			list2.RemoveAt(index);
			return result;
		}

		public void _3A89F3AD()
		{
			while (true)
			{
				uint num = 3845987601u;
				int count = _8DB40C33.Count;
				num = (uint)(-1316443076 << (int)num);
				if (count > CF98DCA2)
				{
					num = 4179249185u;
					List<D3B95303> list = _8DB40C33;
					num = 1302487201 * num;
					list.RemoveAt(CF98DCA2);
					continue;
				}
				break;
			}
		}

		public override void EB3F1497(int _00A592A6)
		{
			uint num = 1369358388u;
			CF98DCA2 = _00A592A6;
			while (true)
			{
				int num2 = (int)num + -1369358388;
				if (num % 3640685114u == 0)
				{
					goto IL_0026;
				}
				goto IL_0071;
				IL_0026:
				num = 992372368u;
				List<D3B95303> list = _8DB40C33;
				uint index = num ^ 0x3B266690;
				num *= 748637976;
				list.Insert((int)index, null);
				num = 3749773728u / num;
				int num3 = num2;
				num = 1392646659 / num;
				int num4 = num3 + ((int)num + -1392646658);
				num %= 2904425393u;
				num2 = num4;
				num ^= 0x29CDA37;
				goto IL_0071;
				IL_0071:
				int num5 = num2;
				num *= 2065413037;
				int cF98DCA = CF98DCA2;
				num %= 1813167787;
				if (num5 >= cF98DCA)
				{
					if (num + 4027793804u != 0)
					{
						break;
					}
					continue;
				}
				goto IL_0026;
			}
		}

		public D3B95303 _73186E25()
		{
			uint num = 1031996310u;
			List<D3B95303> list = _8DB40C33;
			num -= 1210657035;
			int count = list.Count;
			int num2 = (int)num ^ -178660726;
			num /= 1375946122;
			int num3 = count - num2;
			num *= 486762303;
			int index = num3;
			num = 0x90162B8Du | num;
			num = 2963296772u * num;
			return _8DB40C33[index];
		}

		public _56AB72BE()
		{
			uint num = 2115047846u;
			if (num % 236758962 != 0)
			{
				num = 3760218752u * num;
				List<D3B95303> list = new List<D3B95303>();
				num <<= 16;
				_8DB40C33 = list;
				num ^= 0xC72D6CBDu;
				if (num / 2201327511u == 0)
				{
					return;
				}
			}
			num %= 705037720;
		}

		public D3B95303 _30095C38(int _348F6210, D3B95303 E33FEEBE)
		{
			D3B95303 result;
			while (true)
			{
				int num = _348F6210;
				uint num2 = 4121813291u;
				if (num < (int)(num2 ^ 0xF5ADE12Bu))
				{
					num2 = 153323943 / num2;
					goto IL_001b;
				}
				goto IL_006a;
				IL_001b:
				int num3 = _348F6210;
				num2 = 3116211746u + num2;
				num2 /= 2343146261u;
				List<D3B95303> list = _8DB40C33;
				num2 *= 154139025;
				int count = list.Count;
				num2 = 1729353407 * num2;
				int num4 = count - (int)(num2 + 768775890);
				num2 &= 0x642C5B84;
				int num5 = num3 + num4;
				num2 = 3290224172u * num2;
				_348F6210 = num5;
				num2 ^= 0xECB8059Bu;
				goto IL_006a;
				IL_006a:
				num2 = 389555332 + num2;
				if (num2 != 2065322127)
				{
					num2 /= 781850160;
					List<D3B95303> list2 = _8DB40C33;
					num2 ^= 0x781F5A7;
					int index = _348F6210;
					D3B95303 value = (result = E33FEEBE);
					num2 = 2819956379u * num2;
					list2[index] = value;
					if (num2 != 4169722256u)
					{
						break;
					}
					continue;
				}
				goto IL_001b;
			}
			return result;
		}

		public override int _6188C297()
		{
			uint num = 2427435324u;
			return _8DB40C33.Count;
		}
	}

	private sealed class _251D96A3 : _128A201A
	{
		private object _0D39FC9C;

		private FieldInfo _22291D0E;

		public override D3B95303 _5C36403F()
		{
			FieldInfo _0904BB = _22291D0E;
			uint num = 2451627837u;
			num |= 0xA58CA80Fu;
			return new _251D96A3(_0904BB, _0D39FC9C);
		}

		public override void DE8C17B9(object E489761D)
		{
			uint num = 2046909838u;
			do
			{
				FieldInfo fieldInfo = _22291D0E;
				num = 1622336810u >> (int)num;
				_0A94A53A obj = (_0A94A53A)fieldInfo.GetValue(_0D39FC9C);
				int _92B = (int)E489761D;
				num ^= 0x88BB4880u;
				obj.EB3F1497(_92B);
			}
			while (num <= 975363862);
		}

		public override Type D293A3AF()
		{
			uint num = 1337696702u;
			return typeof(int);
		}

		public override object _9F320096()
		{
			FieldInfo fieldInfo = _22291D0E;
			uint num = 431315352u;
			num = 1419974825u >> (int)num;
			object obj = _0D39FC9C;
			num &= 0x6EBD67A3;
			object value = fieldInfo.GetValue(obj);
			num = 3332179247u + num;
			_0A94A53A obj2 = (_0A94A53A)value;
			num *= 2100777250;
			int num2 = obj2._6188C297();
			num = (uint)(-469154272 << (int)num);
			return num2;
		}

		public _251D96A3(FieldInfo _0904BB02, object _64BA0212)
		{
			uint num = 1059435921u;
			do
			{
				num = 2930544300u % num;
				_22291D0E = _0904BB02;
			}
			while (num > 3657508902u);
			num = 2755208337u - num;
			num = 590813703u >> (int)num;
			_0D39FC9C = _64BA0212;
		}
	}

	private sealed class _3014C498 : D3B95303
	{
		private char _91365D16;

		public override uint _3503DA1F()
		{
			uint num = 939665580u;
			return _91365D16;
		}

		public override ushort AD1962B2()
		{
			return _91365D16;
		}

		public override Type D293A3AF()
		{
			uint num = 2081554594u;
			return typeof(char);
		}

		public override D3B95303 _5C36403F()
		{
			uint num = 2013906971u;
			char _0801BC9A = _91365D16;
			num /= 4093762305u;
			return new _3014C498(_0801BC9A);
		}

		public override void DE8C17B9(object _8B368381)
		{
			uint num = 3531633215u;
			char num2 = Convert.ToChar(_8B368381);
			num &= 0xC78352B0u;
			_91365D16 = num2;
		}

		public override sbyte _6C14C0B7()
		{
			uint num = 3274547132u;
			return (sbyte)_91365D16;
		}

		public override byte _6E94D6A9()
		{
			uint num = 379841306u;
			num = 1025990287 - num;
			char num2 = _91365D16;
			num /= 1620339979;
			return (byte)num2;
		}

		public override object _9F320096()
		{
			uint num = 2847485313u;
			char num2 = _91365D16;
			num = 109865535u >> (int)num;
			return num2;
		}

		public override short E39CE9A9()
		{
			uint num = 3146277938u;
			num = 0xF0811899u & num;
			return (short)_91365D16;
		}

		public override int _6527EC0E()
		{
			uint num = 37624748u;
			return _91365D16;
		}

		public override B7078183 A883CB02()
		{
			uint num = 2789026100u;
			int _1B2FFB = _6527EC0E();
			num -= 2830726328u;
			return new B7035AA0(_1B2FFB);
		}

		public _3014C498(char _0801BC9A)
		{
			uint num = 3113839925u;
			do
			{
				num /= 1923028999;
				num = 1581101971 - num;
				num = 1723590682u >> (int)num;
				_91365D16 = _0801BC9A;
			}
			while (-1381570796 == (int)num);
		}
	}

	private sealed class _6293582D : IDisposable
	{
		private List<GCHandle> _76AC0316;

		public void Dispose()
		{
			uint num = 2123726725u;
			num = 2267950980u - num;
			List<GCHandle> list = _76AC0316;
			num = 4269825573u + num;
			List<GCHandle>.Enumerator enumerator = list.GetEnumerator();
			try
			{
				GCHandle current = default(GCHandle);
				while (true)
				{
					num = 0x44095508 | num;
					if (num / 3374027676u == 0)
					{
						num <<= 4;
						bool num2 = enumerator.MoveNext();
						num ^= 0xC38938D;
						if (!num2)
						{
							break;
						}
						num = 3894203562u;
						if (4262218902u > num)
						{
							current = enumerator.Current;
							num = 268986293 - num;
							if ((num ^ 0x74178D24) == 0)
							{
								continue;
							}
						}
					}
					num = 0x530FF1B0 ^ num;
					current.Free();
					num += 2452925289u;
				}
			}
			finally
			{
				num = 394969988u;
				((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
			}
			num = 2811462580u;
			if (-1769142784 << (int)num != 0)
			{
				List<GCHandle> list2 = _76AC0316;
				num = 3850507189u / num;
				list2.Clear();
			}
		}

		public _6293582D()
		{
			List<GCHandle> list = new List<GCHandle>();
			uint num = 1547649801u;
			_76AC0316 = list;
			do
			{
				num = 2386180268u * num;
			}
			while (num <= 2995242502u);
		}

		public IntPtr _6E21DE0F(object _37305BB2)
		{
			uint num = 1560869299u;
			GCHandle item;
			do
			{
				num >>= 25;
				item = GCHandle.Alloc(_37305BB2, (GCHandleType)((int)num + -43));
			}
			while (num >= 2770487973u);
			num %= 127364016;
			_76AC0316.Add(item);
			num += 2249969925u;
			return item.AddrOfPinnedObject();
		}
	}

	private sealed class _5D05C73B : D3B95303
	{
		private ushort F93497B6;

		public override Type D293A3AF()
		{
			return typeof(ushort);
		}

		public override sbyte _6C14C0B7()
		{
			uint num = 3448829881u;
			ushort f93497B = F93497B6;
			num = 1336769184u >> (int)num;
			return (sbyte)f93497B;
		}

		public override uint _3503DA1F()
		{
			uint num = 908407936u;
			num = 346842404 * num;
			return F93497B6;
		}

		public static D3B95303 _35B1A821(D3B95303 _1B96BCA1)
		{
			uint num3;
			do
			{
				IL_0000:
				ulong num = _1B96BCA1._588AFCB3();
				int num2 = _1B96BCA1._6E0A913C();
				num3 = 941352582u;
				int num4 = num2 & 0x10;
				num3 <<= 21;
				int num5 = (int)num3 ^ -792723456;
				num3 = 2617959317u >> (int)num3;
				bool num6 = (uint)num4 > (uint)num5;
				num3 = 3501866670u >> (int)num3;
				uint num7 = num3 - 1669;
				num3 -= 3207558843u;
				int num8 = (int)num7;
				if (num6)
				{
					num3 ^= 0x478537B3;
					if (128869935 < num3)
					{
						goto IL_0000;
					}
				}
				else
				{
					num3 -= 2477711286u;
					if (num3 > 1672802080)
					{
						num3 += 2973195908u;
						long num9 = (int)(num3 - 1582861977);
						num3 ^= 0xA8DC7A8Au;
						if (num > (ulong)num9)
						{
							num3 += 1420089399;
							if (num3 < 403446676)
							{
								goto IL_0000;
							}
							int num10 = num8;
							num3 <<= 18;
							int num11 = num10 | (int)(num3 - 824442872);
							num3 = 0x9B981D3Bu ^ num3;
							num8 = num11;
							num3 += 1271486167;
						}
						goto IL_0137;
					}
				}
				long num12 = (int)num3 + -122992762;
				num3 += 4012882841u;
				if (num > (ulong)num12)
				{
					num3 -= 1099336758;
					if (num3 <= 1765211817)
					{
						goto IL_0000;
					}
					int num13 = num8;
					num3 = 0x8D359624u | num3;
					uint num14 = num3 + 1107298316;
					num3 |= 0x9432FE1Eu;
					int num15 = num13 | (int)num14;
					num3 = 562644779 % num3;
					num8 = num15;
					if (3197739565u < num3)
					{
						goto IL_0000;
					}
					num3 += 3573296359u;
				}
				goto IL_0137;
				IL_0137:
				_1B96BCA1 = new B7035AA0((ushort)num);
				D3B95303 d3B = _1B96BCA1;
				num3 = 0x800E0291u ^ num3;
				d3B._82A5D1BE(num8);
			}
			while ((0x26A03001 ^ num3) == 0);
			return _1B96BCA1;
		}

		public override D3B95303 _5C36403F()
		{
			return new _5D05C73B(F93497B6);
		}

		public override int _6527EC0E()
		{
			uint num = 4113112869u;
			num = 4120907534u + num;
			return F93497B6;
		}

		public override void DE8C17B9(object A017871B)
		{
			uint num = 1905189280u;
			if (1019173252 * num != 0)
			{
				ushort f93497B = Convert.ToUInt16(A017871B);
				num = 0x57BAFA0B & num;
				F93497B6 = f93497B;
			}
		}

		public override byte _6E94D6A9()
		{
			uint num = 1460412557u;
			ushort f93497B = F93497B6;
			num |= 0x26B9BB06;
			return (byte)f93497B;
		}

		public override object _9F320096()
		{
			uint num = 907805992u;
			ushort f93497B = F93497B6;
			num &= 0x8485CD03u;
			return f93497B;
		}

		public override ushort AD1962B2()
		{
			return F93497B6;
		}

		public override B7078183 A883CB02()
		{
			uint num = 2651107335u;
			return new B7035AA0(_6527EC0E());
		}

		public override short E39CE9A9()
		{
			uint num = 2292825861u;
			ushort f93497B = F93497B6;
			num = 0x89BDB51Cu | num;
			return (short)f93497B;
		}

		public _5D05C73B(ushort CD815BA1)
		{
			uint num = 2811231541u;
			num = 2939050555u * num;
			num = 0x14B4EC34 ^ num;
			num ^= 0x40B8D91A;
			num += 1027377561;
			F93497B6 = CD815BA1;
		}
	}

	private sealed class _77BA31B1 : _128A201A
	{
		private D3B95303 FF19E111;

		public override void DE8C17B9(object _59B46306)
		{
			uint num = 589461018u;
			num |= 0x8789A383u;
			D3B95303 fF19E = FF19E111;
			num = 356198289 + num;
			num *= 3154749072u;
			fF19E.DE8C17B9(_59B46306);
		}

		public override Type D293A3AF()
		{
			uint num = 3851462199u;
			num = 262234923 / num;
			D3B95303 fF19E = FF19E111;
			num >>= 5;
			return fF19E.D293A3AF();
		}

		public override object _9F320096()
		{
			uint num = 2165797635u;
			return FF19E111._9F320096();
		}

		public override object DDAAAA0B(FieldInfo _19A2E927)
		{
			uint num = 1169560236u;
			D3B95303 fF19E = FF19E111;
			num |= 0x38BB250B;
			return fF19E.DDAAAA0B(_19A2E927);
		}

		public override void _45971A1D(FieldInfo _90B94281, object _6BBB6308)
		{
			uint num = 3450074127u;
			if ((num & 0xC79582A2u) != 0)
			{
				do
				{
					D3B95303 fF19E = FF19E111;
					num /= 3980295082u;
					fF19E._45971A1D(_90B94281, _6BBB6308);
				}
				while (num > 429547269);
			}
		}

		public override D3B95303 _5C36403F()
		{
			uint num = 582709043u;
			return new _77BA31B1(FF19E111);
		}

		public _77BA31B1(D3B95303 _6039AA25)
		{
			uint num = 1445536312u;
			if (num >= 1035399357)
			{
				goto IL_0011;
			}
			goto IL_001f;
			IL_0011:
			num = 3677167751u / num;
			goto IL_001f;
			IL_001f:
			num >>= 5;
			FF19E111 = _6039AA25;
			if ((0x2436B713 ^ num) != 0)
			{
				return;
			}
			goto IL_0011;
		}
	}

	private sealed class _3900AE97
	{
		private enum _47053A96
		{
			E48B2227 = 14,
			_330C5C02 = 0,
			_091C9009 = 13,
			_9823449E = 18,
			_2EB3A210 = 3,
			A835648B = 19,
			FAB3C324 = 25,
			_87B61210 = 32,
			_8F840ABC = 6,
			B5A6B0A6 = 29,
			_2C1F0692 = 20,
			BA34CA07 = 30,
			_6FB1A432 = 21,
			_7B204AA2 = 2,
			_39833C2B = 27,
			_2C33D81A = 15,
			_2F00B912 = 23,
			E2394F10 = 7,
			D924E6B3 = 26,
			C4B45A1F = 12,
			_6997D61D = 17,
			DE8D2DBE = 31,
			_1ABF6C13 = 22,
			_9335603E = 69,
			_339B0925 = 11,
			ADB0E694 = 24,
			A8A453B5 = 16,
			_130D2B9F = 8,
			_5D0F2220 = 10,
			_16B04C9E = 5,
			_06A28618 = 9,
			_688A7088 = 1,
			AE04F429 = 65,
			AB9344BA = 4,
			D2B58F38 = 28
		}

		private int F80661B4;

		private byte[] _241F9EB4;

		public Type C1228F92(Module _5A8036A4)
		{
			while (true)
			{
				uint num = 3558322087u;
				bool flag = false;
				while (true)
				{
					num >>= 11;
					uint num2 = num ^ 0x1A82F4;
					num = 0x8C31E290u | num;
					bool flag2 = (byte)num2 != 0;
					while (true)
					{
						_47053A96 _47053A97;
						if (!flag2)
						{
							_47053A97 = (_47053A96)_4917C10A();
							if (num == 708754879)
							{
								continue;
							}
							Type type2;
							switch (_47053A97)
							{
							default:
								if (num / 4118856840u != 0)
								{
									goto end_IL_0231;
								}
								num ^= 0;
								goto case _47053A96.A8A453B5;
							case _47053A96._330C5C02:
								num = 2091983622 % num;
								type2 = null;
								if (1108811060 >= num)
								{
									goto end_IL_0231;
								}
								goto IL_0871;
							case _47053A96._688A7088:
								if (num > 3129004814u)
								{
									goto end_IL_000a;
								}
								type2 = typeof(void);
								num += 4034215953u;
								goto IL_0871;
							case _47053A96._7B204AA2:
							{
								num *= 2518745507u;
								if (2810304915u / num == 0)
								{
									goto end_IL_0231;
								}
								Type typeFromHandle2 = typeof(bool);
								num /= 4046897182u;
								type2 = typeFromHandle2;
								num += 2091983622;
								goto IL_0871;
							}
							case _47053A96._2EB3A210:
							{
								Type typeFromHandle7 = typeof(char);
								num ^= 0x69261EBE;
								type2 = typeFromHandle7;
								num ^= 0x99ACDF4Du;
								goto IL_0871;
							}
							case _47053A96.AB9344BA:
								num *= 3895070776u;
								num &= 0xAC1B5404u;
								type2 = typeof(sbyte);
								if (1443535422 == num)
								{
									goto end_IL_000a;
								}
								num ^= 0xD0AB7706u;
								goto IL_0871;
							case _47053A96._16B04C9E:
								num %= 2617776927u;
								type2 = typeof(byte);
								num += 4034215953u;
								goto IL_0871;
							case _47053A96._8F840ABC:
								if (num >= 3601457951u)
								{
									goto end_IL_000a;
								}
								type2 = typeof(short);
								num += 4034215953u;
								goto IL_0871;
							case _47053A96.E2394F10:
							{
								num ^= 0xA5169893u;
								Type typeFromHandle3 = typeof(ushort);
								num *= 1160664841;
								type2 = typeFromHandle3;
								num ^= 0x1F34D490;
								goto IL_0871;
							}
							case _47053A96._130D2B9F:
								num = 1091982889 - num;
								if ((0xDE81C80Au ^ num) == 0)
								{
									goto end_IL_000a;
								}
								type2 = typeof(int);
								if (1570654119 >>> (int)num == 0)
								{
									goto end_IL_000a;
								}
								num += 3352735698u;
								goto IL_0871;
							case _47053A96._06A28618:
							{
								num = 0x57068400 | num;
								if (num << 12 == 0)
								{
									goto end_IL_0231;
								}
								Type typeFromHandle = typeof(uint);
								num |= 0xF6064416u;
								type2 = typeFromHandle;
								if (num <= 419499681)
								{
									break;
								}
								num ^= 0x838EC5F1u;
								goto IL_0871;
							}
							case _47053A96._5D0F2220:
							{
								if (num == 2183075358u)
								{
									goto end_IL_0231;
								}
								num += 3534382493u;
								Type typeFromHandle6 = typeof(long);
								num = 3324645777u >> (int)num;
								type2 = typeFromHandle6;
								num ^= 0x7CB1128C;
								goto IL_0871;
							}
							case _47053A96._339B0925:
								num <<= 4;
								if (num < 2284272297u)
								{
									goto end_IL_000a;
								}
								type2 = typeof(ulong);
								num += 3102929846u;
								goto IL_0871;
							case _47053A96.C4B45A1F:
								if (-1892893908 >>> (int)num == 0)
								{
									goto IL_002c;
								}
								type2 = typeof(float);
								if (num <= 2316341182u)
								{
									break;
								}
								num ^= 0xF08AC1F3u;
								goto IL_0871;
							case _47053A96._091C9009:
							{
								num -= 3103936574u;
								Type typeFromHandle5 = typeof(double);
								num |= 0x6EA6168F;
								type2 = typeFromHandle5;
								if ((int)num + -1455544820 == 0)
								{
									goto end_IL_000a;
								}
								num ^= 0x830EB5B9u;
								goto IL_0871;
							}
							case _47053A96.ADB0E694:
							{
								num -= 3635486983u;
								Type typeFromHandle4 = typeof(IntPtr);
								num *= 4263914500u;
								type2 = typeFromHandle4;
								if (755848854 == num)
								{
									goto IL_002c;
								}
								num ^= 0xE862CCBEu;
								goto IL_0871;
							}
							case _47053A96.FAB3C324:
								type2 = typeof(UIntPtr);
								if (num > 3533265840u)
								{
									goto end_IL_000a;
								}
								num ^= 0xF08AC1F3u;
								goto IL_0871;
							case _47053A96.E48B2227:
								num = 0x41A7F391 & num;
								if (747708183 <= num)
								{
									goto end_IL_000a;
								}
								num += 3221552004u;
								type2 = typeof(string);
								if (num << 18 == 0)
								{
									goto end_IL_000a;
								}
								num ^= 0xBC99FD13u;
								goto IL_0871;
							case _47053A96.D2B58F38:
								num -= 4214888095u;
								num ^= 0x9EB653ABu;
								type2 = typeof(object);
								num ^= 0x7306BCFB;
								goto IL_0871;
							case _47053A96._6997D61D:
							case _47053A96._9823449E:
							{
								num = 0x2713CE3C ^ num;
								uint num3 = _4917C10A();
								int num4 = (int)num ^ -1423430454;
								num %= 3616103956u;
								int num5 = (int)num3 & num4;
								num = 490488237 % num;
								uint num6 = (uint)num5;
								num &= 0x138E500B;
								if (num >= 4105167166u)
								{
									goto end_IL_000a;
								}
								uint num8;
								uint num10;
								uint metadataToken;
								Type type3;
								switch (num6)
								{
								case 0u:
									num8 = num ^ 0x130C4009;
									if (397513660 < num)
									{
										break;
									}
									goto IL_077c;
								case 1u:
								{
									num |= 0x6B99A21E;
									uint num9 = num ^ 0x7A9DE21F;
									num = 1336818223 * num;
									num8 = num9;
									num ^= 0xA845C9B8u;
									goto IL_077c;
								}
								case 2u:
									num &= 0xDC3EF888u;
									num8 = num ^ 0xB0C4008;
									num += 16777217;
									goto IL_077c;
								default:
									{
										num = 0xA2228C03u | num;
										uint num7 = num + 1288778741;
										num >>= 13;
										num8 = num7;
										num ^= 0x1109D97F;
										goto IL_077c;
									}
									IL_077c:
									num10 = num8;
									num %= 3516527668u;
									metadataToken = num10 | (num3 >> (int)(num - 286015495));
									num = 1771847357 - num;
									type3 = _5A8036A4.ResolveType((int)metadataToken);
									num /= 2392176298u;
									type2 = type3;
									num ^= 0x7CB12306;
									goto IL_0871;
								}
								goto end_IL_000a;
							}
							case _47053A96._2C33D81A:
								num ^= 0x369462BA;
								if (1107584643 >= num)
								{
									goto end_IL_0231;
								}
								num &= 0xDA4FA91;
								type2 = C1228F92(_5A8036A4).MakePointerType();
								if (num << 26 == 0)
								{
									goto IL_002c;
								}
								num ^= 0x7415A307;
								goto IL_0871;
							case _47053A96.B5A6B0A6:
							{
								num = 3091079048u - num;
								if (708446596 > num)
								{
									break;
								}
								num /= 2970418986u;
								Type type = C1228F92(_5A8036A4);
								num = 3569120777u - num;
								type2 = type.MakeArrayType();
								num += 2817830141u;
								goto IL_0871;
							}
							case _47053A96.A8A453B5:
							case _47053A96.A835648B:
							case _47053A96._2C1F0692:
							case _47053A96._6FB1A432:
							case _47053A96._1ABF6C13:
							case _47053A96._2F00B912:
							case _47053A96.D924E6B3:
							case _47053A96._39833C2B:
								{
									num <<= 16;
									int errorCode = (int)num + -1658973625;
									num = 2284656314u * num;
									throw new COMException(null, errorCode);
								}
								IL_0871:
								if (flag)
								{
									if ((0x29B2749C & num) == 0)
									{
										break;
									}
									type2 = type2.MakeByRefType();
									num ^= 0;
								}
								return type2;
							}
							continue;
						}
						goto IL_002c;
						IL_002c:
						num = 2542693149u;
						num = 1134685759 + num;
						_47053A97 = (_47053A96)_56117B96();
						num *= 1427621278;
						if ((0x7993200 & num) == 0)
						{
							break;
						}
						_47053A96 num11 = _47053A97;
						num += 3954952603u;
						int num12 = (int)num ^ -73745341;
						num &= 0xB691D38Eu;
						if ((int)num11 <= num12)
						{
							if (3296983996u % num == 0)
							{
								goto end_IL_000a;
							}
							_47053A96 num13 = _47053A97;
							num |= 0xB377D13;
							int num14 = (int)num - -1145570045;
							num = 3820126380u >> (int)num;
							if (num13 == (_47053A96)num14)
							{
								flag = (byte)(num ^ 0x1C77) != 0;
								if (num % 397353883 == 0)
								{
									break;
								}
								num ^= 0x8C3BFE83u;
								continue;
							}
							if (-1372324214 << (int)num == 0)
							{
								break;
							}
							_47053A96 num15 = _47053A97;
							num = 3675314955u / num;
							uint num16 = num ^ 0x7B26C;
							num = 1287021705 % num;
							if ((uint)((int)num15 - (int)num16) <= (num ^ 0x32C95))
							{
								num %= 2872020521u;
								_4917C10A();
								num ^= 0x8C38CE61u;
								continue;
							}
							if (-1895337589 == (int)num)
							{
								goto end_IL_000a;
							}
						}
						else
						{
							if (num <= 2593562025u)
							{
								goto end_IL_000a;
							}
							_47053A96 num17 = _47053A97;
							num = 1623056558 - num;
							int num18 = (int)num ^ -1372761875;
							num -= 1235973267;
							num += 666502876;
							if (num17 == (_47053A96)num18)
							{
								continue;
							}
							num *= 4027536826u;
							_47053A96 num19 = _47053A97;
							num = 0xA004B190u | num;
							uint num20 = num + 499269811;
							num >>= 1;
							num ^= 0xFD253D3Cu;
							if (num19 == (_47053A96)num20)
							{
								continue;
							}
							if (-402622456 * (int)num == 0)
							{
								goto end_IL_000a;
							}
							num += 1942440351;
						}
						uint num21 = num ^ 0x32C94;
						num /= 2972808746u;
						flag2 = (byte)num21 != 0;
						num = 3291096462u * num;
						num ^= 0xA4BFA735u;
						int f80661B = F80661B4;
						num = 0x5A94DE00 | num;
						int num22 = (int)num ^ -20971724;
						num <<= 20;
						F80661B4 = f80661B - num22;
						num += 2565595893u;
						continue;
						end_IL_0231:
						break;
					}
					continue;
					end_IL_000a:
					break;
				}
			}
		}

		public byte _56117B96()
		{
			uint num = 422262179u;
			num += 599021318;
			byte[] array = _241F9EB4;
			num = 3582464029u % num;
			int f80661B = F80661B4;
			num %= 3459897216u;
			int num2 = f80661B;
			num = (uint)(639040312 << (int)num);
			uint num3 = num + 1738806049;
			num %= 1588800258;
			F80661B4 = num2 + (int)num3;
			num *= 2453202110u;
			return array[num2];
		}

		public uint _4917C10A()
		{
			uint num = 4077591333u;
			while (true)
			{
				num = 0x5CAA6823 & num;
				byte[] array = _241F9EB4;
				num = 0x99ADEF3Cu ^ num;
				byte num2 = array[F80661B4];
				num >>= 2;
				byte b = num2;
				num -= 3296941236u;
				if ((int)num + -1666960864 == 0)
				{
					continue;
				}
				while (true)
				{
					uint result;
					if ((b & (num ^ 0x6DE6A593)) == 0)
					{
						if (num <= 86802228)
						{
							continue;
						}
						byte[] array2 = _241F9EB4;
						num /= 663491100;
						int f80661B = F80661B4;
						num = 0x5BA376AC | num;
						byte num3 = array2[f80661B];
						num = 0xAD967F27u & num;
						uint num4 = num3 & (num ^ 0x9827659);
						num /= 430545299;
						result = num4;
						goto IL_008f;
					}
					num = 982904739 / num;
					num = 0x1B8B662E ^ num;
					uint num5 = num ^ 0x1B8B666E;
					num >>= 29;
					uint num6 = b & num5;
					num += 404373257;
					if (num6 == 0)
					{
						if ((num ^ 0x968D7597u) == 0)
						{
							break;
						}
						byte[] array3 = _241F9EB4;
						num <<= 20;
						num = 2539670 * num;
						int f80661B2 = F80661B4;
						num = 2902944549u - num;
						byte num7 = array3[f80661B2];
						num = 0x5D1D430F ^ num;
						int num8 = num7 & ((int)num - -440784917);
						num = 3735245102u + num;
						int num9 = (int)num ^ -1000507056;
						num = 0x2CA80F2F | num;
						int num10 = num8 << num9;
						num <<= 17;
						num = 3576133821u - num;
						byte[] array4 = _241F9EB4;
						num ^= 0x3E84548F;
						int f80661B3 = F80661B4;
						num += 2980650904u;
						int num11 = f80661B3 + ((int)num - -1705620535);
						num = (uint)(867495965 << (int)num);
						int num12 = num10 + array4[num11];
						num %= 1068399746;
						result = (uint)num12;
						if (488057650 < num)
						{
							continue;
						}
						num = 337169843 * num;
						int f80661B4 = F80661B4;
						num = 3633861268u / num;
						uint num13 = num + 1;
						num += 1831962642;
						int f80661B5 = f80661B4 + (int)num13;
						num /= 2223087027u;
						F80661B4 = f80661B5;
						if (1552671758 >>> (int)num == 0)
						{
							break;
						}
						num += 0;
					}
					else
					{
						num /= 824687777;
						if ((0xCAB3B716u ^ num) == 0)
						{
							break;
						}
						byte[] array5 = _241F9EB4;
						num &= 0xA53BDE0Eu;
						byte num14 = array5[F80661B4];
						num = 0x5B00F01 ^ num;
						uint num15 = num ^ 0x5B00F1E;
						num <<= 6;
						uint num16 = num14 & num15;
						num += 3213320199u;
						int num17 = (int)num + -730538031;
						num <<= 4;
						uint num18 = num16 << num17;
						byte[] array6 = _241F9EB4;
						num = 0xBBEC11F ^ num;
						num /= 2486924983u;
						int f80661B6 = F80661B4;
						num = 0x93139FA5u | num;
						int num19 = f80661B6 + (int)(num + 1827430492);
						num /= 2024494759;
						int num20 = (int)num18 + (array6[num19] << (int)(num ^ 0x11));
						byte[] array7 = _241F9EB4;
						num ^= 0x9D910A39u;
						int f80661B7 = F80661B4;
						num = 0x9B983AACu | num;
						byte num21 = array7[f80661B7 + (int)(num ^ 0x9F993ABEu)];
						num = 261094308 + num;
						int num22 = (int)num ^ -1356253592;
						num = 0x20489BB ^ num;
						int num23 = num21 << num22;
						num /= 2483088163u;
						int num24 = num20 + num23;
						num &= 0x3927B930;
						num = 0x46349810 ^ num;
						byte[] array8 = _241F9EB4;
						num -= 849114543;
						int num25 = F80661B4 + (int)(num ^ 0x13982262);
						num ^= 0xA6B7B12Au;
						byte num26 = array8[num25];
						num = 4037942152u + num;
						int num27 = num24 + num26;
						num += 2050201351;
						result = (uint)num27;
						if (num / 3793746487u != 0)
						{
							goto IL_008f;
						}
						int f80661B8 = F80661B4;
						num = 2528272178u / num;
						F80661B4 = f80661B8 + (int)(num + 0);
						num ^= 4;
					}
					goto IL_0336;
					IL_008f:
					num /= 3785165371u;
					F80661B4 += (int)(num ^ 1);
					goto IL_0336;
					IL_0336:
					num = 0x5F250C2A ^ num;
					return result;
				}
			}
		}

		public _3900AE97(byte[] _0082C39F)
		{
			uint num = 2241361596u;
			do
			{
				num = 889227911 + num;
				_241F9EB4 = _0082C39F;
			}
			while (1855075479 == num);
		}
	}

	private sealed class DD1F4626 : B7078183
	{
		private D3B95303 _94B201BB;

		private UIntPtr CC14F287;

		public static D3B95303 _81BA2DB0(D3B95303 _7706CCBF)
		{
			uint num = 2846363697u;
			if (num == 1950280109 || IntPtr.Size != (int)num - -1448603603)
			{
				return _37B6A08E._9EB4EABC(_7706CCBF);
			}
			num = 1857088430 % num;
			return _85140483.A333E7A5(_7706CCBF);
		}

		public override long _249CC8BD()
		{
			uint num = 3415480629u;
			num &= 0x571BE426;
			return _94B201BB._249CC8BD();
		}

		public override ushort AD1962B2()
		{
			uint num = 3650334137u;
			D3B95303 d3B = _94B201BB;
			num = 1496321305 / num;
			return d3B.AD1962B2();
		}

		public override object _9F320096()
		{
			uint num = 2198280585u;
			UIntPtr cC14F = CC14F287;
			num += 3265620797u;
			return cC14F;
		}

		public override uint _3503DA1F()
		{
			uint num = 882541585u;
			D3B95303 d3B = _94B201BB;
			num = 0x94A82CA7u | num;
			return d3B._3503DA1F();
		}

		public override IntPtr _27832122()
		{
			D3B95303 d3B = _94B201BB;
			uint num = 3384791216u;
			return d3B._27832122();
		}

		public override ulong _588AFCB3()
		{
			uint num = 4129261997u;
			return _94B201BB._588AFCB3();
		}

		public override Type D293A3AF()
		{
			uint num = 548832641u;
			return typeof(UIntPtr);
		}

		private static D3B95303 D406189B(UIntPtr _0E127104)
		{
			int size = IntPtr.Size;
			uint num = 2534504482u;
			int num2 = (int)num ^ -1760462810;
			num -= 2156849710u;
			if (size == num2)
			{
				num = 0xB83453BEu ^ num;
				if (num != 362341667)
				{
					return new B7035AA0((int)_0E127104.ToUInt32());
				}
			}
			num &= 0xD7A38612u;
			num *= 1747914519;
			return new D51696A5((long)_0E127104.ToUInt64());
		}

		public override bool C9093688()
		{
			uint num = 556463160u;
			num = 1813101735 / num;
			UIntPtr cC14F = CC14F287;
			num = 0xB0A8EB02u & num;
			UIntPtr zero = UIntPtr.Zero;
			num += 1950055217;
			return cC14F != zero;
		}

		public override D3B95303 _5C36403F()
		{
			return new DD1F4626(CC14F287);
		}

		public override float DEAE8E8E()
		{
			uint num = 3802328485u;
			return _94B201BB.DEAE8E8E();
		}

		public override sbyte _6C14C0B7()
		{
			uint num = 1855015716u;
			return _94B201BB._6C14C0B7();
		}

		public override int _6527EC0E()
		{
			uint num = 488423215u;
			return _94B201BB._6527EC0E();
		}

		public override byte _6E94D6A9()
		{
			uint num = 2575470373u;
			return _94B201BB._6E94D6A9();
		}

		public override UIntPtr _1DB07EA4()
		{
			uint num = 3801388069u;
			num <<= 5;
			return CC14F287;
		}

		public override short E39CE9A9()
		{
			D3B95303 d3B = _94B201BB;
			uint num = 4136024761u;
			return d3B.E39CE9A9();
		}

		public override double DB900D19()
		{
			return _94B201BB.DB900D19();
		}

		public override void DE8C17B9(object _13AB30AF)
		{
			uint num = 3022455478u;
			num = 640860441 - num;
			num = 1881313069 / num;
			UIntPtr cC14F = (UIntPtr)_13AB30AF;
			num = 1879835438 * num;
			CC14F287 = cC14F;
			num &= 0xE39C49B8u;
			do
			{
				UIntPtr cC14F2 = CC14F287;
				num = 1670114819 + num;
				D3B95303 d3B = D406189B(cC14F2);
				num = 0xE71A0E09u ^ num;
				_94B201BB = d3B;
			}
			while (92564611 == num);
		}

		public DD1F4626(UIntPtr FE0FE43E)
		{
			uint num = 302960150u;
			num = 1594073501 / num;
			CC14F287 = FE0FE43E;
			D3B95303 d3B = D406189B(CC14F287);
			num = 0xD00D912Cu | num;
			_94B201BB = d3B;
		}
	}

	private sealed class _6F17E0A1 : _128A201A
	{
		private int _1404099F;

		private Array _36896C0A;

		public override Type D293A3AF()
		{
			uint num = 210577187u;
			Type type = _36896C0A.GetType();
			num = 2970983210u / num;
			return type.GetElementType();
		}

		public override D3B95303 _5C36403F()
		{
			Array c805D68F = _36896C0A;
			uint num = 1199765918u;
			int _9C31500F = _1404099F;
			num = 454244155 % num;
			return new _6F17E0A1(c805D68F, _9C31500F);
		}

		public override object _9F320096()
		{
			uint num = 3012506301u;
			num = (uint)(1387952783 << (int)num);
			Array array = _36896C0A;
			num = (uint)(764636160 << (int)num);
			return array.GetValue(_1404099F);
		}

		public override void DE8C17B9(object _7D2F22AB)
		{
			uint num = 404845068u;
			do
			{
				IL_0006:
				num = 3775791516u * num;
				Type type = D293A3AF();
				num = 0x76B61A0F | num;
				TypeCode typeCode = Type.GetTypeCode(type);
				num += 1434466981;
				if (4119836427u * num != 0)
				{
					goto IL_0036;
				}
				goto IL_0083;
				IL_0083:
				if (num / 3087130630u != 0)
				{
					goto IL_0036;
				}
				object obj = Convert.ToSByte(_7D2F22AB);
				num = 0x6D1F7D1E & num;
				_7D2F22AB = obj;
				num ^= 0;
				continue;
				IL_00b1:
				if (3900864640u % num == 0)
				{
					goto IL_0006;
				}
				object obj2 = Convert.ToByte(_7D2F22AB);
				num = 3247082884u * num;
				_7D2F22AB = obj2;
				if (num > 1413314185)
				{
					goto IL_0083;
				}
				num ^= 0x40000000;
				continue;
				IL_0036:
				while (true)
				{
					num = 0x569EC43A | num;
					uint num2 = num - 1459607098;
					num = (uint)(-2102823535 << (int)num);
					switch ((int)typeCode - (int)num2)
					{
					case 1:
						break;
					case 2:
						goto IL_00b1;
					case 0:
					{
						if (num << 16 != 0)
						{
							continue;
						}
						char num5 = Convert.ToChar(_7D2F22AB);
						num <<= 19;
						object obj3 = num5;
						num = 0x3B09DC04 & num;
						_7D2F22AB = obj3;
						num ^= 0x40000000;
						goto IL_0260;
					}
					case 3:
					{
						num = 3322236302u - num;
						if (2184811662u >= num)
						{
							continue;
						}
						short num6 = Convert.ToInt16(_7D2F22AB);
						num = 0xF40145BEu & num;
						object obj5 = num6;
						num -= 2333193278u;
						_7D2F22AB = obj5;
						num += 1192259248;
						goto IL_0260;
					}
					case 4:
						goto IL_015d;
					case 5:
					{
						num = 0x3F9385 | num;
						object value4 = _7D2F22AB;
						num = 2805987638u + num;
						object obj4 = Convert.ToInt32(value4);
						num /= 2133158458;
						_7D2F22AB = obj4;
						num ^= 0x40000001;
						goto IL_0260;
					}
					case 6:
					{
						object value3 = _7D2F22AB;
						num = 0xFFBF6290u | num;
						uint num4 = Convert.ToUInt32(value3);
						num = (uint)(-612206323 << (int)num);
						_7D2F22AB = num4;
						if (num % 2889115917u == 0)
						{
							continue;
						}
						num += 3337814016u;
						goto IL_0260;
					}
					case 7:
					{
						num = 876019718 + num;
						object value2 = _7D2F22AB;
						num |= 0x29048C92;
						long num3 = Convert.ToInt64(value2);
						num /= 1519288240;
						_7D2F22AB = num3;
						num ^= 0x40000001;
						goto IL_0260;
					}
					case 8:
					{
						num %= 2813497233u;
						object value = _7D2F22AB;
						num += 1655266973;
						_7D2F22AB = Convert.ToUInt64(value);
						num ^= 0xE2A95E9Du;
						goto IL_0260;
					}
					default:
						goto IL_0260;
					}
					break;
				}
				goto IL_0083;
				IL_015d:
				if (num % 363010103 == 0)
				{
					goto IL_0006;
				}
				object value5 = _7D2F22AB;
				num ^= 0xAF81E13Eu;
				ushort num7 = Convert.ToUInt16(value5);
				num = 1192931353 + num;
				object obj6 = num7;
				num /= 2881001654u;
				_7D2F22AB = obj6;
				num ^= 0x40000000;
				IL_0260:;
			}
			while ((0xF002310Cu ^ num) == 0);
			num ^= 0x7F09959A;
			Array array = _36896C0A;
			object value6 = _7D2F22AB;
			num = 1680015015 * num;
			int index = _1404099F;
			num %= 126476713;
			array.SetValue(value6, index);
		}

		public _6F17E0A1(Array C805D68F, int _9C31500F)
		{
			uint num = 2602902705u;
			if (num != 4228411019u)
			{
			}
			_36896C0A = C805D68F;
			num |= 0x310D471E;
			num >>= 20;
			num = 756320783u >> (int)num;
			_1404099F = _9C31500F;
		}
	}

	private sealed class DC09FDAD : B7078183
	{
		private double _8B11B7A1;

		public static D3B95303 _84AB84A7(D3B95303 _050923A8)
		{
			uint num = 286692865u;
			double num3 = default(double);
			if (num < 347964035)
			{
				goto IL_0011;
			}
			goto IL_0028;
			IL_0011:
			D3B95303 d3B = _050923A8;
			num -= 1017374243;
			double num2 = d3B.DB900D19();
			num = 2116355388 * num;
			num3 = num2;
			goto IL_0028;
			IL_0028:
			while (true)
			{
				long num4 = (long)num3;
				num <<= 16;
				ulong num5 = (ulong)num4;
				while (true)
				{
					uint num6 = num + 1912078336;
					num += 3785620481u;
					int num7 = (int)num6;
					if (-1969747401 << (int)num != 0)
					{
						D3B95303 d3B2 = _050923A8;
						num /= 3508511647u;
						int num8 = d3B2._6E0A913C();
						num /= 2854021376u;
						int num9 = num8 & (int)(num ^ 0x10);
						num <<= 1;
						bool num10 = (uint)num9 > (num ^ 0);
						num <<= 1;
						if (num10)
						{
							double num11 = num3;
							num &= 0xEA9FD5A1u;
							if (num11 > -1.0)
							{
								num ^= 0xA19A1213u;
								if (num3 < 1.8446744073709552E+19)
								{
									goto IL_0102;
								}
								num ^= 0xA19A1213u;
							}
							num = 1856080003u >> (int)num;
							if (2668584098u < num)
							{
								break;
							}
							int num12 = num7;
							int num13 = (int)num + -1856079995;
							num -= 506790041;
							int num14 = num12 | num13;
							num <<= 30;
							num7 = num14;
							num ^= 0x219A1213;
							goto IL_0102;
						}
						num |= 0x3D87EC3F;
						double num15 = num3;
						num = 749713693 - num;
						if (num15 > -9.223372036854778E+18)
						{
							num <<= 7;
							if (num >= 2566970529u)
							{
								goto end_IL_0028;
							}
							double num16 = num3;
							num <<= 27;
							num ^= 0xA19A1213u;
							if (num16 < 9.223372036854776E+18)
							{
								goto IL_01f7;
							}
							num ^= 0x4EBDDECD;
						}
						int num17 = num7;
						num = 3851254418u >> (int)num;
						int num18 = (int)num - -5;
						num = 1535418625 + num;
						int num19 = num17 | num18;
						num = 3643027644u * num;
						num7 = num19;
						num += 2238911267u;
					}
					goto IL_01f7;
					IL_0102:
					if (!((double)num5 < 9.223372036854776E+18))
					{
						num = 2442114452u - num;
						ulong num20 = num5;
						num -= 3836795568u;
						double num21 = (long)num20;
						num = (uint)(-1484739799 << (int)num);
						num /= 236552217;
						ulong num22 = (ulong)(num21 - 9.223372036854776E+18);
						num = 0x6583F5B0 ^ num;
						long num23 = (long)num22 + long.MinValue;
						num ^= 0x8E9A2C0Cu;
						num5 = (ulong)num23;
						num += 3061856345u;
					}
					goto IL_01f7;
					IL_01f7:
					num >>= 27;
					if (406100136 > num)
					{
						D51696A5 d51696A = new D51696A5((long)num5);
						num &= 0x8F1F9EB7u;
						_050923A8 = d51696A;
						D3B95303 d3B3 = _050923A8;
						num = (uint)(-1182411881 << (int)num);
						int _6B1C = num7;
						num /= 1427016598;
						d3B3._82A5D1BE(_6B1C);
						num = 0x3400102E ^ num;
						if (-266575332 == (int)num)
						{
							break;
						}
						return _050923A8;
					}
				}
				continue;
				end_IL_0028:
				break;
			}
			goto IL_0011;
		}

		public override sbyte _6C14C0B7()
		{
			uint num = 4001800885u;
			double num2 = _8B11B7A1;
			num *= 757245842;
			return (sbyte)num2;
		}

		public override uint _3503DA1F()
		{
			uint num = 4253602737u;
			double num2 = _8B11B7A1;
			num &= 0x883B0F11u;
			return (uint)num2;
		}

		public override ulong _588AFCB3()
		{
			double num = _8B11B7A1;
			uint num2 = 1972271533u;
			return (ulong)num;
		}

		public override byte _6E94D6A9()
		{
			uint num = 3332066078u;
			double num2 = _8B11B7A1;
			num %= 1471823239;
			return (byte)num2;
		}

		public static D3B95303 _970C65A1(D3B95303 _8FAED1BE, D3B95303 _641780B6)
		{
			double num = _8FAED1BE.DB900D19();
			uint num2 = 1328597784u;
			double num3 = _641780B6.DB900D19();
			num2 = 0x610940B2 & num2;
			double _0AACBAB = num * num3;
			num2 |= 0x643A1D04;
			return new DC09FDAD(_0AACBAB);
		}

		public override char D31384B4()
		{
			uint num = 1586780314u;
			num += 2659952933u;
			return (char)_8B11B7A1;
		}

		public static D3B95303 _708B1E15(D3B95303 A7B5EF36, D3B95303 _809A88B0)
		{
			uint num = 288080022u;
			double num2 = default(double);
			if (num >> 25 != 0)
			{
				goto IL_0012;
			}
			goto IL_0027;
			IL_0012:
			num = (uint)(-527054541 << (int)num);
			num2 = A7B5EF36.DB900D19();
			goto IL_0027;
			IL_0027:
			while (true)
			{
				double num3 = _809A88B0.DB900D19();
				num %= 227776015;
				double num4 = num3;
				num = 1384233483u >> (int)num;
				uint num5 = num - 660;
				num = 0xA115210Cu | num;
				int num6 = (int)num5;
				num ^= 0x6713BB06;
				if (237206292 + num == 0)
				{
					break;
				}
				if (num2 == num4)
				{
					num |= 0x569DA2B3;
					if ((0xE6372239u ^ num) == 0)
					{
						continue;
					}
					int num7 = num6;
					uint num8 = num + 694175047;
					num = 624575153 / num;
					num6 = num7 | (int)num8;
				}
				else
				{
					num = 1183001518 % num;
					if (319148859 >= num)
					{
						break;
					}
					double num9 = num2;
					num -= 2149664808u;
					num += 966663290;
					if (num9 < num4)
					{
						num += 580289042;
						int num10 = num6;
						num /= 1093474621;
						num6 = num10 | (int)(num ^ 4);
						num += 0;
					}
				}
				num = 269575478 - num;
				return new B7035AA0(num6);
			}
			goto IL_0012;
		}

		public static D3B95303 _203B1D90(D3B95303 AB2E9E05, D3B95303 _3437EA18)
		{
			uint num = 1023826617u;
			double num2 = AB2E9E05.DB900D19();
			num += 187275914;
			num = 0x3A0A143C | num;
			double num3 = _3437EA18.DB900D19();
			num = 0xC8BC7E18u ^ num;
			num <<= 12;
			return new DC09FDAD(num2 + num3);
		}

		public override int _6527EC0E()
		{
			double num = _8B11B7A1;
			uint num2 = 2797337110u;
			return (int)num;
		}

		public override void DE8C17B9(object _8E1A9B30)
		{
			uint num = 588279474u;
			_8B11B7A1 = (double)_8E1A9B30;
		}

		public override double DB900D19()
		{
			return _8B11B7A1;
		}

		public override IntPtr _27832122()
		{
			uint num = 3048932868u;
			long value;
			if (IntPtr.Size != (int)num - -1246034432)
			{
				num = 1368960258 - num;
				double num2 = _8B11B7A1;
				num = 2551061414u % num;
				value = (long)num2;
			}
			else
			{
				num |= 0x9B85A4B8u;
				double num3 = _8B11B7A1;
				num = 4094007082u % num;
				int num4 = (int)num3;
				num = 194026652u >> (int)num;
				value = num4;
				num += 2551049572u;
			}
			num = 0xB9B88430u | num;
			return new IntPtr(value);
		}

		public static D3B95303 _06A312A8(D3B95303 D7A25530)
		{
			ulong num3;
			uint num2;
			do
			{
				ulong num = D7A25530._588AFCB3();
				num2 = 2140940058u;
				num3 = num;
				num2 = 2528416908u / num2;
			}
			while (num2 << 4 == 0);
			int num4 = D7A25530._6E0A913C();
			num2 %= 193429515;
			uint num5 = num2 ^ 0x11;
			num2 = 782910222 % num2;
			int num6 = num4 & (int)num5;
			num2 = 897841313 - num2;
			int num7 = (int)num2 + -897841313;
			num2 *= 430137910;
			double _0AACBAB;
			if ((uint)num6 <= (uint)num7)
			{
				num2 /= 1795676190;
				if (num2 <= 212549769)
				{
					_0AACBAB = (long)num3;
					goto IL_008a;
				}
			}
			num2 %= 872597303;
			_0AACBAB = num3;
			num2 ^= 0x67BF718;
			goto IL_008a;
			IL_008a:
			return new DC09FDAD(_0AACBAB);
		}

		public static D3B95303 EA24A01D(D3B95303 BFBDA322)
		{
			return new DC09FDAD(BFBDA322.DB900D19());
		}

		public override D3B95303 _5C36403F()
		{
			double _0AACBAB = _8B11B7A1;
			uint num = 2231403828u;
			return new DC09FDAD(_0AACBAB);
		}

		public static D3B95303 _309061BB(D3B95303 _249383B9)
		{
			uint num = 3896420740u;
			double num2 = _249383B9.DB900D19();
			num = (uint)(909813289 << (int)num);
			return new DC09FDAD(0.0 - num2);
		}

		public static D3B95303 _783C793A(D3B95303 _1D37CF87, D3B95303 BA89639B)
		{
			double num = _1D37CF87.DB900D19();
			uint num2 = 2360689298u;
			num2 = 3341378069u + num2;
			double num3 = BA89639B.DB900D19();
			num2 %= 4282298039u;
			double num4 = num3;
			num2 = (uint)(472590899 << (int)num2);
			double _0AACBAB = num / num4;
			num2 = 2560729255u / num2;
			return new DC09FDAD(_0AACBAB);
		}

		public static D3B95303 _57860B91(D3B95303 _85BC0D8C, D3B95303 _3C006128)
		{
			uint num = 1924289057u;
			num = 0x67AE11BC | num;
			double num2 = _85BC0D8C.DB900D19();
			num = 0xB8A48BA3u | num;
			double num3 = _3C006128.DB900D19();
			double _0AACBAB = num2 % num3;
			num = 2980855223u / num;
			return new DC09FDAD(_0AACBAB);
		}

		public override float DEAE8E8E()
		{
			uint num = 968730511u;
			num += 1890280106;
			double num2 = _8B11B7A1;
			num |= 0x2A174288;
			return (float)num2;
		}

		public override bool C9093688()
		{
			return Convert.ToBoolean(_8B11B7A1);
		}

		public override object _9F320096()
		{
			uint num = 648768656u;
			num <<= 13;
			double num2 = _8B11B7A1;
			num = 0x83BAED93u | num;
			return num2;
		}

		public override short E39CE9A9()
		{
			uint num = 2915037614u;
			num = 974767034 / num;
			double num2 = _8B11B7A1;
			num >>= 18;
			return (short)num2;
		}

		public override long _249CC8BD()
		{
			return (long)_8B11B7A1;
		}

		public override ushort AD1962B2()
		{
			return (ushort)_8B11B7A1;
		}

		public override UIntPtr _1DB07EA4()
		{
			long value;
			uint num;
			if (IntPtr.Size != 4)
			{
				num = 3383827757u;
				if (num > 1237213243)
				{
					double num2 = _8B11B7A1;
					num -= 2550307226u;
					value = (long)(ulong)num2;
					goto IL_004e;
				}
			}
			double num3 = _8B11B7A1;
			num = 3334462392u;
			uint num4 = (uint)num3;
			num = 3464747197u + num;
			value = num4;
			num += 2624245534u;
			goto IL_004e;
			IL_004e:
			num = 1429133453 - num;
			return new UIntPtr((ulong)value);
		}

		public override Type D293A3AF()
		{
			uint num = 3753685139u;
			return typeof(double);
		}

		public DC09FDAD(double _0AACBAB8)
		{
			_8B11B7A1 = _0AACBAB8;
		}
	}

	private abstract class D3B95303
	{
		private int CC13263E;

		public virtual bool C9093688()
		{
			uint num = 2660585399u;
			object value = _9F320096();
			num %= 414148867;
			return Convert.ToBoolean(value);
		}

		public virtual void _45971A1D(FieldInfo _1484D087, object C1885C06)
		{
			object obj = _9F320096();
			uint num = 4011180470u;
			if ((num ^ 0xF3B20EAEu) == 0)
			{
				goto IL_0092;
			}
			object obj2 = obj;
			num *= 2906592055u;
			if (obj2 != null)
			{
				num = 0x2918A00E & num;
				num = 429514018 / num;
				Type declaringType = _1484D087.DeclaringType;
				num |= 0xB7382096u;
				bool isValueType = declaringType.IsValueType;
				num >>= 18;
				num += 2765550156u;
				if (isValueType)
				{
					bool isPrimitive = obj.GetType().IsPrimitive;
					num /= 226617783;
					num += 2765561870u;
					if (isPrimitive)
					{
						num *= 251967364;
						if (num >= 2612490680u)
						{
							goto IL_0092;
						}
					}
				}
			}
			goto IL_00ca;
			IL_0092:
			num /= 2652829989u;
			IntPtr ptr = _27832122();
			num = 2603243560u / num;
			object obj3 = Marshal.PtrToStructure(ptr, _1484D087.DeclaringType);
			num = (uint)(-1338127554 << (int)num);
			obj = obj3;
			num += 1728832026;
			goto IL_00ca;
			IL_00ca:
			num = 1111277875 * num;
			num += 1401878564;
			object obj4 = obj;
			num += 4030691077u;
			_1484D087.SetValue(obj4, C1885C06);
			num = 2761504783u / num;
			ValueType obj5 = obj as ValueType;
			num <<= 26;
			if (obj5 != null)
			{
				DE8C17B9(obj);
				num += 0;
			}
		}

		public virtual bool _4C0EC108()
		{
			uint num = 3970151050u;
			return (byte)(num + 324816246) != 0;
		}

		public virtual B7078183 A883CB02()
		{
			throw new InvalidOperationException();
		}

		public virtual byte _6E94D6A9()
		{
			uint num = 3248999579u;
			object value = _9F320096();
			num <<= 21;
			return Convert.ToByte(value);
		}

		public virtual uint _3503DA1F()
		{
			uint num = 1570284599u;
			object value = _9F320096();
			num = 0xE68B1AB8u & num;
			return Convert.ToUInt32(value);
		}

		public virtual Type D293A3AF()
		{
			throw new InvalidOperationException();
		}

		public virtual int _6527EC0E()
		{
			uint num = 1578065211u;
			return Convert.ToInt32(_9F320096());
		}

		public virtual UIntPtr _1DB07EA4()
		{
			uint num = 4147958815u;
			while (true)
			{
				num += 1259773489;
				object obj = _9F320096();
				num = 0x658EF408 & num;
				object obj2 = obj;
				if (1707069627 / num == 0 || obj2 != null)
				{
					goto IL_0041;
				}
				if (1009479580 - num == 0)
				{
					continue;
				}
				object obj3 = null;
				goto IL_0068;
				IL_0068:
				num = 3885502131u - num;
				if ((Type)obj3 == typeof(UIntPtr))
				{
					num /= 2662440242u;
					return (UIntPtr)obj2;
				}
				if (1443349293 <= num)
				{
					break;
				}
				goto IL_0041;
				IL_0041:
				if (num == 597557546)
				{
					continue;
				}
				num = 246657687u >> (int)num;
				obj3 = obj2.GetType();
				num ^= 0x4EB1C297;
				goto IL_0068;
			}
			throw new InvalidOperationException();
		}

		public abstract void DE8C17B9(object D9957839);

		public virtual sbyte _6C14C0B7()
		{
			uint num = 3231093526u;
			num ^= 0x8B9CB131u;
			object value = _9F320096();
			num = 0x7CB0CF0A | num;
			return Convert.ToSByte(value);
		}

		public static D3B95303 _72358E28(D3B95303 _37307B81)
		{
			int num2;
			uint num;
			do
			{
				IL_0000:
				num = 2828569133u;
				num2 = 0;
				if (-2086857832 - (int)num == 0)
				{
					goto IL_0000;
				}
				int num3 = _37307B81._6E0A913C();
				int num4 = (int)num ^ -1466398147;
				num <<= 19;
				int num5 = num3 & num4;
				num = 0xBCA0C6B7u & num;
				bool num6 = (uint)num5 > (num ^ 0x10200000);
				num |= 0xEA04EE24u;
				if (!num6)
				{
					double d = _37307B81.DB900D19();
					num = 2628480812u / num;
					num |= 0xD3AA459Fu;
					if (!double.IsNaN(d))
					{
						num = (uint)(1980760096 << (int)num);
						num = 0xCBBA0E2Du | num;
						bool num7 = double.IsInfinity(d);
						num += 3556913537u;
						if (!num7)
						{
							continue;
						}
						num ^= 0x4C167A31;
					}
					num = 0x8997BE15u & num;
					if (num <= 4263711662u)
					{
						int num8 = num2;
						num *= 579646489;
						int num9 = (int)num + -369961477;
						num = 62798870 + num;
						num2 = num8 | num9;
						num ^= 0x8677598Du;
						continue;
					}
				}
				float f = _37307B81.DEAE8E8E();
				if (3140458004u > num)
				{
					goto IL_0000;
				}
				num &= 0xF241BB8;
				if (!float.IsNaN(f))
				{
					num |= 0x9FBC3D8Eu;
					if ((0xD428F988u ^ num) == 0)
					{
						goto IL_0000;
					}
					if (!float.IsInfinity(f))
					{
						continue;
					}
					num ^= 0x9598358Eu;
				}
				num = (uint)(-2053098825 << (int)num);
				if (889686049 == num)
				{
					goto IL_0000;
				}
				int num10 = num2;
				num = 103482776 / num;
				uint num11 = num ^ 8;
				num = 0x1C93208F | num;
				num2 = num10 | (int)num11;
				num += 2200510239u;
			}
			while (890924305 == num);
			return new B7035AA0(num2);
		}

		public unsafe static D3B95303 _6388BF9A(object _4BB13A1A, Type _80349F82)
		{
			uint num = 1001649851u;
			while (true)
			{
				bool isEnum = _80349F82.IsEnum;
				num &= 0xE4B4E1BCu;
				if (isEnum)
				{
					if (num == 3271717760u)
					{
						continue;
					}
				}
				else
				{
					while (num != 2107424950)
					{
						num = 4022110617u - num;
						TypeCode typeCode = Type.GetTypeCode(_80349F82);
						if (num >> 1 != 0)
						{
							switch ((int)typeCode - (int)(num + 821319458))
							{
							case 0:
								break;
							case 1:
								goto IL_0146;
							case 2:
								goto IL_016d;
							case 3:
							{
								object value3 = _4BB13A1A;
								num -= 202832012;
								return new _47B891B7(Convert.ToByte(value3));
							}
							case 4:
								num = 0x6120FCA1 ^ num;
								return new _3C352A26(Convert.ToInt16(_4BB13A1A));
							case 5:
								return new _5D05C73B(Convert.ToUInt16(_4BB13A1A));
							case 6:
							{
								object value2 = _4BB13A1A;
								num += 521910807;
								return new B7035AA0(Convert.ToInt32(value2));
							}
							case 7:
								goto IL_01d5;
							case 8:
							{
								num = 3879368335u >> (int)num;
								long _390BF = Convert.ToInt64(_4BB13A1A);
								num ^= 0x8274FBC;
								return new D51696A5(_390BF);
							}
							case 9:
							{
								num = 2620974241u / num;
								object value = _4BB13A1A;
								num = 1409497513 * num;
								ulong _3C29118D = Convert.ToUInt64(value);
								num = 3380793911u + num;
								return new _37B6A08E(_3C29118D);
							}
							case 10:
								num = 3676242483u >> (int)num;
								return new _2038A6B3(Convert.ToSingle(_4BB13A1A));
							case 11:
								num = 0xD1A3AE3Bu | num;
								return new DC09FDAD(Convert.ToDouble(_4BB13A1A));
							default:
								goto IL_0278;
							}
							if ((int)num - -878259556 == 0)
							{
								break;
							}
							object value4 = _4BB13A1A;
							num -= 1954626307;
							return new _0A28F932(Convert.ToBoolean(value4));
						}
						goto IL_0046;
						IL_0146:
						num <<= 13;
						if (num != 3532990350u)
						{
							char _0801BC9A = Convert.ToChar(_4BB13A1A);
							num >>= 7;
							return new _3014C498(_0801BC9A);
						}
					}
				}
				goto IL_0024;
				IL_0088:
				num /= 1226127935;
				if (num <= 2919316011u)
				{
					object obj = _4BB13A1A;
					num ^= 0xA3B8BA1Bu;
					Enum _70A = (Enum)obj;
					num = 3775382451u >> (int)num;
					return new _3BA48917(_70A);
				}
				continue;
				IL_006f:
				num = 3516610839u % num;
				_4BB13A1A = Enum.ToObject(_80349F82, _4BB13A1A);
				num += 193652169;
				goto IL_0088;
				IL_0278:
				if (-467049542 != (int)num)
				{
					if (_80349F82 == typeof(IntPtr))
					{
						num = 3878522675u / num;
						object obj2 = _4BB13A1A;
						num = 4113329335u >> (int)num;
						IntPtr _09B;
						if (obj2 == null)
						{
							if ((0x98B2FEB8u & num) == 0)
							{
								continue;
							}
							_09B = IntPtr.Zero;
						}
						else
						{
							if (3366249916u <= num)
							{
								goto IL_0088;
							}
							_09B = (IntPtr)_4BB13A1A;
							num += 0;
						}
						num &= 0xC4A32D37u;
						return new _88BA7B16(_09B);
					}
					num = 674900787 - num;
					if (num >> 25 != 0)
					{
						Type typeFromHandle = typeof(UIntPtr);
						num |= 0x323A4537;
						bool num2 = _80349F82 == typeFromHandle;
						num = 3124365117u / num;
						if (num2)
						{
							if (num >= 3037521848u)
							{
								continue;
							}
							object obj3 = _4BB13A1A;
							num = 2937708057u - num;
							IntPtr fE0FE43E;
							if (obj3 == null)
							{
								num |= 0x22A1F8A9;
								fE0FE43E = (nint)(nuint)UIntPtr.Zero;
							}
							else
							{
								if (4154201248u <= num)
								{
									goto IL_0046;
								}
								fE0FE43E = (nint)(nuint)(UIntPtr)_4BB13A1A;
								num ^= 0xA020A1;
							}
							return new DD1F4626((nuint)(nint)fE0FE43E);
						}
						if (!_80349F82.IsValueType)
						{
							break;
						}
						if ((num ^ 0xB9127F9Fu) != 0)
						{
							return new _64267A02(_4BB13A1A);
						}
						continue;
					}
					goto IL_0024;
				}
				goto IL_006f;
				IL_0024:
				while (true)
				{
					object obj4 = _4BB13A1A;
					num |= 0x35281506;
					if (obj4 == null)
					{
						break;
					}
					num = 0xA98A20A2u & num;
					if (3365000880u % num == 0)
					{
						continue;
					}
					goto IL_0046;
				}
				goto IL_0088;
				IL_01d5:
				num <<= 26;
				if (num != 4189993731u)
				{
					object value5 = _4BB13A1A;
					num <<= 3;
					uint _2F9E = Convert.ToUInt32(value5);
					num /= 1377272580;
					return new _85140483(_2F9E);
				}
				goto IL_006f;
				IL_0046:
				object obj5 = _4BB13A1A;
				num = 1906648383u >> (int)num;
				Enum obj6 = obj5 as Enum;
				num += 424651887;
				if (obj6 == null)
				{
					num = 160132997 * num;
					goto IL_006f;
				}
				goto IL_0088;
				IL_016d:
				if (num / 1764863631 != 0)
				{
					object value6 = _4BB13A1A;
					num = 0xF51D6F15u & num;
					return new _15343925(Convert.ToSByte(value6));
				}
			}
			num = 0xA71A561Cu & num;
			num = 3934747691u + num;
			if (_80349F82.IsPointer)
			{
				nint ptr;
				if (_4BB13A1A == null)
				{
					ptr = (nint)(uint)((int)num ^ -360219605);
				}
				else
				{
					object ptr2 = _4BB13A1A;
					num |= 0xCE227623u;
					ptr = (nint)Pointer.Unbox(ptr2);
					num ^= 0x4200200;
				}
				num %= 3146325891u;
				object f1A9B = Pointer.Box((void*)ptr, _80349F82);
				num = 2577850553u - num;
				return new _20AC20B8(f1A9B, _80349F82);
			}
			num = 0x648C95AE ^ num;
			object _04B76AB = _4BB13A1A;
			num *= 4102076824u;
			return new B1A0179E(_04B76AB);
		}

		public unsafe D3B95303 BD15691D(Type F809DF29)
		{
			uint num = 1427233793u;
			object obj = default(object);
			while (true)
			{
				bool isEnum = F809DF29.IsEnum;
				num = (uint)(780454975 << (int)num);
				if (isEnum)
				{
					num = 296005524 + num;
					if (num >= 1286239652)
					{
						goto IL_0032;
					}
				}
				else
				{
					num ^= 0xD32F9293u;
					if (num >> 18 != 0)
					{
						TypeCode typeCode = Type.GetTypeCode(F809DF29);
						num = 0x25372AAE & num;
						int num2 = (int)num + -69601961;
						num -= 2852932374u;
						TypeCode num3 = typeCode - num2;
						num *= 285384457;
						switch (num3)
						{
						case TypeCode.Empty:
						{
							num = 3307445527u - num;
							num = 523501072 - num;
							bool _42BCB11B = C9093688();
							num %= 1622919199;
							return new _0A28F932(_42BCB11B);
						}
						case TypeCode.Object:
							num = 3154117421u * num;
							num -= 2551544121u;
							return new _3014C498(D31384B4());
						case TypeCode.DBNull:
						{
							num = (uint)(-2028626631 << (int)num);
							sbyte a12BAD3B = _6C14C0B7();
							num ^= 0x8687A120u;
							return new _15343925(a12BAD3B);
						}
						case TypeCode.Boolean:
						{
							byte _872E3B = _6E94D6A9();
							num |= 0x8ABCF43Eu;
							return new _47B891B7(_872E3B);
						}
						case TypeCode.Char:
							break;
						case TypeCode.SByte:
							goto IL_01c3;
						case TypeCode.Byte:
							goto IL_01e3;
						case TypeCode.Int16:
						{
							num /= 2989515198u;
							uint _2F9E = _3503DA1F();
							num &= 0xB724C631u;
							return new _85140483(_2F9E);
						}
						case TypeCode.UInt16:
							num &= 0x212DFA8D;
							num = 0xA0D4399 ^ num;
							return new D51696A5(_249CC8BD());
						case TypeCode.Int32:
						{
							num = 0x890B7401u & num;
							num = 842590597 / num;
							ulong _3C29118D = _588AFCB3();
							num = 1419563401u >> (int)num;
							return new _37B6A08E(_3C29118D);
						}
						case TypeCode.UInt32:
							goto IL_026c;
						case TypeCode.Int64:
							goto IL_0294;
						default:
							goto IL_02c1;
						}
						if ((num ^ 0xB1A5F3B7u) != 0)
						{
							return new _3C352A26(E39CE9A9());
						}
						goto IL_0032;
					}
				}
				goto IL_0054;
				IL_026c:
				num = 973325220 + num;
				if (2435004467u + num != 0)
				{
					num |= 0x3EACD79C;
					return new _2038A6B3(DEAE8E8E());
				}
				continue;
				IL_0054:
				if (obj != null)
				{
					num &= 0x2DA99989;
					goto IL_0062;
				}
				goto IL_00a5;
				IL_01e3:
				num = 4053910803u + num;
				if (num < 3440928557u)
				{
					int _1B2FFB = _6527EC0E();
					num -= 310582273;
					return new B7035AA0(_1B2FFB);
				}
				goto IL_0062;
				IL_02c1:
				if ((int)num - -752678758 == 0)
				{
					continue;
				}
				num = (uint)(-978094430 << (int)num);
				Type typeFromHandle = typeof(IntPtr);
				num /= 2611150516u;
				if (F809DF29 == typeFromHandle)
				{
					num = 2585367715u - num;
					if ((num & 0xCD36FEA4u) != 0)
					{
						return new _88BA7B16(_27832122());
					}
					continue;
				}
				if ((0x65930AA1 ^ num) == 0)
				{
					continue;
				}
				num <<= 2;
				num %= 3499365912u;
				if (F809DF29 == typeof(UIntPtr))
				{
					num = 0x670E4EA2 ^ num;
					UIntPtr fE0FE43E = _1DB07EA4();
					num %= 2250101249u;
					return new DD1F4626(fE0FE43E);
				}
				num = 3382980642u - num;
				bool isValueType = F809DF29.IsValueType;
				num >>= 18;
				if (isValueType)
				{
					object d4108A8B = _9F320096();
					num %= 2603004075u;
					return new _64267A02(d4108A8B);
				}
				if ((0x63BCCC1A ^ num) != 0)
				{
					if (!F809DF29.IsPointer)
					{
						break;
					}
					num = 3005974019u % num;
					if (num <= 2334602378u)
					{
						IntPtr intPtr = _27832122();
						if (2467508668u * num != 0)
						{
							void* ptr = intPtr.ToPointer();
							num = 0xD51E9A0Du | num;
							return new _20AC20B8(Pointer.Box(ptr, F809DF29), F809DF29);
						}
					}
					goto IL_0032;
				}
				goto IL_0054;
				IL_0062:
				object obj2 = obj;
				num = 0xB1073AA3u & num;
				Enum obj3 = obj2 as Enum;
				num >>= 17;
				num ^= 0x3005CC8C;
				if (obj3 == null)
				{
					num &= 0x269F471C;
					object obj4 = Enum.ToObject(F809DF29, obj);
					num = 1327458470 * num;
					obj = obj4;
					num ^= 0xE8872344u;
				}
				goto IL_00a5;
				IL_00a5:
				Enum _70A = (Enum)obj;
				num = 280760853u >> (int)num;
				return new _3BA48917(_70A);
				IL_0294:
				if (num <= 3230146947u)
				{
					num = 84019903u >> (int)num;
					double _0AACBAB = DB900D19();
					num = 4035571492u - num;
					return new DC09FDAD(_0AACBAB);
				}
				goto IL_0054;
				IL_01c3:
				if (3165293450u * num != 0)
				{
					ushort cD815BA = AD1962B2();
					num = 229056168 - num;
					return new _5D05C73B(cD815BA);
				}
				goto IL_0054;
				IL_0032:
				num ^= 0x2D02830E;
				object obj5 = _9F320096();
				num = 1941088168 % num;
				obj = obj5;
				if (1553632662 < num)
				{
					continue;
				}
				goto IL_0054;
			}
			object _04B76AB = _9F320096();
			num = 3039590294u >> (int)num;
			return new B1A0179E(_04B76AB);
		}

		public virtual short E39CE9A9()
		{
			uint num = 2777500166u;
			return Convert.ToInt16(_9F320096());
		}

		public virtual int _6E0A913C()
		{
			uint num = 1613895200u;
			num = 2056049834 * num;
			return CC13263E;
		}

		public virtual ulong _588AFCB3()
		{
			object value = _9F320096();
			uint num = 296221755u;
			return Convert.ToUInt64(value);
		}

		public virtual long _249CC8BD()
		{
			return Convert.ToInt64(_9F320096());
		}

		public virtual ushort AD1962B2()
		{
			uint num = 179577858u;
			num %= 126334371;
			return Convert.ToUInt16(_9F320096());
		}

		public static D3B95303 F30AD72B(D3B95303 ED2B6514, Type _7DB60024)
		{
			uint num = 1925125398u;
			object obj = null;
			Type type = default(Type);
			int num3 = default(int);
			if (num != 1637333043)
			{
				goto IL_0011;
			}
			goto IL_009a;
			IL_0011:
			obj = ED2B6514._9F320096();
			goto IL_0018;
			IL_0018:
			num = 3291857165u + num;
			uint num2 = num - 922015267;
			num = 3291976098u - num;
			num3 = (int)num2;
			num >>= 29;
			if (num >= 3460148668u)
			{
				goto IL_0011;
			}
			goto IL_0043;
			IL_0043:
			if (obj == null)
			{
				if (num >> 13 == 0)
				{
					int num4 = num3;
					uint num5 = num ^ 6;
					num = 0x820397AFu & num;
					num3 = num4 | (int)num5;
					goto IL_00ea;
				}
			}
			else if (num <= 547082032)
			{
				type = obj.GetType();
				num = 873324724 - num;
				if (!(type == _7DB60024))
				{
					num = 2743127937u % num;
					goto IL_009a;
				}
				goto IL_00b6;
			}
			goto IL_0011;
			IL_009a:
			bool num6 = _7DB60024.IsAssignableFrom(type);
			num ^= 0x7572D75;
			if (num6)
			{
				num ^= 0x340DE0B4;
				goto IL_00b6;
			}
			goto IL_00ea;
			IL_00b6:
			if (832940211 >>> (int)num == 0)
			{
				goto IL_0018;
			}
			int num7 = num3;
			uint num8 = num ^ 0x340DE0B2;
			num = 2887932433u / num;
			int num9 = num7 | (int)num8;
			num = 3985034662u / num;
			num3 = num9;
			num += 2966622413u;
			goto IL_00ea;
			IL_00ea:
			if (1117018279 != num)
			{
				return new B7035AA0(num3);
			}
			goto IL_0043;
		}

		public virtual object DDAAAA0B(FieldInfo _5A03BAA6)
		{
			object obj;
			uint num;
			do
			{
				IL_0000:
				num = 3499373440u;
				obj = _9F320096();
				num -= 4095396399u;
				if ((0xBAA10F09u ^ num) == 0 || obj == null)
				{
					continue;
				}
				num -= 3020793120u;
				num = 3783436447u >> (int)num;
				Type declaringType = _5A03BAA6.DeclaringType;
				num = 3129626893u >> (int)num;
				bool isValueType = declaringType.IsValueType;
				num += 2134130891;
				if (!isValueType)
				{
					continue;
				}
				if (num < 1891276443)
				{
					goto IL_0000;
				}
				bool isPrimitive = obj.GetType().IsPrimitive;
				num += 0;
				if (isPrimitive)
				{
					if (num <= 2517141927u)
					{
						goto IL_0000;
					}
					IntPtr ptr = _27832122();
					num &= 0x33258623;
					Type declaringType2 = _5A03BAA6.DeclaringType;
					num <<= 4;
					object obj2 = Marshal.PtrToStructure(ptr, declaringType2);
					num = 1965423380u >> (int)num;
					obj = obj2;
					num ^= 0xDC791C74u;
				}
			}
			while (807582122 >= num);
			object obj3 = obj;
			num |= 0xF20438F;
			return _5A03BAA6.GetValue(obj3);
		}

		public virtual void _82A5D1BE(int _6B1C1026)
		{
			uint num = 4245046159u;
			do
			{
				CC13263E = _6B1C1026;
			}
			while (num == 53439253);
		}

		public virtual IntPtr _27832122()
		{
			uint num = 438340031u;
			object obj2 = default(object);
			if (num <= 3207078332u)
			{
				object obj = _9F320096();
				num <<= 13;
				obj2 = obj;
				num = 1352205502 - num;
				if (1721669021 >>> (int)num == 0)
				{
					goto IL_0068;
				}
			}
			goto IL_003a;
			IL_0097:
			num = 280933408 * num;
			Type typeFromHandle = typeof(IntPtr);
			num ^= 0x31979481;
			object obj3;
			bool num2 = (Type)obj3 == typeFromHandle;
			num = 0xEE2579B6u ^ num;
			if (num2)
			{
				num = (uint)(1379606573 << (int)num);
				object obj4 = obj2;
				num -= 445144481;
				return (IntPtr)obj4;
			}
			goto IL_00e0;
			IL_003a:
			object obj5 = obj2;
			num &= 0x11B5C930;
			if (obj5 != null)
			{
				goto IL_0068;
			}
			num = 773066128u >> (int)num;
			if ((0xEB25BEBBu ^ num) != 0)
			{
				obj3 = null;
				goto IL_0097;
			}
			goto IL_00e0;
			IL_0068:
			num = (uint)(-652619391 << (int)num);
			if (num == 2467045781u)
			{
				goto IL_003a;
			}
			object obj6 = obj2;
			num = 3787394572u % num;
			obj3 = obj6.GetType();
			num += 4022476808u;
			goto IL_0097;
			IL_00e0:
			throw new InvalidOperationException();
		}

		public virtual char D31384B4()
		{
			object value = _9F320096();
			uint num = 4163113616u;
			return Convert.ToChar(value);
		}

		protected D3B95303()
		{
			uint num = 3517353018u;
			if (4128696504u % num != 0)
			{
				do
				{
				}
				while (-887580889 == (int)num);
			}
		}

		public virtual float DEAE8E8E()
		{
			uint num = 380576307u;
			num = 3190628866u >> (int)num;
			object value = _9F320096();
			num >>= 16;
			return Convert.ToSingle(value);
		}

		public abstract object _9F320096();

		public virtual double DB900D19()
		{
			uint num = 2726446345u;
			return Convert.ToDouble(_9F320096());
		}

		public abstract D3B95303 _5C36403F();
	}

	private sealed class _983F321C : B7078183
	{
		private MethodBase EEAF4C04;

		public override void DE8C17B9(object FAA6A893)
		{
			uint num;
			do
			{
				num = 1085780488u;
				num /= 1562738109;
				EEAF4C04 = (MethodBase)FAA6A893;
			}
			while ((num ^ 0xA331E09) == 0);
		}

		public override Type D293A3AF()
		{
			uint num = 3146490807u;
			return typeof(MethodBase);
		}

		public override D3B95303 _5C36403F()
		{
			uint num = 2100029192u;
			return new _983F321C(EEAF4C04);
		}

		public override IntPtr _27832122()
		{
			uint num = 1336959246u;
			RuntimeMethodHandle runtimeMethodHandle;
			do
			{
				RuntimeMethodHandle methodHandle = EEAF4C04.MethodHandle;
				num ^= 0x4219DF80;
				runtimeMethodHandle = methodHandle;
				num %= 2761412016u;
			}
			while (num >> 26 == 0);
			num >>= 12;
			return runtimeMethodHandle.GetFunctionPointer();
		}

		public override object _9F320096()
		{
			uint num = 2098064155u;
			return EEAF4C04;
		}

		public _983F321C(MethodBase A19DD117)
		{
			uint num = 3442220199u;
			num = 2929285133u + num;
			num = 254211381 * num;
			num = 1302214185 - num;
			EEAF4C04 = A19DD117;
		}
	}

	private sealed class _2038A6B3 : B7078183
	{
		private float _8833D59B;

		public static D3B95303 D1B39196(D3B95303 F58379B5, D3B95303 _6307E5BD)
		{
			uint num = 3617418160u;
			num += 974709547;
			float num2 = F58379B5.DEAE8E8E();
			num += 1504592049;
			float num3 = _6307E5BD.DEAE8E8E();
			num <<= 4;
			float num4 = num3;
			num %= 1243020034;
			float _3690C59B = num2 / num4;
			num -= 1747306405;
			return new _2038A6B3(_3690C59B);
		}

		public override double DB900D19()
		{
			float num = _8833D59B;
			uint num2 = 1705211579u;
			return num;
		}

		public override Type D293A3AF()
		{
			uint num = 3593584780u;
			num = 2930165377u - num;
			return typeof(float);
		}

		public override bool C9093688()
		{
			uint num = 321223200u;
			return Convert.ToBoolean(_8833D59B);
		}

		public override byte _6E94D6A9()
		{
			uint num = 4244888595u;
			return (byte)_8833D59B;
		}

		public static D3B95303 _68AD9820(D3B95303 _1F84999B)
		{
			uint num = 1378150916u;
			float num2 = _1F84999B.DEAE8E8E();
			num = 1778643729 * num;
			return new _2038A6B3(0f - num2);
		}

		public override object _9F320096()
		{
			uint num = 1713784473u;
			return _8833D59B;
		}

		public override void DE8C17B9(object F4096925)
		{
			_8833D59B = Convert.ToSingle(F4096925);
		}

		public static D3B95303 A198643D(D3B95303 _850334B7, D3B95303 BD2834B7)
		{
			uint num = 2249381895u;
			num >>= 9;
			float num2 = _850334B7.DEAE8E8E();
			float num3 = BD2834B7.DEAE8E8E();
			num = 4018881537u * num;
			float num4 = num3;
			num ^= 0xFFA1EE0Du;
			num = 993787138 + num;
			float _3690C59B = num2 + num4;
			num *= 800697472;
			return new _2038A6B3(_3690C59B);
		}

		public static D3B95303 _270AF01E(D3B95303 _0F24F528, D3B95303 _3F83D511)
		{
			uint num = 4095668646u;
			float num2 = _0F24F528.DEAE8E8E();
			num = 0x88AC90A1u ^ num;
			num ^= 0x4B19EE13;
			float num3 = _3F83D511.DEAE8E8E();
			num ^= 0xDB8CA81Au;
			float num4 = num3;
			num = 0x152E34BB | num;
			num &= 0x1DAE9CAB;
			return new _2038A6B3(num2 % num4);
		}

		public static D3B95303 B53C731D(D3B95303 _1236E1AC)
		{
			uint num = 362119563u;
			float _3690C59B = _1236E1AC.DEAE8E8E();
			num = 0xA38A3B0Eu & num;
			return new _2038A6B3(_3690C59B);
		}

		public override char D31384B4()
		{
			uint num = 1111469442u;
			return (char)_8833D59B;
		}

		public static D3B95303 BC9994AA(D3B95303 C38B15BF, D3B95303 F0242628)
		{
			uint num = 3149047853u;
			int num5;
			while (true)
			{
				num = 0xBE8E4712u & num;
				float num2 = C38B15BF.DEAE8E8E();
				float num3 = F0242628.DEAE8E8E();
				int num4 = (int)num ^ -1165885440;
				num ^= 0x7B23190B;
				num5 = num4;
				num -= 3602227458u;
				num = 3576734727u % num;
				if (num2 == num3)
				{
					num = (uint)(-1097101551 << (int)num);
					int num6 = num5 | (int)(num - 1304922238);
					num |= 0x4826F68E;
					num5 = num6;
					if (2812122416u >= num)
					{
						break;
					}
					continue;
				}
				num = 0x51BFECA3 & num;
				if (num * 162379951 != 0)
				{
					num ^= 0x1CD75A8D;
					if (num2 < num3)
					{
						num = 2928818992u - num;
						int num7 = num5 | (int)(num ^ 0x60AA3CA6);
						num = 3380980755u - num;
						num5 = num7;
						num ^= 0x253C91FF;
					}
					break;
				}
			}
			int _1B2FFB = num5;
			num |= 0x7A39011A;
			return new B7035AA0(_1B2FFB);
		}

		public override short E39CE9A9()
		{
			uint num = 3592551990u;
			num += 1637345310;
			float num2 = _8833D59B;
			num %= 1362130207;
			return (short)num2;
		}

		public override UIntPtr _1DB07EA4()
		{
			long value;
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 3803186434u;
				if (size != 4)
				{
					num &= 0xB29246A6u;
					num <<= 4;
					float num2 = _8833D59B;
					num /= 663591313;
					value = (long)(ulong)num2;
					break;
				}
				if (num > 1847086597)
				{
					float num3 = _8833D59B;
					num *= 2830079380u;
					value = (uint)num3;
					num ^= 0x3D0B0F29;
					break;
				}
			}
			num = (uint)(1595055493 << (int)num);
			return new UIntPtr((ulong)value);
		}

		public override IntPtr _27832122()
		{
			uint num = 4087357472u;
			long value;
			if (78541078 < num)
			{
				int size = IntPtr.Size;
				num = 1227120906 / num;
				int num2 = (int)num - -4;
				num += 756225189;
				if (size != num2)
				{
					num = 0xDC176002u | num;
				}
				else if (69623303 < num)
				{
					int num3 = (int)_8833D59B;
					num = 0x6917222A & num;
					value = num3;
					num ^= 0x29130022;
					goto IL_0071;
				}
			}
			num /= 1797214486;
			value = (long)_8833D59B;
			goto IL_0071;
			IL_0071:
			return new IntPtr(value);
		}

		public static D3B95303 _979DC792(D3B95303 _0DB916B0, D3B95303 _5B2C0030)
		{
			uint num = 3188385945u;
			float num2 = _0DB916B0.DEAE8E8E();
			float num3 = _5B2C0030.DEAE8E8E();
			num |= 0xEDB7E88Fu;
			return new _2038A6B3(num2 / num3);
		}

		public override int _6527EC0E()
		{
			float num = _8833D59B;
			uint num2 = 1111109178u;
			return (int)num;
		}

		public override uint _3503DA1F()
		{
			uint num = 362822807u;
			num = 0x79A6D32D ^ num;
			float num2 = _8833D59B;
			num ^= 0x29AD90F;
			return (uint)num2;
		}

		public override long _249CC8BD()
		{
			uint num = 3953942538u;
			float num2 = _8833D59B;
			num &= 0xF2069A8Cu;
			return (long)num2;
		}

		public override ulong _588AFCB3()
		{
			uint num = 1521583038u;
			return (ulong)_8833D59B;
		}

		public override float DEAE8E8E()
		{
			uint num = 3887624460u;
			return _8833D59B;
		}

		public override sbyte _6C14C0B7()
		{
			uint num = 999988765u;
			return (sbyte)_8833D59B;
		}

		public override ushort AD1962B2()
		{
			return (ushort)_8833D59B;
		}

		public override D3B95303 _5C36403F()
		{
			uint num = 3762034822u;
			float _3690C59B = _8833D59B;
			num = 1185941807 * num;
			return new _2038A6B3(_3690C59B);
		}

		public static D3B95303 E625E9A3(D3B95303 AD8A8B36)
		{
			ulong num;
			uint num2;
			do
			{
				num = AD8A8B36._588AFCB3();
				num2 = 2424977952u;
			}
			while (num2 > 4012873640u);
			int num3 = AD8A8B36._6E0A913C();
			num2 = (uint)(1756869001 << (int)num2);
			int num4 = num3 & (int)(num2 - 1756868985);
			num2 -= 773557169;
			bool num5 = (uint)num4 > num2 - 983311832;
			num2 = 3432280599u % num2;
			float _3690C59B;
			if (!num5)
			{
				num2 = 3508209427u >> (int)num2;
				num2 = 973081488 - num2;
				_3690C59B = (long)num;
			}
			else
			{
				num2 %= 1437978533;
				_3690C59B = num;
				num2 += 490629323;
			}
			return new _2038A6B3(_3690C59B);
		}

		public _2038A6B3(float _3690C59B)
		{
			uint num = 3006957098u;
			do
			{
				num = 314474932 * num;
			}
			while ((0x6311BD3F & num) == 0);
			num = 87597720 / num;
			_8833D59B = _3690C59B;
		}
	}

	private enum AA9D8630
	{
		_4826AB98 = 0,
		_991D3628 = 8,
		D5A17F88 = 6,
		AA930EB0 = 5,
		C08C1901 = 16,
		_26BAC98C = 64,
		_9223419A = 4,
		_2D041329 = 3,
		_3E851F9F = 11,
		A837D686 = 7,
		C88800B3 = 1,
		FA955504 = 9,
		_811040BA = 32,
		_55A7608E = 10,
		EC9F568E = 15,
		A79BB7B8 = 2
	}

	private sealed class C2916D0F : _128A201A
	{
		private D3B95303 _9CB394B5;

		private D3B95303 _7184D50F;

		public override D3B95303 _5C36403F()
		{
			uint num = 2088997932u;
			return new C2916D0F(_7184D50F, _9CB394B5);
		}

		public override Type D293A3AF()
		{
			uint num = 2586395160u;
			num = 2787701540u + num;
			return _7184D50F.D293A3AF();
		}

		public override void DE8C17B9(object BD2F081B)
		{
			uint num = 2577433007u;
			if (num > 389303079)
			{
				num = (uint)(606027179 << (int)num);
				D3B95303 d3B = _7184D50F;
				num = 0xB9A76109u ^ num;
				num = 255123599u >> (int)num;
				d3B.DE8C17B9(BD2F081B);
				num = 579959715 / num;
				do
				{
					D3B95303 d3B2 = _9CB394B5;
					D3B95303 d3B3 = _7184D50F;
					num = 0x8617A30Au ^ num;
					d3B2.DE8C17B9(d3B3._9F320096());
				}
				while (-1968007168 + (int)num == 0);
			}
		}

		public override object _9F320096()
		{
			uint num = 3926409993u;
			return _7184D50F._9F320096();
		}

		public C2916D0F(D3B95303 EC8DB8B4, D3B95303 AEB77318)
		{
			uint num;
			do
			{
				num = 3658629910u;
			}
			while (num << 27 == 0);
			do
			{
				num /= 3172563236u;
				_7184D50F = EC8DB8B4;
				num = 1999939505 * num;
			}
			while (-1777623406 == (int)num);
			num = 1252443192 + num;
			num ^= 0x41926593;
			_9CB394B5 = AEB77318;
		}
	}

	private _589EC5AE _3019FA32;

	private _3209E1AD _7D13B119;

	private _56AB72BE _2F2F02A8;

	private static readonly Dictionary<uint, object> _81A40C9C;

	private static readonly Dictionary<object, DynamicMethod> _58A84F99;

	private C1BF430A _7E8CFF31;

	private static readonly Module _7CAA7EBD;

	private Exception _94961F94;

	private List<IntPtr> _162873A6;

	private readonly Dictionary<uint, A93EA20B> E52C86B9;

	private void DE3B28B2()
	{
		Type f809DF;
		D3B95303 d3B;
		uint num;
		while (true)
		{
			num = 3851372336u;
			int _4F365B = _7E8CFF31._25AC239D();
			num <<= 16;
			Type type = _22B05086(_4F365B);
			num >>= 24;
			f809DF = type;
			num = 1998111412 % num;
			if (304498216 - num != 0)
			{
				d3B = _2F2F02A8.ED374FBA();
				if (num <= 872824357)
				{
					break;
				}
			}
		}
		num = 0xBD120C9Cu & num;
		_56AB72BE obj = _2F2F02A8;
		num = 3548987285u + num;
		D3B95303 d3B2 = d3B.BD15691D(f809DF);
		num |= 0xC10C792Eu;
		B1A0179E a = new B1A0179E(d3B2._9F320096());
		num = 3280057612u % num;
		obj._93061C36(a);
	}

	private void _3A865CBF()
	{
		C1BF430A c1BF430A = _7E8CFF31;
		uint num = 2014618647u;
		int num3 = default(int);
		MethodBase methodBase = _239CD025(c1BF430A._25AC239D());
		num *= 1234713487;
		ParameterInfo[] array = default(ParameterInfo[]);
		if (num / 1711946401 != 0)
		{
			ParameterInfo[] parameters = methodBase.GetParameters();
			num = 4163529768u - num;
			array = parameters;
			num <<= 18;
		}
		Dictionary<int, D3B95303> dictionary = new Dictionary<int, D3B95303>();
		num -= 1527121433;
		Dictionary<int, D3B95303> dictionary2 = dictionary;
		num += 698118273;
		object[] array2;
		do
		{
			array2 = new object[array.Length];
			num -= 2837762999u;
		}
		while ((int)num * -1356050260 == 0);
		_6293582D _6293582D2 = new _6293582D();
		try
		{
			if (-913383669 << (int)num != 0)
			{
				goto IL_00a2;
			}
			goto IL_00ca;
			IL_00a2:
			ParameterInfo[] array3 = array;
			num = 1613106308 % num;
			int num2 = array3.Length;
			num = 3157785658u / num;
			num3 = num2 - (int)(num ^ 0);
			goto IL_0260;
			IL_0260:
			num = 0x3CB04483 | num;
			int num4 = num3;
			num = 2192294937u / num;
			if (num4 < (int)(num ^ 2))
			{
				num = 0x9F202380u ^ num;
				if (num < 3819524358u)
				{
					num = (uint)(-373575651 << (int)num);
					ConstructorInfo obj = (ConstructorInfo)methodBase;
					num = 212861847 / num;
					num <<= 18;
					object _4BB13A1A = obj.Invoke(array2);
					num %= 3215199416u;
					Dictionary<int, D3B95303>.Enumerator enumerator = dictionary2.GetEnumerator();
					num = 1982262825 - num;
					Dictionary<int, D3B95303>.Enumerator enumerator2 = enumerator;
					try
					{
						if (2669406647u < num)
						{
							goto IL_02f8;
						}
						goto IL_0383;
						IL_0383:
						bool num5 = enumerator2.MoveNext();
						num += 1543587475;
						if (num5)
						{
							goto IL_02f8;
						}
						goto end_IL_02e7;
						IL_02f8:
						num = 3666482051u;
						if (num / 3634997553u != 0)
						{
							num += 1755542071;
							KeyValuePair<int, D3B95303> current = enumerator2.Current;
							num = 1712794770u >> (int)num;
							if ((num ^ 0xF02805BCu) != 0)
							{
								num -= 1687291306;
								D3B95303 value = current.Value;
								num %= 1999001013;
								num = 2251271339u * num;
								num = 0x79AC7D9E | num;
								value.DE8C17B9(array2[current.Key]);
								num ^= 0x8F889397u;
							}
						}
						goto IL_0383;
						end_IL_02e7:;
					}
					finally
					{
						do
						{
							num = 3073079081u;
							if (1488307477u >> (int)num != 0)
							{
								num = 2098671655 % num;
								((IDisposable)enumerator2/*cast due to constrained. prefix*/).Dispose();
								continue;
							}
							break;
						}
						while ((num ^ 0x943ABBB7u) == 0);
					}
					do
					{
						num = 3843664789u;
						_56AB72BE obj2 = _2F2F02A8;
						num /= 3850429097u;
						num >>= 31;
						Type declaringType = methodBase.DeclaringType;
						num ^= 0x433A9317;
						obj2._93061C36(D3B95303._6388BF9A(_4BB13A1A, declaringType));
					}
					while (num == 3977215403u);
					return;
				}
				goto IL_00a2;
			}
			goto IL_00ca;
			IL_00ca:
			while (true)
			{
				ParameterInfo[] array4 = array;
				num = 4121626637u;
				Type parameterType = array4[num3].ParameterType;
				if ((int)num * -591768315 == 0)
				{
					break;
				}
				num = 3879163038u >> (int)num;
				_56AB72BE obj3 = _2F2F02A8;
				num = 0x8F3922 ^ num;
				D3B95303 d3B = obj3.ED374FBA();
				num = 0x56A7C21D ^ num;
				D3B95303 d3B2 = d3B;
				num = 0xC8B20FB1u | num;
				if (d3B2._4C0EC108())
				{
					num /= 2006103698;
					bool isByRef = parameterType.IsByRef;
					num |= 0x9DA7F506u;
					if (!isByRef)
					{
						if ((num ^ 0x8CBF6C94u) == 0)
						{
							break;
						}
						num = 4220001189u + num;
						int num6 = num3;
						num |= 0x79956014;
						IntPtr intPtr = _6293582D2._6E21DE0F(d3B2._9F320096());
						num ^= 0x1F949F09;
						array2[num6] = intPtr;
						if (254590235 >= num)
						{
							break;
						}
						goto IL_0228;
					}
					num -= 2962798860u;
					if (236411190 << (int)num == 0)
					{
						goto IL_0260;
					}
					int key = num3;
					num >>= 9;
					dictionary2[key] = d3B2;
					num ^= 0xDEC94828u;
				}
				num %= 3733033407u;
				if ((num ^ 0x973586A1u) == 0)
				{
					continue;
				}
				int num7 = num3;
				num %= 4144765589u;
				object obj4 = d3B2.BD15691D(parameterType)._9F320096();
				num = 1015493921 / num;
				array2[num7] = obj4;
				num ^= 0xE621EF4Du;
				goto IL_0228;
				IL_0228:
				if (num >> 5 != 0)
				{
					int num8 = num3;
					num = 0xF6BBC59Du & num;
					int num9 = (int)num ^ -433994348;
					num ^= 0xF88D44B5u;
					num3 = num8 - num9;
					num ^= 0x1EAC8121;
				}
				goto IL_0260;
			}
			goto IL_00a2;
		}
		finally
		{
			num = 3525951543u;
			_6293582D2.Dispose();
		}
	}

	private void EE30EC03()
	{
		uint num = 2130934180u;
		do
		{
			C1BF430A c1BF430A = _7E8CFF31;
			num += 4130957616u;
			FieldInfo fieldInfo = _35086532(c1BF430A._25AC239D());
			num -= 1485433764;
			FieldInfo _0904BB = fieldInfo;
			num = 128052626 / num;
			num = 0x67386E04 ^ num;
			_56AB72BE obj = _2F2F02A8;
			num ^= 0x693FC9C;
			_251D96A3 a = new _251D96A3(_0904BB, this);
			num = 1512797091 % num;
			obj._93061C36(a);
		}
		while (num << 3 == 0);
	}

	private void _97BBBAA6()
	{
		uint num = 480832421u;
		D3B95303 d3B = _2F2F02A8.ED374FBA();
		num = 0x98899D0Au | num;
		D3B95303 _050923A = d3B;
		num ^= 0xAF0A8A16u;
		_56AB72BE obj = _2F2F02A8;
		num <<= 10;
		num = 1217996469 + num;
		D3B95303 a = DC09FDAD._84AB84A7(_050923A);
		num &= 0x498FCE3E;
		obj._93061C36(a);
	}

	private void EBA1110A()
	{
		uint num = 1697567366u;
		D3B95303 _2E2D090B = default(D3B95303);
		if (num != 1225670561)
		{
			_56AB72BE obj = _2F2F02A8;
			num += 3701502104u;
			_2E2D090B = obj.ED374FBA();
		}
		num = 1746407699u >> (int)num;
		D3B95303 d3B = _2F2F02A8.ED374FBA();
		num /= 3247215125u;
		D3B95303 _5735211D = d3B;
		num = 0x220DFA29 & num;
		do
		{
			num ^= 0xFF9F8E9Cu;
			_2F2F02A8._93061C36(_88BA7B16._3E1D40A2(_5735211D, _2E2D090B));
		}
		while ((num ^ 0xB5AAC583u) == 0);
	}

	private void _76021E9C()
	{
		uint num;
		do
		{
			num = 1041179529u;
			_56AB72BE obj = _2F2F02A8;
			num -= 3089230392u;
			num = 3627910174u / num;
			obj._93061C36(new _2038A6B3(_7E8CFF31.B3215496()));
		}
		while (num - 445865103 == 0);
	}

	private void E692F42E()
	{
		uint num = 2543970592u;
		D3B95303 d3B2 = default(D3B95303);
		if (num >= 632466328)
		{
			num = 2083594882u >> (int)num;
			D3B95303 d3B = _2F2F02A8.ED374FBA();
			num = 0xCF31C2BFu ^ num;
			d3B2 = d3B;
		}
		do
		{
			_56AB72BE obj = _2F2F02A8;
			num = 0x352F1E9D ^ num;
			D3B95303 d3B3 = obj.ED374FBA();
			num += 3166388917u;
			D3B95303 _6401AA2C = d3B3;
			num = 0x35AB7097 & num;
			_56AB72BE obj2 = _2F2F02A8;
			num += 3149633691u;
			D3B95303 cF0B = d3B2;
			num <<= 23;
			D3B95303 a = D51696A5.CD0D5192(_6401AA2C, cF0B);
			num = 0x73DAD3B | num;
			obj2._93061C36(a);
		}
		while (897616787 > num);
	}

	private void _3A8CE02D()
	{
		uint num = 184750500u;
		D3B95303 d3B = _2F2F02A8.ED374FBA();
		num = 1603983919 % num;
		Exception obj = d3B._9F320096() as Exception;
		if (obj == null)
		{
			num = 2562083089u / num;
			throw new ArgumentException();
		}
		throw obj;
	}

	private void B90E2FB2()
	{
		D3B95303 d3B2 = default(D3B95303);
		uint num;
		do
		{
			num = 2424508313u;
			D3B95303 _3F83D = _2F2F02A8.ED374FBA();
			num = 0x69BEF70E | num;
			if (num % 2460346428u != 0)
			{
				num = (uint)(2031077129 << (int)num);
				D3B95303 d3B = _2F2F02A8.ED374FBA();
				num %= 4271525248u;
				d3B2 = d3B;
				num = 0x50A79BAB ^ num;
			}
			_56AB72BE obj = _2F2F02A8;
			D3B95303 _0F24F = d3B2;
			num = (uint)(-323605337 << (int)num);
			obj._93061C36(_2038A6B3._270AF01E(_0F24F, _3F83D));
		}
		while (num / 2318047007u == 0);
	}

	static _02B4022E()
	{
		uint num = 3415820161u;
		if (3767212053u > num)
		{
			goto IL_0011;
		}
		goto IL_004d;
		IL_0011:
		_7CAA7EBD = typeof(_02B4022E).Module;
		num |= 0xCC235885u;
		Dictionary<uint, object> dictionary = new Dictionary<uint, object>();
		num = 1779998377u >> (int)num;
		_81A40C9C = dictionary;
		num /= 3970978712u;
		goto IL_004d;
		IL_004d:
		_58A84F99 = new Dictionary<object, DynamicMethod>();
		if (506424195 >= num)
		{
			return;
		}
		goto IL_0011;
	}

	private void _57267AA0()
	{
		uint num = 4044371882u;
		D3B95303 _1F95CFAC;
		D3B95303 d3B3 = default(D3B95303);
		do
		{
			D3B95303 d3B = _2F2F02A8.ED374FBA();
			num = 0x9A273609u ^ num;
			_1F95CFAC = d3B;
			if (num + 1495410058 == 0)
			{
				break;
			}
			num = 3414797608u + num;
			D3B95303 d3B2 = _2F2F02A8.ED374FBA();
			num <<= 14;
			d3B3 = d3B2;
			num = 2805833763u % num;
		}
		while ((0x373FA827 ^ num) == 0);
		num *= 522682548;
		_56AB72BE obj = _2F2F02A8;
		D3B95303 _083F5E = d3B3;
		num &= 0xB5AED62Bu;
		obj._93061C36(B7035AA0._5C220285(_083F5E, _1F95CFAC));
	}

	private void B627B535()
	{
		_56AB72BE obj = _2F2F02A8;
		uint num = 1510816425u;
		D3B95303 _0D2A26A = obj.ED374FBA();
		_56AB72BE obj2 = _2F2F02A8;
		num = 4237440440u + num;
		D3B95303 a = B7035AA0.D715A43D(_0D2A26A);
		num = 0x5216FB2E ^ num;
		obj2._93061C36(a);
	}

	private void _8DB67B0E()
	{
		_56AB72BE obj = _2F2F02A8;
		uint num = 2703730332u;
		D3B95303 d3B = obj.ED374FBA();
		num = 3778680240u + num;
		D3B95303 bEA = d3B;
		num /= 1913494075;
		if (num < 1076610695)
		{
			D3B95303 _7F2AB;
			do
			{
				num = 3565215631u % num;
				_7F2AB = _2F2F02A8.ED374FBA();
			}
			while ((num ^ 0xFC0AAE17u) == 0);
			_56AB72BE obj2 = _2F2F02A8;
			num = 1562097694 + num;
			obj2._93061C36(D51696A5._31051F05(_7F2AB, bEA));
		}
	}

	private void FE07070B()
	{
		if (_94961F94 == null)
		{
			throw new InvalidOperationException();
		}
		uint num = 1587391536u;
		throw _94961F94;
	}

	private void D200888C()
	{
		while (true)
		{
			uint num = 3867912117u;
			D3B95303 _0B10748B = _2F2F02A8.ED374FBA();
			if (num << 19 != 0)
			{
				D3B95303 _3E3A;
				do
				{
					num = 3063720505u + num;
					_3E3A = _2F2F02A8.ED374FBA();
					num |= 0xEB322A21u;
				}
				while ((int)num + -1874970458 == 0);
				num >>= 27;
				_56AB72BE obj = _2F2F02A8;
				num |= 0x4FBE7215;
				obj._93061C36(D51696A5._0C1AAC0A(_3E3A, _0B10748B));
				if (num < 2902473093u)
				{
					break;
				}
			}
		}
	}

	private void _70AD9310()
	{
		uint num;
		do
		{
			_56AB72BE obj = _2F2F02A8;
			num = 2804388399u;
			D3B95303 _5B076C = obj.ED374FBA();
			num %= 503888015;
			num = 1304051246 / num;
			D3B95303 _3E9EB = _2F2F02A8.ED374FBA();
			num = 1437699224 * num;
			_2F2F02A8._93061C36(D51696A5._638C5E8D(_3E9EB, _5B076C));
		}
		while (num >> 29 == 0);
	}

	private void CAB68E1D()
	{
		D3B95303 d3B;
		D3B95303 d3B3;
		uint num;
		do
		{
			num = 1384612155u;
			_56AB72BE obj = _2F2F02A8;
			num >>= 13;
			d3B = obj.ED374FBA();
			_56AB72BE obj2 = _2F2F02A8;
			num -= 1846219042;
			D3B95303 d3B2 = obj2.ED374FBA();
			num += 3196839073u;
			d3B3 = d3B2;
			num ^= 0xCF286B31u;
		}
		while (num <= 429210663);
		do
		{
			num |= 0xC4B47395u;
			D3B95303 d3B4 = d3B3.BD15691D(d3B.D293A3AF());
			num = 0xB239B23Bu ^ num;
			d3B.DE8C17B9(d3B4._9F320096());
		}
		while (3448605718u % num == 0);
	}

	private void _3CAA2C32()
	{
		uint num = 1049547542u;
		D3B95303 _0E36B = default(D3B95303);
		D3B95303 d3B2 = default(D3B95303);
		if (num >> 3 != 0)
		{
			D3B95303 d3B = _2F2F02A8.ED374FBA();
			num -= 2726946946u;
			_0E36B = d3B;
			num = 2747249823u - num;
			num = 0xDA8C150Bu & num;
			_56AB72BE obj = _2F2F02A8;
			num /= 1863739018;
			d3B2 = obj.ED374FBA();
			num = 716254648 + num;
		}
		_56AB72BE obj2 = _2F2F02A8;
		D3B95303 a5A9D = d3B2;
		num = 0x62167688 & num;
		obj2._93061C36(B7035AA0.C025E52A(a5A9D, _0E36B));
	}

	private void F498053B()
	{
		uint num;
		do
		{
			num = 3642112161u;
			_56AB72BE obj = _2F2F02A8;
			num = 0x8710C522u | num;
			D3B95303 _6307E5BD = obj.ED374FBA();
			num = 370107008 * num;
			D3B95303 f58379B = _2F2F02A8.ED374FBA();
			num = (uint)(-1549533263 << (int)num);
			_56AB72BE obj2 = _2F2F02A8;
			D3B95303 a = _2038A6B3.D1B39196(f58379B, _6307E5BD);
			num = 0xCF8A04AAu & num;
			obj2._93061C36(a);
		}
		while (959198761 >= num);
	}

	private void _1502A3A0()
	{
		D3B95303 eD2B = default(D3B95303);
		uint num;
		do
		{
			num = 1579870527u;
			C1BF430A c1BF430A = _7E8CFF31;
			num -= 4205527722u;
			int _4F365B = c1BF430A._25AC239D();
			num = (uint)(-746346623 << (int)num);
			Type _7DB = _22B05086(_4F365B);
			if (2461624377u >> (int)num != 0)
			{
				num = 0x8ABCD32Fu & num;
				eD2B = _2F2F02A8.ED374FBA();
				num = (uint)(-1296391036 << (int)num);
			}
			_56AB72BE obj = _2F2F02A8;
			D3B95303 a = D3B95303.F30AD72B(eD2B, _7DB);
			num = 0x4FBFFE87 | num;
			obj._93061C36(a);
		}
		while (2728247444u >= num);
	}

	private void _64385E2E()
	{
		uint num = 2913733438u;
		if (num == 354204842)
		{
			return;
		}
		D3B95303 d3B = _2F2F02A8.ED374FBA();
		num = 0x14296F99 | num;
		Array array = default(Array);
		if (470634763 <= num)
		{
			_56AB72BE obj = _2F2F02A8;
			num &= 0xDA1B929Au;
			object obj2 = obj.ED374FBA()._9F320096();
			num <<= 4;
			array = obj2 as Array;
			num = 2201588122u % num;
			Array array2 = array;
			num = 1830330404u >> (int)num;
			if (array2 == null)
			{
				throw new ArgumentException();
			}
		}
		num = 0x42B55B93 & num;
		if (1815498753 > num)
		{
			_56AB72BE obj3 = _2F2F02A8;
			Array c805D68F = array;
			num = 311383308u >> (int)num;
			obj3._93061C36(new _6F17E0A1(c805D68F, d3B._6527EC0E()));
		}
	}

	private void _003D8513()
	{
		D3B95303 _3437EA;
		uint num;
		do
		{
			D3B95303 d3B = _2F2F02A8.ED374FBA();
			num = 1648277396u;
			_3437EA = d3B;
		}
		while ((0xEFBCE1BCu ^ num) == 0);
		do
		{
			num = (uint)(160048409 << (int)num);
			D3B95303 d3B2 = _2F2F02A8.ED374FBA();
			num += 455614773;
			D3B95303 aB2E9E = d3B2;
			num <<= 13;
			_56AB72BE obj = _2F2F02A8;
			num += 522487696;
			num |= 0x7A964823;
			obj._93061C36(DC09FDAD._203B1D90(aB2E9E, _3437EA));
		}
		while (num >= 2466545207u);
	}

	private void _27268CBA()
	{
		D3B95303 _3C;
		D3B95303 _85BC0D8C = default(D3B95303);
		uint num;
		do
		{
			D3B95303 d3B = _2F2F02A8.ED374FBA();
			num = 1216644528u;
			_3C = d3B;
			if (1212122291 == num)
			{
				break;
			}
			_56AB72BE obj = _2F2F02A8;
			num /= 504210438;
			D3B95303 d3B2 = obj.ED374FBA();
			num = 2208081187u % num;
			_85BC0D8C = d3B2;
			num += 3792209438u;
		}
		while (num == 3903442328u);
		_56AB72BE obj2 = _2F2F02A8;
		D3B95303 a = DC09FDAD._57860B91(_85BC0D8C, _3C);
		num >>= 12;
		obj2._93061C36(a);
	}

	private void CB95EF1A()
	{
		uint num = 1150692228u;
		D3B95303 d3B = _2F2F02A8.ED374FBA();
		num = (uint)(1170084658 << (int)num);
		int num2 = d3B._6527EC0E();
		num = 2435121343u >> (int)num;
		if (num2 != 0)
		{
			if (3643096745u + num != 0)
			{
				goto IL_0043;
			}
			goto IL_00a2;
		}
		goto IL_010a;
		IL_00a2:
		num /= 1253013946;
		C1BF430A c1BF430A = _7E8CFF31;
		num = (uint)(-676790778 << (int)num);
		num = 0x489AEAA3 | num;
		_589EC5AE obj = _3019FA32;
		num = 2419611696u % num;
		c1BF430A.EB3F1497(obj._923D8C35());
		num = 0xC29A63ADu ^ num;
		if (1093339650 - num != 0)
		{
			num = 3433708064u * num;
			num += 3910168089u;
			_3019FA32 = null;
			return;
		}
		goto IL_0043;
		IL_0043:
		while (true)
		{
			num += 1622537390;
			_3209E1AD obj2 = _7D13B119;
			num |= 0x52BB5603;
			obj2._4781133B();
			if (num % 2922359562u == 0)
			{
				break;
			}
			_56AB72BE obj3 = _2F2F02A8;
			num *= 3710766848u;
			obj3._93061C36(new B1A0179E(_94961F94));
			num = 2829711265u >> (int)num;
			if (num == 1310451716)
			{
				continue;
			}
			goto IL_00a2;
		}
		goto IL_010a;
		IL_010a:
		num |= 0x7C01B300;
		if (num >= 1890835110)
		{
			A815111A();
			return;
		}
		goto IL_0043;
	}

	private void _470FB0A2()
	{
		uint num = 4186924605u;
		D3B95303 e18AE = default(D3B95303);
		D3B95303 _7C97E = default(D3B95303);
		if (388466603 <= num)
		{
			do
			{
				D3B95303 d3B = _2F2F02A8.ED374FBA();
				num /= 2319213111u;
				e18AE = d3B;
			}
			while (num << 15 == 0);
			do
			{
				_56AB72BE obj = _2F2F02A8;
				num = 556353312 + num;
				D3B95303 d3B2 = obj.ED374FBA();
				num = 3517484468u >> (int)num;
				_7C97E = d3B2;
			}
			while ((num ^ 0x5001BD2F) == 0);
		}
		num = 2753203462u >> (int)num;
		_56AB72BE obj2 = _2F2F02A8;
		num = 0x385708 ^ num;
		obj2._93061C36(B7035AA0._308A7609(_7C97E, e18AE));
	}

	private void _1E038BAE()
	{
		D3B95303 bD2834B = _2F2F02A8.ED374FBA();
		uint num = 2189679904u;
		D3B95303 _850334B;
		do
		{
			_56AB72BE obj = _2F2F02A8;
			num ^= 0xBC1A13B5u;
			D3B95303 d3B = obj.ED374FBA();
			num = 2990351035u + num;
			_850334B = d3B;
			num = 423187465 * num;
		}
		while (num > 2325455527u);
		_56AB72BE obj2 = _2F2F02A8;
		num = 4097014844u >> (int)num;
		obj2._93061C36(_2038A6B3.A198643D(_850334B, bD2834B));
	}

	private void _6B96DF08()
	{
		uint num = 462050978u;
		if (num < 1748434055)
		{
			do
			{
				num = 0x373D1815 ^ num;
				D3B95303 d3B = _2F2F02A8.ED374FBA();
				num |= 0xE08E3E38u;
				D3B95303 _5F88A32D = d3B;
				num %= 498526514;
				_56AB72BE obj = _2F2F02A8;
				_8CB2849D a = new _8CB2849D(_5F88A32D);
				num /= 2518029337u;
				obj._93061C36(a);
			}
			while (num > 4128602810u);
		}
	}

	private void _27A0AEA0()
	{
		D3B95303 _1B96BCA = _2F2F02A8.ED374FBA();
		uint num = 68633104u;
		_56AB72BE obj = _2F2F02A8;
		num = 0xD5A5DBBDu ^ num;
		D3B95303 a = _5D05C73B._35B1A821(_1B96BCA);
		num -= 406245677;
		obj._93061C36(a);
	}

	private void _1B3C0EA0()
	{
		uint num = 506230332u;
		if (num != 3115290291u)
		{
			do
			{
				num -= 800092724;
				_56AB72BE obj = _2F2F02A8;
				num *= 17733813;
				C1BF430A c1BF430A = _7E8CFF31;
				num |= 0xFE05E30Cu;
				DC09FDAD a = new DC09FDAD(c1BF430A._5D377817());
				num >>= 24;
				obj._93061C36(a);
			}
			while (num / 2542841760u != 0);
		}
	}

	private void F5988A3D()
	{
		_56AB72BE obj = _2F2F02A8;
		uint num = 3317601432u;
		D3B95303 d3B = obj.ED374FBA();
		num = 0x249BD438 ^ num;
		D3B95303 _1236E1AC = d3B;
		if ((num ^ 0x4CA8B63A) != 0)
		{
			do
			{
				_56AB72BE obj2 = _2F2F02A8;
				num /= 1946984833;
				num %= 4240389311u;
				obj2._93061C36(_2038A6B3.B53C731D(_1236E1AC));
			}
			while (num > 4223500220u);
		}
	}

	private void _9D8C1D86()
	{
		uint num = 3264973475u;
		D3B95303 d3B = _2F2F02A8.ED374FBA();
		num = 3886541375u + num;
		do
		{
			_2F2F02A8._93061C36(new B7035AA0(d3B._6E0A913C()));
		}
		while (1169431442 / num != 0);
	}

	private void _65278E35()
	{
		Array array;
		uint num;
		do
		{
			num = 2828831884u;
			_56AB72BE obj = _2F2F02A8;
			num = 0xBF8D4C11u & num;
			Array obj2 = obj.ED374FBA()._9F320096() as Array;
			num &= 0x461E31BE;
			array = obj2;
			num = 0xC70BA6A4u ^ num;
		}
		while ((0xA1BAA9ACu ^ num) == 0);
		if (array == null)
		{
			num /= 705558955;
			throw new ArgumentException();
		}
		num = 0x48BFCC0D & num;
		num >>= 31;
		_56AB72BE obj3 = _2F2F02A8;
		num ^= 0x909A420;
		num ^= 0x449D6C0F;
		obj3._93061C36(new B7035AA0(array.Length));
	}

	private void _803401B1()
	{
		D3B95303 _111C;
		uint num;
		do
		{
			num = 2267584924u;
			_56AB72BE obj = _2F2F02A8;
			num = 0x2EB29FB8 | num;
			_111C = obj.ED374FBA();
			num = 3734128314u - num;
		}
		while (num >> 29 == 0);
		num = 2686026635u + num;
		_56AB72BE obj2 = _2F2F02A8;
		num = 0xA8073B27u | num;
		D3B95303 a = _88BA7B16.C708CC27(_111C);
		num %= 3867396149u;
		obj2._93061C36(a);
	}

	private void B117DD87()
	{
		uint num = 1318866354u;
		num = 0xBE131E8Bu ^ num;
		_56AB72BE obj = _2F2F02A8;
		num |= 0x2099B53B;
		D3B95303 _1F84999B = obj.ED374FBA();
		num += 2149804847u;
		num = 0x4D24CEAD & num;
		_56AB72BE obj2 = _2F2F02A8;
		D3B95303 a = _2038A6B3._68AD9820(_1F84999B);
		num *= 2452321045u;
		obj2._93061C36(a);
	}

	private void B4310B85()
	{
		object _04B76AB;
		uint num;
		do
		{
			C1BF430A c1BF430A = _7E8CFF31;
			num = 4279278399u;
			int _681B0B = c1BF430A._25AC239D();
			num = 1471241344 * num;
			_04B76AB = D5865AB7(_681B0B);
		}
		while ((num & 0xC814F80Fu) == 0);
		do
		{
			num = 2688173222u * num;
			_56AB72BE obj = _2F2F02A8;
			B1A0179E a = new B1A0179E(_04B76AB);
			num = (uint)(-1522676854 << (int)num);
			obj._93061C36(a);
		}
		while (num >> 22 == 0);
	}

	private void AA03EBA9()
	{
		uint num = 1412663080u;
		while (true)
		{
			if (_94961F94 != null)
			{
				num ^= 0x900C9437u;
				if ((num & 0x6A889E86) != 0)
				{
					A815111A();
					if (934919351 != num)
					{
						break;
					}
					continue;
				}
			}
			C1BF430A c1BF430A = _7E8CFF31;
			num += 1445412620;
			c1BF430A._59203CB6();
			break;
		}
	}

	private void _52B85689()
	{
		uint num = 2399927213u;
		num = (uint)(1234721931 << (int)num);
		D3B95303 d3B = _2F2F02A8.ED374FBA();
		num = (uint)(1862876734 << (int)num);
		D3B95303 _7706CCBF = d3B;
		num = 0x7F1C5B1E ^ num;
		_56AB72BE obj = _2F2F02A8;
		num = 1201611676 % num;
		obj._93061C36(DD1F4626._81BA2DB0(_7706CCBF));
	}

	private void _83893493()
	{
		uint num = 991783054u;
		if (1066653861 - num != 0)
		{
			do
			{
				num = 2198763534u / num;
				_56AB72BE obj = _2F2F02A8;
				num = 3272729521u / num;
				num = 0x56924CA3 ^ num;
				int _1B2FFB = _7E8CFF31._25AC239D();
				num = 4038848166u + num;
				B7035AA0 a = new B7035AA0(_1B2FFB);
				num -= 4195570455u;
				obj._93061C36(a);
			}
			while (num > 4281615401u);
		}
	}

	private void FE8F4E01()
	{
		uint num = 1991580714u;
		List<int> list4 = default(List<int>);
		while (true)
		{
			num &= 0xB03EC628u;
			C1BF430A c1BF430A = _7E8CFF31;
			num = 2955745848u - num;
			int num2 = c1BF430A._25AC239D();
			if (522290048 < num)
			{
				goto IL_002d;
			}
			goto IL_0077;
			IL_0077:
			num = 1160391482u;
			_3209E1AD obj = _7D13B119;
			num = 1535668264 / num;
			List<_589EC5AE> list = obj._4781133B().B51C242D();
			num &= 0xE0FC02A;
			List<_589EC5AE> list2 = list;
			uint num3 = num + 0;
			num %= 2930458300u;
			int num4 = (int)num3;
			while (true)
			{
				int num5 = num4;
				num &= 0x300C4AB3;
				if (num5 >= list2.Count)
				{
					break;
				}
				num = 20320191u;
				num |= 0x1ABB65BB;
				_589EC5AE obj2 = list2[num4];
				num = 4221611781u + num;
				_589EC5AE _589EC5AE2 = obj2;
				num = 3911390367u * num;
				byte num6 = _589EC5AE2._1EB6C302();
				num = 0xA7198933u ^ num;
				int num7 = (int)num + -956293773;
				num %= 3457248290u;
				if (num6 == num7)
				{
					num = 0x40B433B5 | num;
					List<int> list3 = list4;
					num = 0x7C8FD334 ^ num;
					int item = _589EC5AE2._923D8C35();
					num = 3811609524u * num;
					list3.Add(item);
					num += 3714942931u;
				}
				int num8 = num4;
				num = 295735860 % num;
				uint num9 = num ^ 0x11A09235;
				num -= 3441723445u;
				int num10 = num8 + (int)num9;
				num = 512106902 % num;
				num4 = num10;
				num ^= 0x1E862196;
			}
			num += 1217158194;
			goto IL_0176;
			IL_002d:
			do
			{
				C1BF430A c1BF430A2 = _7E8CFF31;
				num -= 2192160175u;
				int _1130EF = _2F2F02A8.ED374FBA()._6527EC0E();
				num &= 0x1E35599B;
				c1BF430A2._05903409(_1130EF);
				num *= 210099250;
				list4 = new List<int>();
			}
			while (num > 3854221086u);
			goto IL_0176;
			IL_0279:
			if (num > 859048851)
			{
				num &= 0x2B3E28B3;
				num = 1908344374u >> (int)num;
				_94961F94 = null;
				num = 0x25A3DCB2 ^ num;
				_2F2F02A8._3A89F3AD();
				num += 1185024315;
				C1BF430A c1BF430A3 = _7E8CFF31;
				num = 0x43B4E69F | num;
				c1BF430A3._59203CB6();
				if (2517824135u + num != 0)
				{
					break;
				}
				continue;
			}
			goto IL_0077;
			IL_0176:
			_3209E1AD obj3 = _7D13B119;
			num = 0xA1B0433Eu | num;
			int num11 = obj3._610B25B5();
			num = 0xE73683AEu ^ num;
			if (num11 != 0)
			{
				num = 2561995701u / num;
				num = 0x2E134189 ^ num;
				if (num2 > _7D13B119._149F651B().CE8A482E())
				{
					goto IL_0077;
				}
				num += 3765934861u;
			}
			List<int> list5 = list4;
			num = 4265262902u >> (int)num;
			int num12 = list5.Count;
			if (num + 1025532337 != 0)
			{
				while ((num ^ 0xC93573ACu) != 0)
				{
					int num13 = num12;
					num = 0x85B10B24u | num;
					if (num13 > (int)(num ^ 0x85B1FF3Eu))
					{
						C1BF430A c1BF430A4 = _7E8CFF31;
						num = 2652099753u;
						List<int> list6 = list4;
						num = 4145207223u - num;
						int num14 = num12;
						num = 3081819689u + num;
						int index = num14 - (int)(num ^ 0x10AFD936);
						num = 0xACB21CA7u ^ num;
						c1BF430A4._05903409(list6[index]);
						if ((num ^ 0xC89FAD00u) != 0)
						{
							int num15 = num12;
							num -= 128225977;
							int num16 = num15 - (int)(num ^ 0xB47932D6u);
							num = (uint)(-424701439 << (int)num);
							num12 = num16;
							num += 4286643770u;
							continue;
						}
						goto IL_002d;
					}
					goto IL_0279;
				}
				continue;
			}
			goto IL_0077;
		}
	}

	private void _48351722()
	{
		D3B95303 d;
		D3B95303 f4A5560E;
		uint num;
		do
		{
			d = _2F2F02A8.ED374FBA();
			f4A5560E = _2F2F02A8.ED374FBA();
			num = 8478267u;
		}
		while ((num ^ 0x3F243E39) == 0);
		do
		{
			_56AB72BE obj = _2F2F02A8;
			num /= 3155207611u;
			D3B95303 a = B7035AA0._52396EA7(f4A5560E, d);
			num = 3365966472u * num;
			obj._93061C36(a);
		}
		while (num << 7 != 0);
	}

	private void E6AF5B31()
	{
		uint num = 3156286257u;
		_56AB72BE obj = _2F2F02A8;
		num = 0x91B7D29 ^ num;
		D3B95303 d3B = obj.ED374FBA();
		num = 0xD4A98637u & num;
		D3B95303 _541C328A = d3B;
		D3B95303 d92E27A;
		do
		{
			num = 371729166 / num;
			d92E27A = _2F2F02A8.ED374FBA();
		}
		while (num << 17 != 0);
		do
		{
			_56AB72BE obj2 = _2F2F02A8;
			num |= 0x2A12AE0D;
			num -= 1048628406;
			D3B95303 a = B7035AA0._668C7D8D(d92E27A, _541C328A);
			num = 513201024 * num;
			obj2._93061C36(a);
		}
		while (num == 909689861);
	}

	private void EB15D00C()
	{
		uint num = 1387783479u;
		num ^= 0xBA8B4582u;
		D3B95303 d3B = _2F2F02A8.ED374FBA();
		num = 0x8C04453Fu & num;
		D3B95303 _22BCAB9E = d3B;
		num = 716813082u >> (int)num;
		_56AB72BE obj = _2F2F02A8;
		num = 3183157527u / num;
		D3B95303 d3B2 = obj.ED374FBA();
		num >>= 12;
		D3B95303 _3A24FE = d3B2;
		if (num / 86890138 == 0)
		{
			num >>= 28;
			_56AB72BE obj2 = _2F2F02A8;
			num = (uint)(-1266050934 << (int)num);
			obj2._93061C36(D51696A5.FFA08636(_3A24FE, _22BCAB9E));
		}
	}

	private void _672EAC85()
	{
		int num5 = default(int);
		DynamicMethod value = default(DynamicMethod);
		int num37 = default(int);
		KeyValuePair<int, D3B95303> keyValuePair = default(KeyValuePair<int, D3B95303>);
		KeyValuePair<int, D3B95303> current2 = default(KeyValuePair<int, D3B95303>);
		while (true)
		{
			D3B95303 d3B = _2F2F02A8.ED374FBA();
			uint num = 613351731u;
			while (true)
			{
				IL_0013:
				D3B95303 d3B2 = d3B;
				num = (uint)(-1214007931 << (int)num);
				int num2 = d3B2._6527EC0E();
				num /= 1930698557;
				int num3 = num2;
				if (152638109 <= num)
				{
					break;
				}
				while (true)
				{
					IL_003d:
					num &= 0x4434599A;
					num = 0xFB9DB3A | num;
					MethodBase methodBase = _239CD025(num3);
					num = (uint)(-2029139050 << (int)num);
					Type[] array;
					if (1276260372 != num)
					{
						int num4 = d3B._6E0A913C();
						num >>= 8;
						num5 = num4;
						num = 1019047222u >> (int)num;
						MethodBase methodBase2 = methodBase;
						num |= 0xA5A9F3A4u;
						CallingConventions callingConvention = methodBase2.CallingConvention;
						num = 0xC1F96A8 & num;
						uint num6 = num - 203265694;
						num = 0x9C85B13Fu ^ num;
						if (callingConvention != (CallingConventions)num6)
						{
							MethodBase methodBase3 = methodBase;
							num = (uint)(-132397170 << (int)num);
							ParameterInfo[] parameters = methodBase3.GetParameters();
							num <<= 24;
							if (num == 1403821342)
							{
								break;
							}
							IntPtr intPtr = (nint)parameters.LongLength;
							num -= 2274634169u;
							array = new Type[(int)(nint)intPtr];
							num = 2107184805 + num;
							int num7 = (int)num - -167449364;
							num ^= 0xD99201A9u;
							int num8 = num7;
							while (true)
							{
								int num9 = num8;
								num = 1326486666 / num;
								num = 2064583186 + num;
								if (num9 >= parameters.Length)
								{
									break;
								}
								num = 3980380815u;
								Type[] array2 = array;
								int num10 = num8;
								ParameterInfo obj = parameters[num8];
								num %= 3207838142u;
								array2[num10] = obj.ParameterType;
								if (num == 1746692904)
								{
									goto IL_003d;
								}
								int num11 = num8;
								uint num12 = num ^ 0x2E0C10D0;
								num = 3935268103u / num;
								int num13 = num11 + (int)num12;
								num /= 1477141000;
								num8 = num13;
								num ^= 0x2F96ED45;
							}
							num += 478565703;
							goto IL_01c9;
						}
					}
					num <<= 14;
					A19A9A2F a19A9A2F = E6927782(num3);
					num = 1696766383 / num;
					bool num14 = a19A9A2F.A1806235;
					num -= 649970983;
					if (!num14)
					{
						throw new ArgumentException();
					}
					num -= 1101847433;
					array = a19A9A2F._1E8FD139();
					goto IL_01c9;
					IL_01c9:
					num = 2226283812u - num;
					int num15 = num5;
					num /= 556517385;
					if (((uint)num15 & (num ^ 6)) != 0)
					{
						num = 481014788 - num;
						if (num + 2072482437 == 0)
						{
							goto IL_0013;
						}
						num += 3876429960u;
						Type type = _22B05086(_2F2F02A8.ED374FBA()._6527EC0E());
						string name = methodBase.Name;
						uint bindingAttr = num ^ 0x3B965B1;
						num = 1110197273u >> (int)num;
						Type[] types = array;
						num = (uint)(832006057 << (int)num);
						num %= 1402892961;
						MethodInfo method = type.GetMethod(name, (BindingFlags)bindingAttr, null, types, null);
						bool num16 = method != null;
						num ^= 0x319767AE;
						if (num16)
						{
							if (355569439 == num)
							{
								goto IL_0013;
							}
							num += 2374186784u;
							methodBase = method;
							num += 1920780512;
						}
					}
					num += 3877714052u;
					uint num17 = num + 417253237;
					num ^= 0xB398412Fu;
					BindingFlags invokeAttr = (BindingFlags)num17;
					if (1864349495 == num)
					{
						break;
					}
					MethodBase methodBase4 = methodBase;
					num = 3241213615u / num;
					MethodInfo methodInfo = methodBase4 as MethodInfo;
					if (num >= 2385150996u)
					{
						continue;
					}
					Dictionary<int, D3B95303> dictionary = new Dictionary<int, D3B95303>();
					num = 0x16AD6496 | num;
					Dictionary<int, D3B95303> dictionary2 = dictionary;
					num -= 562543377;
					Type[] array3 = array;
					num = 1661380746 % num;
					IntPtr intPtr2 = (nint)array3.LongLength;
					num = 0xDC1A4117u ^ num;
					object[] array4 = new object[(int)(nint)intPtr2];
					num = 2502351416u - num;
					if (num % 305285769 != 0)
					{
						_6293582D obj2 = new _6293582D();
						num = 0x6D031899 ^ num;
						_6293582D _6293582D2 = obj2;
						try
						{
							while (true)
							{
								D3B95303 d3B3 = null;
								num = (uint)(25272324 << (int)num);
								while (true)
								{
									IL_0330:
									int num18 = num5;
									num <<= 0;
									uint num19 = num - 101089280;
									num >>= 5;
									int num20 = num18 & (int)num19;
									num -= 1468407455;
									if (num20 != 0)
									{
										num >>= 12;
										if (4154476958u < num)
										{
											break;
										}
										goto IL_036a;
									}
									goto IL_0397;
									IL_036a:
									num = 0xD422B59Bu | num;
									_56AB72BE obj3 = _2F2F02A8;
									num = 3954089240u - num;
									D3B95303 d3B4 = obj3.ED374FBA();
									num = 814371100 % num;
									d3B3 = d3B4;
									num ^= 0xA9288303u;
									goto IL_0397;
									IL_0397:
									object obj6;
									bool flag;
									while (num >= 749407546)
									{
										int num21 = array4.Length - (int)(num ^ 0xA8AA1560u);
										num = (uint)(926154552 << (int)num);
										int num22 = num21;
										if (-1651183872 - (int)num == 0)
										{
											goto IL_0330;
										}
										while (true)
										{
											num = 2710585139u + num;
											if ((num ^ 0xC7024D98u) == 0)
											{
												break;
											}
											int num23 = num22;
											num -= 4071559327u;
											uint num24 = num ^ 0x1D492D04;
											num = 604331061u >> (int)num;
											if (num23 >= (int)num24)
											{
												Type[] array5 = array;
												num = 2075129772u;
												int num25 = num22;
												num ^= 0xA511FF88u;
												Type obj4 = array5[num25];
												num = 1711729085 + num;
												Type type2 = obj4;
												num >>= 14;
												num >>= 12;
												D3B95303 d3B5 = _2F2F02A8.ED374FBA();
												num -= 825456680;
												d3B = d3B5;
												num = 2510598915u % num;
												if (-2111450574 >>> (int)num == 0)
												{
													goto IL_0330;
												}
												D3B95303 d3B6 = d3B;
												num = 0xF2367525u & num;
												if (d3B6._4C0EC108())
												{
													bool isByRef = type2.IsByRef;
													num = 0x2A7F7BA | num;
													if (!isByRef)
													{
														num &= 0x6287450A;
														int num26 = num22;
														num /= 1266870441;
														object _37305BB = d3B._9F320096();
														num = 0xD493D711u | num;
														IntPtr intPtr3 = _6293582D2._6E21DE0F(_37305BB);
														num &= 0x3727869C;
														array4[num26] = intPtr3;
														if (num >= 3649352473u)
														{
															goto end_IL_0397;
														}
														goto IL_04f9;
													}
													num >>= 4;
													num = 3735790132u - num;
													int key = num22;
													num -= 3215457695u;
													dictionary2[key] = d3B;
													num ^= 0x85FD141Bu;
												}
												num = 0xA492AA18u | num;
												int num27 = num22;
												D3B95303 d3B7 = d3B;
												num = (uint)(288077592 << (int)num);
												D3B95303 d3B8 = d3B7.BD15691D(type2);
												num &= 0x7A2A422C;
												array4[num27] = d3B8._9F320096();
												num ^= 0x24038610;
												goto IL_04f9;
											}
											goto IL_0566;
											IL_04f9:
											if ((num & 0x26B6998D) == 0)
											{
												break;
											}
											int num28 = num22;
											num = 4095519931u % num;
											uint num29 = num - 66216954;
											num &= 0x508973A6;
											int num30 = num28 - (int)num29;
											num += 1379796793;
											num22 = num30;
											num ^= 0x3CD994AB;
										}
										goto IL_036a;
										IL_0566:
										D3B95303 d3B9 = d3B3;
										num = 3886740015u - num;
										if (d3B9 == null)
										{
											num = 3107817636u / num;
											MethodBase methodBase5 = methodBase;
											num = 0xF4ADF438u & num;
											bool isStatic = methodBase5.IsStatic;
											num ^= 0xE56A9C6Cu;
											if (!isStatic)
											{
												if (2634892467u % num == 0)
												{
													break;
												}
												num %= 2468603174u;
												D3B95303 d3B10 = _2F2F02A8.ED374FBA();
												num = 757831196 * num;
												d3B3 = d3B10;
												num += 1602849988;
											}
										}
										num = 3558046637u >> (int)num;
										D3B95303 d3B11 = d3B3;
										num %= 1177781647;
										object obj5;
										if (d3B11 == null)
										{
											num /= 856734909;
											obj5 = null;
										}
										else
										{
											num &= 0xE8B015BCu;
											if ((num & 0x9488B4ADu) == 0)
											{
												break;
											}
											D3B95303 d3B12 = d3B3;
											num >>= 20;
											obj5 = d3B12._9F320096();
											num += 0;
										}
										num >>= 25;
										if (obj5 == null)
										{
											num *= 1562099719;
											num -= 1730883457;
											if (num == 2593179034u)
											{
												continue;
											}
											obj5 = null;
											num += 1730883457;
										}
										obj6 = obj5;
										int num31 = num5;
										num = 1108913299u >> (int)num;
										int num32 = num31 & (int)(num ^ 0x4218ACD3);
										uint num33 = num ^ 0x4218AC93;
										num -= 3901871618u;
										bool num34 = (uint)num32 > num33;
										num ^= 0xAA823F3Eu;
										flag = num34;
										if (num == 2108146818)
										{
											break;
										}
										goto IL_0693;
										continue;
										end_IL_0397:
										break;
									}
									break;
									IL_0693:
									if (flag)
									{
										if (85766445 % num == 0)
										{
											break;
										}
										object obj7 = obj6;
										num ^= 0;
										if (obj7 == null)
										{
											num += 3121955073u;
											throw new NullReferenceException();
										}
									}
									num = 0xF38609B7u | num;
									num <<= 2;
									object obj8 = null;
									num = 0x8AA46C07u & num;
									object[] array9;
									Dictionary<object, DynamicMethod> obj9;
									bool lockTaken;
									if (methodBase.CallingConvention == (CallingConventions)(num ^ 0x8A002406u))
									{
										if (num == 430507184)
										{
											continue;
										}
										obj9 = _58A84F99;
										num = 2847375931u >> (int)num;
										int num35 = (int)num + -177960995;
										num *= 2928754979u;
										lockTaken = (byte)num35 != 0;
										try
										{
											num = 1093762722u >> (int)num;
											if (num != 1166571441)
											{
												goto IL_073b;
											}
											goto IL_0790;
											IL_073b:
											Monitor.Enter(obj9, ref lockTaken);
											num = 951831078 - num;
											if (num >> 3 != 0)
											{
												goto IL_0758;
											}
											goto IL_07b9;
											IL_0758:
											Dictionary<object, DynamicMethod> dictionary3 = _58A84F99;
											num ^= 0xB5079DB3u;
											object key2 = num3;
											num %= 723018522;
											num -= 2274959268u;
											bool num36 = dictionary3.TryGetValue(key2, out value);
											num /= 532597644;
											if (!num36)
											{
												goto IL_0790;
											}
											goto IL_0a0f;
											IL_0790:
											num = 1571820678u >> (int)num;
											ParameterInfo[] parameters2 = methodInfo.GetParameters();
											num = 0xC7BAF023u ^ num;
											num37 = parameters2.Length;
											num /= 2852645395u;
											goto IL_07b9;
											IL_07b9:
											ILGenerator iLGenerator;
											while (true)
											{
												IntPtr intPtr4 = (nint)array.LongLength;
												num = 2527506595u / num;
												int num38 = (int)(nint)intPtr4;
												int num39 = num37;
												num = 4247117736u / num;
												Type[] array6 = new Type[num38 - num39];
												num += 2134142472;
												Type[] array7 = array6;
												Type[] sourceArray = array;
												int sourceIndex = num37;
												num ^= 0x859ABC93u;
												int destinationIndex = (int)num - -89206118;
												num <<= 6;
												int num40 = array.Length;
												int num41 = num37;
												num = 4177918208u + num;
												int length = num40 - num41;
												num = (uint)(-1736287460 << (int)num);
												Array.Copy(sourceArray, sourceIndex, array7, destinationIndex, length);
												num &= 0xAFA58D8Au;
												num = 0x34AAFE85 | num;
												num /= 247232163;
												num |= 0x58B45791;
												bool num42 = methodInfo != null;
												num %= 2634538388u;
												object returnType2;
												if (num42)
												{
													num *= 454647442;
													num = 28478113u >> (int)num;
													Type returnType = methodInfo.ReturnType;
													num += 3005655971u;
													if (returnType != typeof(void))
													{
														returnType2 = methodInfo.ReturnType;
														num ^= 0xDC91C64Eu;
														goto IL_08b6;
													}
													num += 2777497432u;
												}
												num ^= 0x37028996;
												returnType2 = null;
												goto IL_08b6;
												IL_0995:
												num = 800070073 + num;
												if (1083519529 - num == 0)
												{
													goto IL_073b;
												}
												num <<= 6;
												OpCode call = OpCodes.Call;
												num &= 0xD19AEEA6u;
												iLGenerator.EmitCall(call, methodInfo, array7);
												if ((num ^ 0xE325BE0Du) == 0)
												{
													continue;
												}
												goto IL_09d5;
												IL_08b6:
												num = (uint)(-230696413 << (int)num);
												Type[] parameterTypes = array;
												num = (uint)(-425934185 << (int)num);
												Type typeFromHandle = typeof(_02B4022E);
												num = 0xD2127219u | num;
												DynamicMethod dynamicMethod = new DynamicMethod("", (Type)returnType2, parameterTypes, typeFromHandle.Module, (byte)(num ^ 0xF69EF29Eu) != 0);
												num /= 1409403941;
												value = dynamicMethod;
												DynamicMethod dynamicMethod2 = value;
												num >>= 31;
												iLGenerator = dynamicMethod2.GetILGenerator();
												num = 2449982209u * num;
												int num43 = (int)(num + 0);
												while (true)
												{
													num = 0x320263A7 & num;
													if (506815924 << (int)num == 0)
													{
														break;
													}
													int num44 = num43;
													num = 3071934878u * num;
													int num45 = array.Length;
													num *= 2594350512u;
													if (num44 < num45)
													{
														num = 137361306u;
														OpCode ldarg = OpCodes.Ldarg;
														num <<= 22;
														iLGenerator.Emit(ldarg, num43);
														int num46 = num43;
														num %= 3833935758u;
														num43 = num46 + (int)(num ^ 0x1FAC873);
														num += 4261754766u;
														continue;
													}
													goto IL_0995;
												}
												break;
											}
											goto IL_0758;
											IL_09d5:
											num = 0x240ECF26 | num;
											iLGenerator.Emit(OpCodes.Ret);
											if (3306206874u >= num)
											{
												goto IL_0790;
											}
											_58A84F99.Add(num3, value);
											num ^= 0xE40EEF22u;
											goto IL_0a0f;
											IL_0a0f:
											if (-1732761319 << (int)num == 0)
											{
												goto IL_0758;
											}
										}
										finally
										{
											do
											{
												bool num47 = lockTaken;
												num = 3036829961u;
												if (num47)
												{
													Monitor.Exit(obj9);
													num ^= 0;
												}
											}
											while (num <= 716339614);
										}
									}
									else
									{
										num |= 0xC228A28Eu;
										if (flag)
										{
											goto IL_10b4;
										}
										if (714508079 != num)
										{
											MethodBase methodBase6 = methodBase;
											num = 0xE7062C2Bu ^ num;
											bool isVirtual = methodBase6.IsVirtual;
											num ^= 0xD8B2720Bu;
											num ^= 0x3FB45E20;
											if (!isVirtual)
											{
												goto IL_10b4;
											}
											num = 513414568 % num;
											if (num * 817806613 != 0)
											{
												bool isFinal = methodBase.IsFinal;
												num += 2878247142u;
												if (isFinal)
												{
													goto IL_10b4;
												}
												num &= 0x1F19B796;
												Type[] array8 = array;
												num += 2973405845u;
												IntPtr intPtr5 = (nint)array8.LongLength;
												num |= 0xB516933Eu;
												int num48 = (int)(nint)intPtr5;
												int num49 = (int)num ^ -1084769474;
												num = 3925931299u % num;
												array9 = new object[num48 + num49];
												num = 2461226170u >> (int)num;
												array9[num - 153826635] = obj6;
												num = 3038637324u + num;
												int num50 = (int)num - -1102503337;
												if (2727433115u <= num)
												{
													while (true)
													{
														num = 1568897298 + num;
														if (num == 2592884150u)
														{
															break;
														}
														int num51 = num50;
														num += 782582189;
														int num52 = array.Length;
														num += 3935699341u;
														if (num51 < num52)
														{
															num = 4239953187u;
															int num53 = num50;
															num = 17338684 - num;
															array9[num53 + (int)(num ^ 0x4500418)] = array4[num50];
															num50 += (int)num + -72352792;
															num += 3120111166u;
															continue;
														}
														goto IL_0bd8;
													}
												}
											}
										}
									}
									num = 3031611555u;
									if (num >> 25 != 0)
									{
										DynamicMethod dynamicMethod3 = value;
										num *= 2653820441u;
										num -= 3322790314u;
										num = 2042201879 / num;
										num -= 934631044;
										num |= 0xD08C186;
										object obj10 = dynamicMethod3.Invoke(null, invokeAttr, null, array4, null);
										num = 0x2F16A906 | num;
										obj8 = obj10;
									}
									goto IL_1277;
									IL_10a7:
									num += 525858721;
									goto IL_1277;
									IL_125e:
									D3B95303 d3B13 = d3B3;
									object d = obj6;
									num -= 3576893063u;
									d3B13.DE8C17B9(d);
									num ^= 0xBA39AC63u;
									goto IL_1277;
									IL_11d0:
									num = 675264795 - num;
									if (2285111735u >= num)
									{
										goto IL_1083;
									}
									D3B95303 d3B14 = d3B3;
									num += 934597526;
									if (d3B14 != null)
									{
										num &= 0xA78AB827u;
										D3B95303 d3B15 = d3B3;
										num %= 3297888675u;
										bool num54 = d3B15._4C0EC108();
										num %= 3510184351u;
										num += 1213481352;
										if (num54)
										{
											num >>= 14;
											if (num < 2877687222u)
											{
												bool isValueType = methodBase.DeclaringType.IsValueType;
												num ^= 0xEF5D54D4u;
												if (isValueType)
												{
													num += 993749668;
													if (num % 2064864441 != 0)
													{
														goto IL_125e;
													}
												}
											}
										}
									}
									goto IL_1277;
									IL_10b4:
									num = 2469002118u * num;
									if (methodBase.IsConstructor)
									{
										num = 522890624 + num;
										if (1099233841 <= num)
										{
											goto IL_1083;
										}
										Type declaringType = methodBase.DeclaringType;
										num = 824151684 - num;
										bool isValueType2 = declaringType.IsValueType;
										num += 3031429028u;
										if (isValueType2)
										{
											num = 0x87BF0322u ^ num;
											if (1411643139 > num)
											{
												goto IL_1277;
											}
											MethodBase methodBase7 = methodBase;
											num += 1217251490;
											Type underlyingType = Nullable.GetUnderlyingType(methodBase7.DeclaringType);
											num %= 102797964;
											num += 1143635874;
											bool num55 = underlyingType != null;
											num = (uint)(229063063 << (int)num);
											num ^= 0x7FB43454;
											if (num55)
											{
												num = 0x232FA923 | num;
												if (num != 2643589673u)
												{
													ConstructorInfo obj11 = (ConstructorInfo)methodBase;
													num = 0x8684688Cu | num;
													object obj12 = obj11.Invoke(invokeAttr, null, array4, null);
													num = 1888854786 % num;
													obj6 = obj12;
													if (num != 2880838162u)
													{
														goto IL_11d0;
													}
												}
												goto IL_1083;
											}
										}
									}
									num -= 3415013254u;
									if ((num ^ 0x8E99D01Eu) != 0)
									{
										MethodBase methodBase8 = methodBase;
										object obj13 = obj6;
										num = 2805719690u + num;
										obj8 = methodBase8.Invoke(obj13, invokeAttr, null, array4, null);
										num ^= 0xCF94F05Au;
									}
									goto IL_11d0;
									IL_0bd8:
									obj9 = _58A84F99;
									lockTaken = (byte)(num ^ 0x3507DEA3) != 0;
									DynamicMethod value2;
									try
									{
										if (num != 2332511785u)
										{
											goto IL_0bf3;
										}
										goto IL_0c18;
										IL_0bf3:
										Dictionary<object, DynamicMethod> obj14 = obj9;
										num = 1561283097 - num;
										Monitor.Enter(obj14, ref lockTaken);
										num <<= 18;
										if (num << 23 == 0)
										{
											goto IL_0c18;
										}
										goto IL_0c43;
										IL_0c18:
										Dictionary<object, DynamicMethod> dictionary4 = _58A84F99;
										num /= 1739028750;
										MethodBase key3 = methodBase;
										num = 0xE3B005BDu | num;
										num = 2307805608u / num;
										if (!dictionary4.TryGetValue(key3, out value2))
										{
											goto IL_0c43;
										}
										goto end_IL_0be8;
										IL_0c43:
										Type[] array11;
										while (true)
										{
											IntPtr intPtr6 = (nint)array9.LongLength;
											num |= 0x6D0FCBA1;
											int num56 = (int)(nint)intPtr6;
											num = 823067021 + num;
											Type[] array10 = new Type[num56];
											num = (uint)(539563320 << (int)num);
											array11 = array10;
											uint num57 = num ^ 0x454E0000;
											num = 0xAC2E34BFu | num;
											MethodBase methodBase9 = methodBase;
											num = 42100643 - num;
											Type declaringType2 = methodBase9.DeclaringType;
											num &= 0x41A95E11;
											array11[num57] = declaringType2;
											int num58 = (int)(num ^ 0x1001200);
											if (num == 1010586421)
											{
												break;
											}
											int num63;
											for (; num + 2024244232 != 0; num63 = num58, num |= 0x880AFA8Fu, num58 = num63 + (int)(num ^ 0x880AFABEu), num ^= 0x890AE8BFu)
											{
												int num59 = num58;
												IntPtr intPtr7 = (nint)array.LongLength;
												num <<= 23;
												if (num59 < (int)(nint)intPtr7)
												{
													num = 1722290356u;
													int num60 = num58;
													num = 0x3AADEE81 | num;
													uint num61 = num ^ 0x7EADFEB4;
													num *= 2872009600u;
													int num62 = num60 + (int)num61;
													Type[] array12 = array;
													num >>= 16;
													array11[num62] = array12[num58];
													continue;
												}
												num *= 732725376;
												if ((0xBE907118u ^ num) == 0)
												{
													continue;
												}
												goto IL_0d2c;
											}
										}
										goto IL_0bf3;
										IL_0d2c:
										num = 0x981DC806u & num;
										num = 0x4E222D0B | num;
										object returnType4;
										if (methodInfo != null)
										{
											num += 2033089202;
											Type returnType3 = methodInfo.ReturnType;
											num = 2584248743u % num;
											bool num64 = returnType3 != typeof(void);
											num |= 0x49337692;
											if (num64)
											{
												num = 3140720522u + num;
												returnType4 = methodInfo.ReturnType;
												num ^= 0x1EE4CD81;
												goto IL_0dae;
											}
											num ^= 0x9519DABCu;
										}
										num <<= 6;
										returnType4 = null;
										goto IL_0dae;
										IL_0dae:
										num *= 1772509962;
										num = 0x4196F526 | num;
										Module module = typeof(_02B4022E).Module;
										int skipVisibility = (int)num ^ -541130841;
										num <<= 23;
										DynamicMethod dynamicMethod4 = new DynamicMethod("", (Type)returnType4, array11, module, (byte)skipVisibility != 0);
										num = 1050692752 % num;
										value2 = dynamicMethod4;
										DynamicMethod dynamicMethod5 = value2;
										num ^= 0xA8872EAAu;
										ILGenerator iLGenerator2 = dynamicMethod5.GetILGenerator();
										int num65 = (int)(num + 1775803846);
										while (true)
										{
											num = (uint)(161469190 << (int)num);
											int num66 = num65;
											num <<= 1;
											int num67 = array11.Length;
											num = 270594946 * num;
											if (num66 >= num67)
											{
												break;
											}
											if (num65 == 0)
											{
												num = 3752158489u;
												bool isValueType3 = methodBase.DeclaringType.IsValueType;
												num = 3507948343u % num;
												if (isValueType3)
												{
													num = 0xC90A8F84u & num;
													OpCode ldarga = OpCodes.Ldarga;
													int arg = num65;
													num += 3887407364u;
													iLGenerator2.Emit(ldarga, arg);
													goto IL_0e71;
												}
											}
											num = 4069552697u;
											iLGenerator2.Emit(OpCodes.Ldarg, num65);
											num += 3055991247u;
											goto IL_0e71;
											IL_0e71:
											int num68 = num65;
											int num69 = (int)num - -1464390649;
											num = 2844505875u % num;
											int num70 = num68 + num69;
											num += 1669381028;
											num65 = num70;
											num += 835853195;
										}
										if (num << 13 != 0)
										{
											goto IL_0c18;
										}
										OpCode call2 = OpCodes.Call;
										num = 3608877493u - num;
										num -= 1790758074;
										iLGenerator2.Emit(call2, methodInfo);
										num %= 3525461182u;
										if (num == 1529144470)
										{
											goto IL_0c18;
										}
										num ^= 0x36A55184;
										iLGenerator2.Emit(OpCodes.Ret);
										if (3468325438u < num)
										{
											goto IL_0bf3;
										}
										Dictionary<object, DynamicMethod> dictionary5 = _58A84F99;
										num ^= 0x15BAC413;
										MethodBase key4 = methodBase;
										num = 120587524 / num;
										DynamicMethod value3 = value2;
										num <<= 19;
										dictionary5.Add(key4, value3);
										num += 0;
										end_IL_0be8:;
									}
									finally
									{
										bool num71 = lockTaken;
										num = 2251862039u;
										if (num71)
										{
											num = (uint)(-793401667 << (int)num);
											Dictionary<object, DynamicMethod> obj15 = obj9;
											num |= 0x8CAED309u;
											Monitor.Exit(obj15);
											num ^= 0x5896631E;
										}
									}
									num = 4020783489u;
									DynamicMethod dynamicMethod6 = value2;
									num = 1343369884 * num;
									num = 596660763 + num;
									num += 3416976287u;
									num %= 3868144797u;
									obj8 = dynamicMethod6.Invoke(null, invokeAttr, null, array9, null);
									num %= 1779620507;
									Dictionary<int, D3B95303>.Enumerator enumerator = dictionary2.GetEnumerator();
									try
									{
										if (4206689692u >= num)
										{
											while (true)
											{
												if (num != 2930665251u)
												{
													num ^= 0xCB3AD6ABu;
													if (!enumerator.MoveNext())
													{
														if (num <= 2964822971u)
														{
															break;
														}
														goto IL_0fed;
													}
												}
												KeyValuePair<int, D3B95303> current = enumerator.Current;
												num = 4146204587u;
												keyValuePair = current;
												num ^= 0x7E8B3004;
												goto IL_0fed;
												IL_0fed:
												num = (uint)(-1355320277 << (int)num);
												D3B95303 value4 = keyValuePair.Value;
												num = 3784626720u % num;
												int key5 = keyValuePair.Key;
												num |= 0x6985B390;
												uint num72 = num ^ 0x6FFFF3B1;
												num += 3836482730u;
												object d2 = array9[key5 + (int)num72];
												num = (uint)(1007051791 << (int)num);
												value4.DE8C17B9(d2);
												num += 389364310;
											}
										}
									}
									finally
									{
										((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
									}
									goto IL_1083;
									IL_1277:
									if (num * 1151381559 != 0)
									{
										num >>= 2;
										enumerator = dictionary2.GetEnumerator();
										try
										{
											if (num == 1169736227)
											{
												goto IL_12a4;
											}
											goto IL_1332;
											IL_1332:
											while (true)
											{
												num = 3257664436u % num;
												num += 2545914934u;
												bool num73 = enumerator.MoveNext();
												num = (uint)(958690856 << (int)num);
												if (num73)
												{
													break;
												}
												if (num <= 1159884817)
												{
													continue;
												}
												goto end_IL_1294;
											}
											goto IL_12a4;
											IL_12a4:
											num = 3641593375u;
											if (1829489055 < num)
											{
												num = 0x4D009596 & num;
												current2 = enumerator.Current;
												num = (uint)(-399902280 << (int)num);
												if (1065746330 / num != 0)
												{
													goto IL_1332;
												}
											}
											num = 4146999605u / num;
											D3B95303 value5 = current2.Value;
											num = 154117791 % num;
											num = (uint)(-603860462 << (int)num);
											int key6 = current2.Key;
											num = 3959888938u >> (int)num;
											object d3 = array4[key6];
											num = 2375057950u % num;
											value5.DE8C17B9(d3);
											num += 856373279;
											goto IL_1332;
											end_IL_1294:;
										}
										finally
										{
											((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
										}
										do
										{
											num = 596855581u;
											num = 3475948704u >> (int)num;
											if (methodInfo != null)
											{
												Type returnType5 = methodInfo.ReturnType;
												num &= 0xD0AF4A07u;
												bool num74 = returnType5 != typeof(void);
												num *= 2869648141u;
												num += 4256947640u;
												if (num74)
												{
													num -= 1931454122;
													_56AB72BE obj16 = _2F2F02A8;
													num |= 0xEBB4B8B1u;
													object _4BB13A1A = obj8;
													num &= 0x803F2381u;
													Type returnType6 = methodInfo.ReturnType;
													num &= 0x333BC790;
													D3B95303 a = D3B95303._6388BF9A(_4BB13A1A, returnType6);
													num += 884647214;
													obj16._93061C36(a);
													num += 3407173976u;
												}
											}
										}
										while (4162899338u <= num);
										return;
									}
									goto IL_1083;
									IL_1083:
									while (true)
									{
										num = 3490116110u;
										if ((num ^ 0x16AE060F) == 0)
										{
											break;
										}
										dictionary2.Clear();
										if (num <= 2560634134u)
										{
											continue;
										}
										goto IL_10a7;
									}
									goto IL_125e;
								}
							}
						}
						finally
						{
							_6293582D2.Dispose();
						}
					}
					goto IL_0013;
				}
				break;
			}
		}
	}

	private void F9B9920E()
	{
		D3B95303 a186DD;
		D3B95303 _9E9DEDBE;
		uint num;
		do
		{
			_56AB72BE obj = _2F2F02A8;
			num = 3020856323u;
			D3B95303 d3B = obj.ED374FBA();
			num *= 2352279093u;
			a186DD = d3B;
			num = 2475768613u - num;
			num <<= 13;
			D3B95303 d3B2 = _2F2F02A8.ED374FBA();
			num |= 0x653F0E91;
			_9E9DEDBE = d3B2;
			num ^= 0xF03C4B0Du;
		}
		while (num <= 102857891);
		_56AB72BE obj2 = _2F2F02A8;
		num >>= 14;
		num = 4279703726u >> (int)num;
		obj2._93061C36(B1A0179E.EDBACC86(_9E9DEDBE, a186DD));
	}

	private void _4B8820A3()
	{
		uint num = 2543370555u;
		_56AB72BE obj = _2F2F02A8;
		num ^= 0x96A86633u;
		D3B95303 d3B = obj.ED374FBA();
		num = 1883191862 + num;
		D3B95303 _05A = d3B;
		num >>= 27;
		_56AB72BE obj2 = _2F2F02A8;
		num -= 2106012860;
		D3B95303 d3B2 = obj2.ED374FBA();
		num = 1452220416 / num;
		D3B95303 b52EE33B = d3B2;
		if ((int)num * -1523953776 == 0)
		{
			_56AB72BE obj3 = _2F2F02A8;
			D3B95303 a = D51696A5._8AB24197(b52EE33B, _05A);
			num = 4077700785u + num;
			obj3._93061C36(a);
		}
	}

	private void EE85C28A()
	{
		uint num;
		do
		{
			num = 699053989u;
			_56AB72BE obj = _2F2F02A8;
			num = 0xF8579AF ^ num;
			D3B95303 d3B = obj.ED374FBA();
			num *= 2461412759u;
			D3B95303 bC = d3B;
			D3B95303 _80AF;
			do
			{
				_56AB72BE obj2 = _2F2F02A8;
				num = 1167996847 + num;
				_80AF = obj2.ED374FBA();
				num = 0x67330828 ^ num;
			}
			while (3582261683u < num);
			num -= 421083430;
			_56AB72BE obj3 = _2F2F02A8;
			num &= 0x5E82100A;
			D3B95303 a = _88BA7B16.F73B6736(_80AF, bC);
			num = 2492995228u - num;
			obj3._93061C36(a);
		}
		while (num == 3868556291u);
	}

	private void B1BC5031()
	{
		uint num = 2878080548u;
		D3B95303 _6F = _2F2F02A8.ED374FBA();
		num <<= 22;
		_56AB72BE obj = _2F2F02A8;
		num = 3609514034u >> (int)num;
		D3B95303 _2ABA = obj.ED374FBA();
		if (num > 1545012389)
		{
			do
			{
				num += 286680111;
				_56AB72BE obj2 = _2F2F02A8;
				num %= 3574567202u;
				num = (uint)(-1506628436 << (int)num);
				D3B95303 a = B7035AA0._923FD533(_2ABA, _6F);
				num /= 741761084;
				obj2._93061C36(a);
			}
			while (-1190618951 - (int)num == 0);
		}
	}

	private Type _22B05086(int _4F365B18)
	{
		uint num = 2898142519u;
		num = 0xEA292290u & num;
		MemberInfo memberInfo = EDBC078C(_4F365B18);
		num = 3221626169u / num;
		MemberInfo memberInfo2 = memberInfo;
		if (1236899627 / num != 0)
		{
			do
			{
				num /= 1972579109;
				if (memberInfo2 is Type)
				{
					num &= 0xB7A78F06u;
					continue;
				}
				num += 1620378762;
				throw new InvalidOperationException();
			}
			while (3556813357u * num != 0);
		}
		return (Type)memberInfo2;
	}

	private void _8AA5B881()
	{
		uint num = 2661030156u;
		D3B95303 _249383B = _2F2F02A8.ED374FBA();
		num += 3954775833u;
		_56AB72BE obj = _2F2F02A8;
		num += 1311579577;
		obj._93061C36(DC09FDAD._309061BB(_249383B));
	}

	private void _5F853100()
	{
		uint num = 1998337551u;
		do
		{
			num /= 3549067549u;
			D3B95303 d3B = _2F2F02A8.ED374FBA();
			num = 3317586967u + num;
			D3B95303 _6A96B5A = d3B;
			D3B95303 d3B2 = _2F2F02A8.ED374FBA();
			num -= 1713958199;
			D3B95303 _02B9AB9D = d3B2;
			num = 0xDE80A111u & num;
			_56AB72BE obj = _2F2F02A8;
			num |= 0xEC957A09u;
			num = 646472601 - num;
			obj._93061C36(_88BA7B16._57319600(_02B9AB9D, _6A96B5A));
		}
		while ((0xE99E512Cu & num) == 0);
	}

	private void BCBA04B2()
	{
		uint num = 1285381394u;
		while (true)
		{
			int dF039BBA = _7E8CFF31._25AC239D();
			num >>= 21;
			if (num >= 2064532791)
			{
				continue;
			}
			while (true)
			{
				num <<= 7;
				num |= 0x91AE0F8Bu;
				MemberInfo memberInfo = EDBC078C(dF039BBA);
				num = (uint)(-936009434 << (int)num);
				MemberInfo memberInfo2 = memberInfo;
				num <<= 29;
				if (memberInfo2 is Type)
				{
					_56AB72BE obj = _2F2F02A8;
					Type obj2 = (Type)memberInfo2;
					num = 4237787578u >> (int)num;
					RuntimeTypeHandle typeHandle = obj2.TypeHandle;
					num = 3694593460u / num;
					object d4108A8B = typeHandle;
					num = 3249678379u * num;
					_64267A02 a = new _64267A02(d4108A8B);
					num /= 1495953466;
					obj._93061C36(a);
					return;
				}
				if (memberInfo2 is MethodBase)
				{
					if ((0xDB2C0939u ^ num) == 0)
					{
						break;
					}
					_56AB72BE obj3 = _2F2F02A8;
					num %= 59425285;
					object d4108A8B2 = ((MethodBase)memberInfo2).MethodHandle;
					num = 4037216800u * num;
					_64267A02 a2 = new _64267A02(d4108A8B2);
					num = 4038557327u - num;
					obj3._93061C36(a2);
					if (num << 6 == 0)
					{
						break;
					}
					return;
				}
				num = 4096956343u + num;
				if (memberInfo2 is FieldInfo)
				{
					if (num == 724974342)
					{
						break;
					}
					num = 0x1C833B0B | num;
					_56AB72BE obj4 = _2F2F02A8;
					num /= 4105407290u;
					FieldInfo obj5 = (FieldInfo)memberInfo2;
					num = 2638028581u >> (int)num;
					RuntimeFieldHandle fieldHandle = obj5.FieldHandle;
					num = 59185716 % num;
					object d4108A8B3 = fieldHandle;
					num = 0x60247EB4 | num;
					obj4._93061C36(new _64267A02(d4108A8B3));
					return;
				}
				num ^= 0x5EB4A601;
				if (num / 3927523128u == 0)
				{
					throw new InvalidOperationException();
				}
			}
		}
	}

	private void _1201F809()
	{
		_56AB72BE obj = _2F2F02A8;
		uint num = 3531809159u;
		D3B95303 d3B = obj.ED374FBA();
		num |= 0xDB90FF3Du;
		D3B95303 a9A6CB = d3B;
		num -= 3592441765u;
		num %= 1231745;
		_56AB72BE obj2 = _2F2F02A8;
		num ^= 0x6401038E;
		obj2._93061C36(D51696A5._28A6C113(a9A6CB));
	}

	private A19A9A2F E6927782(int _6D09DDAE)
	{
		Dictionary<uint, object> dictionary = _81A40C9C;
		uint num = 162345475u;
		uint num5 = default(uint);
		byte[] array2 = default(byte[]);
		A19A9A2F a19A9A2F2 = default(A19A9A2F);
		Dictionary<uint, object> obj = dictionary;
		uint num2 = num ^ 0x9AD3203;
		num = 0xBD06E29Fu | num;
		bool lockTaken = (byte)num2 != 0;
		A19A9A2F result = default(A19A9A2F);
		try
		{
			num = 411406372 % num;
			if (num / 1267574696 == 0)
			{
				goto IL_0038;
			}
			goto IL_017d;
			IL_0038:
			while (true)
			{
				num = 0xAB2A1D22u & num;
				num = (uint)(-133380067 << (int)num);
				Monitor.Enter(obj, ref lockTaken);
				num += 2106800267;
				if (num * 2669874699u != 0)
				{
					while (true)
					{
						int num3 = (int)num + -899678376;
						num = 2258977465u % num;
						int num4 = _6D09DDAE | num3;
						num >>= 31;
						num5 = (uint)num4;
						if (805830973 - num == 0)
						{
							break;
						}
						Dictionary<uint, object> dictionary2 = _81A40C9C;
						num -= 1034026242;
						uint key = num5;
						num /= 2920208530u;
						object value;
						bool num6 = dictionary2.TryGetValue(key, out value);
						num = 1958620852 % num;
						if (num6)
						{
							num = 0x20146EBA ^ num;
							if (num + 3683144092u != 0)
							{
								object obj2 = value;
								num = 0xD1A5E499u | num;
								A19A9A2F obj3 = (A19A9A2F)obj2;
								num %= 2476162572u;
								result = obj3;
								if ((num ^ 0x1F38718E) == 0)
								{
									break;
								}
								goto end_IL_0038;
							}
							continue;
						}
						goto IL_0114;
					}
					continue;
				}
				goto IL_0114;
				IL_0114:
				if (3425088399u < num)
				{
					break;
				}
				Module module = _7CAA7EBD;
				num = 2351735737u + num;
				num = 0xF122C2A3u & num;
				byte[] array = module.ResolveSignature(_6D09DDAE);
				num %= 1253221926;
				array2 = array;
				num |= 0x7AE9405;
				if (3021305739u > num)
				{
					A19A9A2F a19A9A2F = new A19A9A2F();
					num = 0x31FB491 | num;
					a19A9A2F2 = a19A9A2F;
					if (2314676 * num == 0)
					{
						continue;
					}
					goto IL_017d;
				}
				break;
				continue;
				end_IL_0038:
				break;
			}
			goto end_IL_0021;
			IL_017d:
			A19A9A2F a19A9A2F3 = a19A9A2F2;
			byte[] _93B75EBB = array2;
			num >>= 1;
			Module _6DBA06A = _7CAA7EBD;
			num *= 471215635;
			a19A9A2F3.DAA1F320(_93B75EBB, _6DBA06A);
			num = 0xD293D00Au & num;
			Dictionary<uint, object> dictionary3 = _81A40C9C;
			uint key2 = num5;
			num = 1526967040 % num;
			A19A9A2F value2 = a19A9A2F2;
			num = 454366210 % num;
			dictionary3.Add(key2, value2);
			if (3031957633u <= num)
			{
				goto IL_0038;
			}
			A19A9A2F a19A9A2F4 = a19A9A2F2;
			num %= 881184158;
			result = a19A9A2F4;
			end_IL_0021:;
		}
		finally
		{
			do
			{
				bool num7 = lockTaken;
				num = 2273976246u;
				if (num7)
				{
					num += 1837585807;
					if (2251710497u >> (int)num != 0)
					{
						num |= 0x6E267220;
						Monitor.Exit(obj);
						num ^= 0x78BD68D3;
					}
				}
			}
			while (-1657666807 >>> (int)num == 0);
		}
		return result;
	}

	private void _1A319294()
	{
		uint num;
		do
		{
			num = 3641881020u;
			_56AB72BE obj = _2F2F02A8;
			num %= 2551976462u;
			obj._93061C36(_2F2F02A8._73186E25()._5C36403F());
		}
		while (num == 3222081032u);
	}

	private void C0357698()
	{
		Type type2;
		D3B95303 d3B = default(D3B95303);
		uint num;
		do
		{
			num = 1729569415u;
			C1BF430A c1BF430A = _7E8CFF31;
			num %= 2485022393u;
			Type type = _22B05086(c1BF430A._25AC239D());
			num /= 2182638005u;
			type2 = type;
			if (num <= 2189937197u)
			{
				d3B = _2F2F02A8.ED374FBA();
				D3B95303 d3B2 = d3B;
				num /= 2417318675u;
				if (!d3B2._4C0EC108())
				{
					IntPtr _7604EA = d3B._27832122();
					num |= 0xB5038FBCu;
					_3112BC99 obj = new _3112BC99(_7604EA, type2);
					num = 4096471218u * num;
					d3B = obj;
					num ^= 0xDC0130B8u;
				}
			}
		}
		while (-1417015136 == (int)num);
		_56AB72BE obj2 = _2F2F02A8;
		num %= 438117140;
		D3B95303 d3B3 = d3B;
		num &= 0xAE888E;
		num = 4264189103u * num;
		D3B95303 a = d3B3.BD15691D(type2);
		num *= 1512894996;
		obj2._93061C36(a);
	}

	private void _40122130()
	{
		uint num = 1916527247u;
		if (1973493404 / num == 0)
		{
			return;
		}
		do
		{
			num |= 0x6490D907;
			num = (uint)(1639244420 << (int)num);
			C1BF430A c1BF430A = _7E8CFF31;
			num /= 2762130689u;
			int _4F365B = c1BF430A._25AC239D();
			num = 0x2492993C ^ num;
			Type type = _22B05086(_4F365B);
			if (num == 3258303760u)
			{
				break;
			}
			num = (uint)(-1111531731 << (int)num);
			_56AB72BE obj = _2F2F02A8;
			num = 507450783 * num;
			D3B95303 d3B = obj.ED374FBA();
			object obj2 = null;
			num = 0x7D134692 | num;
			bool isValueType = type.IsValueType;
			num = (uint)(1160014863 << (int)num);
			if (isValueType)
			{
				num = 0x96225309u | num;
				Type underlyingType = Nullable.GetUnderlyingType(type);
				num = 0x160F0995 | num;
				bool num2 = underlyingType == null;
				num ^= 0x6035B9D;
				if (num2)
				{
					num = 2034204051 / num;
					num ^= 0xD6222593u;
					object uninitializedObject = FormatterServices.GetUninitializedObject(type);
					num = 0xDA02B119u | num;
					obj2 = uninitializedObject;
					num += 3524872805u;
				}
			}
			num = 0x300E830 ^ num;
			object d = obj2;
			num ^= 0x4318DD2D;
			d3B.DE8C17B9(d);
		}
		while ((0x15386037 ^ num) == 0);
	}

	public object _1CBB33BE(object[] _8836A3B7, int _17169BA9)
	{
		uint num;
		do
		{
			num = 160494611u;
			_7E8CFF31.EB3F1497(_17169BA9);
			num = 4097540870u % num;
		}
		while (num == 1737618716);
		_56AB72BE obj = _2F2F02A8;
		num -= 1907701264;
		B1A0179E a = new B1A0179E(_8836A3B7);
		num = 0xAC08C900u | num;
		obj._93061C36(a);
		object result = default(object);
		try
		{
			while (true)
			{
				num = 1226435461u;
				try
				{
					num = 2512269826u % num;
					while (true)
					{
						Dictionary<uint, A93EA20B> e52C86B = E52C86B9;
						C1BF430A c1BF430A = _7E8CFF31;
						num %= 898713992;
						byte key = c1BF430A._1799AE0F();
						num = 2677796751u % num;
						A93EA20B a93EA20B = e52C86B[key];
						num = 2151480966u - num;
						a93EA20B();
						C1BF430A c1BF430A2 = _7E8CFF31;
						num = (uint)(-745686875 << (int)num);
						int num2 = c1BF430A2._6188C297();
						num = 3273732521u + num;
						if (num2 == 0)
						{
							if ((num ^ 0x27B5D510) != 0)
							{
								goto end_IL_0046;
							}
							continue;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					do
					{
						if (_3019FA32 == null)
						{
							num = 170745602u;
							num = (uint)(-1322385743 << (int)num);
							_94961F94 = ex;
						}
						num = 3633702691u;
						A815111A();
					}
					while (num <= 1779827998);
				}
				continue;
				end_IL_0046:
				break;
			}
			num = 2251840413u;
			if (514690225 != num)
			{
				_56AB72BE obj2 = _2F2F02A8;
				num *= 2124575400;
				object obj3 = obj2.ED374FBA()._9F320096();
				num &= 0x7B3A780A;
				result = obj3;
			}
		}
		finally
		{
			List<IntPtr> list = _162873A6;
			num = 2449867417u;
			List<IntPtr>.Enumerator enumerator = list.GetEnumerator();
			num = 3208511167u * num;
			List<IntPtr>.Enumerator enumerator2 = enumerator;
			try
			{
				if (num != 1586720425)
				{
				}
				while (true)
				{
					num = 2276525222u / num;
					if (num != 3129611790u)
					{
						bool num3 = enumerator2.MoveNext();
						num = 2332589986u * num;
						if (num3)
						{
							num = 3909234064u;
							num |= 0xADA20233u;
							IntPtr current = enumerator2.Current;
							num ^= 0xE501E091u;
							Marshal.FreeHGlobal(current);
							num ^= 0xA6277105u;
						}
						else if (num != 2168278956u)
						{
							break;
						}
					}
				}
			}
			finally
			{
				do
				{
					num = 864584328u;
					((IDisposable)enumerator2/*cast due to constrained. prefix*/).Dispose();
				}
				while ((num & 0x6691012C) == 0);
			}
			num = 4221500574u;
			_162873A6.Clear();
		}
		num = 505361456u;
		return result;
	}

	private void _442EF021()
	{
		uint num = 339713087u;
		Type type = _22B05086(_7E8CFF31._25AC239D());
		num /= 3158135176u;
		Type elementType = type;
		if (num << 18 == 0)
		{
			do
			{
				num |= 0xB5B1D9BFu;
				_56AB72BE obj = _2F2F02A8;
				num = 0x5D01A5BA ^ num;
				num %= 1074833579;
				num /= 705759931;
				_56AB72BE obj2 = _2F2F02A8;
				num = 0x301983AD ^ num;
				int length = obj2.ED374FBA()._6527EC0E();
				num = 2494665115u * num;
				Array _04B76AB = Array.CreateInstance(elementType, length);
				num = 92452513 + num;
				obj._93061C36(new B1A0179E(_04B76AB));
			}
			while (3901633076u < num);
		}
	}

	private void _8D87761A()
	{
		uint num = 596954807u;
		num = 949457848 * num;
		_56AB72BE obj = _2F2F02A8;
		num ^= 0x793A8798;
		D3B95303 _3F06F = obj.ED374FBA();
		num /= 3767342088u;
		do
		{
			D3B95303 _0B11B = _2F2F02A8.ED374FBA();
			num += 3399297967u;
			_2F2F02A8._93061C36(D51696A5._4CAC8707(_0B11B, _3F06F));
		}
		while ((int)num + -1222109030 == 0);
	}

	private void _903894BF()
	{
		uint num = 3978624541u;
		Type type2 = default(Type);
		if (num != 867256869)
		{
			goto IL_0011;
		}
		goto IL_004e;
		IL_0011:
		num = 0xC4AC2EB6u & num;
		num ^= 0xF28C9A9Eu;
		int _4F365B = _7E8CFF31._25AC239D();
		num |= 0x19AC572D;
		Type type = _22B05086(_4F365B);
		num >>= 17;
		type2 = type;
		if (num > 221088923)
		{
			return;
		}
		goto IL_004e;
		IL_004e:
		while (true)
		{
			num = 1477356571 / num;
			_56AB72BE obj = _2F2F02A8;
			num = 0xBA172BB & num;
			D3B95303 d3B = obj.ED374FBA();
			num -= 1774167471;
			D3B95303 d3B2 = d3B;
			if ((0x3B8DD932 ^ num) == 0)
			{
				break;
			}
			num = 0xA9BE08F ^ num;
			D3B95303 d3B3 = _2F2F02A8.ED374FBA();
			num &= 0x7350C02;
			D3B95303 d3B4 = d3B3;
			_56AB72BE obj2 = _2F2F02A8;
			num %= 3967954985u;
			D3B95303 d3B5 = obj2.ED374FBA();
			num -= 1998029488;
			Array obj3 = d3B5._9F320096() as Array;
			num ^= 0x7628F71F;
			if (obj3 == null)
			{
				throw new ArgumentException();
			}
			num |= 0x62B2E18;
			D3B95303 d3B6 = d3B2;
			num |= 0x4D3AA489;
			Type f809DF = type2;
			num = 2652532764u >> (int)num;
			d3B2 = d3B6.BD15691D(f809DF);
			Type type3 = obj3.GetType();
			num <<= 2;
			Type elementType = type3.GetElementType();
			Type type4 = type2;
			num |= 0x7521B687;
			if (type4 != elementType)
			{
				num *= 3140307748u;
				D3B95303 d3B7 = d3B2;
				num += 1873117112;
				D3B95303 d3B8 = d3B7.BD15691D(elementType);
				num = (uint)(-803533941 << (int)num);
				d3B2 = d3B8;
				num ^= 0xCD91B687u;
			}
			num &= 0xDAB25924u;
			object value = d3B2._9F320096();
			num = 4238882096u >> (int)num;
			int index = d3B4._6527EC0E();
			num &= 0x363D363A;
			obj3.SetValue(value, index);
			if (3365463426u % num != 0)
			{
				return;
			}
		}
		goto IL_0011;
	}

	private void A43285A0()
	{
		uint num = 2023270308u;
		D3B95303 d3B2 = default(D3B95303);
		if (1269446786 % num != 0)
		{
			num = 638029994u >> (int)num;
			_56AB72BE obj = _2F2F02A8;
			num <<= 24;
			D3B95303 d3B = obj.ED374FBA();
			num = 1294139573 % num;
			d3B2 = d3B;
			num |= 0xE19CA50Cu;
			if (825469473 << (int)num == 0)
			{
				return;
			}
		}
		_56AB72BE obj2 = _2F2F02A8;
		D3B95303 d3B3 = d3B2;
		num = 0xCEB72C26u & num;
		D3B95303 d3B4 = d3B2;
		num = (uint)(429107384 << (int)num);
		Type f809DF = d3B4.D293A3AF();
		num *= 305301137;
		obj2._93061C36(d3B3.BD15691D(f809DF));
	}

	private void _8C05239F()
	{
		Type type2;
		uint num;
		do
		{
			num = 3013889720u;
			num = 1226654390 - num;
			int _4F365B = _7E8CFF31._25AC239D();
			num -= 2829645986u;
			Type type = _22B05086(_4F365B);
			num = 92505100 % num;
			type2 = type;
		}
		while (num / 4097394725u != 0);
		num &= 0x7D1B720A;
		D3B95303 d3B = _2F2F02A8.ED374FBA();
		num = 1220233511 % num;
		object obj = d3B._9F320096();
		num = 0x7E210638 & num;
		object obj2 = obj;
		Type type3 = obj2.GetType();
		num = 1720252166 - num;
		num /= 346098858;
		if (type3 != type2)
		{
			num = 0x3507F617 | num;
			bool num2 = type2.IsAssignableFrom(type3);
			num = 0x668B3D9F & num;
			num ^= 0x24033413;
			if (!num2)
			{
				throw new InvalidCastException();
			}
		}
		_56AB72BE obj3 = _2F2F02A8;
		num = 0x45951297 ^ num;
		obj3._93061C36(D3B95303._6388BF9A(obj2, type2));
	}

	private void D19B343F()
	{
		while (true)
		{
			uint num = 4228352393u;
			short _348F = _7E8CFF31._5F10D3B8();
			num = 0xAD9C0B3Cu | num;
			_56AB72BE obj = _2F2F02A8;
			num = 0xFF94998Fu ^ num;
			int _4F365B = obj.ED374FBA()._6527EC0E();
			num <<= 27;
			Type type = _22B05086(_4F365B);
			num /= 3752062221u;
			Type type2 = type;
			num = 0xE91516A1u | num;
			if (num < 3885720075u)
			{
				continue;
			}
			D3B95303 d3B = _2F2F02A8.ED374FBA();
			num ^= 0x9DBEAD0Cu;
			D3B95303 d3B2 = _2F2F02A8.ED374FBA();
			num %= 3902868249u;
			D3B95303 d3B3 = d3B2;
			num = (uint)(-1465041384 << (int)num);
			if (num < 2435208214u)
			{
				continue;
			}
			D3B95303 d3B4 = d3B3;
			num = 0xC98B4DA9u & num;
			object obj2 = d3B4._9F320096();
			num *= 2417531576u;
			object obj3 = obj2;
			num <<= 23;
			if (obj3 == null)
			{
				bool isValueType = type2.IsValueType;
				num = 0xAD895F80u ^ num;
				num += 1383506048;
				if (isValueType)
				{
					num <<= 14;
					if (num >= 3945021960u)
					{
						continue;
					}
					num = 520589741 + num;
					object obj4 = Activator.CreateInstance(type2);
					num = 1637874097 - num;
					obj3 = obj4;
					num ^= 0x42986804;
				}
			}
			num += 3392764938u;
			object _4BB13A1A = obj3;
			num = (uint)(-519178706 << (int)num);
			num >>= 25;
			d3B3 = D3B95303._6388BF9A(_4BB13A1A, type2);
			num *= 2290520751u;
			bool num2 = d3B._4C0EC108();
			num -= 353792034;
			if (num2)
			{
				num = 1529492522 + num;
				D3B95303 eC8DB8B = d3B3;
				num = 252600743 - num;
				num = 1293223046u >> (int)num;
				C2916D0F c2916D0F = new C2916D0F(eC8DB8B, d3B);
				num &= 0xE20F4320u;
				d3B3 = c2916D0F;
				num += 1360512851;
			}
			num = 974513971u >> (int)num;
			_2F2F02A8._30095C38(_348F, d3B3);
			if (599043459 * num != 0)
			{
				break;
			}
		}
	}

	private void _8D828EA2()
	{
		while (true)
		{
			D3B95303 _5B2C = _2F2F02A8.ED374FBA();
			uint num = 2193607597u;
			if (730144816 < num)
			{
				_56AB72BE obj = _2F2F02A8;
				num = (uint)(1076866236 << (int)num);
				D3B95303 _0DB916B = obj.ED374FBA();
				num = 4206823695u + num;
				_56AB72BE obj2 = _2F2F02A8;
				num = 3138027577u % num;
				num <<= 4;
				obj2._93061C36(_2038A6B3._979DC792(_0DB916B, _5B2C));
				if (num * 3526434226u != 0)
				{
					break;
				}
			}
		}
	}

	private MemberInfo EDBC078C(int DF039BBA)
	{
		Dictionary<uint, object> obj = _81A40C9C;
		bool lockTaken = false;
		MemberInfo result = default(MemberInfo);
		uint num;
		try
		{
			num = 570519353u;
			if (3349843975u >= num)
			{
				goto IL_001a;
			}
			goto IL_0032;
			IL_001a:
			num = 3087265465u * num;
			num = 2996703417u % num;
			Monitor.Enter(obj, ref lockTaken);
			goto IL_0032;
			IL_0032:
			if (1577565882 % num == 0)
			{
				goto IL_001a;
			}
			Dictionary<uint, object> dictionary = _81A40C9C;
			num /= 2853207726u;
			if (dictionary.TryGetValue((uint)DF039BBA, out var value))
			{
				object obj2 = value;
				num = 0xE7052112u ^ num;
				MemberInfo obj3 = (MemberInfo)obj2;
				num = 3432096005u >> (int)num;
				result = obj3;
			}
			else
			{
				Module module = _7CAA7EBD;
				num = 0xB9185B08u | num;
				MemberInfo memberInfo = module.ResolveMember(DF039BBA);
				num = 1838122382 / num;
				MemberInfo memberInfo2 = memberInfo;
				num |= 0x8C1B95B5u;
				if (num >> 3 != 0)
				{
					Dictionary<uint, object> dictionary2 = _81A40C9C;
					num |= 0x2A3E6E23;
					num = 681375899 - num;
					dictionary2.Add((uint)DF039BBA, memberInfo2);
					num |= 0xB0AA7831u;
					result = memberInfo2;
				}
			}
		}
		finally
		{
			do
			{
				IL_00dd:
				bool num2 = lockTaken;
				num = 1687290556u;
				if (num2)
				{
					num = 118682409 * num;
					if ((0x5D222310 ^ num) == 0)
					{
						goto IL_00dd;
					}
					Monitor.Exit(obj);
					num ^= 0x6DA0E6A0;
				}
			}
			while (876216708 + num == 0);
		}
		num = 2233526661u;
		return result;
	}

	private void _6C051AB3()
	{
		while (true)
		{
			uint num = 2323696033u;
			D3B95303 d3B = _2F2F02A8.ED374FBA();
			num /= 4021794572u;
			D3B95303 _12A8FFA = d3B;
			if (num / 792202538 == 0)
			{
				_2F2F02A8._93061C36(_85140483.A333E7A5(_12A8FFA));
				if (462432057 > num)
				{
					break;
				}
			}
		}
	}

	private void _52BD83B3()
	{
		Type[] array2 = default(Type[]);
		object[] array5 = default(object[]);
		Dictionary<int, D3B95303> dictionary = default(Dictionary<int, D3B95303>);
		int num11 = default(int);
		DynamicMethod value = default(DynamicMethod);
		int num17 = default(int);
		ILGenerator iLGenerator2 = default(ILGenerator);
		object obj3 = default(object);
		while (true)
		{
			IL_0000:
			uint num = 580946569u;
			C1BF430A c1BF430A = _7E8CFF31;
			num = 0x880C7E23u ^ num;
			int _6D09DDAE = c1BF430A._25AC239D();
			num /= 1327286022;
			A19A9A2F a19A9A2F = E6927782(_6D09DDAE);
			if (-583173997 >>> (int)num == 0)
			{
				break;
			}
			while (true)
			{
				if (!a19A9A2F.A1806235)
				{
					num /= 2366301212u;
					if (num <= 699215642)
					{
						break;
					}
				}
				int num2 = (int)num + -2;
				num = (uint)(1258760255 << (int)num);
				BindingFlags invokeAttr = (BindingFlags)num2;
				num -= 1862937361;
				Type[] array = a19A9A2F._1E8FD139();
				num %= 3045365941u;
				if (num < 2391600171u)
				{
					num = 876507141 - num;
					IntPtr intPtr = (nint)array.LongLength;
					num = 2075382801 / num;
					int num3 = (int)(nint)intPtr;
					uint num4 = num ^ 3;
					num -= 739373859;
					int num5 = num3 + (int)num4;
					num = (uint)(-232189539 << (int)num);
					array2 = new Type[num5];
					if (-1960237430 == (int)num)
					{
						goto IL_0000;
					}
					num = 0x18AFC60C | num;
					array.CopyTo(array2, (int)num ^ -1733310964);
					Type[] array3 = array2;
					num = 1956118591 * num;
					int num6 = array.Length;
					num = 1790695834 - num;
					array3[num6] = typeof(IntPtr);
					num = (uint)(-1900718575 << (int)num);
					if (3985593918u <= num)
					{
						continue;
					}
					Type[] array4 = array2;
					num = (uint)(-785630427 << (int)num);
					IntPtr intPtr2 = (nint)array4.LongLength;
					num = 4215043215u % num;
					int num7 = (int)(nint)intPtr2;
					num <<= 8;
					array5 = new object[num7];
					num *= 1687095310;
					if (num == 3005493514u)
					{
						goto IL_0000;
					}
					dictionary = new Dictionary<int, D3B95303>();
					if (2786398869u >= num)
					{
						goto IL_0000;
					}
				}
				_6293582D obj = new _6293582D();
				num = 2822403877u * num;
				_6293582D _6293582D2 = obj;
				try
				{
					num <<= 0;
					if (1871083910u >> (int)num != 0)
					{
						goto IL_01db;
					}
					goto IL_0221;
					IL_01db:
					object[] array6 = array5;
					num += 3256960151u;
					IntPtr intPtr3 = (nint)array6.LongLength;
					num = 0x1533E4AA & num;
					int num8 = (int)(nint)intPtr3;
					num = 0x4216627 | num;
					uint num9 = num ^ 0x1431E6A6;
					num = 0x2E3FFF87 ^ num;
					int num10 = num8 - (int)num9;
					num = 0x5BAAD8BC | num;
					num11 = num10;
					goto IL_03b6;
					IL_03b6:
					while (true)
					{
						int num12 = num11;
						uint num13 = num ^ 0x7BAED9BC;
						num &= 0x34B7A4BE;
						if (num12 >= (int)num13)
						{
							break;
						}
						if ((num ^ 0x233721AF) == 0)
						{
							continue;
						}
						Dictionary<object, DynamicMethod> dictionary2 = _58A84F99;
						num ^= 0xAF93C89Fu;
						Dictionary<object, DynamicMethod> obj2 = dictionary2;
						num = 528900631u >> (int)num;
						uint num14 = num ^ 0x3F0CC42;
						num ^= 0xDA2FB885u;
						bool lockTaken = (byte)num14 != 0;
						try
						{
							if (2183221645u >> (int)num != 0)
							{
								goto IL_0422;
							}
							goto IL_044a;
							IL_0422:
							num |= 0xEFA85D94u;
							Monitor.Enter(obj2, ref lockTaken);
							num &= 0xA48D672Cu;
							if (num != 3331765665u)
							{
								goto IL_044a;
							}
							goto IL_05da;
							IL_044a:
							while (true)
							{
								Dictionary<object, DynamicMethod> dictionary3 = _58A84F99;
								num = 3760529 % num;
								num = 0xC82B8D80u | num;
								num = 4163988746u % num;
								bool num15 = dictionary3.TryGetValue(a19A9A2F, out value);
								num *= 269828020;
								if (num15)
								{
									break;
								}
								if (3878911393u < num)
								{
									continue;
								}
								goto IL_0491;
							}
							goto IL_06f4;
							IL_061b:
							num <<= 21;
							int num16 = num17;
							num %= 2459778363u;
							Type[] array7 = array2;
							num = 0x3A10FE3E & num;
							IntPtr intPtr4 = (nint)array7.LongLength;
							num >>= 24;
							if (num16 < (int)(nint)intPtr4)
							{
								ILGenerator iLGenerator = iLGenerator2;
								num = 2041650351u;
								Dictionary<int, D3B95303> dictionary4 = dictionary;
								num = 3702444309u >> (int)num;
								int key = num17;
								num += 2897411736u;
								bool num18 = dictionary4.ContainsKey(key);
								num >>= 27;
								OpCode opcode;
								if (!num18)
								{
									opcode = OpCodes.Ldarg;
								}
								else
								{
									opcode = OpCodes.Ldarga;
									num ^= 0;
								}
								iLGenerator.Emit(opcode, num17);
								num = 0x202AC91B ^ num;
								if (4205182224u / num != 0)
								{
									goto IL_05da;
								}
							}
							else
							{
								num = 2459593881u - num;
								if (2176713657u >> (int)num != 0)
								{
									ILGenerator iLGenerator3 = iLGenerator2;
									OpCode calli = OpCodes.Calli;
									num = 0x39A6363A | num;
									CallingConvention unmanagedCallConv = a19A9A2F._8939B299;
									Type returnType = a19A9A2F._5F8F8080;
									num = 975734456 * num;
									num ^= 0xC9237534u;
									iLGenerator3.EmitCalli(calli, unmanagedCallConv, returnType, array);
									num >>= 30;
									if (2081628720 * num == 0)
									{
										ILGenerator iLGenerator4 = iLGenerator2;
										num = 0x5081DF9E ^ num;
										iLGenerator4.Emit(OpCodes.Ret);
										num = 0xF2CB403 ^ num;
										_58A84F99.Add(a19A9A2F, value);
										num += 3359374455u;
										goto IL_06f4;
									}
								}
							}
							goto IL_0422;
							IL_0491:
							do
							{
								num ^= 0x5F2CD616;
								Type type = a19A9A2F._5F8F8080;
								num <<= 27;
								num ^= 0x94996B2Bu;
								bool num19 = type != typeof(void);
								num *= 1990932283;
								object returnType2;
								if (!num19)
								{
									num = 0x3F019395 | num;
									returnType2 = null;
								}
								else
								{
									num = 4111235746u / num;
									returnType2 = a19A9A2F._5F8F8080;
									num ^= 0xFF1BFFFCu;
								}
								Type[] parameterTypes = array2;
								num = (uint)(-921262146 << (int)num);
								value = new DynamicMethod("", (Type)returnType2, parameterTypes, typeof(_02B4022E).Module, (byte)(num ^ 0xC0000001u) != 0);
								iLGenerator2 = value.GetILGenerator();
								num = (uint)(-1383183839 << (int)num);
								num17 = (int)num - -1383183839;
							}
							while (2536970682u >= num);
							goto IL_061b;
							IL_05da:
							int num20 = num17;
							num = 50771090u >> (int)num;
							int num21 = (int)num + -3097;
							num = (uint)(-308160458 << (int)num);
							int num22 = num20 + num21;
							num = 1862766395 / num;
							num17 = num22;
							num ^= 0xAD8E4A21u;
							goto IL_061b;
							IL_06f4:
							if (num * 964767261 == 0)
							{
								goto IL_0422;
							}
						}
						finally
						{
							while (true)
							{
								num = 704673929u;
								bool num23 = lockTaken;
								num = 2316387108u * num;
								if (num23)
								{
									num = 3627651646u >> (int)num;
									if (3903550383u * num != 0)
									{
										num = 2537043713u + num;
										Monitor.Exit(obj2);
										num ^= 0x460E1E60;
										break;
									}
									continue;
								}
								break;
							}
						}
						num = 3744304026u;
						if ((num ^ 0x9FB38724u) != 0)
						{
							DynamicMethod dynamicMethod = value;
							num += 4246074658u;
							object[] parameters = array5;
							num <<= 3;
							obj3 = dynamicMethod.Invoke(null, invokeAttr, null, parameters, null);
							num = 126837251 - num;
						}
						Dictionary<int, D3B95303>.Enumerator enumerator = dictionary.GetEnumerator();
						num %= 2260190735u;
						Dictionary<int, D3B95303>.Enumerator enumerator2 = enumerator;
						try
						{
							while (true)
							{
								num -= 981728900;
								if (num > 1562964630)
								{
									bool num24 = enumerator2.MoveNext();
									num %= 2276528787u;
									if (!num24)
									{
										break;
									}
								}
								KeyValuePair<int, D3B95303> current = enumerator2.Current;
								num = 305698071u;
								KeyValuePair<int, D3B95303> keyValuePair = current;
								if (num - 2771638973u != 0)
								{
									D3B95303 value2 = keyValuePair.Value;
									num -= 2503712184u;
									object[] array8 = array5;
									num = 3158053931u >> (int)num;
									object d = array8[keyValuePair.Key];
									num |= 0xA0200593u;
									value2.DE8C17B9(d);
									num ^= 0x855359B0u;
								}
							}
						}
						finally
						{
							do
							{
								num = 4038167349u;
								if (3894871041u - num != 0)
								{
									((IDisposable)enumerator2/*cast due to constrained. prefix*/).Dispose();
									continue;
								}
								break;
							}
							while ((num & 0x4ABAE389) == 0);
						}
						Type type2 = a19A9A2F._5F8F8080;
						num = 748745018u;
						Type typeFromHandle = typeof(void);
						num /= 4220257714u;
						bool num25 = type2 != typeFromHandle;
						num = 0x5E39ACBC & num;
						if (num25 && num % 488945719 == 0)
						{
							_56AB72BE obj4 = _2F2F02A8;
							object _4BB13A1A = obj3;
							num = 3048416642u - num;
							Type _80349F = a19A9A2F._5F8F8080;
							num >>= 26;
							D3B95303 a = D3B95303._6388BF9A(_4BB13A1A, _80349F);
							num ^= 0x24268D83;
							obj4._93061C36(a);
							num += 3688460882u;
						}
						return;
					}
					goto IL_0221;
					IL_0221:
					Type[] array9 = array2;
					num = 270539058u;
					Type obj5 = array9[num11];
					num = (uint)(169691570 << (int)num);
					Type type3 = obj5;
					num = 1796504451u >> (int)num;
					if (num != 554108854)
					{
						num += 3617110298u;
						_56AB72BE obj6 = _2F2F02A8;
						num &= 0x789C3B09;
						D3B95303 d3B = obj6.ED374FBA();
						num &= 0xF80F119;
						D3B95303 d3B2 = d3B;
						num = 4188066072u - num;
						num ^= 0x4D8F9433;
						if (d3B2._4C0EC108())
						{
							if (!type3.IsByRef)
							{
								object[] array10 = array5;
								int num26 = num11;
								num >>= 13;
								object _37305BB = d3B2._9F320096();
								num %= 2923391126u;
								IntPtr intPtr5 = _6293582D2._6E21DE0F(_37305BB);
								num <<= 15;
								object obj7 = intPtr5;
								num = 3700346770u - num;
								array10[num26] = obj7;
								if (num / 2080830339 != 0)
								{
									goto IL_01db;
								}
								goto IL_0395;
							}
							Dictionary<int, D3B95303> dictionary5 = dictionary;
							num = 1939530251 * num;
							int key2 = num11;
							num = (uint)(-134149888 << (int)num);
							num = (uint)(-618287444 << (int)num);
							dictionary5[key2] = d3B2;
							num ^= 0x6F8A9B90;
						}
						num *= 3845621035u;
						if ((0xD72601BFu & num) != 0)
						{
							object[] array11 = array5;
							num = 2511656214u - num;
							int num27 = num11;
							num = 0x2612D01D | num;
							D3B95303 d3B3 = d3B2.BD15691D(type3);
							num += 361723173;
							array11[num27] = d3B3._9F320096();
							num += 3028804174u;
							goto IL_0395;
						}
					}
					goto IL_01db;
					IL_0395:
					num = 1941839650 % num;
					num11 -= (int)(num - 129283035);
					num ^= 0x7C1A6A60;
					goto IL_03b6;
				}
				finally
				{
					do
					{
						num = 1905635595u;
						if (num >> 22 != 0)
						{
							_6293582D2.Dispose();
							continue;
						}
						break;
					}
					while (2025057157 / num == 0);
				}
			}
			break;
		}
		throw new ArgumentException();
	}

	private void B03BFD10()
	{
		D3B95303 c7AB = _2F2F02A8.ED374FBA();
		uint num = 3583067310u;
		_56AB72BE obj = _2F2F02A8;
		num |= 0x2B1A61C;
		obj._93061C36(_3C352A26._1E334C1A(c7AB));
	}

	private void A41F95A0()
	{
		uint num = 3342616074u;
		D3B95303 d3B = _2F2F02A8.ED374FBA();
		num += 211753477;
		D3B95303 _37307B = d3B;
		num = 0x7C13F59E & num;
		num = (uint)(-1674387656 << (int)num);
		_56AB72BE obj = _2F2F02A8;
		D3B95303 a = D3B95303._72358E28(_37307B);
		num = 874609166 + num;
		obj._93061C36(a);
	}

	private void _67B61426()
	{
		D3B95303 d3B = _2F2F02A8.ED374FBA();
		uint num = 1385637298u;
		D3B95303 _8A03C0AB = d3B;
		num += 4179079712u;
		while (true)
		{
			num &= 0x71A2F335;
			_56AB72BE obj = _2F2F02A8;
			num = 0xA70C2D26u | num;
			D3B95303 d3B2 = obj.ED374FBA();
			num = 2107495705u >> (int)num;
			D3B95303 fB08F9BB = d3B2;
			num &= 0x8A8A7922u;
			if (3099023022u >= num)
			{
				num = 3995743500u % num;
				_56AB72BE obj2 = _2F2F02A8;
				D3B95303 a = _88BA7B16.D23D7BA5(fB08F9BB, _8A03C0AB);
				num = (uint)(-317225685 << (int)num);
				obj2._93061C36(a);
				if (1184343852 + num != 0)
				{
					break;
				}
			}
		}
	}

	private void _2FB41ABD()
	{
		while (true)
		{
			D3B95303 d3B = _2F2F02A8.ED374FBA();
			uint num = 2847725739u;
			D3B95303 _9B275F = d3B;
			if (1594817059 > num)
			{
				continue;
			}
			num |= 0x33379A0F;
			D3B95303 c73B1E9E = _2F2F02A8.ED374FBA();
			num >>= 22;
			if (3430953879u > num)
			{
				_56AB72BE obj = _2F2F02A8;
				num = 0x2D82D083 & num;
				num >>= 6;
				D3B95303 a = D51696A5._9F01DB27(c73B1E9E, _9B275F);
				num *= 3032127925u;
				obj._93061C36(a);
				if (num >= 940654898)
				{
					break;
				}
			}
		}
	}

	private void _9780C019()
	{
		D3B95303 bF3AC42B;
		D3B95303 fAB08FA;
		uint num;
		do
		{
			num = 2604101387u;
			_56AB72BE obj = _2F2F02A8;
			num *= 3776172461u;
			D3B95303 d3B = obj.ED374FBA();
			num = 2770656178u + num;
			bF3AC42B = d3B;
			num = 3499210414u / num;
			num |= 0xD4A1519Fu;
			_56AB72BE obj2 = _2F2F02A8;
			num = (uint)(-1005623540 << (int)num);
			fAB08FA = obj2.ED374FBA();
			num += 2529039361u;
		}
		while (num == 4027478453u);
		num = 3048380814u % num;
		_56AB72BE obj3 = _2F2F02A8;
		num = 1420583428 % num;
		D3B95303 a = B7035AA0._44818004(fAB08FA, bF3AC42B);
		num = 4001454878u / num;
		obj3._93061C36(a);
	}

	private void ED048E22()
	{
		D3B95303 d3B = _2F2F02A8.ED374FBA();
		uint num = 77008188u;
		D3B95303 bB = d3B;
		_56AB72BE obj = _2F2F02A8;
		num += 2619883322u;
		D3B95303 d3B2 = obj.ED374FBA();
		num <<= 18;
		D3B95303 bB2F481E = d3B2;
		num -= 2871886124u;
		_56AB72BE obj2 = _2F2F02A8;
		num = 2636410673u + num;
		num /= 3331996060u;
		D3B95303 a = _88BA7B16._6A122385(bB2F481E, bB);
		num &= 0xBC2B24ABu;
		obj2._93061C36(a);
	}

	private void _4C8AE007()
	{
		uint num = 1631493172u;
		D3B95303 b82EA5A = default(D3B95303);
		D3B95303 c6B665BB = default(D3B95303);
		if (1319758857 < num)
		{
			D3B95303 d3B = _2F2F02A8.ED374FBA();
			num = 866614402 * num;
			b82EA5A = d3B;
			if (606357011 <= num)
			{
				num = 0x2DA9789D & num;
				c6B665BB = _2F2F02A8.ED374FBA();
				num = 0xC784E42Bu ^ num;
			}
		}
		_2F2F02A8._93061C36(_88BA7B16.AB230425(c6B665BB, b82EA5A));
	}

	private MethodBase _239CD025(int ECAA7B3D)
	{
		uint num = 2197979398u;
		MemberInfo memberInfo2 = default(MemberInfo);
		if (3682888583u >= num)
		{
			num = 2327405875u + num;
			MemberInfo memberInfo = EDBC078C(ECAA7B3D);
			num >>= 1;
			memberInfo2 = memberInfo;
			num <<= 0;
		}
		MemberInfo memberInfo3 = memberInfo2;
		num += 807883780;
		MethodBase obj = memberInfo3 as MethodBase;
		num %= 2131126680;
		if ((object)obj != null)
		{
			num &= 0xFD27B31Eu;
			MemberInfo memberInfo4 = memberInfo2;
			num |= 0x6729B0B4;
			return (MethodBase)memberInfo4;
		}
		num = 1125568062u >> (int)num;
		throw new InvalidOperationException();
	}

	private void _4E95E919()
	{
		D3B95303 bA89639B;
		uint num;
		do
		{
			num = 1832067841u;
			D3B95303 d3B = _2F2F02A8.ED374FBA();
			num = 288241314 % num;
			bA89639B = d3B;
		}
		while ((num & 0xD03BB916u) == 0);
		D3B95303 _1D37CF;
		do
		{
			_56AB72BE obj = _2F2F02A8;
			num &= 0x18B73685;
			_1D37CF = obj.ED374FBA();
			num = 2193235607u - num;
		}
		while (num / 4005531530u != 0);
		_56AB72BE obj2 = _2F2F02A8;
		num -= 1923041036;
		D3B95303 a = DC09FDAD._783C793A(_1D37CF, bA89639B);
		num %= 1169892130;
		obj2._93061C36(a);
	}

	private void A815111A()
	{
		uint num = 1923427731u;
		List<_589EC5AE> list = default(List<_589EC5AE>);
		if (-536046715 != (int)num)
		{
			goto IL_0013;
		}
		goto IL_00ca;
		IL_0013:
		num = 1806546854 / num;
		_56AB72BE obj = _2F2F02A8;
		num = 2912372661u >> (int)num;
		obj._3A89F3AD();
		goto IL_0038;
		IL_0038:
		_7E8CFF31.F2BA751B();
		goto IL_05bf;
		IL_05bf:
		while (388590120 * num != 0)
		{
			num ^= 0x4A34CF0F;
			_3209E1AD obj2 = _7D13B119;
			num = 1639594908 / num;
			int num2 = obj2._610B25B5();
			num = 3081237561u >> (int)num;
			if (num2 != 0)
			{
				num = 1570200588u;
				_3209E1AD obj3 = _7D13B119;
				num &= 0xD40EE6BDu;
				list = obj3._149F651B().B51C242D();
				num /= 825377286;
				if (_3019FA32 != null)
				{
					num = 3820535612u / num;
					if (413341497 << (int)num == 0)
					{
						continue;
					}
					goto IL_009c;
				}
				goto IL_00ca;
			}
			if (num < 3040025010u)
			{
				break;
			}
			num = 2562375325u / num;
			throw _94961F94;
		}
		goto IL_0013;
		IL_0228:
		_7D13B119._4781133B();
		_589EC5AE _589EC5AE2;
		if (num % 1686174863 != 0)
		{
			_56AB72BE obj4 = _2F2F02A8;
			Exception _04B76AB = _94961F94;
			num *= 1460898474;
			B1A0179E a = new B1A0179E(_04B76AB);
			num = 2996807579u * num;
			obj4._93061C36(a);
			num ^= 0xB2010C03u;
			if (1270468754 << (int)num != 0)
			{
				num ^= 0xE603E82Bu;
				C1BF430A c1BF430A = _7E8CFF31;
				num ^= 0xADB81D3Eu;
				c1BF430A.EB3F1497(_589EC5AE2._923D8C35());
				if (1251776789 / num == 0)
				{
					return;
				}
				goto IL_0038;
			}
		}
		goto IL_0013;
		IL_03d4:
		num >>= 8;
		_7D13B119._4781133B();
		num = 0x9D07DD3Eu | num;
		num += 2467803542u;
		if ((num & 0x21086589) == 0)
		{
			goto IL_0038;
		}
		List<_589EC5AE> list2 = list;
		num = 1250339513 % num;
		int num9;
		int num10;
		for (int num3 = list2.Count; num * 3727368337u != 0; num9 = num3, num = 2500786456u % num, num10 = (int)num ^ -1794180839, num = 0xCE297B91u & num, num3 = num9 - num10, num += 2522784469u)
		{
			int num4 = num3;
			int num5 = (int)num + -442964965;
			num = 3557922178u * num;
			if (num4 > num5)
			{
				num = 1611964342u;
				if (-2059428164 == (int)num)
				{
					break;
				}
				List<_589EC5AE> list3 = list;
				num = 1444175905 / num;
				int num6 = num3;
				num &= 0x5307FC3D;
				_589EC5AE obj5 = list3[num6 - (int)(num ^ 1)];
				num = 792455958 * num;
				_589EC5AE _589EC5AE3 = obj5;
				num = 0x2098D727 & num;
				if (_589EC5AE3._1EB6C302() != num + 2)
				{
					num /= 1191189949;
					byte num7 = _589EC5AE3._1EB6C302();
					num <<= 25;
					int num8 = (int)num - -4;
					num = 2728003738u >> (int)num;
					if (num7 != num8)
					{
						continue;
					}
					num += 1566963558;
				}
				num -= 3451549354u;
				num = 1871247154 % num;
				C1BF430A c1BF430A2 = _7E8CFF31;
				num = 93757628 % num;
				int _1130EF = _589EC5AE3._923D8C35();
				num = 0xBB1DE6AFu | num;
				c1BF430A2._05903409(_1130EF);
				num += 3808043483u;
				continue;
			}
			goto IL_055b;
		}
		goto IL_05bf;
		IL_00ca:
		int num11 = (int)num + -1;
		num ^= 0xE496D9;
		goto IL_00dc;
		IL_055b:
		num %= 2819770811u;
		if (num == 1486914349)
		{
			goto IL_0038;
		}
		num &= 0x491A648C;
		int num12 = _7E8CFF31.F090B89A();
		num = 1988834603 * num;
		num ^= 0x21B33431;
		if (num12 != 0)
		{
			num *= 690396426;
			C1BF430A c1BF430A3 = _7E8CFF31;
			num *= 228424724;
			c1BF430A3._59203CB6();
			return;
		}
		goto IL_05bf;
		IL_009c:
		List<_589EC5AE> list4 = list;
		num = 0x5192A228 | num;
		_589EC5AE item = _3019FA32;
		num %= 1018530329;
		num11 = list4.IndexOf(item) + (int)(num - 14980823);
		goto IL_00dc;
		IL_00dc:
		num = 0xE713E41Bu | num;
		_3019FA32 = null;
		num = 1275190582 - num;
		int num13 = num11;
		while (true)
		{
			num = 0x140AAD37 & num;
			if (num == 3449689878u)
			{
				break;
			}
			int num14 = num13;
			List<_589EC5AE> list5 = list;
			num %= 1613468341;
			int count = list5.Count;
			num /= 3080078357u;
			if (num14 >= count)
			{
				goto IL_03d4;
			}
			List<_589EC5AE> list6 = list;
			int index = num13;
			num = 2302544436u;
			_589EC5AE obj6 = list6[index];
			num = 0xEE91BCB3u & num;
			_589EC5AE2 = obj6;
			num = 3224560285u * num;
			if (num * 1980578332 == 0)
			{
				break;
			}
			byte b = _589EC5AE2._1EB6C302();
			num = 0x8B3EEFA3u & num;
			if (b != 0)
			{
				num = (uint)(10663835 << (int)num);
				uint num15 = num - 10663834;
				num = 0xFA8F686 ^ num;
				if (b == num15)
				{
					goto IL_02bc;
				}
				goto IL_0372;
			}
			Type type = _94961F94.GetType();
			num = (uint)(-1978269656 << (int)num);
			Type type2 = type;
			if (1586073485 / num != 0)
			{
				goto IL_05bf;
			}
			int _4F365B = _589EC5AE2._210F149B();
			num &= 0x17BE79A0;
			Type type3 = _22B05086(_4F365B);
			num = 1856787484 % num;
			num = 3531647110u >> (int)num;
			bool num16 = type2 == type3;
			num = 1739725963 % num;
			if (!num16)
			{
				num = 2133322128 * num;
				bool num17 = type2.IsSubclassOf(type3);
				num ^= 0x702DA88D;
				if (!num17)
				{
					goto IL_0372;
				}
				num ^= 0xF0A411C;
			}
			num ^= 0x471B5A2C;
			if (num >> 27 == 0)
			{
				break;
			}
			goto IL_0228;
			IL_0372:
			if ((int)num * -878277625 == 0)
			{
				break;
			}
			int num18 = num13;
			int num19 = (int)num + -252330268;
			num |= 0x9E0B4930u;
			num13 = num18 + num19;
			num ^= 0xFB02AF66u;
		}
		goto IL_0013;
		IL_02bc:
		if (num <= 1260145569)
		{
			num /= 822192915;
			num %= 3770250639u;
			_3019FA32 = _589EC5AE2;
			if (num < 3433466409u)
			{
				num = 3020831889u >> (int)num;
				_56AB72BE obj7 = _2F2F02A8;
				num |= 0x658108B2;
				Exception _04B76AB2 = _94961F94;
				num *= 478647864;
				B1A0179E a2 = new B1A0179E(_04B76AB2);
				num = 554350014 * num;
				obj7._93061C36(a2);
				num -= 4080068627u;
				C1BF430A c1BF430A4 = _7E8CFF31;
				num -= 3585704892u;
				num ^= 0x5632C33A;
				c1BF430A4.EB3F1497(_589EC5AE2._210F149B());
				if ((num ^ 0x7AA985B2) != 0)
				{
					return;
				}
			}
			goto IL_0013;
		}
		goto IL_009c;
	}

	private void _729F2232()
	{
		while (true)
		{
			uint num = 2535590552u;
			D3B95303 d3B = _2F2F02A8.ED374FBA();
			num |= 0x2709BF1A;
			D3B95303 _690ADCA = d3B;
			num += 2603874725u;
			if (-1038698469 != (int)num)
			{
				_56AB72BE obj = _2F2F02A8;
				num %= 1270263732;
				D3B95303 d3B2 = obj.ED374FBA();
				num = 3131549455u / num;
				D3B95303 _072090BA = d3B2;
				if (num <= 3677335862u)
				{
					_56AB72BE obj2 = _2F2F02A8;
					num |= 0xA62E4400u;
					num -= 196118928;
					D3B95303 a = _88BA7B16.AB1F9D3A(_072090BA, _690ADCA);
					num ^= 0x6826F036;
					obj2._93061C36(a);
					break;
				}
				continue;
			}
			break;
		}
	}

	private void C214DD3C()
	{
		while (true)
		{
			uint num = 3640673691u;
			_56AB72BE obj = _2F2F02A8;
			num = 0xE6A890A6u | num;
			D3B95303 aD8A8B = obj.ED374FBA();
			if (num << 19 != 0)
			{
				_56AB72BE obj2 = _2F2F02A8;
				num ^= 0xCE09F281u;
				num = 2578842292u % num;
				obj2._93061C36(_2038A6B3.E625E9A3(aD8A8B));
				if (num >> 11 != 0)
				{
					break;
				}
			}
		}
	}

	private void _8A0AFC14()
	{
		uint num = 1371385277u;
		D3B95303 f;
		D3B95303 c38B15BF;
		while (true)
		{
			D3B95303 d3B = _2F2F02A8.ED374FBA();
			num -= 3735816738u;
			f = d3B;
			num %= 520607510;
			if (num - 269138999 != 0)
			{
				_56AB72BE obj = _2F2F02A8;
				num = 851258418 % num;
				D3B95303 d3B2 = obj.ED374FBA();
				num = 1773154082 / num;
				c38B15BF = d3B2;
				num = 33773585 + num;
				if (993568445 != num)
				{
					break;
				}
			}
		}
		_56AB72BE obj2 = _2F2F02A8;
		num >>= 25;
		num |= 0x1C33ACBA;
		num >>= 15;
		obj2._93061C36(_2038A6B3.BC9994AA(c38B15BF, f));
	}

	private void AD29420C()
	{
		uint num = 2827882626u;
		while (true)
		{
			num |= 0x8991662Eu;
			C1BF430A c1BF430A = _7E8CFF31;
			num *= 1620347575;
			int _4F365B = c1BF430A._25AC239D();
			num = 3887977871u >> (int)num;
			Type type = _22B05086(_4F365B);
			num &= 0x6BBA9717;
			Type _80349F = type;
			if (num >= 1329556799)
			{
				continue;
			}
			while (true)
			{
				num = 2243204027u / num;
				D3B95303 d3B = _2F2F02A8.ED374FBA();
				num = 329080593 % num;
				D3B95303 d3B2 = d3B;
				num = 616415878 - num;
				if (2569995285u + num != 0)
				{
					num %= 4197542147u;
					_56AB72BE obj = _2F2F02A8;
					num = 3155026197u / num;
					D3B95303 d3B3 = obj.ED374FBA();
					num >>= 24;
					object obj2 = d3B3._9F320096();
					num -= 1973976846;
					Array array = obj2 as Array;
					if (num < 227352374)
					{
						break;
					}
					if (array == null)
					{
						throw new ArgumentException();
					}
					num /= 1328015759;
					_56AB72BE obj3 = _2F2F02A8;
					num = 0x5B254A87 ^ num;
					num *= 663942696;
					object value = array.GetValue(d3B2._6527EC0E());
					num = 0xD93ED819u ^ num;
					obj3._93061C36(D3B95303._6388BF9A(value, _80349F));
					if (num != 2752828728u)
					{
						return;
					}
				}
			}
		}
	}

	private void FA3C8E81()
	{
		uint num = 2365797153u;
		D3B95303 d3B = default(D3B95303);
		if (2417004448u >> (int)num != 0)
		{
			_56AB72BE obj = _2F2F02A8;
			num = 0xD094173Au & num;
			d3B = obj.ED374FBA();
			num = 0x4E203685 | num;
			if (num == 2225663661u)
			{
				return;
			}
		}
		_56AB72BE obj2 = _2F2F02A8;
		num >>= 15;
		D3B95303 d7A = d3B;
		num += 2996501798u;
		D3B95303 a = DC09FDAD._06A312A8(d7A);
		num <<= 28;
		obj2._93061C36(a);
	}

	private void B9281D11()
	{
		uint num = 1301271356u;
		D3B95303 d3B2 = default(D3B95303);
		if ((num ^ 0x5008A33D) != 0)
		{
			num /= 4021637053u;
			_56AB72BE obj = _2F2F02A8;
			num = 1771620543 * num;
			D3B95303 d3B = obj.ED374FBA();
			num /= 429594652;
			d3B2 = d3B;
			if (-300930760 == (int)num)
			{
				return;
			}
		}
		num <<= 23;
		_56AB72BE obj2 = _2F2F02A8;
		num = 3383587724u * num;
		D3B95303 bFBDA = d3B2;
		num = 0x134A11F & num;
		D3B95303 a = DC09FDAD.EA24A01D(bFBDA);
		num = 2235518381u * num;
		obj2._93061C36(a);
	}

	private void E8A32EBC()
	{
		uint num = 3324511399u;
		C1BF430A c1BF430A = _7E8CFF31;
		num = 0x5719EE28 & num;
		int e6955F8F = c1BF430A._25AC239D();
		num = 2952903189u % num;
		FieldInfo fieldInfo = _35086532(e6955F8F);
		num += 1027444783;
		FieldInfo aA1EC59F = fieldInfo;
		num >>= 19;
		_56AB72BE obj = _2F2F02A8;
		num = 2025806468 - num;
		D3B95303 _2332CF = obj.ED374FBA();
		do
		{
			_56AB72BE obj2 = _2F2F02A8;
			num |= 0xB120CE08u;
			_1BB8DC36 a = new _1BB8DC36(aA1EC59F, _2332CF);
			num >>= 9;
			obj2._93061C36(a);
		}
		while (num > 2626625715u);
	}

	private void _0FBA8422()
	{
		while (true)
		{
			_56AB72BE obj = _2F2F02A8;
			uint num = 4256747014u;
			D3B95303 _559EFA = obj.ED374FBA();
			num %= 2787788340u;
			if (1353858084 <= num)
			{
				_56AB72BE obj2 = _2F2F02A8;
				num = 202984968 / num;
				D3B95303 _7B2A85B = obj2.ED374FBA();
				num <<= 25;
				num %= 975040945;
				_56AB72BE obj3 = _2F2F02A8;
				num += 4204414118u;
				num <<= 15;
				D3B95303 a = _88BA7B16.BF82C39A(_7B2A85B, _559EFA);
				num = 0xB43A61BCu ^ num;
				obj3._93061C36(a);
				if (-1557027811 != (int)num)
				{
					break;
				}
			}
		}
	}

	private void _10282C26()
	{
		while (true)
		{
			C1BF430A c1BF430A = _7E8CFF31;
			uint num = 2678907193u;
			byte num2 = c1BF430A._3818FD20();
			num = 1024015879 * num;
			byte eA2E949D = num2;
			num += 3323216034u;
			if ((0x1BA78A83 ^ num) == 0)
			{
				continue;
			}
			int c30618A = _7E8CFF31._25AC239D();
			if (num - 3994749082u != 0)
			{
				int aABCEDA = _7E8CFF31._25AC239D();
				num = 0x88ABCB9Fu | num;
				C1BF430A c1BF430A2 = _7E8CFF31;
				num = 34628911 * num;
				int num3 = c1BF430A2._25AC239D();
				num &= 0xFE0FBE89u;
				int _511746B = num3;
				num = 1043333673 * num;
				num += 797494041;
				int num4 = _7E8CFF31._25AC239D();
				num = 2122759194u >> (int)num;
				int aBA42A = num4;
				num %= 3139971740u;
				num = (uint)(1016841652 << (int)num);
				_3209E1AD obj = _7D13B119;
				num = 0x782C284 ^ num;
				num += 3347225481u;
				num &= 0x5528AA82;
				num = 0xBAA3A5B5u | num;
				obj.E82F463E(c30618A, aABCEDA, eA2E949D, _511746B, aBA42A);
				if (num << 26 != 0)
				{
					break;
				}
			}
		}
	}

	private void _11884D88()
	{
		uint num = 613398548u;
		num >>= 18;
		_56AB72BE obj = _2F2F02A8;
		num -= 3694838149u;
		D3B95303 e035EA = obj.ED374FBA();
		num += 2223888043u;
		do
		{
			_2F2F02A8._93061C36(_37B6A08E._9EB4EABC(e035EA));
		}
		while ((0x291C034 ^ num) == 0);
	}

	private void _3286A91D()
	{
		uint num = 864337055u;
		IntPtr cb = _2F2F02A8.ED374FBA()._27832122();
		num = 1032257333 - num;
		IntPtr intPtr = Marshal.AllocHGlobal(cb);
		num -= 288865693;
		num = 2358457661u >> (int)num;
		List<IntPtr> list = _162873A6;
		num = 0xE49546B1u & num;
		list.Add(intPtr);
		if ((num ^ 0x8A11C201u) != 0)
		{
			do
			{
				_56AB72BE obj = _2F2F02A8;
				num %= 2754053654u;
				obj._93061C36(new _88BA7B16(intPtr));
			}
			while (num == 3182185000u);
		}
	}

	private void _5C9EBE36()
	{
		uint num = 1292262800u;
		D3B95303 eFAC540B = default(D3B95303);
		if ((num ^ 0x3DB036BD) != 0)
		{
			num = 4045967027u >> (int)num;
			_56AB72BE obj = _2F2F02A8;
			num = 0x3410EA2C ^ num;
			D3B95303 d3B = obj.ED374FBA();
			num |= 0xC899FF84u;
			eFAC540B = d3B;
			num = 0xD7AFD83Cu & num;
			if (num << 25 == 0)
			{
				return;
			}
		}
		num >>= 19;
		D3B95303 _6A93D = _2F2F02A8.ED374FBA();
		num /= 1370491559;
		if ((num & 0xD69135B0u) == 0)
		{
			num *= 162138890;
			_56AB72BE obj2 = _2F2F02A8;
			num = 0x5292AA87 | num;
			obj2._93061C36(_88BA7B16._1105CE02(_6A93D, eFAC540B));
		}
	}

	private void _29B79425()
	{
		uint num = 4186574381u;
		num ^= 0xEAB8600Fu;
		C1BF430A c1BF430A = _7E8CFF31;
		num = 0x9B807B0Du & num;
		int num2 = c1BF430A._5F10D3B8();
		num = 0xAB1301AAu | num;
		while (true)
		{
			num = 54405299 / num;
			_56AB72BE obj = _2F2F02A8;
			num -= 3190140683u;
			D3B95303 d3B = obj.ED374FBA();
			num = 3716895890u / num;
			D3B95303 d3B2 = d3B;
			num = 0xCBA60B0Eu | num;
			while (true)
			{
				num = (uint)(-1669122294 << (int)num);
				int num3 = (int)num ^ -1685782528;
				num = 1345318298 - num;
				if (num2 < num3)
				{
					break;
				}
				num += 480750761;
				num >>= 0;
				_56AB72BE obj2 = _2F2F02A8;
				num = 0xFA15A697u | num;
				D3B95303 d3B3 = obj2.C4BFC635(num2);
				num = 0x57B35B3C ^ num;
				D3B95303 d3B4 = d3B3;
				num = 0x83166B2 & num;
				if (d3B4 == null)
				{
					num ^= 0xB01C9CA6u;
					if (-493077493 != (int)num)
					{
						bool num4 = d3B2._4C0EC108();
						num = 2260455303u - num;
						if (!num4)
						{
							num = (uint)(746954810 << (int)num);
							throw new ArgumentException();
						}
						num = 0xF692EC9Fu ^ num;
						_56AB72BE obj3 = _2F2F02A8;
						num += 1493365129;
						num = 622996773 + num;
						obj3._30095C38(num2, d3B2);
						num = 3733351731u % num;
					}
					return;
				}
				num &= 0x29B162A6;
				num = 0xE9B5D492u ^ num;
				num = 0x9A3679ADu ^ num;
				num >>= 4;
				Type f809DF = d3B4.D293A3AF();
				num >>= 1;
				D3B95303 d3B5 = d3B2.BD15691D(f809DF);
				num = 3055658043u - num;
				d3B4.DE8C17B9(d3B5._9F320096());
				if (num * 1183433611 != 0)
				{
					return;
				}
			}
			if (num << 17 != 0)
			{
				_56AB72BE obj4 = _2F2F02A8;
				num = 1880433181 + num;
				int _348F = num2 + _2F2F02A8._6188C297();
				num += 3978712371u;
				obj4._30095C38(_348F, d3B2);
				num -= 3602207375u;
				break;
			}
		}
	}

	private void _6C8C4E1C()
	{
		uint num = 3339213316u;
		num &= 0x5B233E21;
		int _4F365B = _7E8CFF31._25AC239D();
		num <<= 13;
		Type type = _22B05086(_4F365B);
		Dictionary<object, DynamicMethod> dictionary = _58A84F99;
		num = 0x8C2E19B7u | num;
		Dictionary<object, DynamicMethod> obj = dictionary;
		int num2 = (int)num ^ -1888609865;
		num = 312300314 * num;
		bool lockTaken = (byte)num2 != 0;
		DynamicMethod value;
		try
		{
			if (num > 1497325734)
			{
				goto IL_005c;
			}
			goto IL_00a3;
			IL_005c:
			do
			{
				Monitor.Enter(obj, ref lockTaken);
				num = 2879826307u / num;
			}
			while (num * 220312751 != 0);
			goto IL_007b;
			IL_007b:
			while (true)
			{
				Dictionary<object, DynamicMethod> dictionary2 = _58A84F99;
				num -= 2459655049u;
				if (dictionary2.TryGetValue(type, out value))
				{
					break;
				}
				if (num == 3904691856u)
				{
					continue;
				}
				goto IL_00a3;
			}
			goto IL_01b1;
			IL_01b1:
			if (num * 1646717868 == 0)
			{
				goto IL_005c;
			}
			goto end_IL_0050;
			IL_00a3:
			num |= 0x3038CBA6;
			Type typeFromHandle = typeof(int);
			num = 3357587487u * num;
			num = 465002931u >> (int)num;
			num = 2863684894u * num;
			Type typeFromHandle2 = typeof(_02B4022E);
			num ^= 0x8F23623Cu;
			Module module = typeFromHandle2.Module;
			uint skipVisibility = num ^ 0x7C4DCC9D;
			num -= 3331365012u;
			DynamicMethod dynamicMethod = new DynamicMethod("", typeFromHandle, null, module, (byte)skipVisibility != 0);
			num *= 403881117;
			value = dynamicMethod;
			DynamicMethod dynamicMethod2 = value;
			num = 0x5E82F11F | num;
			ILGenerator iLGenerator = dynamicMethod2.GetILGenerator();
			num &= 0xEE085D33u;
			num -= 2434665872u;
			OpCode opcode = OpCodes.Sizeof;
			num = 2511572777u / num;
			iLGenerator.Emit(opcode, type);
			num |= 0x86267B0Du;
			OpCode ret = OpCodes.Ret;
			num = 2856057142u % num;
			iLGenerator.Emit(ret);
			num *= 2803754899u;
			if (-754051784 >>> (int)num == 0)
			{
				goto IL_007b;
			}
			Dictionary<object, DynamicMethod> dictionary3 = _58A84F99;
			num = 2408345638u / num;
			dictionary3.Add(type, value);
			num += 1835312247;
			goto IL_01b1;
			end_IL_0050:;
		}
		finally
		{
			num = 1897782057u;
			if (2277459745u > num && lockTaken)
			{
				num = 4137133244u / num;
				num = 3223868426u + num;
				Monitor.Exit(obj);
				num ^= 0xB1358F25u;
			}
		}
		do
		{
			num = 19005707u;
			_56AB72BE obj2 = _2F2F02A8;
			DynamicMethod dynamicMethod3 = value;
			num = 3711450301u % num;
			object obj3 = dynamicMethod3.Invoke(null, null);
			num += 487952786;
			obj2._93061C36(new B7035AA0((int)obj3));
		}
		while (-502192623 == (int)num);
	}

	private void _9A3BC4AD()
	{
		uint num;
		do
		{
			_56AB72BE obj = _2F2F02A8;
			num = 975148223u;
			D3B95303 d3B = obj.ED374FBA();
			num %= 730358821;
			D3B95303 _38B3B = d3B;
			_56AB72BE obj2 = _2F2F02A8;
			num ^= 0xD4AF98ABu;
			obj2._93061C36(_15343925.CA976A91(_38B3B));
		}
		while ((num ^ 0x67076BAE) == 0);
	}

	private void DB8B980D()
	{
		while (true)
		{
			uint num = 1796588981u;
			C1BF430A c1BF430A = _7E8CFF31;
			num = 523583506 + num;
			Type type = _22B05086(c1BF430A._25AC239D());
			num -= 3334168116u;
			Type type2 = type;
			num %= 2954977572u;
			D3B95303 d3B3;
			D3B95303 d3B2;
			while (true)
			{
				num = 0x2F0E059F & num;
				D3B95303 d3B = _2F2F02A8.ED374FBA();
				num = 1679000837 + num;
				d3B2 = d3B;
				d3B3 = _2F2F02A8.ED374FBA();
				num *= 2258948138u;
				if (2821032582u >= num)
				{
					D3B95303 d3B4 = d3B2;
					num &= 0xE03DCF84u;
					num -= 1469770921;
					D3B95303 d3B5 = d3B4.BD15691D(type2);
					num = 2785617153u + num;
					d3B2 = d3B5;
					if ((num ^ 0x763F6A99) != 0)
					{
						break;
					}
				}
			}
			while (true)
			{
				if (d3B3._4C0EC108())
				{
					D3B95303 d3B6 = d3B3;
					num -= 2814350756u;
					Type type3 = d3B6.D293A3AF();
					num = 2344435871u >> (int)num;
					bool num2 = type3 != type2;
					num ^= 0xFA8CCD38u;
					if (num2)
					{
						num ^= 0xB30C498Eu;
						if (num << 12 == 0)
						{
							continue;
						}
						D3B95303 d3B7 = d3B2;
						num = 2712050595u / num;
						D3B95303 d3B8 = d3B3;
						num >>= 13;
						Type f809DF = d3B8.D293A3AF();
						num = 0x7E83DD82 | num;
						D3B95303 d3B9 = d3B7.BD15691D(f809DF);
						num ^= 0xDB32E489u;
						d3B2 = d3B9;
						if (1614253456 >= num)
						{
							break;
						}
						num ^= 0x5F3DFC88;
					}
				}
				else
				{
					num = 2743176749u * num;
					D3B95303 d3B10 = d3B3;
					num -= 3532356248u;
					_3112BC99 obj = new _3112BC99(d3B10._27832122(), type2);
					num = (uint)(-1909171575 << (int)num);
					d3B3 = obj;
					num += 1817733882;
				}
				num = 2822416128u * num;
				D3B95303 d3B11 = d3B3;
				num = 0x9AA53333u ^ num;
				d3B11.DE8C17B9(d3B2._9F320096());
				return;
			}
		}
	}

	private void _45AE3104()
	{
		uint num;
		do
		{
			num = 2276794778u;
			_56AB72BE obj = _2F2F02A8;
			num -= 1409965727;
			D3B95303 d3B = obj.ED374FBA();
			num = 1304197163 % num;
			D3B95303 _031E = d3B;
			num = (uint)(1653744657 << (int)num);
			_56AB72BE obj2 = _2F2F02A8;
			D3B95303 a = _47B891B7._8E3E80A7(_031E);
			num = 288658098 - num;
			obj2._93061C36(a);
		}
		while (3392531716u >= num);
	}

	private void _46B75F0E()
	{
		while (true)
		{
			D3B95303 a1A50A = _2F2F02A8.ED374FBA();
			uint num = 562738747u;
			if (2694240801u / num != 0)
			{
				D3B95303 _7133EFB = _2F2F02A8.ED374FBA();
				if (num - 2544620204u != 0)
				{
					_56AB72BE obj = _2F2F02A8;
					num |= 0xB1B55BBEu;
					D3B95303 a = D51696A5.C534C01C(_7133EFB, a1A50A);
					num ^= 0x4A80FFB5;
					obj._93061C36(a);
					break;
				}
				continue;
			}
			break;
		}
	}

	private void FC284D0F()
	{
		D3B95303 _60337DAF;
		uint num;
		do
		{
			num = 3887216645u;
			_60337DAF = _2F2F02A8.ED374FBA();
		}
		while (num / 1050842244 == 0);
		num <<= 10;
		D3B95303 _39B6162E = _2F2F02A8.ED374FBA();
		_2F2F02A8._93061C36(B7035AA0._8631ED1D(_39B6162E, _60337DAF));
	}

	private void CD21BC33()
	{
		uint num = 3701866627u;
		D3B95303 d3B = default(D3B95303);
		C1BF430A c1BF430A2 = default(C1BF430A);
		int num3 = default(int);
		if (372435626 < num)
		{
			goto IL_0013;
		}
		goto IL_008f;
		IL_0013:
		_56AB72BE obj = _2F2F02A8;
		num = 0xE5341AB0u | num;
		d3B = obj.ED374FBA();
		num = 1250294447u >> (int)num;
		if (num <= 413360771)
		{
			goto IL_0045;
		}
		goto IL_00be;
		IL_0045:
		C1BF430A c1BF430A = new C1BF430A();
		num %= 3556864567u;
		c1BF430A2 = c1BF430A;
		num /= 857170877;
		if (num == 3700267649u)
		{
			goto IL_0013;
		}
		goto IL_006c;
		IL_006c:
		C1BF430A c1BF430A3 = c1BF430A2;
		num = 2417364513u + num;
		c1BF430A3.EB3F1497(d3B._6527EC0E());
		if (1915797533 > num)
		{
			goto IL_0045;
		}
		goto IL_008f;
		IL_008f:
		D3B95303 d3B2 = d3B;
		num = 0xD42A5685u | num;
		int num2 = d3B2._6E0A913C();
		num <<= 1;
		num3 = num2;
		if (-198692186 << (int)num == 0)
		{
			goto IL_0013;
		}
		goto IL_00be;
		IL_00be:
		C1BF430A c1BF430A4 = c1BF430A2;
		num = 0x5CB9870E ^ num;
		short num4 = c1BF430A4._5F10D3B8();
		num += 2107058845;
		ushort num5 = (ushort)num4;
		num |= 0x4A1635BC;
		ushort num6 = num5;
		if (2812378651u <= num)
		{
			goto IL_0045;
		}
		Dictionary<int, D3B95303> dictionary = new Dictionary<int, D3B95303>();
		num -= 1411597855;
		num += 2301417649u;
		object[] array = null;
		uint num7 = num + 1352136561;
		num = 2124445461 / num;
		if ((int)num6 > (int)num7)
		{
			num = (uint)(1619208225 << (int)num);
			if (num - 2149432634u != 0)
			{
				object[] array2 = new object[num6];
				num &= 0xFB8FC31Cu;
				array = array2;
				if (num / 2352221871u == 0)
				{
					uint num8 = num6 - (num ^ 0x60830001);
					num |= 0x6B41AB9;
					int num9 = (int)num8;
					if (num != 3390994482u)
					{
						while (num != 899184650)
						{
							int num10 = num9;
							num = 2703041163u % num;
							uint num11 = num - 979765202;
							num = 1562069781 + num;
							if (num10 >= (int)num11)
							{
								_56AB72BE obj2 = _2F2F02A8;
								num = 682447011u;
								D3B95303 d3B3 = obj2.ED374FBA();
								num = 4255025944u + num;
								d3B = d3B3;
								num &= 0x682073B0;
								if (1822551445 >= num)
								{
									if (d3B._4C0EC108())
									{
										num = 0xAD2E8BBDu & num;
										num = (uint)(1770066335 << (int)num);
										int key = num9;
										D3B95303 value = d3B;
										num = 4078516007u >> (int)num;
										dictionary[key] = value;
										num ^= 0xD3196497u;
									}
									num = 0x14BC291E ^ num;
									object[] array3 = array;
									num -= 1773977109;
									int num12 = num9;
									num = 2618762550u * num;
									D3B95303 d3B4 = d3B;
									num = 3468431748u - num;
									num += 2652551823u;
									object obj3 = d3B4.BD15691D(_22B05086(c1BF430A2._25AC239D()))._9F320096();
									num = 788937907 / num;
									array3[num12] = obj3;
									num = 0x743ED08A & num;
									if (num <= 4127392545u)
									{
										int num13 = num9;
										uint num14 = num ^ 1;
										num = 1093197596u >> (int)num;
										int num15 = num13 - (int)num14;
										num = 137367226 + num;
										num9 = num15;
										num += 492711139;
										continue;
									}
								}
								goto IL_0045;
							}
							goto IL_02d0;
						}
					}
					goto IL_006c;
				}
			}
			goto IL_0013;
		}
		goto IL_02da;
		IL_03ad:
		num ^= 0xAC264420u;
		int num17;
		if (45342887 <= num)
		{
			c1BF430A2._25AC239D();
			num /= 448009259;
			if ((num ^ 0x5C961222) != 0)
			{
				_02B4022E obj4 = new _02B4022E();
				num = 0x903B2715u ^ num;
				object[] _8836A3B = array;
				num &= 0xE18D9B1Fu;
				C1BF430A c1BF430A5 = c1BF430A2;
				num /= 3644680878u;
				object _4BB13A1A = obj4._1CBB33BE(_8836A3B, c1BF430A5._6188C297());
				num = 2777980567u - num;
				Dictionary<int, D3B95303>.Enumerator enumerator = dictionary.GetEnumerator();
				try
				{
					while (true)
					{
						num += 126437930;
						if (2240454169u < num)
						{
							bool num16 = enumerator.MoveNext();
							num += 3249642920u;
							if (!num16)
							{
								break;
							}
							num = 2453044738u;
							num = 1711593275 * num;
							KeyValuePair<int, D3B95303> current = enumerator.Current;
							num &= 0xC613490Fu;
							D3B95303 value2 = current.Value;
							object[] array4 = array;
							num -= 1585531288;
							num = 2651381155u >> (int)num;
							value2.DE8C17B9(array4[current.Key]);
							num += 2777818740u;
						}
					}
				}
				finally
				{
					num = 11250850u;
					((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
				}
				while (true)
				{
					num = 2084041400u;
					if (num17 != 0 && num != 3208340487u)
					{
						goto IL_04e8;
					}
					goto IL_0587;
					IL_04e8:
					num = 620783538u >> (int)num;
					Type type = _22B05086(num17);
					if (1629107875 * num == 0)
					{
						continue;
					}
					num = 2751791535u * num;
					Type typeFromHandle = typeof(void);
					num = (uint)(-1347241551 << (int)num);
					bool num18 = type != typeFromHandle;
					num ^= 0xE9FA7AB8u;
					if (num18)
					{
						if (num == 992659463)
						{
							continue;
						}
						_56AB72BE obj5 = _2F2F02A8;
						num = 520595750 * num;
						num = 1779336883 / num;
						obj5._93061C36(D3B95303._6388BF9A(_4BB13A1A, type));
						num += 2084041399;
					}
					goto IL_0587;
					IL_0587:
					if (1914854150 != num)
					{
						break;
					}
					goto IL_04e8;
				}
				return;
			}
			goto IL_0013;
		}
		goto IL_0045;
		IL_02d0:
		num ^= 0x978152E7u;
		goto IL_02da;
		IL_02da:
		C1BF430A c1BF430A6 = c1BF430A2;
		num ^= 0xE49EC9ADu;
		int num19 = c1BF430A6._25AC239D();
		num = 3491126277u / num;
		num17 = num19;
		int num20 = num3 & (int)(num ^ 0x40);
		uint num21 = num ^ 0;
		num = 85267872 + num;
		bool num22 = (uint)num20 > num21;
		num %= 3347628070u;
		if (num22)
		{
			num = 2885784873u >> (int)num;
			if (num - 2897805587u != 0)
			{
				object[] array5 = array;
				num &= 0xEB2719A3u;
				if (array5 != null)
				{
					num = 0x7FBBCEAF | num;
					object[] array6 = array;
					num /= 1778696742;
					int num23 = (int)num + -2;
					num = 0x29E9680 & num;
					object obj6 = array6[num23];
					num |= 0xDC973127u;
					num ^= 0xD9822487u;
					if (obj6 != null)
					{
						goto IL_03ad;
					}
					num ^= 0xAD140481u;
				}
				num = 0x2299D86 ^ num;
				throw new NullReferenceException();
			}
			goto IL_0013;
		}
		goto IL_03ad;
	}

	private void _2EA28017()
	{
		uint num = 3894419762u;
		D3B95303 _641780B;
		do
		{
			num += 3483175454u;
			_56AB72BE obj = _2F2F02A8;
			num = 3459927073u * num;
			_641780B = obj.ED374FBA();
			num %= 1706986897;
		}
		while (1000273326 / num == 0);
		do
		{
			D3B95303 _8FAED1BE = _2F2F02A8.ED374FBA();
			num = 1345695883 - num;
			_56AB72BE obj2 = _2F2F02A8;
			num = 4145246228u >> (int)num;
			obj2._93061C36(DC09FDAD._970C65A1(_8FAED1BE, _641780B));
		}
		while (num - 1644788097 == 0);
	}

	private FieldInfo _35086532(int E6955F8F)
	{
		uint num = 1452839853u;
		MemberInfo memberInfo2 = default(MemberInfo);
		if ((num ^ 0x46847832) != 0)
		{
			num -= 2066021175;
			num = 0x8615BEB9u & num;
			MemberInfo memberInfo = EDBC078C(E6955F8F);
			num = 1680260901 % num;
			memberInfo2 = memberInfo;
		}
		while (true)
		{
			FieldInfo obj = memberInfo2 as FieldInfo;
			num %= 254293767;
			if ((object)obj == null)
			{
				break;
			}
			if (2114992054 / num != 0)
			{
				return (FieldInfo)memberInfo2;
			}
		}
		throw new InvalidOperationException();
	}

	private void _1F9AC134()
	{
		object obj2 = default(object);
		while (true)
		{
			IL_0000:
			uint num = 4254465072u;
			num >>= 8;
			MethodBase methodBase = _239CD025(_7E8CFF31._25AC239D());
			num = (uint)(1646177598 << (int)num);
			MethodBase methodBase2 = methodBase;
			if (-972502091 != (int)num)
			{
				goto IL_0039;
			}
			goto IL_0063;
			IL_0063:
			while (true)
			{
				object obj = obj2;
				num %= 230081855;
				MethodInfo methodInfo;
				if (obj != null)
				{
					num += 3090717342u;
					Type type = obj2.GetType();
					num >>= 10;
					Type type2 = type;
					if ((0x48A55688 ^ num) == 0)
					{
						break;
					}
					while (true)
					{
						MethodBase methodBase3 = methodBase2;
						num = 906982272 * num;
						Type declaringType = methodBase3.DeclaringType;
						if ((num ^ 0xDE00F002u) == 0)
						{
							continue;
						}
						MethodBase methodBase4 = methodBase2;
						num = 428305814u >> (int)num;
						ParameterInfo[] parameters = methodBase4.GetParameters();
						num |= 0x53B75313;
						IntPtr intPtr = (nint)parameters.LongLength;
						num %= 84083847;
						Type[] array = new Type[(int)(nint)intPtr];
						num = 3096602386u / num;
						Type[] array2 = array;
						num = 1831918113 * num;
						int num2 = (int)num + -155710394;
						ParameterInfo[] array3 = parameters;
						num = 0x48056781 | num;
						int num3 = (int)num + -1229453243;
						num = 3944195096u / num;
						int num4 = num3;
						while (1403398929 > num)
						{
							int num5 = num4;
							IntPtr intPtr2 = (nint)array3.LongLength;
							num <<= 8;
							int num6 = (int)(nint)intPtr2;
							num >>= 6;
							if (num5 < num6)
							{
								ParameterInfo parameterInfo = array3[num4];
								int num7 = num2;
								int num8 = num7 + 1;
								num = 3247210259u;
								num2 = num8;
								num *= 800871724;
								array2[num7] = parameterInfo.ParameterType;
								num = 0x19A73225 & num;
								if (1245024178 == num)
								{
									goto end_IL_0097;
								}
								int num9 = num4;
								num &= 0xC1AD1D0Du;
								int num10 = num9 + (int)(num ^ 0x1010005);
								num <<= 7;
								num4 = num10;
								num += 2139094531;
								continue;
							}
							goto IL_0198;
						}
						continue;
						IL_0198:
						if (1664041406 < num)
						{
							goto IL_0000;
						}
						while (true)
						{
							num = 3004734620u + num;
							if (3046041517u < num)
							{
								break;
							}
							Type type3 = type2;
							num = 0x6BB6F5A1 ^ num;
							bool num11 = type3 != null;
							num = 0xD1036E88u | num;
							num += 800457165;
							if (num11)
							{
								num = 0xF83E7E17u & num;
								if (num >= 1865494719)
								{
									goto end_IL_0097;
								}
								Type type4 = type2;
								num += 1102110236;
								if (type4 != declaringType)
								{
									num = 2475753144u;
									Type type5 = type2;
									string name = methodBase2.Name;
									int bindingAttr = (int)num ^ -1819160946;
									num ^= 0xB514E996u;
									num |= 0x10AC0238;
									uint callConvention = num ^ 0x36AC173D;
									num -= 3703403918u;
									num = 2159630982u - num;
									MethodInfo method = type5.GetMethod(name, (BindingFlags)bindingAttr, null, (CallingConventions)callConvention, array2, null);
									num += 355587747;
									methodInfo = method;
									num &= 0x3F05CF1C;
									num += 4046225420u;
									if (methodInfo != null)
									{
										if ((num & 0xFF225A2Bu) == 0)
										{
											goto end_IL_0097;
										}
										num = 0xB20A8F15u & num;
										bool num12 = methodInfo.GetBaseDefinition() == methodBase2;
										num = 789962772 * num;
										num += 2813878996u;
										if (num12)
										{
											goto IL_0249;
										}
									}
									num /= 1730914342;
									if ((0xBF24AE80u & num) != 0)
									{
										break;
									}
									Type baseType = type2.BaseType;
									num = 0x2E931414 | num;
									type2 = baseType;
									num += 3513576440u;
									continue;
								}
								num += 3213894436u;
							}
							goto IL_02fb;
						}
						continue;
						end_IL_0097:
						break;
					}
					break;
				}
				goto IL_02fb;
				IL_0249:
				methodBase2 = methodInfo;
				if ((num ^ 0x82EC32F) == 0)
				{
					continue;
				}
				num ^= 0x25547E72;
				goto IL_02fb;
				IL_02fb:
				num -= 1980865044;
				_56AB72BE obj3 = _2F2F02A8;
				num ^= 0x5A1501A7;
				_983F321C a = new _983F321C(methodBase2);
				num = (uint)(1126541200 << (int)num);
				obj3._93061C36(a);
				if (num + 3147701820u != 0)
				{
					return;
				}
				goto IL_0000;
			}
			goto IL_0039;
			IL_0039:
			num /= 3173312668u;
			_56AB72BE obj4 = _2F2F02A8;
			num = 1686114608 - num;
			obj2 = obj4.ED374FBA()._9F320096();
			num *= 4154311066u;
			goto IL_0063;
		}
	}

	private void AC801780()
	{
		uint num = 890268215u;
		if (314110142 < num)
		{
			_56AB72BE obj = _2F2F02A8;
			num = 0x5892051D | num;
			long _390BF = _7E8CFF31.F7035F27();
			num >>= 29;
			D51696A5 a = new D51696A5(_390BF);
			num += 847413675;
			obj._93061C36(a);
		}
	}

	private void B7AB4FB8()
	{
		uint num = 1065495816u;
		_56AB72BE obj = _2F2F02A8;
		num -= 822499388;
		obj.ED374FBA();
	}

	private void _2991242C()
	{
		uint num;
		do
		{
			num = 1888813227u;
			C1BF430A c1BF430A = _7E8CFF31;
			num -= 3691633577u;
			byte num2 = c1BF430A._3818FD20();
			num &= 0x7DACB8B9;
			int _6B1C = num2;
			if (num - 1396284476 != 0)
			{
				num <<= 13;
				D3B95303 d3B = _2F2F02A8._73186E25();
				num &= 0xB4357E04u;
				d3B._82A5D1BE(_6B1C);
				continue;
			}
			break;
		}
		while (4038576299u <= num);
	}

	private void F49B8FA3()
	{
		while (true)
		{
			short c83B8C = _7E8CFF31._5F10D3B8();
			uint num = 3960682680u;
			if (num << 14 == 0)
			{
				break;
			}
			num = 1286100900 / num;
			D3B95303 d3B = _2F2F02A8.C4BFC635(c83B8C);
			num <<= 15;
			if (num <= 244262425)
			{
				do
				{
					_56AB72BE obj = _2F2F02A8;
					num = 864837163 - num;
					obj._93061C36(d3B._5C36403F());
				}
				while (-501890299 + (int)num == 0);
				break;
			}
		}
	}

	private void _6E9F1788()
	{
		uint num = 679871422u;
		D3B95303 d3B = default(D3B95303);
		if (9903633 < num)
		{
			d3B = _2F2F02A8.ED374FBA();
			if (num + 1093797258 == 0)
			{
				return;
			}
		}
		_56AB72BE obj = _2F2F02A8;
		num = 0x5BB92C9A ^ num;
		D3B95303 _4D8ED = obj.ED374FBA();
		_56AB72BE obj2 = _2F2F02A8;
		num ^= 0x6C9D7110;
		D3B95303 _73B4CE = d3B;
		num <<= 23;
		obj2._93061C36(B7035AA0._93862D8D(_4D8ED, _73B4CE));
	}

	private void FE1500AA()
	{
		uint num = 1929921949u;
		while (true)
		{
			short num2 = _7E8CFF31._5F10D3B8();
			num |= 0x30BC52BB;
			short c83B8C = num2;
			if (num << 20 == 0)
			{
				break;
			}
			num >>= 30;
			_56AB72BE obj = _2F2F02A8;
			num = (uint)(-1726813133 << (int)num);
			D3B95303 d3B = obj.C4BFC635(c83B8C);
			num *= 924091669;
			D3B95303 d3B2 = d3B;
			while (true)
			{
				num *= 1118622731;
				if (d3B2._4C0EC108())
				{
					if (num >> 20 == 0)
					{
						break;
					}
					throw new ArgumentException();
				}
				num *= 3061969330u;
				if (num * 4035607969u != 0)
				{
					_56AB72BE obj2 = _2F2F02A8;
					num = 0xC63A9230u & num;
					num <<= 5;
					obj2._93061C36(new _77BA31B1(d3B2));
					if (num == 2047714219)
					{
						break;
					}
					return;
				}
			}
		}
	}

	private void AC958491()
	{
		while (true)
		{
			uint num = 4272928187u;
			_56AB72BE obj = _2F2F02A8;
			num >>= 12;
			D3B95303 d3B = obj.ED374FBA();
			num = (uint)(-1785988706 << (int)num);
			D3B95303 _809A88B = d3B;
			num *= 2281934748u;
			if (num <= 3995203474u)
			{
				num = 0xA38425A8u & num;
				_56AB72BE obj2 = _2F2F02A8;
				num = 0xC1185188u | num;
				D3B95303 d3B2 = obj2.ED374FBA();
				num = 473062554 % num;
				D3B95303 a7B5EF = d3B2;
				num -= 3846174245u;
				_2F2F02A8._93061C36(DC09FDAD._708B1E15(a7B5EF, _809A88B));
				if (num * 2014299058 != 0)
				{
					break;
				}
			}
		}
	}

	private unsafe object D5865AB7(int _681B0B31)
	{
		if (_681B0B31 == 0)
		{
			return null;
		}
		uint num = 1462434491u;
		Dictionary<uint, object> dictionary = _81A40C9C;
		num >>= 4;
		Dictionary<uint, object> obj = dictionary;
		uint num2 = num - 91402155;
		num <<= 15;
		bool lockTaken = (byte)num2 != 0;
		object result = default(object);
		try
		{
			while (true)
			{
				num >>= 12;
				num %= 3015623218u;
				Monitor.Enter(obj, ref lockTaken);
				if ((num ^ 0x349358AE) == 0)
				{
					continue;
				}
				while (true)
				{
					num = 4037316773u % num;
					int num3 = _681B0B31 | ((int)num - -2147483371);
					num = 3691620788u >> (int)num;
					uint key = (uint)num3;
					num = 1144083877 * num;
					if (num > 3934730170u)
					{
						break;
					}
					Dictionary<uint, object> dictionary2 = _81A40C9C;
					num = 532054662 / num;
					num -= 3892450071u;
					num -= 1588883458;
					if (dictionary2.TryGetValue(key, out var value))
					{
						result = value;
						goto end_IL_0033;
					}
					IntPtr intPtr = _441DAF82.EEA4DE97((uint)_681B0B31);
					num *= 1761984416;
					byte* ptr = (byte*)(void*)intPtr;
					num >>= 30;
					uint num4 = num + 163074597;
					num = 243904959u >> (int)num;
					uint num5 = num4;
					int num6 = *(int*)ptr;
					num = 0xAA3142A6u ^ num;
					int num7 = num6 ^ (int)num5;
					num ^= 0xC08D6E8Bu;
					string text;
					if (num7 == 0)
					{
						string empty = string.Empty;
						num = 229835661 - num;
						text = empty;
						if ((num ^ 0x2222FABE) == 0)
						{
							goto end_IL_0033;
						}
						goto IL_02a5;
					}
					num = 3431413915u / num;
					byte* num8 = ptr;
					num = 0xFF09AD26u | num;
					byte* num9 = num8 + ((int)num ^ -16143069);
					num -= 495891896;
					ptr = num9;
					num = 0x8F184CABu & num;
					num ^= 0x2504E586;
					byte[] array = new byte[num7];
					num = 0xEE119084u ^ num;
					byte[] array2 = array;
					num |= 0x2D00F83C;
					uint num10 = num - 1863186749;
					num = 0x95A59FB8u & num;
					int num11 = (int)num10;
					while (2199061255u * num != 0)
					{
						int num12 = num11;
						num -= 1058051114;
						if (num12 < num7)
						{
							int num13 = num11;
							num = 1779827587u;
							byte* num14 = ptr;
							num -= 3518608772u;
							byte num15 = num14[num11];
							num %= 4085330446u;
							int num16 = num11 & (int)(num + 1738781216);
							num = 2441731768u + num;
							uint num17 = num5 << num16;
							uint num18 = num - 702950551;
							int num19 = num11;
							num *= 2384370309u;
							int num20 = ((int)num18 - num19) & (int)(num + 85110540);
							num %= 4221882415u;
							uint num21 = num15 ^ (num17 | (num5 >> num20));
							num = 2653458462u - num;
							byte num22 = (byte)num21;
							num >>= 29;
							array2[num13] = num22;
							if (num > 2552722872u)
							{
								goto end_IL_005d;
							}
							int num23 = num11;
							uint num24 = num - 4;
							num *= 3283013034u;
							num11 = num23 + (int)num24;
							num ^= 0xD76F9D6Au;
							continue;
						}
						goto IL_028f;
					}
					continue;
					IL_028f:
					text = Encoding.UTF8.GetString(array2);
					num += 3696288869u;
					goto IL_02a5;
					IL_02a5:
					if ((0x660CF587 ^ num) == 0)
					{
						break;
					}
					Dictionary<uint, object> dictionary3 = _81A40C9C;
					num *= 1277383198;
					num = 0x3FB80735 | num;
					string value2 = text;
					num /= 2651478330u;
					dictionary3.Add(key, value2);
					if (3549915581u >= num)
					{
						string text2 = text;
						num = 3917565873u - num;
						result = text2;
						if (296375969 >= num)
						{
							break;
						}
						goto end_IL_0033;
					}
					continue;
					end_IL_005d:
					break;
				}
				continue;
				end_IL_0033:
				break;
			}
		}
		finally
		{
			do
			{
				num = 723077254u;
				if ((num ^ 0x8C0A75A6u) == 0)
				{
					goto IL_0341;
				}
				bool num25 = lockTaken;
				num %= 2134221579;
				if (num25)
				{
					num %= 3951973810u;
					if (3064576562u > num)
					{
						goto IL_0341;
					}
				}
				continue;
				IL_0341:
				Monitor.Exit(obj);
				num ^= 0;
			}
			while (388097303 - num == 0);
		}
		return result;
	}

	public _02B4022E()
	{
		while (true)
		{
			Dictionary<uint, A93EA20B> e52C86B = new Dictionary<uint, A93EA20B>();
			uint num = 982601658u;
			E52C86B9 = e52C86B;
			while (true)
			{
				IL_0011:
				num = 1008952838 * num;
				C1BF430A c1BF430A = new C1BF430A();
				num = 0x2115FB1D ^ num;
				_7E8CFF31 = c1BF430A;
				num = 2478603417u * num;
				if (num > 2260643481u)
				{
					break;
				}
				while (true)
				{
					IL_003f:
					_2F2F02A8 = new _56AB72BE();
					while (true)
					{
						IL_004a:
						num = 4280268946u % num;
						_3209E1AD obj = new _3209E1AD();
						num <<= 4;
						_7D13B119 = obj;
						if (num % 1715021060 == 0)
						{
							break;
						}
						while (true)
						{
							IL_0071:
							List<IntPtr> list = new List<IntPtr>();
							num *= 2047526837;
							_162873A6 = list;
							while (true)
							{
								num = 2661578891u + num;
								if ((0x2CA07F08 & num) == 0)
								{
									break;
								}
								Dictionary<uint, A93EA20B> e52C86B2 = E52C86B9;
								int key = (int)num ^ -124494197;
								num %= 386504254;
								e52C86B2[(uint)key] = _48351722;
								num >>= 8;
								num = 3910211105u - num;
								Dictionary<uint, A93EA20B> e52C86B3 = E52C86B9;
								num = 1964889013 % num;
								uint key2 = num ^ 0x751DD3B4;
								num = 4027822626u * num;
								num = 0xEC28969Du ^ num;
								num = 2000610972 / num;
								e52C86B3[key2] = _3A8CE02D;
								num = 4203677847u + num;
								if (3892716558u > num)
								{
									goto end_IL_004a;
								}
								num = 0x123A5796 & num;
								Dictionary<uint, A93EA20B> e52C86B4 = E52C86B9;
								num ^= 0xDA07E7ACu;
								int key3 = (int)num ^ -938612930;
								num = 1252994312 % num;
								num = 673206832 + num;
								e52C86B4[(uint)key3] = _4E95E919;
								num += 411833746;
								if (num / 2058991915 != 0)
								{
									num /= 3778830478u;
									Dictionary<uint, A93EA20B> e52C86B5 = E52C86B9;
									num = 1309054505 * num;
									uint key4 = num ^ 3;
									num = 865304747 + num;
									num = 4211917735u / num;
									A93EA20B value = F9B9920E;
									num = 3733870231u % num;
									e52C86B5[key4] = value;
									num /= 2216782879u;
									Dictionary<uint, A93EA20B> e52C86B6 = E52C86B9;
									num -= 2558741050u;
									uint key5 = num ^ 0x677CB5C2;
									num = 0xE615D037u & num;
									e52C86B6[key5] = _67B61426;
									if (num << 18 != 0)
									{
										Dictionary<uint, A93EA20B> e52C86B7 = E52C86B9;
										uint key6 = num ^ 0x66149003;
										num /= 3750865160u;
										num = (uint)(614208782 << (int)num);
										num = 3627384747u % num;
										A93EA20B value2 = B9281D11;
										num |= 0x852E7A2Cu;
										e52C86B7[key6] = value2;
										if (2074711211 < num)
										{
											Dictionary<uint, A93EA20B> e52C86B8 = E52C86B9;
											int key7 = (int)num ^ -1523614101;
											A93EA20B value3 = _6E9F1788;
											num = 1217432229 + num;
											e52C86B8[(uint)key7] = value3;
											if (num > 3892810758u)
											{
												num = 0x6044B85 | num;
												Dictionary<uint, A93EA20B> e52C86B9 = E52C86B9;
												num >>= 6;
												uint key8 = num - 62853415;
												num = 0xFC342729u | num;
												e52C86B9[key8] = B03BFD10;
												num = 2417987892u - num;
												Dictionary<uint, A93EA20B> e52C86B10 = E52C86B9;
												num *= 137573687;
												uint key9 = num - 240476171;
												num = 4187242768u / num;
												num |= 0xD922C910u;
												A93EA20B value4 = FC284D0F;
												num ^= 0xE93E509Fu;
												e52C86B10[key9] = value4;
												num = 1107978528 % num;
												Dictionary<uint, A93EA20B> e52C86B11 = E52C86B9;
												num &= 0x7BBDE138;
												uint key10 = num - 296599815;
												num >>= 11;
												num = 523107083u >> (int)num;
												A93EA20B value5 = _470FB0A2;
												num &= 0x81137AB0u;
												e52C86B11[key10] = value5;
												num *= 2468562844u;
												num -= 3887385614u;
												Dictionary<uint, A93EA20B> e52C86B12 = E52C86B9;
												int key11 = (int)num + -1249881512;
												num /= 2786310181u;
												num += 893005976;
												A93EA20B value6 = A41F95A0;
												num = 0x26A073B8 | num;
												e52C86B12[(uint)key11] = value6;
												if (539166483 > num)
												{
													break;
												}
												Dictionary<uint, A93EA20B> e52C86B13 = E52C86B9;
												uint key12 = num ^ 0x37BA73B3;
												num = 0xACBC0D90u | num;
												num += 4231946248u;
												A93EA20B value7 = _9D8C1D86;
												num |= 0x2911BC35;
												e52C86B13[key12] = value7;
												num = 3457855021u % num;
												num <<= 15;
												Dictionary<uint, A93EA20B> e52C86B14 = E52C86B9;
												uint key13 = num ^ 0x571C000C;
												num = 1991229344u >> (int)num;
												A93EA20B value8 = _2991242C;
												num &= 0xC9A265A6u;
												e52C86B14[key13] = value8;
												if (num > 1303769908)
												{
													goto end_IL_004a;
												}
												Dictionary<uint, A93EA20B> e52C86B15 = E52C86B9;
												num %= 4019463486u;
												uint key14 = num ^ 0x40A225AD;
												num *= 3174325910u;
												num = 3281296897u * num;
												e52C86B15[key14] = _903894BF;
												Dictionary<uint, A93EA20B> e52C86B16 = E52C86B9;
												uint key15 = num ^ 0x52134BCE;
												num = 185000499 - num;
												num >>= 8;
												A93EA20B value9 = _40122130;
												num = 0x663C5E24 | num;
												e52C86B16[key15] = value9;
												num += 1988928311;
												Dictionary<uint, A93EA20B> e52C86B17 = E52C86B9;
												int key16 = (int)num - -582376738;
												num &= 0xE8A3ADACu;
												e52C86B17[(uint)key16] = _803401B1;
												if (3339200691u > num)
												{
													goto end_IL_004a;
												}
												Dictionary<uint, A93EA20B> e52C86B18 = E52C86B9;
												num *= 4146354749u;
												int key17 = (int)num - -955268884;
												num = 247100439u >> (int)num;
												num |= 0x958C4201u;
												e52C86B18[(uint)key17] = B4310B85;
												Dictionary<uint, A93EA20B> e52C86B19 = E52C86B9;
												int key18 = (int)num ^ -1785970160;
												A93EA20B value10 = B90E2FB2;
												num = 0x6F14AFB2 | num;
												e52C86B19[(uint)key18] = value10;
												num += 1814417673;
												if (num - 658355850 == 0)
												{
													goto end_IL_004a;
												}
												Dictionary<uint, A93EA20B> e52C86B20 = E52C86B9;
												int key19 = (int)num + -1807925418;
												num = 0x53887714 & num;
												A93EA20B value11 = EE30EC03;
												num *= 1678649909;
												e52C86B20[(uint)key19] = value11;
												num -= 2862009657u;
												Dictionary<uint, A93EA20B> e52C86B21 = E52C86B9;
												num = (uint)(1714987425 << (int)num);
												int key20 = (int)num - -989001747;
												num = 0x3E3B542C ^ num;
												A93EA20B value12 = F498053B;
												num += 958026557;
												e52C86B21[(uint)key20] = value12;
												num |= 0xDE81D484u;
												num = (uint)(285603720 << (int)num);
												Dictionary<uint, A93EA20B> e52C86B22 = E52C86B9;
												int key21 = (int)num - -1091502100;
												A93EA20B value13 = _8D87761A;
												num &= 0x3C3ED32E;
												e52C86B22[(uint)key21] = value13;
												num = 0xB0A0AD38u & num;
												if (1629998621 <= num)
												{
													goto end_IL_004a;
												}
												num &= 0xE0977E21u;
												Dictionary<uint, A93EA20B> e52C86B23 = E52C86B9;
												num = 0x421E7520 | num;
												uint key22 = num ^ 0x621E7535;
												num += 2182174652u;
												num = 1858049700 - num;
												A93EA20B value14 = _3CAA2C32;
												num *= 3180225181u;
												e52C86B23[key22] = value14;
												num = 227362586 % num;
												if ((num ^ 0xB193F527u) == 0)
												{
													break;
												}
												num %= 1186670469;
												Dictionary<uint, A93EA20B> e52C86B24 = E52C86B9;
												num *= 1184209722;
												uint key23 = num - 439409102;
												num <<= 16;
												num <<= 21;
												num = 520394781 - num;
												e52C86B24[key23] = AC958491;
												num ^= 0x44254503;
												Dictionary<uint, A93EA20B> e52C86B25 = E52C86B9;
												num = 1922846500 / num;
												int key24 = (int)num - -22;
												num = 1630400543 / num;
												A93EA20B value15 = _76021E9C;
												num <<= 17;
												e52C86B25[(uint)key24] = value15;
												num = 93349003 % num;
												Dictionary<uint, A93EA20B> e52C86B26 = E52C86B9;
												int key25 = (int)num + -93348979;
												num = 2318657724u + num;
												A93EA20B value16 = _2FB41ABD;
												num -= 1719788087;
												e52C86B26[(uint)key25] = value16;
												num |= 0x56284A33;
												if (num != 246757164)
												{
													Dictionary<uint, A93EA20B> e52C86B27 = E52C86B9;
													uint key26 = num ^ 0x7F6A6B2A;
													num = 3322626962u >> (int)num;
													num ^= 0x5FBB231B;
													num = 3812515902u + num;
													A93EA20B value17 = B627B535;
													num >>= 10;
													e52C86B27[key26] = value17;
													if (num * 1293922575 == 0)
													{
														goto end_IL_004a;
													}
													Dictionary<uint, A93EA20B> e52C86B28 = E52C86B9;
													num <<= 2;
													uint key27 = num ^ 0x42F986;
													num = 85935622u >> (int)num;
													num &= 0x95B3DF99u;
													num = 78767418 - num;
													A93EA20B value18 = D19B343F;
													num %= 2545549068u;
													e52C86B28[key27] = value18;
													if ((num ^ 0xBE0E43ADu) == 0)
													{
														goto end_IL_004a;
													}
													num <<= 15;
													Dictionary<uint, A93EA20B> e52C86B29 = E52C86B9;
													int key28 = (int)num ^ -224591845;
													num = 0x9338A785u | num;
													e52C86B29[(uint)key28] = EB15D00C;
													Dictionary<uint, A93EA20B> e52C86B30 = E52C86B9;
													num &= 0x4D2510B8;
													uint key29 = num - 1092943972;
													num = 3961874353u / num;
													num ^= 0x14B31E23;
													e52C86B30[key29] = BCBA04B2;
													num <<= 10;
													if (num < 916585218)
													{
														goto end_IL_004a;
													}
													Dictionary<uint, A93EA20B> e52C86B31 = E52C86B9;
													uint key30 = num + 864518173;
													num /= 1346203919;
													A93EA20B value19 = _1F9AC134;
													num = 2771091982u % num;
													e52C86B31[key30] = value19;
													num ^= 0xD19B19AEu;
													if ((num ^ 0xB8235E1Du) != 0)
													{
														Dictionary<uint, A93EA20B> e52C86B32 = E52C86B9;
														int key31 = (int)num ^ -778364496;
														num = 1010384036u >> (int)num;
														num *= 3667027463u;
														A93EA20B value20 = _83893493;
														num >>= 24;
														e52C86B32[(uint)key31] = value20;
														num = 3474602810u >> (int)num;
														num = 1606264988u >> (int)num;
														Dictionary<uint, A93EA20B> e52C86B33 = E52C86B9;
														uint key32 = num ^ 0x17EE9;
														num = 865082787 - num;
														num = (uint)(-1280930659 << (int)num);
														num /= 335858723;
														A93EA20B value21 = _729F2232;
														num = 2427684878u % num;
														e52C86B33[key32] = value21;
														num &= 0xDE2CEF2Eu;
														if (num - 2845600644u != 0)
														{
															num = 2173540795u / num;
															Dictionary<uint, A93EA20B> e52C86B34 = E52C86B9;
															num %= 3557040801u;
															int key33 = (int)num + -271692567;
															num += 2661138851u;
															num -= 1501804835;
															num <<= 0;
															A93EA20B value22 = _97BBBAA6;
															num <<= 10;
															e52C86B34[(uint)key33] = value22;
															if ((int)num - -1280627680 == 0)
															{
																goto end_IL_004a;
															}
															Dictionary<uint, A93EA20B> e52C86B35 = E52C86B9;
															uint key34 = num - 787405791;
															num -= 1377867693;
															num = 2181331510u * num;
															num *= 1955530417;
															A93EA20B value23 = FC284D0F;
															num = 3148838811u + num;
															e52C86B35[key34] = value23;
															if (2428035853u * num != 0)
															{
																num = 0x881A14B7u | num;
																Dictionary<uint, A93EA20B> e52C86B36 = E52C86B9;
																int key35 = (int)num ^ -920996643;
																num = 3642245549u + num;
																num ^= 0xB2378885u;
																num = 0x8C1FED18u | num;
																A93EA20B value24 = E6AF5B31;
																num = 0x13B64BBA | num;
																e52C86B36[(uint)key35] = value24;
																num = 412338313u >> (int)num;
																if (-869395402 - (int)num == 0)
																{
																	goto end_IL_004a;
																}
																Dictionary<uint, A93EA20B> e52C86B37 = E52C86B9;
																num = 0x4A16010A & num;
																uint key36 = num ^ 0x21;
																num = 0xA7326D98u ^ num;
																num ^= 0x86A58D20u;
																e52C86B37[key36] = E692F42E;
																num *= 2636500797u;
																Dictionary<uint, A93EA20B> e52C86B38 = E52C86B9;
																num = 0x5881668F & num;
																int key37 = (int)num + -1484808670;
																num >>= 17;
																A93EA20B value25 = _442EF021;
																num /= 3458582017u;
																e52C86B38[(uint)key37] = value25;
																num /= 3811193487u;
																Dictionary<uint, A93EA20B> e52C86B39 = E52C86B9;
																num = 0x3016E1A6 ^ num;
																uint key38 = num - 806805889;
																A93EA20B value26 = F5988A3D;
																num %= 262175294;
																e52C86B39[key38] = value26;
																if (num > 721747760)
																{
																	goto end_IL_004a;
																}
																E52C86B9[num ^ 0x13572CA] = _27A0AEA0;
																if (110230297 << (int)num == 0)
																{
																	goto end_IL_004a;
																}
																num ^= 0x5A0C898C;
																Dictionary<uint, A93EA20B> e52C86B40 = E52C86B9;
																num = 1805443862 - num;
																uint key39 = num ^ 0x1062E791;
																num ^= 0x8014C884u;
																num = 0x28178383 & num;
																A93EA20B value27 = _003D8513;
																num /= 395738278;
																e52C86B40[key39] = value27;
																Dictionary<uint, A93EA20B> e52C86B41 = E52C86B9;
																num = 4112196622u * num;
																uint key40 = num + 40;
																num >>= 9;
																num += 1603570366;
																A93EA20B value28 = C0357698;
																num = (uint)(-1079627515 << (int)num);
																e52C86B41[key40] = value28;
																num = 3768631180u - num;
																Dictionary<uint, A93EA20B> e52C86B42 = E52C86B9;
																num = 2350137512u * num;
																uint key41 = num - 542159799;
																num = (uint)(-2137654638 << (int)num);
																num = 1898946994 % num;
																A93EA20B value29 = B1BC5031;
																num -= 2610655744u;
																e52C86B42[key41] = value29;
																num += 3424151685u;
																Dictionary<uint, A93EA20B> e52C86B43 = E52C86B9;
																int key42 = (int)num ^ -1582524387;
																num = 504294075 - num;
																num = 641235120 / num;
																A93EA20B value30 = ED048E22;
																num /= 3475798950u;
																e52C86B43[(uint)key42] = value30;
																num = 3334268991u + num;
																Dictionary<uint, A93EA20B> e52C86B44 = E52C86B9;
																uint key43 = num + 960698348;
																num %= 3727848324u;
																A93EA20B value31 = FE1500AA;
																num ^= 0xCE9A37ADu;
																e52C86B44[key43] = value31;
																num = 0x178E7E33 | num;
																if (num >= 1956650785)
																{
																	goto end_IL_004a;
																}
																Dictionary<uint, A93EA20B> e52C86B45 = E52C86B9;
																uint key44 = num - 531562375;
																num = 4248160900u + num;
																num &= 0x8E13350Bu;
																A93EA20B value32 = CD21BC33;
																num = 579470101 / num;
																e52C86B45[key44] = value32;
																num >>= 23;
																if (2610417066u * num != 0)
																{
																	goto end_IL_004a;
																}
																Dictionary<uint, A93EA20B> e52C86B46 = E52C86B9;
																num %= 2072942653;
																int key45 = (int)num - -45;
																A93EA20B value33 = CAB68E1D;
																num /= 3416607520u;
																e52C86B46[(uint)key45] = value33;
																num = 2864584759u >> (int)num;
																if (1024334998 > num)
																{
																	goto end_IL_004a;
																}
																num %= 3007115024u;
																Dictionary<uint, A93EA20B> e52C86B47 = E52C86B9;
																uint key46 = num + 1430382583;
																num = 2000237361 / num;
																num = (uint)(808421294 << (int)num);
																num *= 2636640409u;
																A93EA20B value34 = _1A319294;
																num = 1989581584 * num;
																e52C86B47[key46] = value34;
																Dictionary<uint, A93EA20B> e52C86B48 = E52C86B9;
																int key47 = (int)num ^ -822920753;
																num <<= 5;
																num = 0x71A94791 & num;
																e52C86B48[(uint)key47] = F49B8FA3;
																if (num > 2443209142u)
																{
																	goto end_IL_004a;
																}
																Dictionary<uint, A93EA20B> e52C86B49 = E52C86B9;
																int key48 = (int)num + -1344340944;
																num = 0x6B8F94A9 & num;
																num += 2386538038u;
																num -= 146241027;
																A93EA20B value35 = B117DD87;
																num -= 1512887996;
																e52C86B49[(uint)key48] = value35;
																num += 3426274606u;
																if (num - 1427299104 == 0)
																{
																	goto IL_0071;
																}
																num = 0xFE94F506u & num;
																Dictionary<uint, A93EA20B> e52C86B50 = E52C86B9;
																num = 0x23073035 ^ num;
																uint key49 = num ^ 0x15930000;
																num += 2905752705u;
																num ^= 0xF4228080u;
																A93EA20B value36 = _9A3BC4AD;
																num -= 2015544845;
																e52C86B50[key49] = value36;
																num = 0x8619A025u | num;
																Dictionary<uint, A93EA20B> e52C86B51 = E52C86B9;
																int key50 = (int)num - -1092747789;
																num /= 3984762130u;
																num = 1076008381 + num;
																A93EA20B value37 = E8A32EBC;
																num = (uint)(1436297738 << (int)num);
																e52C86B51[(uint)key50] = value37;
																num ^= 0x66B2FF29;
																Dictionary<uint, A93EA20B> e52C86B52 = E52C86B9;
																uint key51 = num ^ 0x26B2FF1A;
																num |= 0x1C946C03;
																A93EA20B value38 = AD29420C;
																num *= 3711821868u;
																e52C86B52[key51] = value38;
																E52C86B9[num ^ 0x8AF1D350u] = FE07070B;
																num = 1689481373 - num;
																if (437158055 == num)
																{
																	break;
																}
																num = 1253078441u >> (int)num;
																Dictionary<uint, A93EA20B> e52C86B53 = E52C86B9;
																num = 0x7F0BE7AA & num;
																uint key52 = num ^ 0x15;
																num = 346984885 + num;
																num = 178642561 % num;
																A93EA20B value39 = EBA1110A;
																num >>= 22;
																e52C86B53[key52] = value39;
																if (num >> 0 == 0)
																{
																	goto end_IL_004a;
																}
																num <<= 18;
																Dictionary<uint, A93EA20B> e52C86B54 = E52C86B9;
																num *= 135776541;
																e52C86B54[num ^ 0xFB080036u] = _1E038BAE;
																num *= 2814315683u;
																E52C86B9[num - 907542473] = _57267AA0;
																if (1913941786 + num == 0)
																{
																	goto IL_004a;
																}
																num %= 4013890725u;
																Dictionary<uint, A93EA20B> e52C86B55 = E52C86B9;
																num = 1941623470 % num;
																uint key53 = num - 126538358;
																num %= 3492477836u;
																e52C86B55[key53] = _45AE3104;
																if ((0xC89CF62Fu ^ num) != 0)
																{
																	num = 0xE8387D85u ^ num;
																	Dictionary<uint, A93EA20B> e52C86B56 = E52C86B9;
																	num <<= 29;
																	uint key54 = num ^ 0x60000039;
																	num &= 0x808C7DAEu;
																	A93EA20B value40 = _1B3C0EA0;
																	num += 673328574;
																	e52C86B56[key54] = value40;
																	if (1402566298 >>> (int)num == 0)
																	{
																		goto end_IL_004a;
																	}
																	Dictionary<uint, A93EA20B> e52C86B57 = E52C86B9;
																	num %= 1077552423;
																	uint key55 = num - 673328516;
																	num = 0x7005AB87 ^ num;
																	A93EA20B value41 = _4B8820A3;
																	num <<= 31;
																	e52C86B57[key55] = value41;
																	Dictionary<uint, A93EA20B> e52C86B58 = E52C86B9;
																	int key56 = (int)num ^ -2147483589;
																	num = 0x6A975BAE | num;
																	num <<= 28;
																	e52C86B58[(uint)key56] = FE8F4E01;
																	num <<= 25;
																	num = 0xD81DB5B5u & num;
																	Dictionary<uint, A93EA20B> e52C86B59 = E52C86B9;
																	uint key57 = num ^ 0x3C;
																	num |= 0x8716F689u;
																	num = 61037723 / num;
																	A93EA20B value42 = _470FB0A2;
																	num -= 1964135859;
																	e52C86B59[key57] = value42;
																	num &= 0x76AEB21E;
																	Dictionary<uint, A93EA20B> e52C86B60 = E52C86B9;
																	num = 4070965153u - num;
																	int key58 = (int)num - -268870312;
																	num *= 3120759809u;
																	num *= 431874484;
																	num /= 789706798;
																	A93EA20B value43 = _29B79425;
																	num *= 2710403892u;
																	e52C86B60[(uint)key58] = value43;
																	num = 0xE316AF0Bu ^ num;
																	if (1866017552 >>> (int)num == 0)
																	{
																		goto end_IL_004a;
																	}
																	num = 2056013328 * num;
																	Dictionary<uint, A93EA20B> e52C86B61 = E52C86B9;
																	uint key59 = num ^ 0x5D5F334E;
																	num &= 0xAF3505AEu;
																	num = 3801119244u - num;
																	A93EA20B value44 = DE3B28B2;
																	num = (uint)(1873173633 << (int)num);
																	e52C86B61[key59] = value44;
																	num <<= 2;
																	if (num % 3097923856u == 0)
																	{
																		goto end_IL_004a;
																	}
																	Dictionary<uint, A93EA20B> e52C86B62 = E52C86B9;
																	num = 2746252187u / num;
																	uint key60 = num + 62;
																	num &= 0x5CA47B3D;
																	num &= 0xE2A089A3u;
																	e52C86B62[key60] = AC801780;
																	if (2251204495u <= num)
																	{
																		continue;
																	}
																	Dictionary<uint, A93EA20B> e52C86B63 = E52C86B9;
																	uint key61 = num ^ 0x41;
																	num = 1225174698u >> (int)num;
																	num %= 1378274869;
																	A93EA20B value45 = _5F853100;
																	num += 2903805373u;
																	e52C86B63[key61] = value45;
																	num = 1831337020 / num;
																	num = 2098432931 + num;
																	Dictionary<uint, A93EA20B> e52C86B64 = E52C86B9;
																	int key62 = (int)num + -2098432866;
																	num &= 0xAA84D1B2u;
																	num >>= 5;
																	e52C86B64[(uint)key62] = _8A0AFC14;
																	num -= 3340575148u;
																	if (513247395 >= num)
																	{
																		break;
																	}
																	Dictionary<uint, A93EA20B> e52C86B65 = E52C86B9;
																	num = 0xCC13DEB2u & num;
																	uint key63 = num ^ 0x802C262;
																	A93EA20B value46 = _6C8C4E1C;
																	num ^= 0xE31404BEu;
																	e52C86B65[key63] = value46;
																	num -= 2744759987u;
																	Dictionary<uint, A93EA20B> e52C86B66 = E52C86B9;
																	num <<= 4;
																	uint key64 = num ^ 0x77D0FEF3;
																	A93EA20B value47 = _3A865CBF;
																	num = 1052725412u >> (int)num;
																	e52C86B66[key64] = value47;
																	num = 0xD63C799Bu ^ num;
																	if (-653214414 == (int)num)
																	{
																		break;
																	}
																	Dictionary<uint, A93EA20B> e52C86B67 = E52C86B9;
																	num = 2810252810u >> (int)num;
																	uint key65 = num ^ 0xA7810A4;
																	num /= 2418689040u;
																	e52C86B67[key65] = _52B85689;
																	num /= 1696914305;
																	Dictionary<uint, A93EA20B> e52C86B68 = E52C86B9;
																	num = 0xAF11CB13u | num;
																	int key66 = (int)num ^ -1357788330;
																	num |= 0x52171A2;
																	num |= 0xE8960F26u;
																	e52C86B68[(uint)key66] = C214DD3C;
																	if ((num & 0x798F32B5) == 0)
																	{
																		break;
																	}
																	Dictionary<uint, A93EA20B> e52C86B69 = E52C86B9;
																	uint key67 = num + 273154191;
																	num = 984872346 % num;
																	num = 1243582978 + num;
																	e52C86B69[key67] = _8AA5B881;
																	if (687964841 == num)
																	{
																		goto end_IL_004a;
																	}
																	num <<= 28;
																	Dictionary<uint, A93EA20B> e52C86B70 = E52C86B9;
																	uint key68 = num + 1073741895;
																	num = 3215799719u * num;
																	e52C86B70[key68] = _8C05239F;
																	Dictionary<uint, A93EA20B> e52C86B71 = E52C86B9;
																	uint key69 = num ^ 0x40000048;
																	num -= 3861711360u;
																	e52C86B71[key69] = _64385E2E;
																	num = (uint)(2049178038 << (int)num);
																	num ^= 0xB8BBB89Bu;
																	Dictionary<uint, A93EA20B> e52C86B72 = E52C86B9;
																	num <<= 9;
																	uint key70 = num ^ 0x30825A49;
																	num = 0x3C1E9009 ^ num;
																	A93EA20B value48 = _65278E35;
																	num <<= 27;
																	e52C86B72[key70] = value48;
																	if ((num & 0x50B99C83) != 0)
																	{
																		Dictionary<uint, A93EA20B> e52C86B73 = E52C86B9;
																		uint key71 = num ^ 0x4800004A;
																		num = 0xFC9284B6u ^ num;
																		num = 799702694 / num;
																		A93EA20B value49 = _8D828EA2;
																		num >>= 11;
																		e52C86B73[key71] = value49;
																		num = 0x400C6D2F | num;
																		Dictionary<uint, A93EA20B> e52C86B74 = E52C86B9;
																		num = 0x7026182A ^ num;
																		uint key72 = num ^ 0x302A754E;
																		num = 4062820363u % num;
																		e52C86B74[key72] = _6B96DF08;
																		num /= 1787639565;
																		num -= 2050320409;
																		Dictionary<uint, A93EA20B> e52C86B75 = E52C86B9;
																		num |= 0xE3BA092Fu;
																		int key73 = (int)num ^ -403005533;
																		num >>= 27;
																		num = 791438387 * num;
																		e52C86B75[(uint)key73] = A43285A0;
																		if (1158638360 == num)
																		{
																			goto end_IL_004a;
																		}
																		num = 0xE0A3B826u & num;
																		Dictionary<uint, A93EA20B> e52C86B76 = E52C86B9;
																		uint key74 = num - 545435575;
																		num = 0xF7273C20u ^ num;
																		num = 0xC6974E9Bu & num;
																		A93EA20B value50 = _52BD83B3;
																		num = 3465191307u / num;
																		e52C86B76[key74] = value50;
																		num ^= 0xFE361194u;
																		if (num != 1258845977)
																		{
																			num = 1588264225 - num;
																			Dictionary<uint, A93EA20B> e52C86B77 = E52C86B9;
																			num &= 0x2D94738B;
																			uint key75 = num ^ 0x201463C6;
																			num = 2905584143u % num;
																			e52C86B77[key75] = CB95EF1A;
																			if (-930495229 == (int)num)
																			{
																				goto end_IL_004a;
																			}
																			num %= 4030597649u;
																			Dictionary<uint, A93EA20B> e52C86B78 = E52C86B9;
																			int key76 = (int)num + -214548504;
																			num &= 0x182E8AB0;
																			e52C86B78[(uint)key76] = _1201F809;
																			if (num << 18 == 0)
																			{
																				goto end_IL_004a;
																			}
																			num |= 0xDC8CB393u;
																			Dictionary<uint, A93EA20B> e52C86B79 = E52C86B9;
																			int key77 = (int)num ^ -594758685;
																			num = 0x3B9EF301 & num;
																			num /= 389542712;
																			num = 3426486558u + num;
																			e52C86B79[(uint)key77] = B7AB4FB8;
																			num = 4203128853u + num;
																			Dictionary<uint, A93EA20B> e52C86B80 = E52C86B9;
																			int key78 = (int)num - -960319261;
																			num = 4147163034u / num;
																			num -= 204660759;
																			A93EA20B value51 = _3286A91D;
																			num ^= 0x8B499D;
																			e52C86B80[(uint)key78] = value51;
																			num = 2499996197u % num;
																			if (num << 30 == 0)
																			{
																				break;
																			}
																			Dictionary<uint, A93EA20B> e52C86B81 = E52C86B9;
																			int key79 = (int)num - -1794971181;
																			num %= 329613487;
																			A93EA20B value52 = EE85C28A;
																			num |= 0xF2263E84u;
																			e52C86B81[(uint)key79] = value52;
																			if (4244927156u < num)
																			{
																				goto end_IL_004a;
																			}
																			Dictionary<uint, A93EA20B> e52C86B82 = E52C86B9;
																			int key80 = (int)num ^ -75595889;
																			num <<= 20;
																			num = 1068238505 * num;
																			e52C86B82[(uint)key80] = _8DB67B0E;
																			if ((num ^ 0x55343B8D) == 0)
																			{
																				goto end_IL_004a;
																			}
																			num &= 0xA0BF3512u;
																			E52C86B9[num ^ 0x800054] = _46B75F0E;
																			Dictionary<uint, A93EA20B> e52C86B83 = E52C86B9;
																			num = 0xBD0C52B4u | num;
																			int key81 = (int)num ^ -1114877215;
																			num = 4043800213u / num;
																			num = 2189790355u + num;
																			num /= 1320437559;
																			A93EA20B value53 = _10282C26;
																			num = 0x1C2A2C99 ^ num;
																			e52C86B83[(uint)key81] = value53;
																			num = 3677859114u + num;
																			if ((num ^ 0xE6006A2Cu) == 0)
																			{
																				goto end_IL_004a;
																			}
																			num ^= 0xCD075617u;
																			Dictionary<uint, A93EA20B> e52C86B84 = E52C86B9;
																			uint key82 = num - 979799935;
																			num = 4129086898u >> (int)num;
																			num <<= 29;
																			A93EA20B value54 = _1502A3A0;
																			num = 680139664 + num;
																			e52C86B84[key82] = value54;
																			num -= 2284210335u;
																			num = 3422827535u - num;
																			Dictionary<uint, A93EA20B> e52C86B85 = E52C86B9;
																			num ^= 0x62A1CF8E;
																			uint key83 = num - 1224846905;
																			num = 0x42B9DE1A ^ num;
																			num = 772355124 + num;
																			num &= 0xF01BF8B6u;
																			A93EA20B value55 = _5C9EBE36;
																			num += 2669863959u;
																			e52C86B85[key83] = value55;
																			num = (uint)(-644841075 << (int)num);
																			if (163474980 << (int)num == 0)
																			{
																				goto end_IL_004a;
																			}
																			Dictionary<uint, A93EA20B> e52C86B86 = E52C86B9;
																			int key84 = (int)num + -271687592;
																			num -= 2160041116u;
																			num -= 2049665410;
																			e52C86B86[(uint)key84] = _672EAC85;
																			num <<= 8;
																			if (num >= 3913223185u)
																			{
																				break;
																			}
																			Dictionary<uint, A93EA20B> e52C86B87 = E52C86B9;
																			num = 1739299464 + num;
																			uint key85 = num + 1371177937;
																			num = 0xAE056C20u | num;
																			num <<= 25;
																			num -= 3147592583u;
																			A93EA20B value56 = FA3C8E81;
																			num |= 0x81AFD4A8u;
																			e52C86B87[key85] = value56;
																			num = (uint)(-1627378672 << (int)num);
																			Dictionary<uint, A93EA20B> e52C86B88 = E52C86B9;
																			num = 0x7D0020A1 & num;
																			int key86 = (int)num + -536870822;
																			A93EA20B value57 = _11884D88;
																			num /= 520480423;
																			e52C86B88[(uint)key86] = value57;
																			num = 2786092040u / num;
																			Dictionary<uint, A93EA20B> e52C86B89 = E52C86B9;
																			num = 2536843042u + num;
																			uint key87 = num - 1027967695;
																			A93EA20B value58 = D200888C;
																			num = 1948340148 - num;
																			e52C86B89[key87] = value58;
																			num = 4088897339u + num;
																			Dictionary<uint, A93EA20B> e52C86B90 = E52C86B9;
																			num = 456057523u >> (int)num;
																			uint key88 = num - 14251705;
																			num = 3124166708u * num;
																			e52C86B90[key88] = _27268CBA;
																			num /= 2619108789u;
																			Dictionary<uint, A93EA20B> e52C86B91 = E52C86B9;
																			num &= 0x611FD835;
																			uint key89 = num + 93;
																			num |= 0x8A3FFA31u;
																			A93EA20B value59 = _2EA28017;
																			num = 3451889304u % num;
																			e52C86B91[key89] = value59;
																			Dictionary<uint, A93EA20B> e52C86B92 = E52C86B9;
																			num %= 26714673;
																			uint key90 = num ^ 0x9F1003;
																			num %= 1555142035;
																			num *= 857260214;
																			e52C86B92[key90] = _6C051AB3;
																			num >>= 22;
																			if (num >= 2516785946u)
																			{
																				goto end_IL_004a;
																			}
																			Dictionary<uint, A93EA20B> e52C86B93 = E52C86B9;
																			num = 2006421810u >> (int)num;
																			uint key91 = num ^ 0x726;
																			num -= 758327713;
																			num /= 3971569582u;
																			num %= 607849377;
																			A93EA20B value60 = AA03EBA9;
																			num *= 2434035971u;
																			e52C86B93[key91] = value60;
																			num = (uint)(-2053428067 << (int)num);
																			Dictionary<uint, A93EA20B> e52C86B94 = E52C86B9;
																			num ^= 0x752EF2B7;
																			uint key92 = num + 256516662;
																			num |= 0x3909C422;
																			num = 3784071597u / num;
																			num = 2433094445u >> (int)num;
																			A93EA20B value61 = DB8B980D;
																			num = 1141027207 % num;
																			e52C86B94[key92] = value61;
																			if ((num & 0x629CF2AC) == 0)
																			{
																				goto end_IL_004a;
																			}
																			num >>= 7;
																			Dictionary<uint, A93EA20B> e52C86B95 = E52C86B9;
																			uint key93 = num - 8914178;
																			num %= 4262095521u;
																			num = (uint)(664223542 << (int)num);
																			A93EA20B value62 = _9780C019;
																			num = 3064267016u + num;
																			e52C86B95[key93] = value62;
																			num <<= 21;
																			if (num > 3652902585u)
																			{
																				goto IL_0071;
																			}
																			num >>= 5;
																			Dictionary<uint, A93EA20B> e52C86B96 = E52C86B9;
																			uint key94 = num ^ 0x2B80062;
																			num = 0x14387C1A ^ num;
																			A93EA20B value63 = _70AD9310;
																			num = 1740352153 + num;
																			e52C86B96[key94] = value63;
																			Dictionary<uint, A93EA20B> e52C86B97 = E52C86B9;
																			num = 1486831906 - num;
																			int key95 = (int)num ^ -631039476;
																			num = 1857501192 + num;
																			num = 0xD58735B3u & num;
																			A93EA20B value64 = _8D828EA2;
																			num = 0x234C82E ^ num;
																			e52C86B97[(uint)key95] = value64;
																			num >>= 16;
																			Dictionary<uint, A93EA20B> e52C86B98 = E52C86B9;
																			num = 0x4A20EE1D & num;
																			uint key96 = num ^ 0x4270;
																			num = 506166154 % num;
																			num = 2971675285u % num;
																			num = 3911041834u / num;
																			A93EA20B value65 = _5C9EBE36;
																			num = 899604521 - num;
																			e52C86B98[key96] = value65;
																			num = 0x71A0F335 | num;
																			Dictionary<uint, A93EA20B> e52C86B99 = E52C86B9;
																			uint key97 = num - 1974662032;
																			num = 0xE629750Fu | num;
																			A93EA20B value66 = _8D828EA2;
																			num = 675186489 % num;
																			e52C86B99[key97] = value66;
																			num -= 1543767982;
																			num &= 0xD1265E1Eu;
																			Dictionary<uint, A93EA20B> e52C86B100 = E52C86B9;
																			num += 2046993342;
																			int key98 = (int)num + -975503714;
																			num = 0xF40D6482u | num;
																			num = (uint)(-996417913 << (int)num);
																			num %= 2637512986u;
																			A93EA20B value67 = _3A865CBF;
																			num |= 0x97ABEEAFu;
																			e52C86B100[(uint)key98] = value67;
																			num <<= 29;
																			num <<= 1;
																			Dictionary<uint, A93EA20B> e52C86B101 = E52C86B9;
																			uint key99 = num + 1073741927;
																			num = 0xEBA27A2 ^ num;
																			num = 1562297249 / num;
																			A93EA20B value68 = DB8B980D;
																			num |= 0x2CB6443D;
																			e52C86B101[key99] = value68;
																			Dictionary<uint, A93EA20B> e52C86B102 = E52C86B9;
																			num = 822312895 + num;
																			int key100 = (int)num + -1572455316;
																			num = 0x9B8ED205u | num;
																			e52C86B102[(uint)key100] = F9B9920E;
																			if ((num ^ 0x151423B8) == 0)
																			{
																				goto end_IL_004a;
																			}
																			Dictionary<uint, A93EA20B> e52C86B103 = E52C86B9;
																			num = 2654911021u >> (int)num;
																			int key101 = (int)num - -101;
																			num -= 2643609791u;
																			A93EA20B value69 = _10282C26;
																			num &= 0x853531A7u;
																			e52C86B103[(uint)key101] = value69;
																			num = 842697139 % num;
																			if ((num & 0x9B80CB22u) != 0)
																			{
																				Dictionary<uint, A93EA20B> e52C86B104 = E52C86B9;
																				num = 3912762416u >> (int)num;
																				int key102 = (int)num + -826;
																				num >>= 22;
																				num *= 3615591585u;
																				e52C86B104[(uint)key102] = _45AE3104;
																				Dictionary<uint, A93EA20B> e52C86B105 = E52C86B9;
																				num += 3457773216u;
																				int key103 = (int)num ^ -837194037;
																				A93EA20B value70 = _83893493;
																				num /= 1981012240;
																				e52C86B105[(uint)key103] = value70;
																				if (932234386 / num == 0)
																				{
																					goto end_IL_004a;
																				}
																				Dictionary<uint, A93EA20B> e52C86B106 = E52C86B9;
																				num = 0x358E2D8F ^ num;
																				uint key104 = num ^ 0x358E2DE2;
																				num /= 3350375328u;
																				num = 842039845 - num;
																				e52C86B106[key104] = _3CAA2C32;
																				num = 0xE707E12Au & num;
																				Dictionary<uint, A93EA20B> e52C86B107 = E52C86B9;
																				int key105 = (int)num + -570458035;
																				num = 2771312273u + num;
																				A93EA20B value71 = DE3B28B2;
																				num += 1470276260;
																				e52C86B107[(uint)key105] = value71;
																				num = 2846336899u * num;
																				Dictionary<uint, A93EA20B> e52C86B108 = E52C86B9;
																				num = 3246675627u >> (int)num;
																				uint key106 = num + 109;
																				num /= 3491419949u;
																				num &= 0x68964D33;
																				num ^= 0xBC2F132Fu;
																				e52C86B108[key106] = _3CAA2C32;
																				num += 404280620;
																				Dictionary<uint, A93EA20B> e52C86B109 = E52C86B9;
																				num = 3952701068u >> (int)num;
																				uint key107 = num ^ 0x72;
																				num /= 1302860314;
																				num <<= 15;
																				e52C86B109[key107] = _4B8820A3;
																				num >>= 25;
																				if (714848641 + num == 0)
																				{
																					break;
																				}
																				Dictionary<uint, A93EA20B> e52C86B110 = E52C86B9;
																				int key108 = (int)num - -112;
																				num /= 3837138309u;
																				e52C86B110[(uint)key108] = A43285A0;
																				if (num != 3423827774u)
																				{
																					num |= 0x45248C35;
																					Dictionary<uint, A93EA20B> e52C86B111 = E52C86B9;
																					num *= 2503133367u;
																					uint key109 = num - 906207602;
																					num = 2603886874u % num;
																					num /= 1677901495;
																					num *= 2276027292u;
																					e52C86B111[key109] = A43285A0;
																					num = (uint)(-1414827841 << (int)num);
																					Dictionary<uint, A93EA20B> e52C86B112 = E52C86B9;
																					num %= 3359057324u;
																					int key110 = (int)num ^ -1414827827;
																					A93EA20B value72 = _27268CBA;
																					num <<= 0;
																					e52C86B112[(uint)key110] = value72;
																					num >>= 15;
																					num <<= 2;
																					Dictionary<uint, A93EA20B> e52C86B113 = E52C86B9;
																					num = (uint)(833360425 << (int)num);
																					int key111 = (int)num + -687865741;
																					num = 2905861296u / num;
																					num %= 984100789;
																					A93EA20B value73 = _4B8820A3;
																					num = 0x7F9B5528 | num;
																					e52C86B113[(uint)key111] = value73;
																					if ((num & 0x1235231C) == 0)
																					{
																						goto end_IL_004a;
																					}
																					Dictionary<uint, A93EA20B> e52C86B114 = E52C86B9;
																					num = 0xF60CCF07u ^ num;
																					e52C86B114[num ^ 0x89979A5Fu] = _470FB0A2;
																					if (858520970 - num == 0)
																					{
																						goto end_IL_004a;
																					}
																					num /= 3718513976u;
																					Dictionary<uint, A93EA20B> e52C86B115 = E52C86B9;
																					uint key112 = num ^ 0x75;
																					num = 0x510C0C35 | num;
																					num &= 0xD7AFE6BEu;
																					A93EA20B value74 = B117DD87;
																					num <<= 31;
																					e52C86B115[key112] = value74;
																					num &= 0x42AFB63A;
																					num = 950911023 - num;
																					Dictionary<uint, A93EA20B> e52C86B116 = E52C86B9;
																					num ^= 0x6F8A12B5;
																					uint key113 = num ^ 0x5727D2EC;
																					num /= 856620680;
																					num *= 2972377118u;
																					e52C86B116[key113] = _1A319294;
																					num = (uint)(1596094764 << (int)num);
																					Dictionary<uint, A93EA20B> e52C86B117 = E52C86B9;
																					num = 0x618AC803 ^ num;
																					int key114 = (int)num + -1636485004;
																					num = (uint)(1763781311 << (int)num);
																					e52C86B117[(uint)key114] = _65278E35;
																					num = 1371381391 + num;
																					if ((num ^ 0xDC1C6495u) == 0)
																					{
																						break;
																					}
																					Dictionary<uint, A93EA20B> e52C86B118 = E52C86B9;
																					int key115 = (int)num - -1698237425;
																					num ^= 0xBAA10905u;
																					num = 790332594 + num;
																					A93EA20B value75 = B90E2FB2;
																					num ^= 0xD733C28Bu;
																					e52C86B118[(uint)key115] = value75;
																					num += 152717084;
																					if (num << 8 == 0)
																					{
																						goto end_IL_004a;
																					}
																					Dictionary<uint, A93EA20B> e52C86B119 = E52C86B9;
																					num -= 3761428885u;
																					uint key116 = num + 1047024179;
																					num = (uint)(-694326240 << (int)num);
																					num = 0xFB948202u & num;
																					num = 2267291318u % num;
																					e52C86B119[key116] = B9281D11;
																					num *= 2600929810u;
																					Dictionary<uint, A93EA20B> e52C86B120 = E52C86B9;
																					num *= 2140399238;
																					uint key117 = num ^ 0x68E14AB2;
																					num |= 0x6AAAA383;
																					num = 59212472 % num;
																					e52C86B120[key117] = B90E2FB2;
																					num -= 3724609965u;
																					if (62529831 << (int)num == 0)
																					{
																						goto end_IL_004a;
																					}
																					num &= 0x232F3C92;
																					Dictionary<uint, A93EA20B> e52C86B121 = E52C86B9;
																					num /= 4198479360u;
																					uint key118 = num ^ 0x7B;
																					num = 3935955599u - num;
																					A93EA20B value76 = _29B79425;
																					num /= 3501212593u;
																					e52C86B121[key118] = value76;
																					if (num != 415208217)
																					{
																						Dictionary<uint, A93EA20B> e52C86B122 = E52C86B9;
																						uint key119 = num ^ 0x7D;
																						num <<= 11;
																						num |= 0x89326892u;
																						A93EA20B value77 = _8D87761A;
																						num |= 0x42306A9C;
																						e52C86B122[key119] = value77;
																						num = 0x2196AD81 ^ num;
																						Dictionary<uint, A93EA20B> e52C86B123 = E52C86B9;
																						num = 3727427263u - num;
																						int key120 = (int)num ^ -209240099;
																						num |= 0x599FC231;
																						num &= 0x2ABAC480;
																						e52C86B123[(uint)key120] = _57267AA0;
																						if (num >= 3493815102u)
																						{
																							break;
																						}
																						num &= 0x110BE816;
																						Dictionary<uint, A93EA20B> e52C86B124 = E52C86B9;
																						num = 0x111B52A9 ^ num;
																						uint key121 = num - 286364203;
																						num >>= 12;
																						A93EA20B value78 = B7AB4FB8;
																						num = 0x848F6B14u | num;
																						e52C86B124[key121] = value78;
																						if (9029925 > num)
																						{
																							goto end_IL_004a;
																						}
																						num = 4078584251u + num;
																						Dictionary<uint, A93EA20B> e52C86B125 = E52C86B9;
																						uint key122 = num ^ 0x77A9BCA7;
																						num = 4126731 - num;
																						num = 0x9A3A39BFu ^ num;
																						A93EA20B value79 = _65278E35;
																						num += 3399055239u;
																						e52C86B125[key122] = value79;
																						if (-1701023586 != (int)num)
																						{
																							num <<= 14;
																							Dictionary<uint, A93EA20B> e52C86B126 = E52C86B9;
																							uint key123 = num ^ 0x1E84C080;
																							num &= 0xDEA53A86u;
																							A93EA20B value80 = _5C9EBE36;
																							num += 2761667725u;
																							e52C86B126[key123] = value80;
																							num <<= 6;
																							Dictionary<uint, A93EA20B> e52C86B127 = E52C86B9;
																							int key124 = (int)num ^ -940760127;
																							num = 4012944921u >> (int)num;
																							num = 3693120133u + num;
																							num <<= 13;
																							e52C86B127[(uint)key124] = B90E2FB2;
																							num = 0xC8171198u ^ num;
																							if (num - 983455907 == 0)
																							{
																								goto end_IL_004a;
																							}
																							num >>= 23;
																							Dictionary<uint, A93EA20B> e52C86B128 = E52C86B9;
																							num = 731155900u >> (int)num;
																							uint key125 = num ^ 0x82;
																							num /= 783711253;
																							e52C86B128[key125] = _1502A3A0;
																							num -= 297282953;
																							if (1166295849 << (int)num == 0)
																							{
																								goto end_IL_004a;
																							}
																							Dictionary<uint, A93EA20B> e52C86B129 = E52C86B9;
																							int key126 = (int)num - -297283084;
																							num &= 0x2538D818;
																							e52C86B129[(uint)key126] = F9B9920E;
																							E52C86B9[num + 3690934388u] = _9780C019;
																							if (num == 3401012915u)
																							{
																								goto end_IL_004a;
																							}
																							num = 0xBD3B602Du ^ num;
																							Dictionary<uint, A93EA20B> e52C86B130 = E52C86B9;
																							num %= 639970335;
																							uint key127 = num - 10944316;
																							num = 3862680501u + num;
																							e52C86B130[key127] = _8DB67B0E;
																							num = 2937102100u - num;
																							Dictionary<uint, A93EA20B> e52C86B131 = E52C86B9;
																							num -= 3994314035u;
																							int key128 = (int)num - -635869723;
																							num = 0x1E93A8B3 ^ num;
																							e52C86B131[(uint)key128] = _4B8820A3;
																							Dictionary<uint, A93EA20B> e52C86B132 = E52C86B9;
																							int key129 = (int)num - -997536175;
																							num = 2735615673u - num;
																							num = 1253716922 + num;
																							num = 3071909917u + num;
																							A93EA20B value81 = _470FB0A2;
																							num = 3013406616u - num;
																							e52C86B132[(uint)key129] = value81;
																							if (num <= 2039813672)
																							{
																								goto end_IL_004a;
																							}
																							num *= 1514081697;
																							Dictionary<uint, A93EA20B> e52C86B133 = E52C86B9;
																							int key130 = (int)num + -1703249752;
																							num = 0xA9F16A7 | num;
																							A93EA20B value82 = _6C051AB3;
																							num *= 1186685082;
																							e52C86B133[(uint)key130] = value82;
																							Dictionary<uint, A93EA20B> e52C86B134 = E52C86B9;
																							uint key131 = num ^ 0x1EB5007F;
																							num = 463928456u >> (int)num;
																							num %= 940337703;
																							A93EA20B value83 = DE3B28B2;
																							num = 0xC3B16F1Du ^ num;
																							e52C86B134[key131] = value83;
																							num /= 523418802;
																							if ((num ^ 0x8CA48CA3u) == 0)
																							{
																								break;
																							}
																							Dictionary<uint, A93EA20B> e52C86B135 = E52C86B9;
																							num = 135022998 % num;
																							int key132 = (int)num - -138;
																							num = 3055777945u >> (int)num;
																							num -= 1739915699;
																							e52C86B135[(uint)key132] = FE8F4E01;
																							num >>= 29;
																							if (num > 513720071)
																							{
																								goto end_IL_004a;
																							}
																							Dictionary<uint, A93EA20B> e52C86B136 = E52C86B9;
																							uint key133 = num ^ 0x89;
																							num = 0xEA214589u ^ num;
																							e52C86B136[key133] = _8D828EA2;
																							num = 933553554 % num;
																							Dictionary<uint, A93EA20B> e52C86B137 = E52C86B9;
																							uint key134 = num ^ 0x37A4E51E;
																							num = 4103507107u % num;
																							num <<= 20;
																							e52C86B137[key134] = _2EA28017;
																							Dictionary<uint, A93EA20B> e52C86B138 = E52C86B9;
																							uint key135 = num - 1706033011;
																							num >>= 4;
																							A93EA20B value84 = _2EA28017;
																							num *= 1720341657;
																							e52C86B138[key135] = value84;
																							if (-1675128027 << (int)num == 0)
																							{
																								goto end_IL_004a;
																							}
																							num |= 0x38A5B58B;
																							Dictionary<uint, A93EA20B> e52C86B139 = E52C86B9;
																							num ^= 0x278E1F22;
																							uint key136 = num + 1620465125;
																							num = 3650178740u >> (int)num;
																							e52C86B139[key136] = C214DD3C;
																							num = 1387721900u >> (int)num;
																							Dictionary<uint, A93EA20B> e52C86B140 = E52C86B9;
																							int key137 = (int)num + -10841434;
																							num /= 881397272;
																							num = 1192563982u >> (int)num;
																							num %= 788802454;
																							e52C86B140[(uint)key137] = _52B85689;
																							num *= 2879509010u;
																							Dictionary<uint, A93EA20B> e52C86B141 = E52C86B9;
																							num *= 1680231041;
																							uint key138 = num ^ 0x475E72E0;
																							num >>= 17;
																							A93EA20B value85 = _470FB0A2;
																							num &= 0x47BE2B9A;
																							e52C86B141[key138] = value85;
																							if (num == 2863245848u)
																							{
																								break;
																							}
																							Dictionary<uint, A93EA20B> e52C86B142 = E52C86B9;
																							uint key139 = num - 8953;
																							num <<= 31;
																							num = 0x5BA0CE04 ^ num;
																							A93EA20B value86 = _8D87761A;
																							num |= 0x8493AB20u;
																							e52C86B142[key139] = value86;
																							Dictionary<uint, A93EA20B> e52C86B143 = E52C86B9;
																							int key140 = (int)num - -541856110;
																							num |= 0xFAB05607u;
																							e52C86B143[(uint)key140] = _4B8820A3;
																							Dictionary<uint, A93EA20B> e52C86B144 = E52C86B9;
																							num = 647610429 / num;
																							uint key141 = num + 147;
																							num = 0x9D8871B2u | num;
																							A93EA20B value87 = _67B61426;
																							num = 2453304469u - num;
																							e52C86B144[key141] = value87;
																							num = 3618019714u * num;
																							if (num <= 413258559)
																							{
																								continue;
																							}
																							Dictionary<uint, A93EA20B> e52C86B145 = E52C86B9;
																							int key142 = (int)num + -709960114;
																							num ^= 0xBF06190Au;
																							A93EA20B value88 = AC801780;
																							num = 2636619143u >> (int)num;
																							e52C86B145[(uint)key142] = value88;
																							num %= 674806182;
																							Dictionary<uint, A93EA20B> e52C86B146 = E52C86B9;
																							uint key143 = num ^ 0x9D2EC;
																							num |= 0xC0826D87u;
																							num = 3090995249u / num;
																							e52C86B146[key143] = _2EA28017;
																							Dictionary<uint, A93EA20B> e52C86B147 = E52C86B9;
																							int key144 = (int)num - -150;
																							num &= 0xA50D7C8Bu;
																							e52C86B147[(uint)key144] = _48351722;
																							num = 3348630313u * num;
																							Dictionary<uint, A93EA20B> e52C86B148 = E52C86B9;
																							num <<= 29;
																							uint key145 = num + 151;
																							num = 2601120268u >> (int)num;
																							A93EA20B value89 = _2EA28017;
																							num = 3792758309u >> (int)num;
																							e52C86B148[key145] = value89;
																							num = 655493532 + num;
																							if (num > 2260646533u)
																							{
																								goto IL_0071;
																							}
																							Dictionary<uint, A93EA20B> e52C86B149 = E52C86B9;
																							num >>= 30;
																							uint key146 = num ^ 0x98;
																							num <<= 4;
																							e52C86B149[key146] = _65278E35;
																							if ((num ^ 0x430D80AE) == 0)
																							{
																								break;
																							}
																							num = 251999275 * num;
																							Dictionary<uint, A93EA20B> e52C86B150 = E52C86B9;
																							num /= 1966368791;
																							uint key147 = num ^ 0x99;
																							num += 2846646810u;
																							A93EA20B value90 = _1502A3A0;
																							num -= 1159423026;
																							e52C86B150[key147] = value90;
																							if (1445308043 > num)
																							{
																								goto end_IL_004a;
																							}
																							Dictionary<uint, A93EA20B> e52C86B151 = E52C86B9;
																							int key148 = (int)num + -1687223630;
																							num -= 2820991141u;
																							e52C86B151[(uint)key148] = _97BBBAA6;
																							num = 0xAC2D5F28u | num;
																							Dictionary<uint, A93EA20B> e52C86B152 = E52C86B9;
																							uint key149 = num + 1133682992;
																							num %= 162534933;
																							num = 0xD0BD1080u | num;
																							A93EA20B value91 = _8D87761A;
																							num = 3338995251u * num;
																							e52C86B152[key149] = value91;
																							num = 0x6A043820 & num;
																							if (2944712977u / num != 0)
																							{
																								num = 2937634328u + num;
																								Dictionary<uint, A93EA20B> e52C86B153 = E52C86B9;
																								int key150 = (int)num ^ -1222848892;
																								num = 2231568301u / num;
																								A93EA20B value92 = B627B535;
																								num |= 0x9DAD059Du;
																								e52C86B153[(uint)key150] = value92;
																								num = 1234592640 - num;
																								Dictionary<uint, A93EA20B> e52C86B154 = E52C86B9;
																								num /= 604957583;
																								uint key151 = num ^ 0x99;
																								num = 3222059321u - num;
																								num = 3183348120u / num;
																								num = 0x532F8AB2 & num;
																								A93EA20B value93 = _470FB0A2;
																								num <<= 17;
																								e52C86B154[key151] = value93;
																								num |= 0x1617D900;
																								if (1772668166 << (int)num == 0)
																								{
																									goto end_IL_004a;
																								}
																								Dictionary<uint, A93EA20B> e52C86B155 = E52C86B9;
																								num = 976625716u >> (int)num;
																								int key152 = (int)num + -976625558;
																								num = 0xDEBAA933u & num;
																								A93EA20B value94 = FE07070B;
																								num = 0x58AA3A95 | num;
																								e52C86B155[(uint)key152] = value94;
																								if (3205997185u <= num)
																								{
																									goto end_IL_004a;
																								}
																								Dictionary<uint, A93EA20B> e52C86B156 = E52C86B9;
																								int key153 = (int)num + -1522154006;
																								num = 1184867998 / num;
																								e52C86B156[(uint)key153] = _8DB67B0E;
																								Dictionary<uint, A93EA20B> e52C86B157 = E52C86B9;
																								num = 1344396091 - num;
																								uint key154 = num ^ 0x5021DB9B;
																								num %= 1478949638;
																								e52C86B157[key154] = FC284D0F;
																								num = 2854146720u * num;
																								Dictionary<uint, A93EA20B> e52C86B158 = E52C86B9;
																								int key155 = (int)num - -1175885249;
																								num += 2829897993u;
																								A93EA20B value95 = FA3C8E81;
																								num -= 797952292;
																								e52C86B158[(uint)key155] = value95;
																								num = 3115913771u / num;
																								if (690886042 != num)
																								{
																									num ^= 0x86014430u;
																									Dictionary<uint, A93EA20B> e52C86B159 = E52C86B9;
																									int key156 = (int)num ^ -2046737263;
																									num |= 0xCD080F3Cu;
																									num = 378948254 - num;
																									A93EA20B value96 = _10282C26;
																									num ^= 0xAB037233u;
																									e52C86B159[(uint)key156] = value96;
																									num ^= 0xB08D5AA3u;
																									if (3122605105u + num != 0)
																									{
																										num = 2610308536u >> (int)num;
																										Dictionary<uint, A93EA20B> e52C86B160 = E52C86B9;
																										num = 16966972 + num;
																										uint key157 = num ^ 0x1041CCB;
																										num *= 3230961446u;
																										num = 0xF52985B7u | num;
																										A93EA20B value97 = _3CAA2C32;
																										num += 370834866;
																										e52C86B160[key157] = value97;
																										num += 1303385136;
																										num = 1225402785 % num;
																										Dictionary<uint, A93EA20B> e52C86B161 = E52C86B9;
																										num += 270826541;
																										uint key158 = num ^ 0x592EA56A;
																										num ^= 0xD2BCBB3Du;
																										e52C86B161[key158] = _48351722;
																										num = 1585667846 % num;
																										Dictionary<uint, A93EA20B> e52C86B162 = E52C86B9;
																										int key159 = (int)num + -1585667681;
																										num |= 0xCA893304u;
																										num = 2645636864u + num;
																										e52C86B162[(uint)key159] = _6E9F1788;
																										num = 3072007866u - num;
																										if (num == 832462606)
																										{
																											goto IL_004a;
																										}
																										Dictionary<uint, A93EA20B> e52C86B163 = E52C86B9;
																										uint key160 = num ^ 0x3ADE6812;
																										num = 1789077168 % num;
																										num = 3669889178u / num;
																										num /= 195697293;
																										e52C86B163[key160] = DB8B980D;
																										num *= 263167754;
																										Dictionary<uint, A93EA20B> e52C86B164 = E52C86B9;
																										uint key161 = num ^ 0xA7;
																										num = 4110707859u >> (int)num;
																										num &= 0x9F059CBFu;
																										num >>= 30;
																										e52C86B164[key161] = D19B343F;
																										if (4172180612u >= num)
																										{
																											Dictionary<uint, A93EA20B> e52C86B165 = E52C86B9;
																											uint key162 = num ^ 0xAA;
																											num = 3113938352u + num;
																											num = 1445013277 % num;
																											e52C86B165[key162] = _8D87761A;
																											num |= 0x95A1FC26u;
																											num = 2604030606u - num;
																											Dictionary<uint, A93EA20B> e52C86B166 = E52C86B9;
																											int key163 = (int)num ^ -1013687322;
																											num = 0x150E2F96 | num;
																											e52C86B166[(uint)key163] = _1A319294;
																											num = 2777076142u / num;
																											Dictionary<uint, A93EA20B> e52C86B167 = E52C86B9;
																											num *= 1774048296;
																											uint key164 = num ^ 0xAA;
																											num = (uint)(-1968368080 << (int)num);
																											num = 2157967878u % num;
																											e52C86B167[key164] = _5F853100;
																											if ((0xEF94A78Fu ^ num) == 0)
																											{
																												goto end_IL_004a;
																											}
																											num = 0x679FCAA9 & num;
																											Dictionary<uint, A93EA20B> e52C86B168 = E52C86B9;
																											uint key165 = num ^ 0x9FCAAB;
																											num = (uint)(-1005688155 << (int)num);
																											num += 448402327;
																											num += 352654472;
																											e52C86B168[key165] = _52B85689;
																											num -= 389662487;
																											if (num == 227505431)
																											{
																												goto end_IL_004a;
																											}
																											num /= 4128385932u;
																											Dictionary<uint, A93EA20B> e52C86B169 = E52C86B9;
																											int key166 = (int)num - -172;
																											num = 1225762590 * num;
																											num ^= 0x3169795;
																											e52C86B169[(uint)key166] = EE30EC03;
																											if (num > 3560385430u)
																											{
																												goto end_IL_004a;
																											}
																											Dictionary<uint, A93EA20B> e52C86B170 = E52C86B9;
																											uint key167 = num - 51812072;
																											num %= 1370640679;
																											num |= 0xF21B259Du;
																											num = (uint)(-1718186441 << (int)num);
																											A93EA20B value98 = _5F853100;
																											num |= 0xC214CC0Eu;
																											e52C86B170[key167] = value98;
																											Dictionary<uint, A93EA20B> e52C86B171 = E52C86B9;
																											int key168 = (int)num - -501953696;
																											num = 0xAA2FAA0Fu ^ num;
																											num *= 1938646919;
																											A93EA20B value99 = _52B85689;
																											num *= 697590039;
																											e52C86B171[(uint)key168] = value99;
																											num &= 0x60B4402;
																											Dictionary<uint, A93EA20B> e52C86B172 = E52C86B9;
																											num |= 0xF6AD4225u;
																											int key169 = (int)num ^ -156286326;
																											num /= 314167216;
																											A93EA20B value100 = FE8F4E01;
																											num <<= 12;
																											e52C86B172[(uint)key169] = value100;
																											if ((int)num + -175485160 == 0)
																											{
																												goto end_IL_004a;
																											}
																											num = 1805652109 * num;
																											Dictionary<uint, A93EA20B> e52C86B173 = E52C86B9;
																											uint key170 = num ^ 0xD7290B0;
																											num = 2719965503u + num;
																											A93EA20B value101 = _29B79425;
																											num &= 0x521D1A6;
																											e52C86B173[key170] = value101;
																											num <<= 16;
																											num ^= 0x37B71C0B;
																											Dictionary<uint, A93EA20B> e52C86B174 = E52C86B9;
																											uint key171 = num + 426697894;
																											num += 205084302;
																											e52C86B174[key171] = B627B535;
																											if (num == 3786132400u)
																											{
																												break;
																											}
																											num |= 0x3E8DA604;
																											Dictionary<uint, A93EA20B> e52C86B175 = E52C86B9;
																											int key172 = (int)num ^ -19925457;
																											num = 0xE3A5981 & num;
																											e52C86B175[(uint)key172] = _2EA28017;
																											num /= 3348158995u;
																											if ((num ^ 0x919A8026u) != 0)
																											{
																												Dictionary<uint, A93EA20B> e52C86B176 = E52C86B9;
																												uint key173 = num ^ 0xB3;
																												num <<= 14;
																												e52C86B176[key173] = _8D828EA2;
																												num *= 1225610911;
																												if (2930677011u < num)
																												{
																													goto end_IL_004a;
																												}
																												num = 1627431842u >> (int)num;
																												Dictionary<uint, A93EA20B> e52C86B177 = E52C86B9;
																												uint key174 = num ^ 0x6100A316;
																												num = 0xDC2D368Eu | num;
																												e52C86B177[key174] = _6C051AB3;
																												if (2567941520u > num)
																												{
																													goto end_IL_004a;
																												}
																												Dictionary<uint, A93EA20B> e52C86B178 = E52C86B9;
																												num = 3608007190u * num;
																												uint key175 = num + 1200585665;
																												num += 1185512714;
																												num = 1932873344 - num;
																												e52C86B178[key175] = _4B8820A3;
																												num |= 0xCF0EF882u;
																												if (num < 235874358)
																												{
																													goto end_IL_004a;
																												}
																												num = 454019731 * num;
																												Dictionary<uint, A93EA20B> e52C86B179 = E52C86B9;
																												num |= 0xE79B2F9Du;
																												int key176 = (int)num ^ -4473079;
																												num <<= 1;
																												num -= 3055541786u;
																												e52C86B179[(uint)key176] = _8D828EA2;
																												num = 0xCA9D3D3Cu | num;
																												if ((num & 0x560DD2B4) != 0)
																												{
																													Dictionary<uint, A93EA20B> e52C86B180 = E52C86B9;
																													num += 3062537735u;
																													int key177 = (int)num - -2106959156;
																													num *= 3929105437u;
																													e52C86B180[(uint)key177] = _6C8C4E1C;
																													if (288525867 > num)
																													{
																														goto end_IL_004a;
																													}
																													Dictionary<uint, A93EA20B> e52C86B181 = E52C86B9;
																													num /= 2308268310u;
																													uint key178 = num ^ 0xB9;
																													num = 0x690D949C | num;
																													e52C86B181[key178] = ED048E22;
																													num = 916662656 + num;
																													num /= 3325297068u;
																													Dictionary<uint, A93EA20B> e52C86B182 = E52C86B9;
																													num = 2042236295 - num;
																													uint key179 = num - 2042236110;
																													num = 0x7B2430B9 & num;
																													A93EA20B value102 = EE85C28A;
																													num = (uint)(632480786 << (int)num);
																													e52C86B182[key179] = value102;
																													Dictionary<uint, A93EA20B> e52C86B183 = E52C86B9;
																													uint key180 = num ^ 0x4B65C89E;
																													num = 1250557706 + num;
																													A93EA20B value103 = B7AB4FB8;
																													num = 0x6B009388 ^ num;
																													e52C86B183[key180] = value103;
																													if (num == 3482239142u)
																													{
																														break;
																													}
																													Dictionary<uint, A93EA20B> e52C86B184 = E52C86B9;
																													int key181 = (int)num ^ -17869795;
																													num &= 0x3B1B0E90;
																													e52C86B184[(uint)key181] = _803401B1;
																													if (num - 361911808 == 0)
																													{
																														break;
																													}
																													Dictionary<uint, A93EA20B> e52C86B185 = E52C86B9;
																													num = 3988652847u - num;
																													int key182 = (int)num ^ -1280115181;
																													num = 3602894219u * num;
																													num *= 1024960647;
																													e52C86B185[(uint)key182] = C214DD3C;
																													if (4239308319u < num)
																													{
																														goto end_IL_004a;
																													}
																													Dictionary<uint, A93EA20B> e52C86B186 = E52C86B9;
																													uint key183 = num ^ 0x7CF43E1E;
																													num = 2544882085u * num;
																													num ^= 0xE522638Cu;
																													num %= 2796999864u;
																													e52C86B186[key183] = _67B61426;
																													if (num != 1614644670)
																													{
																														Dictionary<uint, A93EA20B> e52C86B187 = E52C86B9;
																														num <<= 13;
																														uint key184 = num + 1037017278;
																														num = 53407021 - num;
																														A93EA20B value104 = _65278E35;
																														num += 2226845211u;
																														e52C86B187[key184] = value104;
																														if (num >= 4152894377u)
																														{
																															goto end_IL_004a;
																														}
																														Dictionary<uint, A93EA20B> e52C86B188 = E52C86B9;
																														num /= 1386298404;
																														uint key185 = num ^ 0xBD;
																														num = 2721527475u + num;
																														num += 480915079;
																														e52C86B188[key185] = _470FB0A2;
																														num = 3054259221u * num;
																														if (num == 3954167564u)
																														{
																															goto end_IL_004a;
																														}
																														num -= 3314359975u;
																														Dictionary<uint, A93EA20B> e52C86B189 = E52C86B9;
																														num >>= 16;
																														int key186 = (int)num + -13069;
																														num = 0x5E335714 & num;
																														num &= 0x991C1C;
																														A93EA20B value105 = _4B8820A3;
																														num = 0x97173BA8u ^ num;
																														e52C86B189[(uint)key186] = value105;
																														if (-1221562820 - (int)num == 0)
																														{
																															break;
																														}
																														Dictionary<uint, A93EA20B> e52C86B190 = E52C86B9;
																														uint key187 = num + 1760089365;
																														num = 212776576 * num;
																														A93EA20B value106 = _29B79425;
																														num = (uint)(1890363582 << (int)num);
																														e52C86B190[key187] = value106;
																														num = (uint)(-963807075 << (int)num);
																														if (num >= 1269082415)
																														{
																															goto end_IL_004a;
																														}
																														Dictionary<uint, A93EA20B> e52C86B191 = E52C86B9;
																														uint key188 = num ^ 0x400000C2;
																														num <<= 26;
																														e52C86B191[key188] = _3CAA2C32;
																														num /= 656326413;
																														Dictionary<uint, A93EA20B> e52C86B192 = E52C86B9;
																														uint key189 = num ^ 0xC3;
																														num = 1435131310 - num;
																														num = (uint)(-139216601 << (int)num);
																														num *= 4172545420u;
																														e52C86B192[key189] = _1A319294;
																														num -= 2159862027u;
																														if (59366569 + num != 0)
																														{
																															Dictionary<uint, A93EA20B> e52C86B193 = E52C86B9;
																															uint key190 = num + 229106127;
																															num = 3382386996u + num;
																															num = 1402577721u >> (int)num;
																															A93EA20B value107 = _29B79425;
																															num *= 2349937032u;
																															e52C86B193[key190] = value107;
																															Dictionary<uint, A93EA20B> e52C86B194 = E52C86B9;
																															num *= 143323272;
																															int key191 = (int)num ^ -1634859899;
																															num = 2249690778u % num;
																															num |= 0x59A8760C;
																															num /= 1161635360;
																															e52C86B194[(uint)key191] = B03BFD10;
																															num -= 3306330913u;
																															if ((num ^ 0xBABEEA93u) == 0)
																															{
																																goto end_IL_004a;
																															}
																															Dictionary<uint, A93EA20B> e52C86B195 = E52C86B9;
																															uint key192 = num ^ 0x3AED6424;
																															num /= 1444344961;
																															num ^= 0x8D8BB13Cu;
																															num = 1403892254 / num;
																															e52C86B195[key192] = _470FB0A2;
																															num = 0x33800D88 & num;
																															Dictionary<uint, A93EA20B> e52C86B196 = E52C86B9;
																															uint key193 = num ^ 0xC7;
																															num = 1470770238 - num;
																															num |= 0x3715DC39;
																															A93EA20B value108 = FC284D0F;
																															num = 1586164743 % num;
																															e52C86B196[key193] = value108;
																															if (num == 413406374)
																															{
																																goto end_IL_004a;
																															}
																															num &= 0x631649AE;
																															Dictionary<uint, A93EA20B> e52C86B197 = E52C86B9;
																															num = 3954316418u + num;
																															int key194 = (int)num + -766792640;
																															num <<= 24;
																															num = 0x35BED3A1 & num;
																															num |= 0xFF1F9B2Du;
																															e52C86B197[(uint)key194] = B03BFD10;
																															num = 0x6CAD31B5 ^ num;
																															Dictionary<uint, A93EA20B> e52C86B198 = E52C86B9;
																															num = 1680269189 % num;
																															uint key195 = num ^ 0x6426DF4C;
																															num ^= 0x50186000;
																															num = 0x1CAA6325 & num;
																															e52C86B198[key195] = B90E2FB2;
																															num %= 2953625220u;
																															if (2696012437u % num == 0)
																															{
																																goto end_IL_004a;
																															}
																															Dictionary<uint, A93EA20B> e52C86B199 = E52C86B9;
																															uint key196 = num ^ 0x142A23CF;
																															num += 1125456256;
																															num |= 0xD6274428u;
																															e52C86B199[key196] = _6C8C4E1C;
																															Dictionary<uint, A93EA20B> e52C86B200 = E52C86B9;
																															uint key197 = num + 683705374;
																															num = 0x22FAB81 | num;
																															e52C86B200[key197] = E692F42E;
																															num ^= 0x8039848Bu;
																															if (2962306474u < num)
																															{
																																break;
																															}
																															Dictionary<uint, A93EA20B> e52C86B201 = E52C86B9;
																															uint key198 = num - 1460042330;
																															num /= 1049601156;
																															A93EA20B value109 = _9A3BC4AD;
																															num += 185857297;
																															e52C86B201[key198] = value109;
																															Dictionary<uint, A93EA20B> e52C86B202 = E52C86B9;
																															uint key199 = num ^ 0xB13F5DF;
																															num = 515397931 / num;
																															A93EA20B value110 = _470FB0A2;
																															num *= 3993213712u;
																															e52C86B202[key199] = value110;
																															num = 0x198BA24 & num;
																															Dictionary<uint, A93EA20B> e52C86B203 = E52C86B9;
																															uint key200 = num ^ 0x32EE;
																															num &= 0x12A8EDBA;
																															num = 0x1D092C2E & num;
																															e52C86B203[key200] = _4E95E919;
																															num = 998319029 + num;
																															Dictionary<uint, A93EA20B> e52C86B204 = E52C86B9;
																															num -= 1887840798;
																															uint key201 = num + 889513752;
																															num = 0xC71C5E0Bu ^ num;
																															num = 0x923C0C29u & num;
																															A93EA20B value111 = _8D828EA2;
																															num = 0xF1A71605u ^ num;
																															e52C86B204[key201] = value111;
																															if (529325331 < num)
																															{
																																num += 789323318;
																																Dictionary<uint, A93EA20B> e52C86B205 = E52C86B9;
																																uint key202 = num ^ 0x208F30B3;
																																num += 2827424407u;
																																num = 2435578256u % num;
																																A93EA20B value112 = _8D828EA2;
																																num -= 934885764;
																																e52C86B205[key202] = value112;
																																num = 127717171u >> (int)num;
																																if (num <= 1930887299)
																																{
																																	Dictionary<uint, A93EA20B> e52C86B206 = E52C86B9;
																																	uint key203 = num ^ 0x791D;
																																	num = 564560155 * num;
																																	A93EA20B value113 = _4E95E919;
																																	num = 973324844 % num;
																																	e52C86B206[key203] = value113;
																																	num = 2442614942u / num;
																																	if (162924984 <= num)
																																	{
																																		break;
																																	}
																																	num = 0xB1A88725u | num;
																																	Dictionary<uint, A93EA20B> e52C86B207 = E52C86B9;
																																	int key204 = (int)num - -1314355627;
																																	num |= 0xE134EBB3u;
																																	num = 0xE4869483u | num;
																																	A93EA20B value114 = E8A32EBC;
																																	num += 3180713994u;
																																	e52C86B207[(uint)key204] = value114;
																																	Dictionary<uint, A93EA20B> e52C86B208 = E52C86B9;
																																	int key205 = (int)num ^ -1286285550;
																																	num = 1963828620 / num;
																																	e52C86B208[(uint)key205] = _803401B1;
																																	Dictionary<uint, A93EA20B> e52C86B209 = E52C86B9;
																																	uint key206 = num ^ 0xD4;
																																	num |= 0x1FA4B50D;
																																	e52C86B209[key206] = CAB68E1D;
																																	num = 380072219 * num;
																																	Dictionary<uint, A93EA20B> e52C86B210 = E52C86B9;
																																	int key207 = (int)num + -1136972938;
																																	A93EA20B value115 = _9780C019;
																																	num = 614481964 % num;
																																	e52C86B210[(uint)key207] = value115;
																																	num = 93044149 * num;
																																	num ^= 0x1B3AD784;
																																	Dictionary<uint, A93EA20B> e52C86B211 = E52C86B9;
																																	num -= 1922714035;
																																	int key208 = (int)num - -2129608177;
																																	num /= 2923055130u;
																																	num = 2987305624u + num;
																																	A93EA20B value116 = A43285A0;
																																	num |= 0x17130BA6;
																																	e52C86B211[(uint)key208] = value116;
																																	num ^= 0x4FBAE103;
																																	if (num % 229661491 == 0)
																																	{
																																		goto end_IL_004a;
																																	}
																																	Dictionary<uint, A93EA20B> e52C86B212 = E52C86B9;
																																	num = 3222592808u + num;
																																	e52C86B212[num - 3099207438u] = B1BC5031;
																																	Dictionary<uint, A93EA20B> e52C86B213 = E52C86B9;
																																	num = 546251441 % num;
																																	int key209 = (int)num + -546251225;
																																	num = 0x60805432 | num;
																																	e52C86B213[(uint)key209] = _9A3BC4AD;
																																	num ^= 0x4393B58D;
																																	Dictionary<uint, A93EA20B> e52C86B214 = E52C86B9;
																																	num *= 2123348357;
																																	int key210 = (int)num ^ -1700053521;
																																	num *= 4128917167u;
																																	num = 0xE36C93C | num;
																																	e52C86B214[(uint)key210] = F498053B;
																																	num <<= 1;
																																	Dictionary<uint, A93EA20B> e52C86B215 = E52C86B9;
																																	num = 1620244267u >> (int)num;
																																	uint key211 = num ^ 0xDC;
																																	num = 0x2F8165B9 ^ num;
																																	A93EA20B value117 = _3A865CBF;
																																	num |= 0x5E80E683;
																																	e52C86B215[key211] = value117;
																																	if (-1239437941 + (int)num == 0)
																																	{
																																		continue;
																																	}
																																	num *= 3515362073u;
																																	Dictionary<uint, A93EA20B> e52C86B216 = E52C86B9;
																																	num = 2704112900u >> (int)num;
																																	int key212 = (int)num + -21125663;
																																	num *= 1126628505;
																																	num = 0x77A1E61C ^ num;
																																	e52C86B216[(uint)key212] = _57267AA0;
																																	Dictionary<uint, A93EA20B> e52C86B217 = E52C86B9;
																																	num = 0x2E036626 ^ num;
																																	uint key213 = num ^ 0x58F0F78C;
																																	num = 1697098161 / num;
																																	num = 943700119 % num;
																																	A93EA20B value118 = _4E95E919;
																																	num /= 3149062077u;
																																	e52C86B217[key213] = value118;
																																	num = (uint)(-1550343417 << (int)num);
																																	if (3810751138u % num == 0)
																																	{
																																		goto end_IL_004a;
																																	}
																																	Dictionary<uint, A93EA20B> e52C86B218 = E52C86B9;
																																	num = 3724800289u - num;
																																	uint key214 = num ^ 0x3A6C4EC7;
																																	A93EA20B value119 = _3CAA2C32;
																																	num = 3022793785u % num;
																																	e52C86B218[key214] = value119;
																																	num = 2536633526u * num;
																																	num <<= 18;
																																	Dictionary<uint, A93EA20B> e52C86B219 = E52C86B9;
																																	num ^= 0xA4166380u;
																																	int key215 = (int)num ^ -1067556002;
																																	num = (uint)(-1450072652 << (int)num);
																																	num /= 1781240628;
																																	e52C86B219[(uint)key215] = _10282C26;
																																	Dictionary<uint, A93EA20B> e52C86B220 = E52C86B9;
																																	uint key216 = num + 222;
																																	num = 135467280 - num;
																																	num |= 0xE104F8B6u;
																																	e52C86B220[key216] = B90E2FB2;
																																	num = 3222551731u + num;
																																	num += 2638173343u;
																																	Dictionary<uint, A93EA20B> e52C86B221 = E52C86B9;
																																	int key217 = (int)num + -1181452849;
																																	num = 1244519969 - num;
																																	num /= 530743683;
																																	num = 34235282 - num;
																																	e52C86B221[(uint)key217] = _8D828EA2;
																																	if ((num & 0xA7160E91u) == 0)
																																	{
																																		goto end_IL_004a;
																																	}
																																	Dictionary<uint, A93EA20B> e52C86B222 = E52C86B9;
																																	uint key218 = num - 34235057;
																																	num *= 2239834678u;
																																	num = 0x5A09E38C ^ num;
																																	e52C86B222[key218] = _1502A3A0;
																																	num |= 0x8F1078B3u;
																																	if ((num & 0x1F8AA322) == 0)
																																	{
																																		goto end_IL_004a;
																																	}
																																	Dictionary<uint, A93EA20B> e52C86B223 = E52C86B9;
																																	int key219 = (int)num - -15630575;
																																	num = 915612339 % num;
																																	num = 506009749 + num;
																																	A93EA20B value120 = DE3B28B2;
																																	num ^= 0xF583521Au;
																																	e52C86B223[(uint)key219] = value120;
																																	Dictionary<uint, A93EA20B> e52C86B224 = E52C86B9;
																																	int key220 = (int)num ^ -1589679695;
																																	num -= 262638907;
																																	num = 2150455737u * num;
																																	e52C86B224[(uint)key220] = _10282C26;
																																	num = 2308425749u - num;
																																	Dictionary<uint, A93EA20B> e52C86B225 = E52C86B9;
																																	num %= 296363832;
																																	uint key221 = num ^ 0x10A21F72;
																																	num /= 479247260;
																																	num /= 1251330728;
																																	e52C86B225[key221] = _8D828EA2;
																																	num += 3601166261u;
																																	Dictionary<uint, A93EA20B> e52C86B226 = E52C86B9;
																																	num &= 0x67AF8708;
																																	int key222 = (int)num + -1185220123;
																																	num >>= 7;
																																	num &= 0x17B7C802;
																																	num &= 0x5CBB1090;
																																	A93EA20B value121 = _4B8820A3;
																																	num >>= 10;
																																	e52C86B226[(uint)key222] = value121;
																																	num = 1015494053 * num;
																																	if (num == 3357447868u)
																																	{
																																		goto end_IL_004a;
																																	}
																																	Dictionary<uint, A93EA20B> e52C86B227 = E52C86B9;
																																	uint key223 = num ^ 0x88209A6;
																																	num <<= 23;
																																	e52C86B227[key223] = _2EA28017;
																																	Dictionary<uint, A93EA20B> e52C86B228 = E52C86B9;
																																	num %= 882774403;
																																	e52C86B228[num ^ 0x225CB90] = AC801780;
																																	E52C86B9[num + 4258936177u] = _1502A3A0;
																																	num = 3443346221u >> (int)num;
																																	if (-1241374709 + (int)num == 0)
																																	{
																																		goto IL_004a;
																																	}
																																	num = 0x63964F8C | num;
																																	Dictionary<uint, A93EA20B> e52C86B229 = E52C86B9;
																																	uint key224 = num - 1670794933;
																																	num = 4163187621u + num;
																																	num = 2192885143u >> (int)num;
																																	e52C86B229[key224] = _003D8513;
																																	Dictionary<uint, A93EA20B> e52C86B230 = E52C86B9;
																																	uint key225 = num ^ 0x10569858;
																																	num /= 2047968397;
																																	num = 0x4B317FBA | num;
																																	e52C86B230[key225] = _27268CBA;
																																	Dictionary<uint, A93EA20B> e52C86B231 = E52C86B9;
																																	num %= 1327867178;
																																	uint key226 = num - 1261534927;
																																	num = (uint)(-587094736 << (int)num);
																																	num = (uint)(2033137331 << (int)num);
																																	num = 3450768156u - num;
																																	A93EA20B value122 = B03BFD10;
																																	num += 798901892;
																																	e52C86B231[key226] = value122;
																																	Dictionary<uint, A93EA20B> e52C86B232 = E52C86B9;
																																	num /= 2920942993u;
																																	uint key227 = num ^ 0xEC;
																																	num |= 0x3DA72891;
																																	e52C86B232[key227] = _10282C26;
																																	num *= 154678676;
																																	if (237194384 > num)
																																	{
																																		goto end_IL_004a;
																																	}
																																	num = (uint)(-1590048215 << (int)num);
																																	Dictionary<uint, A93EA20B> e52C86B233 = E52C86B9;
																																	num = 3382578177u / num;
																																	uint key228 = num ^ 0xEC;
																																	num = 0xECACB832u | num;
																																	num <<= 2;
																																	e52C86B233[key228] = AC801780;
																																	num = 4263921337u * num;
																																	if (num != 524191644)
																																	{
																																		Dictionary<uint, A93EA20B> e52C86B234 = E52C86B9;
																																		num = 3023480089u * num;
																																		int key229 = (int)num ^ -830576286;
																																		num &= 0x429ADD81;
																																		e52C86B234[(uint)key229] = FE1500AA;
																																		num |= 0xF889F609u;
																																		num /= 1975201701;
																																		Dictionary<uint, A93EA20B> e52C86B235 = E52C86B9;
																																		num *= 1191342896;
																																		e52C86B235[num + 1912281743] = _1A319294;
																																		num = 4002909972u - num;
																																		Dictionary<uint, A93EA20B> e52C86B236 = E52C86B9;
																																		uint key230 = num ^ 0x6092A844;
																																		num -= 1151647278;
																																		A93EA20B value123 = _672EAC85;
																																		num = 1745184815 / num;
																																		e52C86B236[key230] = value123;
																																		num += 1312294037;
																																		if ((0xB4AD412Bu ^ num) != 0)
																																		{
																																			num = 842982016 + num;
																																			Dictionary<uint, A93EA20B> e52C86B237 = E52C86B9;
																																			num = (uint)(-1994366842 << (int)num);
																																			int key231 = (int)num - -2046820593;
																																			num = 2612082975u * num;
																																			e52C86B237[(uint)key231] = _6E9F1788;
																																			num = 153011074 - num;
																																			Dictionary<uint, A93EA20B> e52C86B238 = E52C86B9;
																																			num = 0x71B6B507 ^ num;
																																			int key232 = (int)num ^ -1096255881;
																																			num = 1621495085 / num;
																																			num = 0xDF34DE39u | num;
																																			e52C86B238[(uint)key232] = _70AD9310;
																																			num = (uint)(-1909504839 << (int)num);
																																			if (1488623415 < num)
																																			{
																																				num = 4264008618u * num;
																																				Dictionary<uint, A93EA20B> e52C86B239 = E52C86B9;
																																				num = 0x1F0E6888 | num;
																																				int key233 = (int)num ^ -1089574789;
																																				A93EA20B value124 = B4310B85;
																																				num *= 1711427841;
																																				e52C86B239[(uint)key233] = value124;
																																				num &= 0x373D3395;
																																				Dictionary<uint, A93EA20B> e52C86B240 = E52C86B9;
																																				num = 337197630 * num;
																																				int key234 = (int)num - -1620656628;
																																				num = 0x1154BAA ^ num;
																																				num = 0x390DBF25 & num;
																																				A93EA20B value125 = FC284D0F;
																																				num -= 646385552;
																																				e52C86B240[(uint)key234] = value125;
																																				num = 1102641825 % num;
																																				if (num << 24 == 0)
																																				{
																																					goto end_IL_004a;
																																				}
																																				Dictionary<uint, A93EA20B> e52C86B241 = E52C86B9;
																																				num <<= 0;
																																				int key235 = (int)num + -1102641580;
																																				num += 1394875275;
																																				num = 3120622641u * num;
																																				e52C86B241[(uint)key235] = _470FB0A2;
																																				if (-1132136697 - (int)num == 0)
																																				{
																																					goto end_IL_004a;
																																				}
																																				Dictionary<uint, A93EA20B> e52C86B242 = E52C86B9;
																																				num = 3197301948u % num;
																																				int key236 = (int)num + -823088878;
																																				num = 0xDA86C024u & num;
																																				e52C86B242[(uint)key236] = _8DB67B0E;
																																				num |= 0x893CE692u;
																																				if ((num ^ 0x8F933F09u) == 0)
																																				{
																																					goto end_IL_004a;
																																				}
																																				num = 0xB41158A9u & num;
																																				Dictionary<uint, A93EA20B> e52C86B243 = E52C86B9;
																																				int key237 = (int)num ^ -1877983145;
																																				num = 246508554 / num;
																																				e52C86B243[(uint)key237] = B90E2FB2;
																																				num >>= 26;
																																				num = 3677690540u - num;
																																				Dictionary<uint, A93EA20B> e52C86B244 = E52C86B9;
																																				int key238 = (int)num - -617277004;
																																				num = 2360488628u - num;
																																				num -= 2895346946u;
																																				e52C86B244[(uint)key238] = _470FB0A2;
																																				num = 3374327324u / num;
																																				num >>= 0;
																																				Dictionary<uint, A93EA20B> e52C86B245 = E52C86B9;
																																				num &= 0x9324E531u;
																																				uint key239 = num ^ 0xD9;
																																				num = 1244569772 % num;
																																				e52C86B245[key239] = _2EA28017;
																																				Dictionary<uint, A93EA20B> e52C86B246 = E52C86B9;
																																				num >>= 7;
																																				uint key240 = num + 250;
																																				num = 1009598369 + num;
																																				num ^= 0xB48F2017u;
																																				e52C86B246[key240] = _5F853100;
																																				num &= 0x49078011;
																																				num = 1202216468 - num;
																																				Dictionary<uint, A93EA20B> e52C86B247 = E52C86B9;
																																				int key241 = (int)num + -1067867401;
																																				num &= 0xBA95601Du;
																																				A93EA20B value126 = B03BFD10;
																																				num -= 1504909347;
																																				e52C86B247[(uint)key241] = value126;
																																				Dictionary<uint, A93EA20B> e52C86B248 = E52C86B9;
																																				int key242 = (int)num ^ -523163875;
																																				num -= 3917761933u;
																																				num -= 1494091032;
																																				e52C86B248[(uint)key242] = _5F853100;
																																				num = 45193232 % num;
																																				Dictionary<uint, A93EA20B> e52C86B249 = E52C86B9;
																																				uint key243 = num ^ 0x2B198ED;
																																				num += 2408658698u;
																																				e52C86B249[key243] = ED048E22;
																																				if (num % 3784902945u == 0)
																																				{
																																					break;
																																				}
																																				num = 1680925448 + num;
																																				Dictionary<uint, A93EA20B> e52C86B250 = E52C86B9;
																																				int key244 = (int)num ^ -160189732;
																																				num += 3456363939u;
																																				num *= 3457051306u;
																																				A93EA20B value127 = _10282C26;
																																				num <<= 27;
																																				e52C86B250[(uint)key244] = value127;
																																				num /= 1696023573;
																																				Dictionary<uint, A93EA20B> e52C86B251 = E52C86B9;
																																				num = 2435849405u / num;
																																				int key245 = (int)num - -1859118146;
																																				num = 0x4B0FFE26 ^ num;
																																				num -= 372032827;
																																				e52C86B251[(uint)key245] = _4B8820A3;
																																				if (num < 1907588634)
																																				{
																																					goto end_IL_004a;
																																				}
																																				return;
																																			}
																																			continue;
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
								goto IL_0011;
							}
							break;
						}
						goto IL_003f;
						continue;
						end_IL_004a:
						break;
					}
					break;
				}
				break;
			}
		}
	}
}
