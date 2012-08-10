using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Windows.Forms;
namespace ns0
{
	public sealed class ActivateKeyDialog : Form
	{
		private const int int_0 = 2798;
		private string string_0;
		private IContainer icontainer_0;
		private Panel panel1;
		private Label label2;
		private GroupBox groupBox1;
		private Label labelActivationStatus;
		private Button button1;
		private TextBox textBox1;
		public ActivateKeyDialog(string string_1)
		{
			this.string_0 = string_1;
			this.InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			this.button1.Enabled = false;
			try
			{
				TcpClient tcpClient = new TcpClient();
				this.labelActivationStatus.Text = "Connecting...";
				if (!tcpClient.smethod_7(this.string_0, 2798, 5000))
				{
					throw new Exception("Could not connect to server");
				}
				NetworkStream stream = tcpClient.GetStream();
				stream.smethod_3(this.textBox1.Text.Trim());
				int num = stream.smethod_4();
				stream.Close();
				if (num == 1)
				{
					MessageBox.Show("Key activation successful!\r\nYou can use that key to login now.", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
					base.Close();
					return;
				}
				this.labelActivationStatus.Text = "";
				MessageBox.Show("This key already active or invalid!!\r\n\r\nYou only have to activate the key once.\r\nThen you can login with it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{
				this.labelActivationStatus.Text = "Error: " + ex.Message;
			}
			this.button1.Enabled = true;
		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			this.button1.Enabled = (this.textBox1.Text.Length == 32);
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ActivateKeyDialog));
			this.panel1 = new Panel();
			this.groupBox1 = new GroupBox();
			this.labelActivationStatus = new Label();
			this.button1 = new Button();
			this.textBox1 = new TextBox();
			this.label2 = new Label();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.panel1.BorderStyle = BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new Padding(16);
			this.panel1.Size = new Size(466, 259);
			this.panel1.TabIndex = 0;
			this.groupBox1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBox1.Controls.Add(this.labelActivationStatus);
			this.groupBox1.Location = new Point(19, 158);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(426, 80);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Status";
			this.labelActivationStatus.Dock = DockStyle.Fill;
			this.labelActivationStatus.Location = new Point(3, 16);
			this.labelActivationStatus.Name = "labelActivationStatus";
			this.labelActivationStatus.Padding = new Padding(12, 4, 4, 4);
			this.labelActivationStatus.Size = new Size(420, 61);
			this.labelActivationStatus.TabIndex = 0;
			this.labelActivationStatus.TextAlign = ContentAlignment.MiddleLeft;
			this.button1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button1.Enabled = false;
			this.button1.Location = new Point(359, 126);
			this.button1.Name = "button1";
			this.button1.Size = new Size(89, 26);
			this.button1.TabIndex = 3;
			this.button1.Text = "Activate Key";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.textBox1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.textBox1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.textBox1.Location = new Point(19, 126);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Size(331, 26);
			this.textBox1.TabIndex = 2;
			this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
			this.label2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.label2.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.Location = new Point(19, 16);
			this.label2.Name = "label2";
			this.label2.Size = new Size(426, 107);
			this.label2.TabIndex = 1;
			this.label2.Text = componentResourceManager.GetString("label2.Text");
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackgroundImage = Class9.gradient_orange;
			this.BackgroundImageLayout = ImageLayout.Stretch;
			base.ClientSize = new Size(490, 283);
			base.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ActivateKeyDialog";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Activate a LicenceKey";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			base.ResumeLayout(false);
		}
	}
}
