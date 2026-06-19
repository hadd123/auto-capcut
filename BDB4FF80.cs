internal struct BDB4FF80
{
	private uint D4248A82;

	public uint _59049A8B(_3D933C99 _4F1E818E)
	{
		uint num = (_4F1E818E.E38B6F1F >> 11) * D4248A82;
		if (_4F1E818E._1885D20D < num)
		{
			_4F1E818E.E38B6F1F = num;
			D4248A82 += 2048 - D4248A82 >> 5;
			if (_4F1E818E.E38B6F1F < 16777216)
			{
				_4F1E818E._1885D20D = (_4F1E818E._1885D20D << 8) | (byte)_4F1E818E._188325B8.ReadByte();
				_4F1E818E.E38B6F1F <<= 8;
			}
			return 0u;
		}
		_4F1E818E.E38B6F1F -= num;
		_4F1E818E._1885D20D -= num;
		D4248A82 -= D4248A82 >> 5;
		if (_4F1E818E.E38B6F1F < 16777216)
		{
			_4F1E818E._1885D20D = (_4F1E818E._1885D20D << 8) | (byte)_4F1E818E._188325B8.ReadByte();
			_4F1E818E.E38B6F1F <<= 8;
		}
		return 1u;
	}

	public void _4E2CE890()
	{
		D4248A82 = 1024u;
	}
}
