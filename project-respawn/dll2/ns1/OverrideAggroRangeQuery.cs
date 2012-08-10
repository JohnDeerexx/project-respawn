using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace ns1
{
	public class OverrideAggroRangeQuery : Form
	{
		private IContainer icontainer_0 = null;
		private Button button1;
		private Button button2;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private GroupBox groupBox1;
		internal NumericUpDown newRange;
		internal NumericUpDown time;
		internal CheckBox doAutoReset;
		private Label label6;
		public OverrideAggroRangeQuery()
		{
			this.InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.newRange.Value <= 1m)
			{
				DialogResult dialogResult = MessageBox.Show("The new range is really small.\r\n\r\nMobs will block you and you will die.\r\n\r\nDo you really want to do that???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (dialogResult != DialogResult.Yes)
				{
					return;
				}
			}
			base.DialogResult = DialogResult.OK;
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
			this.label1 = new Label();
			this.newRange = new NumericUpDown();
			this.label2 = new Label();
			this.time = new NumericUpDown();
			this.label3 = new Label();
			this.label4 = new Label();
			this.doAutoReset = new CheckBox();
			this.label5 = new Label();
			this.groupBox1 = new GroupBox();
			this.label6 = new Label();
			((ISupportInitialize)this.newRange).BeginInit();
			((ISupportInitialize)this.time).BeginInit();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.button1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button1.Location = new Point(176, 263);
			this.button1.Name = "button1";
			this.button1.Size = new Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.button2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button2.DialogResult = DialogResult.Cancel;
			this.button2.Location = new Point(95, 263);
			this.button2.Name = "button2";
			this.button2.Size = new Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.label1.AutoSize = true;
			this.label1.Location = new Point(17, 29);
			this.label1.Name = "label1";
			this.label1.Size = new Size(67, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "New Range:";
			NumericUpDown arg_228_0 = this.newRange;
			int[] array = new int[4];
			array[0] = 5;
			arg_228_0.Increment = new decimal(array);
			this.newRange.Location = new Point(20, 47);
			this.newRange.Name = "newRange";
			this.newRange.Size = new Size(120, 20);
			this.newRange.TabIndex = 3;
			this.label2.AutoSize = true;
			this.label2.Location = new Point(17, 103);
			this.label2.Name = "label2";
			this.label2.Size = new Size(177, 26);
			this.label2.TabIndex = 4;
			this.label2.Text = "Maximum Time\r\n(time until this command auto-resets)";
			this.time.Location = new Point(20, 134);
			NumericUpDown arg_306_0 = this.time;
			array = new int[4];
			array[0] = 9999;
			arg_306_0.Maximum = new decimal(array);
			this.time.Name = "time";
			this.time.Size = new Size(120, 20);
			this.time.TabIndex = 5;
			this.label3.AutoSize = true;
			this.label3.Location = new Point(146, 138);
			this.label3.Name = "label3";
			this.label3.Size = new Size(47, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "seconds";
			this.label4.AutoSize = true;
			this.label4.Location = new Point(146, 51);
			this.label4.Name = "label4";
			this.label4.Size = new Size(29, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "units";
			this.doAutoReset.AutoSize = true;
			this.doAutoReset.Location = new Point(20, 171);
			this.doAutoReset.Name = "doAutoReset";
			this.doAutoReset.Size = new Size(79, 17);
			this.doAutoReset.TabIndex = 8;
			this.doAutoReset.Text = "Auto Reset";
			this.doAutoReset.UseVisualStyleBackColor = true;
			this.label5.Location = new Point(17, 191);
			this.label5.Name = "label5";
			this.label5.Size = new Size(202, 44);
			this.label5.TabIndex = 9;
			this.label5.Text = "Reset on world change, will reset the range to its original value when the \"world\" changes. (ignores time)";
			this.groupBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.newRange);
			this.groupBox1.Controls.Add(this.doAutoReset);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.time);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(237, 245);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Settings";
			this.label6.AutoSize = true;
			this.label6.Location = new Point(17, 70);
			this.label6.Name = "label6";
			this.label6.Size = new Size(126, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Default aggro range is 40";
			base.AcceptButton = this.button1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button2;
			base.ClientSize = new Size(263, 298);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "OverrideAggroRangeQuery";
			this.Text = "Override Aggro Range";
			((ISupportInitialize)this.newRange).EndInit();
			((ISupportInitialize)this.time).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}
	}
}
