using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DgtAutoCapcut;

public class AutoControl
{
	public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

	public class WinInfo
	{
		public string Title { get; set; }

		public IntPtr Hwnd { get; set; }

		public Rectangle Rectangle { get; set; }

		public bool HasChild { get; set; }
	}

	public delegate bool CallBack(IntPtr hwnd, IntPtr lParam);

	private delegate bool EnumWindowProc(IntPtr hwnd, IntPtr lParam);

	[Flags]
	public enum MouseEventFlags : uint
	{
		LEFTDOWN = 2u,
		LEFTUP = 4u,
		MIDDLEDOWN = 0x20u,
		MIDDLEUP = 0x40u,
		MOVE = 1u,
		ABSOLUTE = 0x8000u,
		RIGHTDOWN = 8u,
		RIGHTUP = 0x10u,
		WHEEL = 0x800u,
		XDOWN = 0x80u,
		XUP = 0x100u,
		XBUTTON1 = 1u,
		XBUTTON2 = 2u
	}

	private const int WM_CLOSE = 16;

	private static Random rand = new Random();

	public const uint GW_CHILD = 5u;

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

	[DllImport("user32.dll")]
	public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

	public static bool CheckWindow(int processId, IntPtr hWnd)
	{
		GetWindowThreadProcessId(hWnd, out var lpdwProcessId);
		return lpdwProcessId == processId;
	}

	[DllImport("User32.dll")]
	public static extern int GetWindowText(IntPtr hWnd, StringBuilder s, int nMaxCount);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

	[DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
	private static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll")]
	private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, IntPtr lParam);

	[DllImport("user32.dll")]
	private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll")]
	private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, string lParam);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);

	[DllImport("user32.dll")]
	private static extern IntPtr GetDlgItem(IntPtr hWnd, int nIDDlgItem);

	[DllImport("user32.dll")]
	private static extern bool SetDlgItemTextA(IntPtr hWnd, int nIDDlgItem, string gchar);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	private static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string lclassName, string windowTitle);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

	[DllImport("user32.dll")]
	private static extern bool SetForegroundWindow(IntPtr hWnd);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

	[DllImport("user32")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool EnumChildWindows(IntPtr window, EnumWindowProc callback, IntPtr lParam);

	[DllImport("user32.dll")]
	public static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, UIntPtr dwExtraInfo);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint SendInput(uint numberOfInputs, INPUT[] inputs, int sizeOfInputStructure);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWindowVisible(IntPtr hWnd);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern IntPtr GetParent(IntPtr hWnd);

	public static IntPtr BringToFront(string className, string windowName = null)
	{
		IntPtr intPtr = FindWindow(className, windowName);
		SetForegroundWindow(intPtr);
		return intPtr;
	}

	public static void CloseWindow(IntPtr hwnd)
	{
		PostMessage(hwnd, 16, IntPtr.Zero, IntPtr.Zero);
	}

	public static IntPtr BringToFront(IntPtr hWnd)
	{
		SetForegroundWindow(hWnd);
		return hWnd;
	}

	public static bool IsWindowVisible_(IntPtr handle)
	{
		return IsWindowVisible(handle);
	}

	public static IntPtr FindWindowHandle(string className, string windowName)
	{
		_ = IntPtr.Zero;
		return FindWindow(className, windowName);
	}

	public static bool HasChildWindow(IntPtr hWnd)
	{
		bool hasChild = false;
		EnumChildWindows(hWnd, delegate
		{
			hasChild = true;
			return false;
		}, IntPtr.Zero);
		return hasChild;
	}

	public static List<WinInfo> GetVisibleWindowsOfProcess(IntPtr mainHwnd)
	{
		List<WinInfo> result = new List<WinInfo>();
		if (mainHwnd == IntPtr.Zero)
		{
			return result;
		}
		GetWindowThreadProcessId(mainHwnd, out var targetPid);
		EnumWindows(delegate(IntPtr hWnd, IntPtr lParam)
		{
			if (!IsWindowVisible(hWnd))
			{
				return true;
			}
			GetWindowThreadProcessId(hWnd, out var lpdwProcessId);
			if (lpdwProcessId != targetPid)
			{
				return true;
			}
			StringBuilder stringBuilder = new StringBuilder(512);
			GetWindowText(hWnd, stringBuilder, stringBuilder.Capacity);
			RECT lpRect = default(RECT);
			if (!GetWindowRect(hWnd, ref lpRect))
			{
				return true;
			}
			bool hasChild = HasChildWindow(hWnd);
			result.Add(new WinInfo
			{
				Hwnd = hWnd,
				Title = stringBuilder.ToString(),
				Rectangle = new Rectangle(lpRect.Left, lpRect.Top, lpRect.Right - lpRect.Left, lpRect.Bottom - lpRect.Top),
				HasChild = hasChild
			});
			return true;
		}, IntPtr.Zero);
		return result;
	}

	public static (IntPtr hwnd, string Process) FindWindowsByProcessNameAndTitle(string processName, string classname, string windowTitle, int minWidth)
	{
		Process[] processesByName = Process.GetProcessesByName(processName);
		string item = "";
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			IntPtr hwndFound = IntPtr.Zero;
			EnumWindows(delegate(IntPtr hWnd, IntPtr lParam)
			{
				if (CheckWindow(process.Id, hWnd))
				{
					StringBuilder stringBuilder = new StringBuilder(256);
					GetWindowText(hWnd, stringBuilder, stringBuilder.Capacity);
					bool flag = IsWindowVisible(hWnd);
					RECT windowRect = GetWindowRect(hWnd);
					string className = GetClassName(hWnd);
					if ((string.IsNullOrEmpty(classname) || className.Contains(classname) || className.Contains("WindowOwn")) && windowRect.Right - windowRect.Left > minWidth && flag && !string.IsNullOrEmpty(stringBuilder.ToString()) && stringBuilder.ToString().Contains(windowTitle))
					{
						hwndFound = hWnd;
						return false;
					}
				}
				return true;
			}, IntPtr.Zero);
			if (hwndFound != IntPtr.Zero)
			{
				return (hwnd: hwndFound, Process: item);
			}
		}
		return (hwnd: IntPtr.Zero, Process: item);
	}

	public static List<IntPtr> FindWindowHandlesFromProcesses(string className, string windowName, int maxCount = 1)
	{
		Process[] processes = Process.GetProcesses();
		List<IntPtr> list = new List<IntPtr>();
		int num = 0;
		Process[] array = processes;
		for (int i = 0; i < array.Length; i++)
		{
			IntPtr mainWindowHandle = array[i].MainWindowHandle;
			string className2 = GetClassName(mainWindowHandle);
			string text = GetText(mainWindowHandle);
			if (className2 == className || text == windowName)
			{
				list.Add(mainWindowHandle);
				if (num >= maxCount)
				{
					break;
				}
				num++;
			}
		}
		return list;
	}

	public static IntPtr FindWindowHandleFromProcesses(string processname, string className, string windowName)
	{
		Process[] array = null;
		array = ((!string.IsNullOrEmpty(processname)) ? Process.GetProcessesByName(processname) : Process.GetProcesses());
		IntPtr result = IntPtr.Zero;
		foreach (Process item in array.Where((Process p) => p.MainWindowHandle != IntPtr.Zero))
		{
			IntPtr mainWindowHandle = item.MainWindowHandle;
			string className2 = GetClassName(mainWindowHandle);
			string text = GetText(mainWindowHandle);
			if (IsWindowVisible(mainWindowHandle) && (className2 == className || text == windowName))
			{
				result = mainWindowHandle;
				break;
			}
		}
		return result;
	}

	public static IntPtr FindWindowExFromParent(IntPtr parentHandle, string text, string className)
	{
		return FindWindowEx(parentHandle, IntPtr.Zero, className, text);
	}

	private static IntPtr FindWindowByIndex(IntPtr hWndParent, int index)
	{
		if (index == 0)
		{
			return hWndParent;
		}
		int num = 0;
		IntPtr intPtr = IntPtr.Zero;
		do
		{
			intPtr = FindWindowEx(hWndParent, intPtr, "Button", null);
			if (intPtr != IntPtr.Zero)
			{
				num++;
			}
		}
		while (num < index && intPtr != IntPtr.Zero);
		return intPtr;
	}

	public static IntPtr GetControlHandleFromControlID(IntPtr parentHandle, int controlId)
	{
		return GetDlgItem(parentHandle, controlId);
	}

	public static List<IntPtr> GetChildHandle(IntPtr parentHandle)
	{
		List<IntPtr> list = new List<IntPtr>();
		GCHandle value = GCHandle.Alloc(list);
		IntPtr lParam = GCHandle.ToIntPtr(value);
		try
		{
			EnumWindowProc callback = delegate(IntPtr hWnd, IntPtr value2)
			{
				GCHandle gCHandle = GCHandle.FromIntPtr(value2);
				if (gCHandle.Target == null)
				{
					return false;
				}
				(gCHandle.Target as List<IntPtr>).Add(hWnd);
				return true;
			};
			EnumChildWindows(parentHandle, callback, lParam);
			return list;
		}
		finally
		{
			value.Free();
		}
	}

	public static IntPtr FindHandleWithText(List<IntPtr> handles, string className, string text)
	{
		return handles.Find(delegate(IntPtr ptr)
		{
			string className2 = GetClassName(ptr);
			string text2 = GetText(ptr);
			return className2 == className || text2 == text;
		});
	}

	public static List<IntPtr> FindHandlesWithText(List<IntPtr> handles, string className, string text)
	{
		new List<IntPtr>();
		return handles.Where(delegate(IntPtr ptr)
		{
			string className2 = GetClassName(ptr);
			string text2 = GetText(ptr);
			return className2 == className || text2 == text;
		}).ToList();
	}

	public static IntPtr FindHandle(IntPtr parentHandle, string className, string text)
	{
		return FindHandleWithText(GetChildHandle(parentHandle), className, text);
	}

	public static List<IntPtr> FindHandles(IntPtr parentHandle, string className, string text)
	{
		return FindHandlesWithText(GetChildHandle(parentHandle), className, text);
	}

	public static bool CallbackChild(IntPtr hWnd, IntPtr lParam)
	{
		string text = GetText(hWnd);
		string className = GetClassName(hWnd);
		if (!(text == "&Options >>") || !className.StartsWith("ToolbarWindow32"))
		{
			return true;
		}
		SendMessage(hWnd, 0, IntPtr.Zero, IntPtr.Zero);
		return false;
	}

	public static void SendClickOnControlById(IntPtr parentHWND, int controlID)
	{
		IntPtr dlgItem = GetDlgItem(parentHWND, controlID);
		int wParam = 0 | (controlID & 0xFFFF);
		SendMessage(parentHWND, 273, wParam, dlgItem);
	}

	public static void SendClickOnControlByHandle(IntPtr hWndButton)
	{
		SendMessage(hWndButton, 513, IntPtr.Zero, IntPtr.Zero);
		SendMessage(hWndButton, 514, IntPtr.Zero, IntPtr.Zero);
	}

	public static void SendClickOnPosition(IntPtr controlHandle, int x, int y, EMouseKey mouseButton = EMouseKey.LEFT, int clickTimes = 1)
	{
		int msg = 0;
		int msg2 = 0;
		if (mouseButton == EMouseKey.LEFT)
		{
			msg = 513;
			msg2 = 514;
		}
		if (mouseButton == EMouseKey.RIGHT)
		{
			msg = 516;
			msg2 = 517;
		}
		IntPtr lParam = MakeLParamFromXY(x, y);
		switch (mouseButton)
		{
		case EMouseKey.LEFT:
		case EMouseKey.RIGHT:
		{
			for (int i = 0; i < clickTimes; i++)
			{
				PostMessage(controlHandle, 6, new IntPtr(1), lParam);
				PostMessage(controlHandle, msg, new IntPtr(1), lParam);
				PostMessage(controlHandle, msg2, new IntPtr(0), lParam);
			}
			return;
		}
		case EMouseKey.DOUBLE_LEFT:
			msg = 515;
			msg2 = 514;
			break;
		}
		if (mouseButton == EMouseKey.DOUBLE_RIGHT)
		{
			msg = 518;
			msg2 = 517;
		}
		PostMessage(controlHandle, msg, new IntPtr(1), lParam);
		PostMessage(controlHandle, msg2, new IntPtr(0), lParam);
	}

	public static void SendClickOnPositionRandom(IntPtr controlHandle, int x, int y, int ranX, int ranY, EMouseKey mouseButton = EMouseKey.LEFT, int clickTimes = 1)
	{
		int msg = 0;
		int msg2 = 0;
		if (mouseButton == EMouseKey.LEFT)
		{
			msg = 513;
			msg2 = 514;
		}
		if (mouseButton == EMouseKey.RIGHT)
		{
			msg = 516;
			msg2 = 517;
		}
		ranX = rand.Next(ranX);
		ranY = rand.Next(ranY);
		IntPtr lParam = MakeLParamFromXY(x + ranX, y + ranY);
		switch (mouseButton)
		{
		case EMouseKey.LEFT:
		case EMouseKey.RIGHT:
		{
			for (int i = 0; i < clickTimes; i++)
			{
				PostMessage(controlHandle, 6, new IntPtr(1), lParam);
				PostMessage(controlHandle, msg, new IntPtr(1), lParam);
				PostMessage(controlHandle, msg2, new IntPtr(0), lParam);
			}
			return;
		}
		case EMouseKey.DOUBLE_LEFT:
			msg = 515;
			msg2 = 514;
			break;
		}
		if (mouseButton == EMouseKey.DOUBLE_RIGHT)
		{
			msg = 518;
			msg2 = 517;
		}
		PostMessage(controlHandle, msg, new IntPtr(1), lParam);
		PostMessage(controlHandle, msg2, new IntPtr(0), lParam);
	}

	public static void SendDragAndDropOnPosition(IntPtr controlHandle, int x, int y, int x2, int y2, int stepx = 10, int stepy = 10, double delay = 0.05)
	{
		int msg = 513;
		int msg2 = 514;
		IntPtr lParam = MakeLParamFromXY(x, y);
		IntPtr lParam2 = MakeLParamFromXY(x2, y2);
		if (x2 < x)
		{
			stepx *= -1;
		}
		if (y2 < y)
		{
			stepy *= -1;
		}
		PostMessage(controlHandle, 6, new IntPtr(1), lParam);
		PostMessage(controlHandle, msg, new IntPtr(1), lParam);
		bool flag = false;
		bool flag2 = false;
		while (true)
		{
			PostMessage(controlHandle, 512, new IntPtr(1), MakeLParamFromXY(x, y));
			if (stepx > 0)
			{
				if (x < x2)
				{
					x += stepx;
				}
				else
				{
					flag = true;
				}
			}
			else if (x > x2)
			{
				x += stepx;
			}
			else
			{
				flag = true;
			}
			if (stepy > 0)
			{
				if (y < y2)
				{
					y += stepy;
				}
				else
				{
					flag2 = true;
				}
			}
			else if (y > y2)
			{
				y += stepy;
			}
			else
			{
				flag2 = true;
			}
			if (flag && flag2)
			{
				break;
			}
			Thread.Sleep(TimeSpan.FromSeconds(delay));
		}
		PostMessage(controlHandle, msg2, new IntPtr(0), lParam2);
	}

	public static void SendDragAndDropOnMultiPosition(IntPtr controlHandle, Point[] points, int stepx = 10, int stepy = 10, double delay = 0.05)
	{
		if (points != null && points.Length >= 2)
		{
			int msg = 513;
			int msg2 = 514;
			IntPtr lParam = MakeLParamFromXY(points[0].X, points[0].Y);
			PostMessage(controlHandle, 6, new IntPtr(1), lParam);
			PostMessage(controlHandle, msg, new IntPtr(1), lParam);
			for (int i = 0; i < points.Length - 1; i++)
			{
				MouseMoveDrag(controlHandle, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y, stepx, stepy, delay);
			}
			PostMessage(controlHandle, msg2, new IntPtr(0), MakeLParamFromXY(points[points.Length - 1].X, points[points.Length - 1].Y));
		}
	}

	private static void MouseMoveDrag(IntPtr controlHandle, int x, int y, int x2, int y2, int stepx = 10, int stepy = 10, double delay = 0.05)
	{
		MakeLParamFromXY(x2, y2);
		if (x2 < x)
		{
			stepx *= -1;
		}
		if (y2 < y)
		{
			stepy *= -1;
		}
		bool flag = false;
		bool flag2 = false;
		while (true)
		{
			PostMessage(controlHandle, 512, new IntPtr(1), MakeLParamFromXY(x, y));
			if (stepx > 0)
			{
				if (x < x2)
				{
					x += stepx;
				}
				else
				{
					flag = true;
				}
			}
			else if (x > x2)
			{
				x += stepx;
			}
			else
			{
				flag = true;
			}
			if (stepy > 0)
			{
				if (y < y2)
				{
					y += stepy;
				}
				else
				{
					flag2 = true;
				}
			}
			else if (y > y2)
			{
				y += stepy;
			}
			else
			{
				flag2 = true;
			}
			if (!(flag && flag2))
			{
				Thread.Sleep(TimeSpan.FromSeconds(delay));
				continue;
			}
			break;
		}
	}

	public static void SendClickDownOnPosition(IntPtr controlHandle, int x, int y, EMouseKey mouseButton = EMouseKey.LEFT, int clickTimes = 1)
	{
		int msg = 0;
		if (mouseButton == EMouseKey.LEFT)
		{
			msg = 513;
		}
		if (mouseButton == EMouseKey.RIGHT)
		{
			msg = 516;
		}
		IntPtr lParam = MakeLParamFromXY(x, y);
		for (int i = 0; i < clickTimes; i++)
		{
			PostMessage(controlHandle, 6, new IntPtr(1), lParam);
			PostMessage(controlHandle, msg, new IntPtr(1), lParam);
		}
	}

	public static void SendClickUpOnPosition(IntPtr controlHandle, int x, int y, EMouseKey mouseButton = EMouseKey.LEFT, int clickTimes = 1)
	{
		int msg = 0;
		if (mouseButton == EMouseKey.LEFT)
		{
			msg = 514;
		}
		if (mouseButton == EMouseKey.RIGHT)
		{
			msg = 517;
		}
		IntPtr lParam = MakeLParamFromXY(x, y);
		for (int i = 0; i < clickTimes; i++)
		{
			PostMessage(controlHandle, 6, new IntPtr(1), lParam);
			SendMessage(controlHandle, msg, new IntPtr(0), lParam);
		}
	}

	public static void SendText(IntPtr handle, string text)
	{
		SendMessage(handle, 12, 0, text);
	}

	public static void SendKeyBoardPress(IntPtr handle, VKeys key)
	{
		PostMessage(handle, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(handle, 256, new IntPtr((int)key), new IntPtr(1));
		PostMessage(handle, 257, new IntPtr((int)key), new IntPtr(0));
	}

	public static void SendKeyBoardPressStepByStep(IntPtr handle, string message, float delay = 0.1f)
	{
		string text = message.ToLower();
		foreach (char c in text)
		{
			VKeys key = VKeys.VK_0;
			switch (c)
			{
			case '0':
				key = VKeys.VK_0;
				break;
			case '1':
				key = VKeys.VK_1;
				break;
			case '2':
				key = VKeys.VK_2;
				break;
			case '3':
				key = VKeys.VK_3;
				break;
			case '4':
				key = VKeys.VK_4;
				break;
			case '5':
				key = VKeys.VK_5;
				break;
			case '6':
				key = VKeys.VK_6;
				break;
			case '7':
				key = VKeys.VK_7;
				break;
			case '8':
				key = VKeys.VK_8;
				break;
			case '9':
				key = VKeys.VK_9;
				break;
			case 'a':
				key = VKeys.VK_A;
				break;
			case 'b':
				key = VKeys.VK_B;
				break;
			case 'c':
				key = VKeys.VK_V;
				break;
			case 'd':
				key = VKeys.VK_D;
				break;
			case 'e':
				key = VKeys.VK_E;
				break;
			case 'f':
				key = VKeys.VK_F;
				break;
			case 'g':
				key = VKeys.VK_G;
				break;
			case 'h':
				key = VKeys.VK_H;
				break;
			case 'i':
				key = VKeys.VK_I;
				break;
			case 'j':
				key = VKeys.VK_J;
				break;
			case 'k':
				key = VKeys.VK_K;
				break;
			case 'l':
				key = VKeys.VK_L;
				break;
			case 'm':
				key = VKeys.VK_M;
				break;
			case 'n':
				key = VKeys.VK_N;
				break;
			case 'o':
				key = VKeys.VK_O;
				break;
			case 'p':
				key = VKeys.VK_P;
				break;
			case 'q':
				key = VKeys.VK_Q;
				break;
			case 'r':
				key = VKeys.VK_R;
				break;
			case 's':
				key = VKeys.VK_S;
				break;
			case 't':
				key = VKeys.VK_T;
				break;
			case 'u':
				key = VKeys.VK_U;
				break;
			case 'v':
				key = VKeys.VK_V;
				break;
			case 'w':
				key = VKeys.VK_W;
				break;
			case 'x':
				key = VKeys.VK_X;
				break;
			case 'y':
				key = VKeys.VK_Y;
				break;
			case 'z':
				key = VKeys.VK_Z;
				break;
			}
			SendKeyBoardPress(handle, key);
			Thread.Sleep(TimeSpan.FromSeconds(delay));
		}
	}

	public static void SendKeyBoardUp(IntPtr handle, VKeys key)
	{
		PostMessage(handle, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(handle, 257, new IntPtr((int)key), new IntPtr(0));
	}

	public static void SendKeyChar(IntPtr handle, VKeys key)
	{
		PostMessage(handle, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(handle, 258, new IntPtr((int)key), new IntPtr(0));
	}

	public static void SendKeyChar(IntPtr handle, int key)
	{
		PostMessage(handle, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(handle, 258, new IntPtr(key), new IntPtr(0));
	}

	public static void SendKeyBoardDown(IntPtr handle, VKeys key)
	{
		PostMessage(handle, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(handle, 256, new IntPtr((int)key), new IntPtr(0));
	}

	public static void SendTextKeyBoard(IntPtr handle, string text, float delay = 0.1f)
	{
		foreach (char key in text)
		{
			SendKeyChar(handle, key);
		}
	}

	public static void SendKeyFocus(KeyCode key)
	{
		SendKeyPress(key);
	}

	public static void SendMultiKeysFocus(KeyCode[] keys)
	{
		KeyCode[] array = keys;
		for (int i = 0; i < array.Length; i++)
		{
			SendKeyDown(array[i]);
		}
		array = keys;
		for (int i = 0; i < array.Length; i++)
		{
			SendKeyUp(array[i]);
		}
	}

	public static void SendStringFocus(string message)
	{
		Clipboard.SetText(message);
		SendMultiKeysFocus(new KeyCode[2]
		{
			KeyCode.CONTROL,
			KeyCode.KEY_V
		});
	}

	public static void SendKeyPress(KeyCode keyCode)
	{
		INPUT iNPUT = new INPUT
		{
			Type = 1u
		};
		iNPUT.Data.Keyboard = new KEYBDINPUT
		{
			Vk = (ushort)keyCode,
			Scan = 0,
			Flags = 0u,
			Time = 0u,
			ExtraInfo = IntPtr.Zero
		};
		INPUT iNPUT2 = new INPUT
		{
			Type = 1u
		};
		iNPUT2.Data.Keyboard = new KEYBDINPUT
		{
			Vk = (ushort)keyCode,
			Scan = 0,
			Flags = 2u,
			Time = 0u,
			ExtraInfo = IntPtr.Zero
		};
		if (SendInput(2u, new INPUT[2] { iNPUT, iNPUT2 }, Marshal.SizeOf(typeof(INPUT))) == 0)
		{
			throw new Exception();
		}
	}

	public static void SendKeyPressStepByStep(string message, double delay = 0.5)
	{
		for (int i = 0; i < message.Length; i++)
		{
			switch (message[i])
			{
			case '0':
				SendKeyPress(KeyCode.KEY_0);
				break;
			case '1':
				SendKeyPress(KeyCode.KEY_1);
				break;
			case '2':
				SendKeyPress(KeyCode.KEY_2);
				break;
			case '3':
				SendKeyPress(KeyCode.KEY_3);
				break;
			case '4':
				SendKeyPress(KeyCode.KEY_4);
				break;
			case '5':
				SendKeyPress(KeyCode.KEY_5);
				break;
			case '6':
				SendKeyPress(KeyCode.KEY_6);
				break;
			case '7':
				SendKeyPress(KeyCode.KEY_7);
				break;
			case '8':
				SendKeyPress(KeyCode.KEY_8);
				break;
			case '9':
				SendKeyPress(KeyCode.KEY_9);
				break;
			}
			Thread.Sleep(TimeSpan.FromSeconds(delay));
		}
	}

	public static void SendKeyDown(KeyCode keyCode)
	{
		INPUT iNPUT = new INPUT
		{
			Type = 1u
		};
		iNPUT.Data.Keyboard = default(KEYBDINPUT);
		iNPUT.Data.Keyboard.Vk = (ushort)keyCode;
		iNPUT.Data.Keyboard.Scan = 0;
		iNPUT.Data.Keyboard.Flags = 0u;
		iNPUT.Data.Keyboard.Time = 0u;
		iNPUT.Data.Keyboard.ExtraInfo = IntPtr.Zero;
		if (SendInput(1u, new INPUT[1] { iNPUT }, Marshal.SizeOf(typeof(INPUT))) == 0)
		{
			throw new Exception();
		}
	}

	public static void SendKeyUp(KeyCode keyCode)
	{
		INPUT iNPUT = new INPUT
		{
			Type = 1u
		};
		iNPUT.Data.Keyboard = default(KEYBDINPUT);
		iNPUT.Data.Keyboard.Vk = (ushort)keyCode;
		iNPUT.Data.Keyboard.Scan = 0;
		iNPUT.Data.Keyboard.Flags = 2u;
		iNPUT.Data.Keyboard.Time = 0u;
		iNPUT.Data.Keyboard.ExtraInfo = IntPtr.Zero;
		if (SendInput(1u, new INPUT[1] { iNPUT }, Marshal.SizeOf(typeof(INPUT))) == 0)
		{
			throw new Exception();
		}
	}

	public static void MouseClick(int x, int y, EMouseKey mouseKey = EMouseKey.LEFT)
	{
		Cursor.Position = new Point(x, y);
		Click(mouseKey);
	}

	public static void MouseDragX(Point startPoint, int deltaX, bool isNegative = false)
	{
		Cursor.Position = startPoint;
		mouse_event(2u, 0, 0, 0, UIntPtr.Zero);
		for (int i = 0; i < deltaX; i++)
		{
			if (!isNegative)
			{
				mouse_event(1u, 1, 0, 0, UIntPtr.Zero);
			}
			else
			{
				mouse_event(1u, -1, 0, 0, UIntPtr.Zero);
			}
		}
		mouse_event(32772u, 0, 0, 0, UIntPtr.Zero);
	}

	public static void MouseDragY(Point startPoint, int deltaY, bool isNegative = false)
	{
		Cursor.Position = startPoint;
		mouse_event(2u, 0, 0, 0, UIntPtr.Zero);
		for (int i = 0; i < deltaY; i++)
		{
			if (!isNegative)
			{
				mouse_event(1u, 0, 1, 0, UIntPtr.Zero);
			}
			else
			{
				mouse_event(1u, 0, -1, 0, UIntPtr.Zero);
			}
		}
		mouse_event(32772u, 0, 0, 0, UIntPtr.Zero);
	}

	public static void MouseScroll(Point startPoint, int deltaY, bool isNegative = false)
	{
		Cursor.Position = startPoint;
		mouse_event(2048u, 0, 0, deltaY, UIntPtr.Zero);
	}

	public static void MouseClick(Point point, EMouseKey mouseKey = EMouseKey.LEFT)
	{
		Cursor.Position = point;
		Click(mouseKey);
	}

	public static void Click(EMouseKey mouseKey = EMouseKey.LEFT)
	{
		switch (mouseKey)
		{
		case EMouseKey.LEFT:
			mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
			break;
		case EMouseKey.RIGHT:
			mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
			break;
		case EMouseKey.DOUBLE_LEFT:
			mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
			mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
			break;
		case EMouseKey.DOUBLE_RIGHT:
			mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
			mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
			break;
		}
	}

	public static RECT GetWindowRect(IntPtr hWnd)
	{
		RECT lpRect = default(RECT);
		GetWindowRect(hWnd, ref lpRect);
		return lpRect;
	}

	public static Point GetGlobalPoint(IntPtr hWnd, Point? point = null)
	{
		Point result = default(Point);
		RECT windowRect = GetWindowRect(hWnd);
		if (!point.HasValue)
		{
			point = default(Point);
		}
		result.X = point.Value.X + windowRect.Left;
		result.Y = point.Value.Y + windowRect.Top;
		return result;
	}

	public static Point GetGlobalPoint(IntPtr hWnd, int x = 0, int y = 0)
	{
		Point result = default(Point);
		RECT windowRect = GetWindowRect(hWnd);
		result.X = x + windowRect.Left;
		result.Y = y + windowRect.Top;
		return result;
	}

	public static string GetText(IntPtr hWnd)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		GetWindowText(hWnd, stringBuilder, 256);
		return stringBuilder.ToString().Trim();
	}

	public static string GetClassName(IntPtr hWnd)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		GetClassName(hWnd, stringBuilder, 256);
		return stringBuilder.ToString().Trim();
	}

	public static IntPtr MakeLParam(int LoWord, int HiWord)
	{
		return (IntPtr)((HiWord << 16) | (LoWord & 0xFFFF));
	}

	public static IntPtr MakeLParamFromXY(int x, int y)
	{
		return (IntPtr)((y << 16) | x);
	}
}
