public class _84186B01
{
	public static uint E4B03639(uint _0EB84DA0)
	{
		uint num = _0EB84DA0 & 0xFF00FF;
		uint num2 = _0EB84DA0 & 0xFF00FF00u;
		return ((num >> 8) | (num << 24)) + ((num2 << 8) | (num2 >> 24));
	}

	public static uint D8272B81(uint _4694CC86, int E5A79613)
	{
		return (_4694CC86 << E5A79613) | (_4694CC86 >> 32 - E5A79613);
	}
}
