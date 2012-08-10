using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace ns0
{
	public sealed class LoginFailedDialog : Form
	{
		private IContainer icontainer_0;
		private Panel panel1;
		private Label label1;
		private TextBox textBox1;
		private Button button1;
		public LoginFailedDialog(string string_0)
		{
			this.InitializeComponent();
			this.textBox1.Text = string_0;
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
			this.panel1 = new Panel();
			this.textBox1 = new TextBox();
			this.button1 = new Button();
			this.label1 = new Label();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panel1.BackColor = Color.Transparent;
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new Padding(18, 18, 18, 8);
			this.panel1.Size = new Size(530, 311);
			this.panel1.TabIndex = 0;
			this.textBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.textBox1.BorderStyle = BorderStyle.FixedSingle;
			this.textBox1.Font = new Font("Consolas", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.textBox1.Location = new Point(21, 45);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new Size(488, 226);
			this.textBox1.TabIndex = 3;
			this.button1.Anchor = AnchorStyles.Bottom;
			this.button1.DialogResult = DialogResult.OK;
			this.button1.Location = new Point(228, 277);
			this.button1.Name = "button1";
			this.button1.Size = new Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.label1.AutoSize = true;
			this.label1.Location = new Point(21, 18);
			this.label1.Name = "label1";
			this.label1.Size = new Size(206, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Login failed, this is what the server replied:";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackgroundImage = Class9.gradient_dim;
			this.BackgroundImageLayout = ImageLayout.Stretch;
			base.ClientSize = new Size(554, 335);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "LoginFailedDialog";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Login Failed";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}
	}
}
