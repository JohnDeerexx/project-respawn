using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace ns0
{
	public sealed class AutoLogin : Form
	{
		private int int_0;
		private IContainer icontainer_0;
		private Label label1;
		private Label label2;
		private Button button1;
		private Timer timer_0;
		public AutoLogin(float float_0 = 1.5f)
		{
			this.InitializeComponent();
			this.int_0 = (int)((float)(1000 / this.timer_0.Interval) * float_0);
			this.timer_0.Start();
			this.timer_0_Tick(null, null);
		}
		private void timer_0_Tick(object sender, EventArgs e)
		{
			this.int_0--;
			this.label1.Text = "Automatic login: " + ((float)this.int_0 / 100f).ToString("0.00");
			if (this.int_0 <= 0)
			{
				base.DialogResult = DialogResult.OK;
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			this.label1 = new Label();
			this.label2 = new Label();
			this.button1 = new Button();
			this.timer_0 = new Timer(this.icontainer_0);
			base.SuspendLayout();
			this.label1.Location = new Point(13, 13);
			this.label1.Margin = new Padding(4);
			this.label1.Name = "label1";
			this.label1.Size = new Size(230, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Automatic login: ";
			this.label2.BorderStyle = BorderStyle.Fixed3D;
			this.label2.Location = new Point(12, 34);
			this.label2.Name = "label2";
			this.label2.Size = new Size(231, 2);
			this.label2.TabIndex = 1;
			this.button1.Location = new Point(13, 48);
			this.button1.Margin = new Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new Size(229, 41);
			this.button1.TabIndex = 2;
			this.button1.Text = "Cancel...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 10;
			this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(255, 102);
			base.ControlBox = false;
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AutoLogin";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Auto Login";
			base.TopMost = true;
			base.ResumeLayout(false);
		}
	}
}
