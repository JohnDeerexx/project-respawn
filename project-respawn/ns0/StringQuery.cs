using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace ns0
{
	public sealed class StringQuery : Form
	{
		public string string_0 = "";
		private IContainer icontainer_0;
		private Button button1;
		private Button button2;
		private Panel panel1;
		private TextBox ResultTextBox;
		private Label label1;
		public StringQuery(string string_1, string string_2)
		{
			this.InitializeComponent();
			this.Text = string_1;
			this.label1.Text = string_2;
		}
		private void ResultTextBox_TextChanged(object sender, EventArgs e)
		{
			this.string_0 = this.ResultTextBox.Text;
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
			this.button2 = new Button();
			this.panel1 = new Panel();
			this.label1 = new Label();
			this.ResultTextBox = new TextBox();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.button1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button1.DialogResult = DialogResult.OK;
			this.button1.Location = new Point(296, 102);
			this.button1.Name = "button1";
			this.button1.Size = new Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button2.DialogResult = DialogResult.Cancel;
			this.button2.Location = new Point(215, 102);
			this.button2.Name = "button2";
			this.button2.Size = new Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.panel1.BackColor = SystemColors.ButtonHighlight;
			this.panel1.Controls.Add(this.ResultTextBox);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = DockStyle.Top;
			this.panel1.Location = new Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(383, 86);
			this.panel1.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.Location = new Point(31, 24);
			this.label1.Name = "label1";
			this.label1.Size = new Size(63, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Description:";
			this.ResultTextBox.Location = new Point(34, 42);
			this.ResultTextBox.Name = "ResultTextBox";
			this.ResultTextBox.Size = new Size(318, 20);
			this.ResultTextBox.TabIndex = 1;
			this.ResultTextBox.TextChanged += new EventHandler(this.ResultTextBox_TextChanged);
			base.AcceptButton = this.button1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button2;
			base.ClientSize = new Size(383, 137);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "StringQuery";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "StringQuery";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}
	}
}
