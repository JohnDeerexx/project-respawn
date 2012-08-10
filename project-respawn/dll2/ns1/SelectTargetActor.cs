using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace ns1
{
	public class SelectTargetActor : Form
	{
		private IContainer icontainer_0 = null;
		private Button button1;
		private Button button2;
		private TextBox textBox1;
		private Label label1;
		private CheckBox ignoreErrorsBox;
		private CheckBox exactMatchBox;
		private CheckBox CheckBox_SkipBeginAwait;
		private Label label2;
		[CompilerGenerated]
		private string string_0;
		[CompilerGenerated]
		private bool bool_0;
		[CompilerGenerated]
		private bool bool_1;
		[CompilerGenerated]
		private bool bool_2;
		public string DialogResultString
		{
			get;
			private set;
		}
		public bool DialogResultMustBeExactMatch
		{
			get;
			private set;
		}
		public bool DialogResultIgnoreErrors
		{
			get;
			private set;
		}
		public bool DialogResultSkipBeginAwait
		{
			get;
			private set;
		}
		public SelectTargetActor()
		{
			this.InitializeComponent();
			this.DialogResultString = "";
			this.DialogResultIgnoreErrors = true;
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
			this.ignoreErrorsBox = new CheckBox();
			this.exactMatchBox = new CheckBox();
			this.textBox1 = new TextBox();
			this.label1 = new Label();
			this.button1 = new Button();
			this.button2 = new Button();
			this.CheckBox_SkipBeginAwait = new CheckBox();
			this.label2 = new Label();
			base.SuspendLayout();
			this.ignoreErrorsBox.AutoSize = true;
			this.ignoreErrorsBox.Checked = true;
			this.ignoreErrorsBox.CheckState = CheckState.Checked;
			this.ignoreErrorsBox.Location = new Point(88, 117);
			this.ignoreErrorsBox.Name = "ignoreErrorsBox";
			this.ignoreErrorsBox.Size = new Size(193, 17);
			this.ignoreErrorsBox.TabIndex = 4;
			this.ignoreErrorsBox.Text = "Don't abort quest if unit is not found";
			this.ignoreErrorsBox.UseVisualStyleBackColor = true;
			this.exactMatchBox.AutoSize = true;
			this.exactMatchBox.Location = new Point(88, 38);
			this.exactMatchBox.Name = "exactMatchBox";
			this.exactMatchBox.Size = new Size(174, 17);
			this.exactMatchBox.TabIndex = 2;
			this.exactMatchBox.Text = "Unit name must match perfectly";
			this.exactMatchBox.UseVisualStyleBackColor = true;
			this.textBox1.Location = new Point(88, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Size(331, 20);
			this.textBox1.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Location = new Point(24, 15);
			this.label1.Name = "label1";
			this.label1.Size = new Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Unit name:";
			this.button1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button1.DialogResult = DialogResult.OK;
			this.button1.Location = new Point(344, 178);
			this.button1.Name = "button1";
			this.button1.Size = new Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button2.DialogResult = DialogResult.Abort;
			this.button2.Location = new Point(263, 178);
			this.button2.Name = "button2";
			this.button2.Size = new Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Abort";
			this.button2.UseVisualStyleBackColor = true;
			this.CheckBox_SkipBeginAwait.AutoSize = true;
			this.CheckBox_SkipBeginAwait.Location = new Point(88, 140);
			this.CheckBox_SkipBeginAwait.Name = "CheckBox_SkipBeginAwait";
			this.CheckBox_SkipBeginAwait.Size = new Size(289, 17);
			this.CheckBox_SkipBeginAwait.TabIndex = 5;
			this.CheckBox_SkipBeginAwait.Text = "If unit cannot be found, skip enclosing BEGIN<>AWAIT";
			this.CheckBox_SkipBeginAwait.UseVisualStyleBackColor = true;
			this.CheckBox_SkipBeginAwait.CheckedChanged += new EventHandler(this.CheckBox_SkipBeginAwait_CheckedChanged);
			this.label2.Location = new Point(107, 58);
			this.label2.Name = "label2";
			this.label2.Size = new Size(294, 44);
			this.label2.TabIndex = 6;
			this.label2.Text = "Warning: Always strip the \"-xxx\"!\r\nIf the unit name you wish to interact with is (for example): \"Leah-456\", then you must enter: \"Leah\"";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(431, 213);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.CheckBox_SkipBeginAwait);
			base.Controls.Add(this.ignoreErrorsBox);
			base.Controls.Add(this.exactMatchBox);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SelectTargetActor";
			base.ShowInTaskbar = false;
			this.Text = "Interact with unit";
			base.TopMost = true;
			base.FormClosing += new FormClosingEventHandler(this.SelectTargetActor_FormClosing);
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		private void SelectTargetActor_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DialogResultString = this.textBox1.Text;
			this.DialogResultMustBeExactMatch = this.exactMatchBox.Checked;
			this.DialogResultIgnoreErrors = this.ignoreErrorsBox.Checked;
			this.DialogResultSkipBeginAwait = this.CheckBox_SkipBeginAwait.Checked;
		}
		private void CheckBox_SkipBeginAwait_CheckedChanged(object sender, EventArgs e)
		{
			if (this.CheckBox_SkipBeginAwait.Checked)
			{
				this.ignoreErrorsBox.Checked = true;
				this.ignoreErrorsBox.Enabled = false;
				this.DialogResultSkipBeginAwait = true;
			}
			else
			{
				this.ignoreErrorsBox.Enabled = true;
				this.ignoreErrorsBox.Checked = false;
				this.DialogResultSkipBeginAwait = false;
			}
		}
	}
}
