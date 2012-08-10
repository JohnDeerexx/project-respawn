using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace ns1
{
	public class CurrentSpells : Form
	{
		private IContainer icontainer_0 = null;
		internal TextBox OutputBox;
		public CurrentSpells()
		{
			this.InitializeComponent();
		}
		private void method_0(object sender, EventArgs e)
		{
			base.Close();
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
			this.OutputBox = new TextBox();
			base.SuspendLayout();
			this.OutputBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.OutputBox.BackColor = SystemColors.ButtonHighlight;
			this.OutputBox.Location = new Point(12, 12);
			this.OutputBox.Multiline = true;
			this.OutputBox.Name = "OutputBox";
			this.OutputBox.ReadOnly = true;
			this.OutputBox.Size = new Size(330, 285);
			this.OutputBox.TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(354, 309);
			base.Controls.Add(this.OutputBox);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "CurrentSpells";
			base.ShowIcon = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "CurrentSpells";
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
