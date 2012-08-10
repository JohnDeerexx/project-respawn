using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace ns1
{
	public class SelectEventScript : Form
	{
		private IContainer icontainer_0 = null;
		private Button button1;
		private Button cancelBtn;
		private Label label1;
		internal ComboBox comboBox1;
		public SelectEventScript()
		{
			this.InitializeComponent();
			this.comboBox1.SelectedIndex = 0;
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
			this.cancelBtn = new Button();
			this.label1 = new Label();
			this.comboBox1 = new ComboBox();
			base.SuspendLayout();
			this.button1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button1.DialogResult = DialogResult.OK;
			this.button1.Location = new Point(332, 81);
			this.button1.Name = "button1";
			this.button1.Size = new Size(75, 25);
			this.button1.TabIndex = 1;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.cancelBtn.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.cancelBtn.DialogResult = DialogResult.Cancel;
			this.cancelBtn.Location = new Point(251, 81);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new Size(75, 25);
			this.cancelBtn.TabIndex = 2;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.label1.AutoSize = true;
			this.label1.Location = new Point(12, 36);
			this.label1.Name = "label1";
			this.label1.Size = new Size(53, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Available:";
			this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[]
			{
				"CRYPT_CORRECT"
			});
			this.comboBox1.Location = new Point(71, 33);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new Size(336, 21);
			this.comboBox1.TabIndex = 4;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(419, 118);
			base.Controls.Add(this.comboBox1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.cancelBtn);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SelectEventScript";
			base.ShowInTaskbar = false;
			this.Text = "Hardcoded Script";
			base.TopMost = true;
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
