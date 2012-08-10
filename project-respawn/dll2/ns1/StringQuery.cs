using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace ns1
{
	public class StringQuery : Form
	{
		private IContainer icontainer_0 = null;
		private TextBox textBox1;
		private Panel panel1;
		private Button button2;
		private Button button1;
		private Label DescriptionString;
		[CompilerGenerated]
		private string string_0;
		public string ResultString
		{
			get;
			private set;
		}
		public StringQuery(string string_1, string string_2)
		{
			this.InitializeComponent();
			this.Text = string_1;
			this.DescriptionString.Text = string_2;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			this.ResultString = this.textBox1.Text;
			base.DialogResult = DialogResult.OK;
		}
		private void StringQuery_Shown(object sender, EventArgs e)
		{
			base.Activate();
			this.textBox1.Focus();
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(StringQuery));
			this.DescriptionString = new Label();
			this.textBox1 = new TextBox();
			this.panel1 = new Panel();
			this.button2 = new Button();
			this.button1 = new Button();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.DescriptionString.AutoSize = true;
			this.DescriptionString.Location = new Point(23, 29);
			this.DescriptionString.Name = "DescriptionString";
			this.DescriptionString.Size = new Size(0, 13);
			this.DescriptionString.TabIndex = 0;
			this.textBox1.Location = new Point(26, 45);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Size(392, 20);
			this.textBox1.TabIndex = 1;
			this.panel1.BackColor = SystemColors.Control;
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = DockStyle.Bottom;
			this.panel1.Location = new Point(0, 84);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(442, 53);
			this.panel1.TabIndex = 0;
			this.button2.DialogResult = DialogResult.Cancel;
			this.button2.Location = new Point(262, 15);
			this.button2.Name = "button2";
			this.button2.Size = new Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button1.Location = new Point(343, 15);
			this.button1.Name = "button1";
			this.button1.Size = new Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			base.AcceptButton = this.button1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.ButtonHighlight;
			base.CancelButton = this.button2;
			base.ClientSize = new Size(442, 137);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.DescriptionString);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "StringQuery";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			base.Shown += new EventHandler(this.StringQuery_Shown);
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
