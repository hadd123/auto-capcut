using System;
using System.Threading;
using System.Windows.Forms;

namespace DgtAutoCapcut;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		bool createdNew = true;
		using (new Mutex(initiallyOwned: true, "DgtAutoCapcut", out createdNew))
		{
			if (createdNew)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(defaultValue: false);
				Application.Run(new Login());
			}
			else
			{
				MessageBox.Show("Ứng dụng đang chạy !!!!");
			}
		}
	}
}
