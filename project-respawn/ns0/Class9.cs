using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
namespace ns0
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
	internal sealed class Class9
	{
		private static ResourceManager resourceManager_0;
		private static CultureInfo cultureInfo_0;
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Class9.resourceManager_0, null))
				{
					ResourceManager resourceManager = new ResourceManager("ns0.Class9", typeof(Class9).Assembly);
					Class9.resourceManager_0 = resourceManager;
				}
				return Class9.resourceManager_0;
			}
		}
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Class9.cultureInfo_0;
			}
			set
			{
				Class9.cultureInfo_0 = value;
			}
		}
		internal static Bitmap gradient_dim
		{
			get
			{
				object @object = Class9.ResourceManager.GetObject("gradient_dim", Class9.cultureInfo_0);
				return (Bitmap)@object;
			}
		}
		internal static Bitmap gradient_orange
		{
			get
			{
				object @object = Class9.ResourceManager.GetObject("gradient_orange", Class9.cultureInfo_0);
				return (Bitmap)@object;
			}
		}
		internal Class9()
		{
		}
	}
}
