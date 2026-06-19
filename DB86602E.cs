using System;
using System.IO;

public class DB86602E
{
	private class CC33F317
	{
		private C08D5ABD C298E5BA = new C08D5ABD(8);

		private readonly C08D5ABD[] _45B4CC25 = new C08D5ABD[16];

		private uint _1A1FB1B6;

		private readonly C08D5ABD[] F486308E = new C08D5ABD[16];

		private BDB4FF80 _3310AC02;

		private BDB4FF80 D0096C00;

		public uint F2072291(_3D933C99 CFA6F1B2, uint A49920B9)
		{
			if (D0096C00._59049A8B(CFA6F1B2) == 0)
			{
				return _45B4CC25[A49920B9].D0814B0B(CFA6F1B2);
			}
			uint num = 8u;
			if (_3310AC02._59049A8B(CFA6F1B2) == 0)
			{
				return num + F486308E[A49920B9].D0814B0B(CFA6F1B2);
			}
			num += 8;
			return num + C298E5BA.D0814B0B(CFA6F1B2);
		}

		public void _4B22DC34()
		{
			D0096C00._4E2CE890();
			for (uint num = 0u; num < _1A1FB1B6; num++)
			{
				_45B4CC25[num]._7924162C();
				F486308E[num]._7924162C();
			}
			_3310AC02._4E2CE890();
			C298E5BA._7924162C();
		}

		public void D60ACC80(uint F82A0B1D)
		{
			for (uint num = _1A1FB1B6; num < F82A0B1D; num++)
			{
				_45B4CC25[num] = new C08D5ABD(3);
				F486308E[num] = new C08D5ABD(3);
			}
			_1A1FB1B6 = F82A0B1D;
		}
	}

	private class DD30FB21
	{
		private struct _7E281B84
		{
			private BDB4FF80[] _39038434;

			public byte _5D82E799(_3D933C99 FFA3E1AD, byte _1BAE4210)
			{
				uint num = 1u;
				do
				{
					uint num2 = (uint)((_1BAE4210 >> 7) & 1);
					_1BAE4210 <<= 1;
					uint num3 = _39038434[(1 + num2 << 8) + num]._59049A8B(FFA3E1AD);
					num = (num << 1) | num3;
					if (num2 != num3)
					{
						while (num < 256)
						{
							num = (num << 1) | _39038434[num]._59049A8B(FFA3E1AD);
						}
						break;
					}
				}
				while (num < 256);
				return (byte)num;
			}

			public void _889E9804()
			{
				for (int i = 0; i < 768; i++)
				{
					_39038434[i]._4E2CE890();
				}
			}

			public byte C323711F(_3D933C99 DA27459D)
			{
				uint num = 1u;
				do
				{
					num = (num << 1) | _39038434[num]._59049A8B(DA27459D);
				}
				while (num < 256);
				return (byte)num;
			}

			public void A11E012E()
			{
				_39038434 = new BDB4FF80[768];
			}
		}

		private uint F03EB49C;

		private int _5683628A;

		private int C22D6E87;

		private _7E281B84[] _050B8F8F;

		private uint _11A26110 = 1u;

		public byte _8EAE6C8D(_3D933C99 _54AF6F12, uint _3681091A, byte E5BC6613, byte FD1D9390)
		{
			return _050B8F8F[_8D08AB90(_3681091A, E5BC6613)]._5D82E799(_54AF6F12, FD1D9390);
		}

		public byte _901C753F(_3D933C99 _87A27BB3, uint FFB5A59D, byte EA8D6D07)
		{
			return _050B8F8F[_8D08AB90(FFB5A59D, EA8D6D07)].C323711F(_87A27BB3);
		}

		private uint _8D08AB90(uint BD1776BF, byte _5AA64388)
		{
			return ((BD1776BF & F03EB49C) << _5683628A) + (uint)(_5AA64388 >> 8 - _5683628A);
		}

		public void _183FE6AB()
		{
			uint num = (uint)(1 << _5683628A + C22D6E87);
			for (uint num2 = 0u; num2 < num; num2++)
			{
				_050B8F8F[num2]._889E9804();
			}
		}

		public void _1AB3233E(int _2DA5EC13, int _60251F3F)
		{
			if (_050B8F8F == null || _5683628A != _60251F3F || C22D6E87 != _2DA5EC13)
			{
				C22D6E87 = _2DA5EC13;
				F03EB49C = (uint)((1 << _2DA5EC13) - 1);
				_5683628A = _60251F3F;
				uint num = (uint)(1 << _5683628A + C22D6E87);
				_050B8F8F = new _7E281B84[num];
				for (uint num2 = 0u; num2 < num; num2++)
				{
					_050B8F8F[num2].A11E012E();
				}
			}
		}
	}

	private readonly BDB4FF80[] _4135FD87 = new BDB4FF80[12];

	private readonly CC33F317 _30067C23 = new CC33F317();

	private C08D5ABD _8C037E8E = new C08D5ABD(4);

	private readonly BDB4FF80[] B21BD0B1 = new BDB4FF80[114];

	private readonly _882A780C _723C1B09 = new _882A780C();

	private readonly _3D933C99 _43899027 = new _3D933C99();

	private readonly CC33F317 _90109617 = new CC33F317();

	private readonly DD30FB21 C33B2882 = new DD30FB21();

	private readonly BDB4FF80[] _8020DF23 = new BDB4FF80[192];

	private readonly BDB4FF80[] E5B1951E = new BDB4FF80[12];

	private readonly C08D5ABD[] _79A3DC13 = new C08D5ABD[4];

	private uint ED3978B7;

	private uint _931E528C;

	private readonly BDB4FF80[] F5A95618 = new BDB4FF80[192];

	private readonly BDB4FF80[] A4A2F21A = new BDB4FF80[12];

	private readonly BDB4FF80[] EC31ED12 = new BDB4FF80[12];

	private uint CBB57F2E;

	private uint _1D2AB03F = 1u;

	private void _40BA72BC(uint F3351111)
	{
		if (_931E528C != F3351111)
		{
			_931E528C = F3351111;
			CBB57F2E = Math.Max(_931E528C, 1u);
			uint e3B7E13D = Math.Max(CBB57F2E, 4096u);
			_723C1B09.DB278788(e3B7E13D);
		}
	}

	private void _20A192A0(int _1A1A12AB, int _7D0AAAA7)
	{
		if (_1A1A12AB > 8)
		{
			throw new ArgumentException();
		}
		if (_7D0AAAA7 > 8)
		{
			throw new ArgumentException();
		}
		C33B2882._1AB3233E(_1A1A12AB, _7D0AAAA7);
	}

	public void _632CC512(byte[] _71240F84)
	{
		if (_71240F84.Length < 5)
		{
			throw new ArgumentException();
		}
		int _7D0AAAA = _71240F84[0] % 9;
		int num = _71240F84[0] / 9;
		int _1A1A12AB = num % 5;
		int num2 = num / 5;
		if (num2 > 4)
		{
			throw new ArgumentException();
		}
		uint num3 = 0u;
		for (int i = 0; i < 4; i++)
		{
			num3 += (uint)(_71240F84[1 + i] << i * 8);
		}
		_40BA72BC(num3);
		_20A192A0(_1A1A12AB, _7D0AAAA);
		_61B9ABA1(num2);
	}

	private void _8AB17CAC(Stream _6E935A1F, Stream _4115DDB3)
	{
		_43899027._68291387(_6E935A1F);
		_723C1B09.E5245721(_4115DDB3, _29A23E01: false);
		for (uint num = 0u; num < 12; num++)
		{
			for (uint num2 = 0u; num2 <= ED3978B7; num2++)
			{
				uint num3 = (num << 4) + num2;
				F5A95618[num3]._4E2CE890();
				_8020DF23[num3]._4E2CE890();
			}
			E5B1951E[num]._4E2CE890();
			A4A2F21A[num]._4E2CE890();
			EC31ED12[num]._4E2CE890();
			_4135FD87[num]._4E2CE890();
		}
		C33B2882._183FE6AB();
		for (uint num = 0u; num < 4; num++)
		{
			_79A3DC13[num]._7924162C();
		}
		for (uint num = 0u; num < 114; num++)
		{
			B21BD0B1[num]._4E2CE890();
		}
		_90109617._4B22DC34();
		_30067C23._4B22DC34();
		_8C037E8E._7924162C();
	}

	private void _61B9ABA1(int _3D86DA1F)
	{
		if (_3D86DA1F > 4)
		{
			throw new ArgumentException();
		}
		uint num = (uint)(1 << _3D86DA1F);
		_90109617.D60ACC80(num);
		_30067C23.D60ACC80(num);
		ED3978B7 = num - 1;
	}

	public void _65BF0B01(Stream _87B9208C, Stream _28307986, long _3E0CA79E)
	{
		_8AB17CAC(_87B9208C, _28307986);
		_24AA1D0C.DBA1D883 dBA1D = default(_24AA1D0C.DBA1D883);
		dBA1D._4112E181();
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		ulong num5 = 0uL;
		if (num5 < (ulong)_3E0CA79E)
		{
			if (F5A95618[dBA1D.C786B6AF << 4]._59049A8B(_43899027) != 0)
			{
				throw new InvalidDataException();
			}
			dBA1D.F83B4A37();
			byte _5C0F358E = C33B2882._901C753F(_43899027, 0u, 0);
			_723C1B09.B6969A23(_5C0F358E);
			num5++;
		}
		while (num5 < (ulong)_3E0CA79E)
		{
			uint num6 = (uint)(int)num5 & ED3978B7;
			if (F5A95618[(dBA1D.C786B6AF << 4) + num6]._59049A8B(_43899027) == 0)
			{
				byte b = _723C1B09.D7A43D13(0u);
				byte _5C0F358E2 = (dBA1D._1C3179A1() ? C33B2882._901C753F(_43899027, (uint)num5, b) : C33B2882._8EAE6C8D(_43899027, (uint)num5, b, _723C1B09.D7A43D13(num)));
				_723C1B09.B6969A23(_5C0F358E2);
				dBA1D.F83B4A37();
				num5++;
				continue;
			}
			uint num8;
			if (E5B1951E[dBA1D.C786B6AF]._59049A8B(_43899027) == 1)
			{
				if (A4A2F21A[dBA1D.C786B6AF]._59049A8B(_43899027) == 0)
				{
					if (_8020DF23[(dBA1D.C786B6AF << 4) + num6]._59049A8B(_43899027) == 0)
					{
						dBA1D._4C991F3B();
						_723C1B09.B6969A23(_723C1B09.D7A43D13(num));
						num5++;
						continue;
					}
				}
				else
				{
					uint num7;
					if (EC31ED12[dBA1D.C786B6AF]._59049A8B(_43899027) == 0)
					{
						num7 = num2;
					}
					else
					{
						if (_4135FD87[dBA1D.C786B6AF]._59049A8B(_43899027) == 0)
						{
							num7 = num3;
						}
						else
						{
							num7 = num4;
							num4 = num3;
						}
						num3 = num2;
					}
					num2 = num;
					num = num7;
				}
				num8 = _30067C23.F2072291(_43899027, num6) + 2;
				dBA1D.C5393AA8();
			}
			else
			{
				num4 = num3;
				num3 = num2;
				num2 = num;
				num8 = 2 + _90109617.F2072291(_43899027, num6);
				dBA1D._4039FEB3();
				uint num9 = _79A3DC13[_24AA1D0C.E1326EA8(num8)].D0814B0B(_43899027);
				if (num9 >= 4)
				{
					int num10 = (int)((num9 >> 1) - 1);
					num = (2 | (num9 & 1)) << num10;
					if (num9 < 14)
					{
						num += C08D5ABD._9B99E2BC(B21BD0B1, num - num9 - 1, _43899027, num10);
					}
					else
					{
						num += _43899027._362573A3(num10 - 4) << 4;
						num += _8C037E8E._0F958E12(_43899027);
					}
				}
				else
				{
					num = num9;
				}
			}
			if (num >= _723C1B09._1420DDAC + num5 || num >= CBB57F2E)
			{
				if (num == uint.MaxValue)
				{
					break;
				}
				throw new InvalidDataException();
			}
			_723C1B09.E19BD436(num, num8);
			num5 += num8;
		}
		_723C1B09._2595302C();
		_723C1B09._9D842833();
		_43899027.ED209803();
	}

	public DB86602E()
	{
		_931E528C = uint.MaxValue;
		for (int i = 0; (long)i < 4L; i++)
		{
			_79A3DC13[i] = new C08D5ABD(6);
		}
	}
}
