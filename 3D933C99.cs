using System.IO;

internal class _3D933C99
{
	public uint E38B6F1F;

	public uint _1885D20D;

	public Stream _188325B8;

	private uint _7024372C = 1u;

	public uint _362573A3(int BB84180B)
	{
		uint num = E38B6F1F;
		uint num2 = _1885D20D;
		uint num3 = 0u;
		for (int num4 = BB84180B; num4 > 0; num4--)
		{
			num >>= 1;
			uint num5 = num2 - num >> 31;
			num2 -= num & (num5 - 1);
			num3 = (num3 << 1) | (1 - num5);
			if (num < 16777216)
			{
				num2 = (num2 << 8) | (byte)_188325B8.ReadByte();
				num <<= 8;
			}
		}
		E38B6F1F = num;
		_1885D20D = num2;
		return num3;
	}

	public void ED209803()
	{
		_188325B8 = null;
	}

	public void _68291387(Stream _7308EE97)
	{
		_188325B8 = _7308EE97;
		_1885D20D = 0u;
		E38B6F1F = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			_1885D20D = (_1885D20D << 8) | (byte)_188325B8.ReadByte();
		}
	}
}
