using System.IO;

public class _882A780C
{
	public uint _1420DDAC;

	private uint _10364B0D;

	private Stream _2A9D99AE;

	private uint _7B93C723 = 1u;

	private uint _103F5785;

	private uint _1C9959B8;

	private byte[] _51850B0E;

	public void _9D842833()
	{
		_2595302C();
		_2A9D99AE = null;
	}

	public void E19BD436(uint C22951AE, uint DA08B1BA)
	{
		uint num = _1C9959B8 - C22951AE - 1;
		if (num >= _103F5785)
		{
			num += _103F5785;
		}
		while (DA08B1BA != 0)
		{
			if (num >= _103F5785)
			{
				num = 0u;
			}
			_51850B0E[_1C9959B8++] = _51850B0E[num++];
			if (_1C9959B8 >= _103F5785)
			{
				_2595302C();
			}
			DA08B1BA--;
		}
	}

	public byte D7A43D13(uint _888852A8)
	{
		uint num = _1C9959B8 - _888852A8 - 1;
		if (num >= _103F5785)
		{
			num += _103F5785;
		}
		return _51850B0E[num];
	}

	public void E5245721(Stream _6830A036, bool _29A23E01)
	{
		_9D842833();
		_2A9D99AE = _6830A036;
		if (!_29A23E01)
		{
			_10364B0D = 0u;
			_1C9959B8 = 0u;
			_1420DDAC = 0u;
		}
	}

	public void _2595302C()
	{
		uint num = _1C9959B8 - _10364B0D;
		if (num != 0)
		{
			_2A9D99AE.Write(_51850B0E, (int)_10364B0D, (int)num);
			if (_1C9959B8 >= _103F5785)
			{
				_1C9959B8 = 0u;
			}
			_10364B0D = _1C9959B8;
		}
	}

	public void B6969A23(byte _5C0F358E)
	{
		_51850B0E[_1C9959B8++] = _5C0F358E;
		if (_1C9959B8 >= _103F5785)
		{
			_2595302C();
		}
	}

	public void DB278788(uint E3B7E13D)
	{
		if (_103F5785 != E3B7E13D)
		{
			_51850B0E = new byte[E3B7E13D];
		}
		_103F5785 = E3B7E13D;
		_1C9959B8 = 0u;
		_10364B0D = 0u;
	}
}
