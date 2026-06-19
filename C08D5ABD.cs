internal struct C08D5ABD
{
	private readonly BDB4FF80[] _07AB05B6;

	private readonly int _053CDCB3;

	public uint D0814B0B(_3D933C99 _07985E22)
	{
		uint num = 1u;
		for (int num2 = _053CDCB3; num2 > 0; num2--)
		{
			num = (num << 1) + _07AB05B6[num]._59049A8B(_07985E22);
		}
		return num - (uint)(1 << _053CDCB3);
	}

	public void _7924162C()
	{
		for (uint num = 1u; num < 1 << _053CDCB3; num++)
		{
			_07AB05B6[num]._4E2CE890();
		}
	}

	public uint _0F958E12(_3D933C99 B30B3205)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < _053CDCB3; i++)
		{
			uint num3 = _07AB05B6[num]._59049A8B(B30B3205);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	public static uint _9B99E2BC(BDB4FF80[] _05BAC5BA, uint BD9C3883, _3D933C99 E738EB33, int CA3A3F0C)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < CA3A3F0C; i++)
		{
			uint num3 = _05BAC5BA[BD9C3883 + num]._59049A8B(E738EB33);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	public C08D5ABD(int E3220922)
	{
		_053CDCB3 = E3220922;
		_07AB05B6 = new BDB4FF80[1 << E3220922];
	}
}
