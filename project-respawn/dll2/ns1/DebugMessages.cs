using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace ns1
{
	public class DebugMessages : Form
	{
		[CompilerGenerated]
		private sealed class Class128
		{
			public DebugMessages debugMessages_0;
			public string string_0;
			public void method_0()
			{
				this.debugMessages_0.listBox1.BeginUpdate();
				while (this.debugMessages_0.list_0.Count > this.debugMessages_0.int_0)
				{
					this.debugMessages_0.list_0.RemoveAt(0);
				}
				while (this.debugMessages_0.listBox1.Items.Count > this.debugMessages_0.int_0)
				{
					this.debugMessages_0.listBox1.Items.RemoveAt(0);
				}
				Class60.Class59 @class = new Class60.Class59(this.string_0, true);
				this.debugMessages_0.list_0.Add(@class);
				this.debugMessages_0.listBox1.smethod_2(@class.ToString());
				this.debugMessages_0.listBox1.EndUpdate();
			}
		}
		[CompilerGenerated]
		private sealed class Class127
		{
			public DebugMessages debugMessages_0;
			public string string_0;
			public void method_0()
			{
				this.debugMessages_0.listBox1.BeginUpdate();
				while (this.debugMessages_0.list_0.Count > this.debugMessages_0.int_0)
				{
					this.debugMessages_0.list_0.RemoveAt(0);
				}
				while (this.debugMessages_0.listBox1.Items.Count > this.debugMessages_0.int_0)
				{
					this.debugMessages_0.listBox1.Items.RemoveAt(0);
				}
				Class60.Class59 @class = new Class60.Class59(this.string_0, false);
				this.debugMessages_0.list_0.Add(@class);
				this.debugMessages_0.listBox1.smethod_2(@class.ToString());
				this.debugMessages_0.listBox1.EndUpdate();
			}
		}
		private IContainer icontainer_0 = null;
		private ListBox listBox1;
		private List<Class60.Class59> list_0;
		private int int_0 = 50;
		public DebugMessages()
		{
			this.InitializeComponent();
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
			this.listBox1 = new ListBox();
			base.SuspendLayout();
			this.listBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.listBox1.DrawMode = DrawMode.OwnerDrawVariable;
			this.listBox1.Font = new Font("Consolas", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.IntegralHeight = false;
			this.listBox1.Location = new Point(12, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new Size(523, 222);
			this.listBox1.TabIndex = 0;
			this.listBox1.DrawItem += new DrawItemEventHandler(this.listBox1_DrawItem);
			this.listBox1.MeasureItem += new MeasureItemEventHandler(this.listBox1_MeasureItem);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(547, 246);
			base.Controls.Add(this.listBox1);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "DebugMessages";
			this.Text = "Debug Messages & Error Log";
			base.FormClosed += new FormClosedEventHandler(this.DebugMessages_FormClosed);
			base.Shown += new EventHandler(this.DebugMessages_Shown);
			base.ResumeLayout(false);
		}
		private void method_0(string string_0)
		{
			DebugMessages.Class128 @class = new DebugMessages.Class128();
			@class.string_0 = string_0;
			@class.debugMessages_0 = this;
			base.BeginInvoke(new MethodInvoker(@class.method_0));
		}
		private void method_1(string string_0)
		{
			DebugMessages.Class127 @class = new DebugMessages.Class127();
			@class.string_0 = string_0;
			@class.debugMessages_0 = this;
			base.BeginInvoke(new MethodInvoker(@class.method_0));
		}
		private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
		{
			e.DrawBackground();
			if (e.Index >= 0 && e.Index < this.list_0.Count)
			{
				if (e.State == DrawItemState.Selected)
				{
					e.Graphics.FillRectangle(SystemBrushes.HotTrack, e.Bounds);
				}
				else
				{
					if (this.list_0[e.Index].IsError)
					{
						e.Graphics.FillRectangle(new SolidBrush(Class83.smethod_0()), e.Bounds);
					}
					else
					{
						e.Graphics.FillRectangle(new SolidBrush(Class82.smethod_3()), e.Bounds);
					}
				}
				string s = this.list_0[e.Index].ToString();
				Brush brush = new SolidBrush(Color.Black);
				e.Graphics.DrawString(s, e.Font, brush, e.Bounds);
			}
		}
		private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
		{
			Size size = TextRenderer.MeasureText(this.listBox1.Items[e.Index].ToString(), this.listBox1.Font);
			e.ItemHeight = size.Height;
			e.ItemWidth = size.Width;
		}
		private void DebugMessages_FormClosed(object sender, FormClosedEventArgs e)
		{
			GClass0.smethod_0().method_1(new Action<string>(this.method_0));
			GClass0.smethod_0().method_3(new Action<string>(this.method_1));
		}
		private void DebugMessages_Shown(object sender, EventArgs e)
		{
			this.list_0 = new List<Class60.Class59>();
			this.list_0.AddRange(GClass0.smethod_0().class60_0.method_3());
			GClass0.smethod_0().method_0(new Action<string>(this.method_0));
			GClass0.smethod_0().method_2(new Action<string>(this.method_1));
			while (this.list_0.Count > this.int_0)
			{
				this.list_0.RemoveAt(0);
			}
			this.listBox1.BeginUpdate();
			foreach (Class60.Class59 current in this.list_0)
			{
				this.listBox1.smethod_3(current.ToString(), 60);
			}
			this.listBox1.EndUpdate();
		}
	}
}
