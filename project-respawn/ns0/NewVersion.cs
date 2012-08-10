using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace ns0
{
	public sealed class NewVersion : Form
	{
		private IContainer icontainer_0;
		private Button button1;
		private GroupBox groupBox1;
		private Label label1;
		private LinkLabel linkLabel1;
		public NewVersion(string string_0)
		{
			this.InitializeComponent();
			this.linkLabel1.Text = string_0;
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
			this.button1 = new Button();
			this.groupBox1 = new GroupBox();
			this.linkLabel1 = new LinkLabel();
			this.label1 = new Label();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.button1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button1.DialogResult = DialogResult.OK;
			this.button1.Location = new Point(365, 155);
			this.button1.Name = "button1";
			this.button1.Size = new Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.groupBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBox1.BackColor = Color.Transparent;
			this.groupBox1.Controls.Add(this.linkLabel1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new Padding(8);
			this.groupBox1.Size = new Size(428, 137);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Update";
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new Point(11, 98);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new Size(55, 13);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "linkLabel1";
			this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.label1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.label1.Font = new Font("Lucida Console", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.Location = new Point(11, 21);
			this.label1.Name = "label1";
			this.label1.Size = new Size(389, 57);
			this.label1.TabIndex = 0;
			this.label1.Text = "An update for the launcher is available.\r\nYou always need the latest version of the launcher.\r\n\r\n\r\nDownload the newest version from here:";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackgroundImage = Class9.gradient_dim;
			this.BackgroundImageLayout = ImageLayout.Stretch;
			base.ClientSize = new Size(452, 190);
			base.ControlBox = false;
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "NewVersion";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Update";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(this.linkLabel1.Text);
		}
	}
}
