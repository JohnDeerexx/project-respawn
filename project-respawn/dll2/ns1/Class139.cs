using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
namespace ns1
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
	internal class Class139
	{
		private static ResourceManager resourceManager_0;
		private static CultureInfo cultureInfo_0;
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Class139.resourceManager_0, null))
				{
					ResourceManager resourceManager = new ResourceManager("ns1.Class139", typeof(Class139).Assembly);
					Class139.resourceManager_0 = resourceManager;
				}
				return Class139.resourceManager_0;
			}
		}
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Class139.cultureInfo_0;
			}
			set
			{
				Class139.cultureInfo_0 = value;
			}
		}
		internal static Bitmap gradient
		{
			get
			{
				object @object = Class139.ResourceManager.GetObject("gradient", Class139.cultureInfo_0);
				return (Bitmap)@object;
			}
		}
		internal Class139()
		{
		}
	}
}
