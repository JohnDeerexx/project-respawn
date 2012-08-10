using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace ns0
{
	public sealed class BetaWarning : Form
	{
		private int int_0 = 6;
		private IContainer icontainer_0;
		private Panel panel1;
		private Panel panel2;
		private Button button1;
		private Panel panel4;
		private Panel panel3;
		private Timer timer_0;
		private LinkLabel linkLabel2;
		private LinkLabel linkLabel1;
		private TableLayoutPanel tableLayoutPanel1;
		private Label label2;
		private Label label3;
		public BetaWarning()
		{
			this.InitializeComponent();
			this.timer_0_Tick(null, null);
		}
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://project-respawn/forum/.com");
		}
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
            Process.Start("http://project-respawn/");
		}
		private void timer_0_Tick(object sender, EventArgs e)
		{
			this.int_0--;
			this.button1.Text = "OK";
			if (this.int_0 <= 0)
			{
				this.timer_0.Stop();
				base.Close();
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}
		private void button1_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				base.Close();
			}
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(BetaWarning));
			this.panel1 = new Panel();
			this.panel2 = new Panel();
			this.label2 = new Label();
			this.tableLayoutPanel1 = new TableLayoutPanel();
			this.label3 = new Label();
			this.linkLabel2 = new LinkLabel();
			this.linkLabel1 = new LinkLabel();
			this.panel4 = new Panel();
			this.panel3 = new Panel();
			this.button1 = new Button();
			this.timer_0 = new Timer(this.icontainer_0);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panel1.BorderStyle = BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(642, 284);
			this.panel1.TabIndex = 0;
			this.panel2.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panel2.BackColor = SystemColors.ButtonFace;
			this.panel2.BackgroundImage = Class9.gradient_dim;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.BorderStyle = BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.tableLayoutPanel1);
			this.panel2.Controls.Add(this.linkLabel2);
			this.panel2.Controls.Add(this.linkLabel1);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Location = new Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new Padding(8, 12, 8, 8);
			this.panel2.Size = new Size(634, 276);
			this.panel2.TabIndex = 0;
			this.label2.Anchor = AnchorStyles.Bottom;
			this.label2.BackColor = Color.Transparent;
			this.label2.Font = new Font("Lucida Console", 6.75f, FontStyle.Italic, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.DarkGray;
			this.label2.Location = new Point(73, 236);
			this.label2.Margin = new Padding(6, 6, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new Size(487, 27);
			this.label2.TabIndex = 0;
			this.label2.Text = componentResourceManager.GetString("label2.Text");
			this.label2.TextAlign = ContentAlignment.TopCenter;
			this.tableLayoutPanel1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.tableLayoutPanel1.BackColor = Color.Transparent;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel1.Location = new Point(11, 15);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.Size = new Size(610, 93);
			this.tableLayoutPanel1.TabIndex = 8;
			this.label3.Dock = DockStyle.Fill;
			this.label3.Font = new Font("Lucida Console", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.FromArgb(64, 64, 64);
			this.label3.Location = new Point(8, 8);
			this.label3.Margin = new Padding(8);
			this.label3.Name = "label3";
			this.label3.Size = new Size(594, 77);
			this.label3.TabIndex = 1;
			this.label3.Text = "When using this program you argree to the TOS on www.project-respawn.com/tos/\r\nThis dialog will auto-close in 6 seconds.";
			this.label3.TextAlign = ContentAlignment.MiddleCenter;
			this.linkLabel2.Anchor = AnchorStyles.Bottom;
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.BackColor = Color.FromArgb(245, 240, 233);
			this.linkLabel2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.linkLabel2.Location = new Point(331, 134);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new Size(147, 20);
			this.linkLabel2.TabIndex = 7;
			this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "project-respawn.com";
			this.linkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			this.linkLabel1.Anchor = AnchorStyles.Bottom;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = Color.FromArgb(245, 240, 233);
			this.linkLabel1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.linkLabel1.Location = new Point(154, 134);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new Size(155, 20);
			this.linkLabel1.TabIndex = 6;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "project-respawn.com/forum/";
			this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.panel4.Anchor = AnchorStyles.Bottom;
			this.panel4.BackColor = Color.White;
			this.panel4.BorderStyle = BorderStyle.FixedSingle;
			this.panel4.Location = new Point(73, 222);
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size(487, 3);
			this.panel4.TabIndex = 5;
			this.panel3.Anchor = AnchorStyles.Bottom;
			this.panel3.BackColor = Color.White;
			this.panel3.BorderStyle = BorderStyle.FixedSingle;
			this.panel3.Location = new Point(13, 114);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(607, 3);
			this.panel3.TabIndex = 4;
			this.button1.Anchor = AnchorStyles.Bottom;
			this.button1.Font = new Font("Lucida Console", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button1.Location = new Point(232, 166);
			this.button1.Name = "button1";
			this.button1.Size = new Size(178, 39);
			this.button1.TabIndex = 0;
			this.button1.Text = "Wait...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.button1.MouseUp += new MouseEventHandler(this.button1_MouseUp);
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 1000;
			this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
			base.AcceptButton = this.button1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackgroundImage = Class9.gradient_orange;
			this.BackgroundImageLayout = ImageLayout.Stretch;
			base.ClientSize = new Size(666, 308);
			base.ControlBox = false;
			base.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "BetaWarning";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Disclaimer";
			base.TopMost = true;
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}
	}
}
