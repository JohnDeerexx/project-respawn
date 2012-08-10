using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace ns1
{
	internal static class Class64
	{
		[CompilerGenerated]
		private sealed class Class66
		{
			public Control control_0;
			public string string_0;
			public void method_0()
			{
				this.control_0.Text = this.string_0;
			}
		}
		[CompilerGenerated]
		private sealed class Class63
		{
			public ListBox listBox_0;
			public string string_0;
			public void method_0()
			{
				this.listBox_0.Items.Add(this.string_0);
				this.listBox_0.TopIndex = this.listBox_0.Items.Count - 1;
			}
		}
		[CompilerGenerated]
		private sealed class Class65
		{
			public ListBox listBox_0;
			public string string_0;
			public int int_0;
			public void method_0()
			{
				while (this.listBox_0.Items.Count >= this.int_0)
				{
					this.listBox_0.Items.RemoveAt(0);
				}
				this.listBox_0.Items.Add(this.string_0);
				this.listBox_0.TopIndex = this.listBox_0.Items.Count - 1;
			}
		}
		internal static void smethod_0(this Control control_0, string string_0)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(control_0, string_0);
		}
		internal static void smethod_1(this Control control_0, string string_0)
		{
			Class64.Class66 @class = new Class64.Class66();
			@class.control_0 = control_0;
			@class.string_0 = string_0;
			if (@class.control_0.InvokeRequired)
			{
				@class.control_0.BeginInvoke(new MethodInvoker(@class.method_0));
			}
			else
			{
				@class.control_0.Text = @class.string_0;
			}
		}
		internal static void smethod_2(this ListBox listBox_0, string string_0)
		{
			Class64.Class63 @class = new Class64.Class63();
			@class.listBox_0 = listBox_0;
			@class.string_0 = string_0;
			if (@class.listBox_0.InvokeRequired)
			{
				@class.listBox_0.BeginInvoke(new MethodInvoker(@class.method_0));
			}
			else
			{
				@class.listBox_0.Items.Add(@class.string_0);
				@class.listBox_0.TopIndex = @class.listBox_0.Items.Count - 1;
			}
		}
		internal static void smethod_3(this ListBox listBox_0, string string_0, int int_0)
		{
			MethodInvoker methodInvoker = null;
			Class64.Class65 @class = new Class64.Class65();
			@class.listBox_0 = listBox_0;
			@class.string_0 = string_0;
			@class.int_0 = int_0;
			if (@class.int_0 <= 0 || @class.int_0 > 10000)
			{
				@class.int_0 = 10000;
			}
			if (@class.listBox_0.InvokeRequired)
			{
				Control arg_6D_0 = @class.listBox_0;
				if (methodInvoker == null)
				{
					methodInvoker = new MethodInvoker(@class.method_0);
				}
				arg_6D_0.BeginInvoke(methodInvoker);
			}
			else
			{
				while (@class.listBox_0.Items.Count >= @class.int_0)
				{
					@class.listBox_0.Items.RemoveAt(0);
				}
				@class.listBox_0.Items.Add(@class.string_0);
				@class.listBox_0.TopIndex = @class.listBox_0.Items.Count - 1;
			}
		}
	}
}
