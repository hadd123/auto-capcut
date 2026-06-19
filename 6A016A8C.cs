public class _6A016A8C
{
	private uint _52818113;

	public uint _593FDB9C(uint _7D99451C)
	{
		uint num = _7D99451C ^ _52818113;
		_52818113 = ((_52818113 << 7) | (_52818113 >> 25)) ^ num;
		return num;
	}

	public _6A016A8C()
	{
		_52818113 = 3333008665u;
	}
}
