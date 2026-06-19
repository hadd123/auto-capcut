internal abstract class _24AA1D0C
{
	public struct DBA1D883
	{
		public uint C786B6AF;

		public bool _1C3179A1()
		{
			return C786B6AF < 7;
		}

		public void _4C991F3B()
		{
			C786B6AF = ((C786B6AF < 7) ? 9u : 11u);
		}

		public void C5393AA8()
		{
			C786B6AF = ((C786B6AF < 7) ? 8u : 11u);
		}

		public void _4039FEB3()
		{
			C786B6AF = ((C786B6AF < 7) ? 7u : 10u);
		}

		public void F83B4A37()
		{
			if (C786B6AF < 4)
			{
				C786B6AF = 0u;
			}
			else if (C786B6AF < 10)
			{
				C786B6AF -= 3u;
			}
			else
			{
				C786B6AF -= 6u;
			}
		}

		public void _4112E181()
		{
			C786B6AF = 0u;
		}
	}

	public static uint E1326EA8(uint B08E3531)
	{
		B08E3531 -= 2;
		if (B08E3531 < 4)
		{
			return B08E3531;
		}
		return 3u;
	}
}
