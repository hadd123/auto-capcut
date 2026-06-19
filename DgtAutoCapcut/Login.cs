using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using DgtAutoCapcut.Properties;

namespace DgtAutoCapcut;

public class Login : Form
{
	public class Config
	{
		public string UserName { get; set; }

		public string Password { get; set; }
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAntiDebug_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				if (num != 0)
				{
					goto IL_000a;
				}
				TaskAwaiter awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter);
				num = (_003C_003E1__state = -1);
				goto IL_007c;
				IL_007c:
				awaiter.GetResult();
				goto IL_000a;
				IL_000a:
				bool isDebuggerPresent = false;
				CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref isDebuggerPresent);
				if (isDebuggerPresent)
				{
					Environment.Exit(0);
				}
				awaiter = Task.Delay(500).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = (_003C_003E1__state = 0);
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_007c;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
			}
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	public static string configfilepath = ".\\dgt-ytd-chrome.xml";

	private Form1 frmMain = new Form1();

	private Config _cfg = new Config();

	private IContainer components;

	private Label label1;

	private TextBox txtTenDangNhap;

	private TextBox txtMatKhau;

	private Label label2;

	private Button btnDangNhap;

	private Button btnClose;

	private Label label3;

	private Button button1;

	public static DateTime ExpiredDate { get; set; }

	public static long Money { get; set; }

	public static string Extra { get; set; }

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

	[DllImport("DgtCore.dll", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.BStr)]
	private static extern string CheckAccount(string u, string p, string a);

	[DllImport("DgtCore.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int GetProfilePid(string Profile);

	public Login()
	{
		InitializeComponent();
		if (File.Exists("vtmedia.ico"))
		{
			Form1.BrandType = 1;
			base.Icon = Resources.vtmedia2;
			label3.Text = "Login - VT Media Capcut";
		}
	}

	[AsyncStateMachine(typeof(_003CAntiDebug_003Ed__19))]
	private void AntiDebug()
	{
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		Environment.Exit(0);
	}

	private void btnDangNhap_Click(object sender, EventArgs e)
	{
		Form1.username = "local";
		Form1.password = "";
		Form1.maxthread = long.MaxValue;
		ExpiredDate = DateTime.MaxValue;
		Money = long.MaxValue;
		Extra = "Edit,Render,TTS";
		Hide();
		frmMain.Show();
	}

	private void TxtMatKhau_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			btnDangNhap_Click(null, null);
		}
	}

	private void Login_Load(object sender, EventArgs e)
	{
		_cfg = LoadSetting();
		txtTenDangNhap.Text = _cfg.UserName;
		txtMatKhau.Text = Base64Decode(_cfg.Password);
	}

	public static string Base64Encode(string plainText)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
	}

	public static string Base64Decode(string base64EncodedData)
	{
		if (string.IsNullOrEmpty(base64EncodedData))
		{
			return "";
		}
		byte[] bytes = Convert.FromBase64String(base64EncodedData);
		return Encoding.UTF8.GetString(bytes);
	}

	public void SaveSetting()
	{
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(Config));
		StreamWriter streamWriter = new StreamWriter(configfilepath);
		xmlSerializer.Serialize(streamWriter, new Config
		{
			UserName = _cfg.UserName,
			Password = _cfg.Password
		});
		streamWriter.Close();
	}

	public Config LoadSetting()
	{
		if (File.Exists(configfilepath))
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(Config));
			FileStream fileStream = new FileStream(configfilepath, FileMode.Open);
			try
			{
				return (Config)xmlSerializer.Deserialize(fileStream);
			}
			catch
			{
			}
			finally
			{
				fileStream.Close();
			}
		}
		return new Config();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		string text = "";
		if (File.Exists("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe"))
		{
			text = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";
		}
		else if (File.Exists("C:\\Program Files\\Mozilla Firefox\\firefox.exe"))
		{
			text = "C:\\Program Files\\Mozilla Firefox\\firefox.exe";
		}
		if (!string.IsNullOrEmpty(text))
		{
			Process process = new Process();
			process.StartInfo.FileName = text;
			process.StartInfo.Arguments = "https://mmo.dgvant.com/Operations/Signup";
			process.Start();
		}
		else
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "https://mmo.dgvant.com/Operations/Signup",
				UseShellExecute = true
			});
		}
	}

	private void Login_Shown(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DgtAutoCapcut.Login));
		this.label1 = new System.Windows.Forms.Label();
		this.txtTenDangNhap = new System.Windows.Forms.TextBox();
		this.txtMatKhau = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.btnDangNhap = new System.Windows.Forms.Button();
		this.btnClose = new System.Windows.Forms.Button();
		this.label3 = new System.Windows.Forms.Label();
		this.button1 = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.BackColor = System.Drawing.Color.Transparent;
		this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
		this.label1.Location = new System.Drawing.Point(181, 94);
		this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(60, 18);
		this.label1.TabIndex = 0;
		this.label1.Text = "Email:";
		this.txtTenDangNhap.Location = new System.Drawing.Point(247, 91);
		this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
		this.txtTenDangNhap.Name = "txtTenDangNhap";
		this.txtTenDangNhap.Size = new System.Drawing.Size(220, 27);
		this.txtTenDangNhap.TabIndex = 1;
		this.txtMatKhau.Location = new System.Drawing.Point(247, 126);
		this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
		this.txtMatKhau.Name = "txtMatKhau";
		this.txtMatKhau.PasswordChar = '*';
		this.txtMatKhau.Size = new System.Drawing.Size(220, 27);
		this.txtMatKhau.TabIndex = 3;
		this.txtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(TxtMatKhau_KeyDown);
		this.label2.AutoSize = true;
		this.label2.BackColor = System.Drawing.Color.Transparent;
		this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
		this.label2.Location = new System.Drawing.Point(149, 129);
		this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(92, 18);
		this.label2.TabIndex = 2;
		this.label2.Text = "Password:";
		this.btnDangNhap.BackColor = System.Drawing.Color.RoyalBlue;
		this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDangNhap.Font = new System.Drawing.Font("Verdana", 12f, System.Drawing.FontStyle.Bold);
		this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.btnDangNhap.Location = new System.Drawing.Point(361, 169);
		this.btnDangNhap.Name = "btnDangNhap";
		this.btnDangNhap.Size = new System.Drawing.Size(106, 36);
		this.btnDangNhap.TabIndex = 4;
		this.btnDangNhap.Text = "Login";
		this.btnDangNhap.UseVisualStyleBackColor = false;
		this.btnDangNhap.Click += new System.EventHandler(btnDangNhap_Click);
		this.btnClose.BackColor = System.Drawing.Color.Red;
		this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnClose.Location = new System.Drawing.Point(584, 3);
		this.btnClose.Name = "btnClose";
		this.btnClose.Size = new System.Drawing.Size(24, 25);
		this.btnClose.TabIndex = 5;
		this.btnClose.Text = "X";
		this.btnClose.UseVisualStyleBackColor = false;
		this.btnClose.Click += new System.EventHandler(btnClose_Click);
		this.label3.BackColor = System.Drawing.Color.Transparent;
		this.label3.Font = new System.Drawing.Font("Verdana", 18f, System.Drawing.FontStyle.Bold);
		this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
		this.label3.Location = new System.Drawing.Point(100, 34);
		this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(437, 29);
		this.label3.TabIndex = 6;
		this.label3.Text = "Login - Auto Capcut";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Font = new System.Drawing.Font("Verdana", 12f, System.Drawing.FontStyle.Bold);
		this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
		this.button1.Location = new System.Drawing.Point(247, 169);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(106, 36);
		this.button1.TabIndex = 7;
		this.button1.Text = "Register";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Visible = false;
		this.button1.Click += new System.EventHandler(button1_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(10f, 18f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.DimGray;
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		base.ClientSize = new System.Drawing.Size(614, 238);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.btnClose);
		base.Controls.Add(this.btnDangNhap);
		base.Controls.Add(this.txtMatKhau);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.txtTenDangNhap);
		base.Controls.Add(this.label1);
		this.Font = new System.Drawing.Font("Verdana", 12f);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "Login";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Login";
		base.Load += new System.EventHandler(Login_Load);
		base.Shown += new System.EventHandler(Login_Shown);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
