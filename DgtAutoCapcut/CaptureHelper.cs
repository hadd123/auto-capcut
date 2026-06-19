using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;

namespace DgtAutoCapcut;

public class CaptureHelper
{
	public class GDI32
	{
		public const int SRCCOPY = 13369376;

		[DllImport("gdi32.dll")]
		public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hObjectSource, int nXSrc, int nYSrc, int dwRop);

		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth, int nHeight);

		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

		[DllImport("gdi32.dll")]
		public static extern bool DeleteDC(IntPtr hDC);

		[DllImport("gdi32.dll")]
		public static extern bool DeleteObject(IntPtr hObject);

		[DllImport("gdi32.dll")]
		public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
	}

	public class User32
	{
		public struct RECT
		{
			public int left;

			public int top;

			public int right;

			public int bottom;
		}

		public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

		[DllImport("USER32.DLL")]
		private static extern IntPtr GetShellWindow();

		[DllImport("USER32.DLL")]
		private static extern bool IsWindowVisible(IntPtr hWnd);

		[DllImport("user32.dll")]
		public static extern IntPtr GetDesktopWindow();

		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowDC(IntPtr hWnd);

		[DllImport("user32.dll")]
		public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);

		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		private static extern int GetWindowText(IntPtr hWnd, StringBuilder strText, int maxCount);

		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		private static extern int GetWindowTextLength(IntPtr hWnd);

		[DllImport("user32.dll")]
		private static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

		public static string GetWindowText(IntPtr hWnd)
		{
			int windowTextLength = GetWindowTextLength(hWnd);
			if (windowTextLength > 0)
			{
				StringBuilder stringBuilder = new StringBuilder(windowTextLength + 1);
				GetWindowText(hWnd, stringBuilder, stringBuilder.Capacity);
				return stringBuilder.ToString();
			}
			return string.Empty;
		}

		public static IDictionary<IntPtr, string> GetOpenWindows()
		{
			IntPtr shellWindow = GetShellWindow();
			Dictionary<IntPtr, string> windows = new Dictionary<IntPtr, string>();
			EnumWindows(delegate(IntPtr hWnd, IntPtr lParam)
			{
				if (hWnd == shellWindow)
				{
					return true;
				}
				if (!IsWindowVisible(hWnd))
				{
					return true;
				}
				int windowTextLength = GetWindowTextLength(hWnd);
				if (windowTextLength == 0)
				{
					return true;
				}
				StringBuilder stringBuilder = new StringBuilder(windowTextLength);
				GetWindowText(hWnd, stringBuilder, windowTextLength + 1);
				windows[hWnd] = stringBuilder.ToString();
				return true;
			}, IntPtr.Zero);
			return windows;
		}

		public static IEnumerable<IntPtr> FindWindows(EnumWindowsProc filter)
		{
			_ = IntPtr.Zero;
			List<IntPtr> windows = new List<IntPtr>();
			EnumWindows(delegate(IntPtr wnd, IntPtr param)
			{
				if (filter(wnd, param))
				{
					windows.Add(wnd);
				}
				return true;
			}, IntPtr.Zero);
			return windows;
		}

		public static IEnumerable<IntPtr> FindWindowsWithText(string titleText)
		{
			return FindWindows((IntPtr wnd, IntPtr param) => GetWindowText(wnd).Contains(titleText));
		}

		public static IEnumerable<IntPtr> FindWindowsActive()
		{
			return FindWindows(delegate(IntPtr wnd, IntPtr param)
			{
				RECT rect = default(RECT);
				GetWindowRect(wnd, ref rect);
				return (GetWindowText(wnd).Length > 0 && rect.right - rect.left > 10 && rect.bottom - rect.top > 10) ? true : false;
			});
		}
	}

	public static int X;

	public static int Y;

	public static Image CaptureScreen()
	{
		return CaptureWindow(User32.GetDesktopWindow(), inactivemode: false);
	}

	public static Bitmap CaptureWindow(IntPtr handle, bool inactivemode)
	{
		if (inactivemode)
		{
			IntPtr windowDC = User32.GetWindowDC(handle);
			User32.RECT rect = default(User32.RECT);
			User32.GetWindowRect(handle, ref rect);
			int num = rect.right - rect.left;
			int num2 = rect.bottom - rect.top;
			if (num == 0 && num2 == 0)
			{
				return null;
			}
			IntPtr intPtr = GDI32.CreateCompatibleDC(windowDC);
			IntPtr intPtr2 = GDI32.CreateCompatibleBitmap(windowDC, num, num2);
			IntPtr hObject = GDI32.SelectObject(intPtr, intPtr2);
			GDI32.BitBlt(intPtr, 0, 0, num, num2, windowDC, 0, 0, 13369376);
			GDI32.SelectObject(intPtr, hObject);
			GDI32.DeleteDC(intPtr);
			User32.ReleaseDC(handle, windowDC);
			Bitmap result = Image.FromHbitmap(intPtr2);
			GDI32.DeleteObject(intPtr2);
			return result;
		}
		User32.RECT rect2 = default(User32.RECT);
		User32.GetWindowRect(handle, ref rect2);
		if (rect2.right == 0 || rect2.bottom == 0)
		{
			return new Bitmap(1, 1);
		}
		Rectangle rectangle = new Rectangle(rect2.left, rect2.top, rect2.right - rect2.left, rect2.bottom - rect2.top);
		Bitmap bitmap = new Bitmap(rectangle.Width, rectangle.Height);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.CopyFromScreen(new Point(rectangle.Left, rectangle.Top), Point.Empty, rectangle.Size);
		return bitmap;
	}

	public static Bitmap ScaleImage(Image a, double zoomin)
	{
		try
		{
			return ResizeImage(a, a.Size.Width + (int)((double)a.Size.Width * zoomin), a.Size.Height + (int)((double)a.Size.Height * zoomin));
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static Bitmap ResizeImage(Image image, int width, int height)
	{
		Rectangle destRect = new Rectangle(0, 0, width, height);
		Bitmap bitmap = new Bitmap(width, height);
		bitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.CompositingMode = CompositingMode.SourceCopy;
		graphics.CompositingQuality = CompositingQuality.HighQuality;
		graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		using ImageAttributes imageAttributes = new ImageAttributes();
		imageAttributes.SetWrapMode(WrapMode.TileFlipXY);
		graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
		return bitmap;
	}

	public static void CaptureScreenToFile(string filename, ImageFormat format)
	{
		CaptureScreen().Save(filename, format);
	}

	public static Bitmap CaptureImage(Size size, Point position)
	{
		try
		{
			Bitmap bitmap = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppRgb);
			Graphics.FromImage(bitmap).CopyFromScreen(position.X + X, position.Y + Y, 0, 0, size, CopyPixelOperation.SourceCopy);
			return bitmap;
		}
		catch
		{
			return null;
		}
	}

	[DllImport("gdi32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeleteObject([In] IntPtr hObject);

	public static Bitmap CropImage(Image img, Rectangle cropRect)
	{
		Bitmap image = img as Bitmap;
		Bitmap bitmap = new Bitmap(cropRect.Width, cropRect.Height);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.DrawImage(image, new Rectangle(0, 0, bitmap.Width, bitmap.Height), cropRect, GraphicsUnit.Pixel);
		return bitmap;
	}

	public static Bitmap CropImage(Bitmap img, Rectangle cropRect)
	{
		Bitmap bitmap = new Bitmap(cropRect.Width, cropRect.Height);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.DrawImage(img, new Rectangle(0, 0, bitmap.Width, bitmap.Height), cropRect, GraphicsUnit.Pixel);
		return bitmap;
	}
}
