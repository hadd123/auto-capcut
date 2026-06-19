using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class _1CA75C83
{
	public class _5203163E
	{
		[Serializable]
		private sealed class _5A3A0F23
		{
			public static RemoteCertificateValidationCallback _068E963F;

			public static readonly _5A3A0F23 _15929E3C = new _5A3A0F23();

			internal bool _28AF308B(object _1488E8BE, X509Certificate E825F300, X509Chain _4E9E32AA, SslPolicyErrors FD2E9E09)
			{
				return true;
			}
		}

		private string _74971895;

		private string _96271380;

		public string _6E9BC9AC
		{
			get
			{
				return _74971895;
			}
			private set
			{
				_74971895 = value;
			}
		}

		public string DFAAEDB2
		{
			get
			{
				return _96271380;
			}
			private set
			{
				_96271380 = value;
			}
		}

		protected void _63345EBB(string _0805B2B7, string _34A42426)
		{
			_00B3359F(_0805B2B7, _7F93B69C: false);
			_00B3359F(_34A42426, _7F93B69C: true);
		}

		protected void _95871788()
		{
			DFAAEDB2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(DFAAEDB2));
		}

		private void _00B3359F(string BE3DAC90, bool _7F93B69C)
		{
			if (_7F93B69C)
			{
				StringBuilder stringBuilder = new StringBuilder(DFAAEDB2);
				foreach (char c in BE3DAC90)
				{
					switch (c)
					{
					case '+':
						stringBuilder.Append("%2B");
						break;
					case '/':
						stringBuilder.Append("%2F");
						break;
					case '=':
						stringBuilder.Append("%3D");
						break;
					default:
						stringBuilder.Append(c);
						break;
					}
				}
				DFAAEDB2 = stringBuilder.ToString();
			}
			else
			{
				DFAAEDB2 += BE3DAC90;
			}
		}

		protected bool B73C850A(byte[] _5C199835)
		{
			int num = BitConverter.ToInt32(_5C199835, 32);
			if (num == 0)
			{
				return false;
			}
			int index = BitConverter.ToInt32(_5C199835, 28);
			DFAAEDB2 = Encoding.UTF8.GetString(_5C199835, index, num);
			if (DFAAEDB2[DFAAEDB2.Length - 1] != '/')
			{
				DFAAEDB2 += "/";
			}
			return true;
		}
	}

	public class _982E498C : _5203163E
	{
		private string _430134AB;
	}

	public class D58D63A4 : _5203163E
	{
	}

	private int _6EB08D30;

	private readonly int F0893005;

	private readonly object F029FA80;

	private byte[] _199CEC08;

	private B8ADBB8B _58840607;

	private long E7A9B328;

	private uint _5A96D68F;

	private readonly byte[] _772FF29C;

	public _1CA75C83(byte[] CBBE43A4)
	{
		new _02B4022E()._1CBB33BE(new object[2] { this, CBBE43A4 }, 1165181);
	}

	public _1CA75C83()
	{
		new _02B4022E()._1CBB33BE(new object[1] { this }, 1067076);
	}
}
