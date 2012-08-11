using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace ns0
{
	public class NewVersion : Form
	{
        private PictureBox pictureBox1;
        private Label label1;
		
		public NewVersion(string string_0)
		{
			this.InitializeComponent();
			
		}

        public NewVersion()
        {
            // TODO: Complete member initialization
        }
		protected override void Dispose(bool disposing)
		{
			
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewVersion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 584);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(130, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "for free?...lulz\r\nyou will pay for it,bro :)";
            // 
            // NewVersion
            // 
            this.ClientSize = new System.Drawing.Size(501, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewVersion";
            this.Text = "What do you think?....";
            this.Load += new System.EventHandler(this.NewVersion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private void button1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

        private void NewVersion_Load(object sender, EventArgs e)
        {

        }
	}
}
