using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DgtAutoCapcut;

public class AutoShutdown : Form
{
	private int timeoff = 15;

	private IContainer components;

	private Label lblInfo;

	private Timer timer1;

	public AutoShutdown()
	{
		InitializeComponent();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		timeoff--;
		lblInfo.Text = $"Máy tính sẽ tự động tắt sau {timeoff}s nữa";
		if (timeoff <= 0)
		{
			try
			{
				Process.Start(new ProcessStartInfo
				{
					FileName = "shutdown",
					Arguments = "/s /f /t 0",
					CreateNoWindow = true,
					UseShellExecute = false
				});
			}
			catch (Exception)
			{
			}
		}
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
		this.components = new System.ComponentModel.Container();
		this.lblInfo = new System.Windows.Forms.Label();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		base.SuspendLayout();
		this.lblInfo.Font = new System.Drawing.Font("Verdana", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		this.lblInfo.ForeColor = System.Drawing.Color.Red;
		this.lblInfo.Location = new System.Drawing.Point(13, 30);
		this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		this.lblInfo.Name = "lblInfo";
		this.lblInfo.Size = new System.Drawing.Size(395, 27);
		this.lblInfo.TabIndex = 0;
		this.lblInfo.Text = "Máy tính sẽ tự động tắt sau 15s nữa";
		this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.timer1.Enabled = true;
		this.timer1.Interval = 1000;
		this.timer1.Tick += new System.EventHandler(timer1_Tick);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Yellow;
		base.ClientSize = new System.Drawing.Size(421, 80);
		base.Controls.Add(this.lblInfo);
		this.Font = new System.Drawing.Font("Verdana", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
		base.Name = "AutoShutdown";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "AutoShutdown";
		base.TopMost = true;
		base.ResumeLayout(false);
	}
}
