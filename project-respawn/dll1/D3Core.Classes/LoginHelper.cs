using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
namespace D3Core.Classes
{
	public static class LoginHelper
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate uint Delegate27(uint someOffset);
		[CompilerGenerated]
		private sealed class Class36
		{
			public string string_0;
			public string string_1;
			public void method_0()
			{
				LoginHelper.delegate27_0 = Helper.RegisterDelegate<LoginHelper.Delegate27>(9691888u);
				uint num = LoginHelper.delegate27_0(24011488u);
				uint address = Helper.smethod_1(num + 2776u);
				Helper.WriteString(address, this.string_0, new UTF8Encoding());
				num = LoginHelper.delegate27_0(24012008u);
				address = Helper.smethod_1(num + 2776u);
				Helper.WriteString(address, this.string_1, new UTF8Encoding());
				Framework.PressLoginButton();
			}
		}
		private static LoginHelper.Delegate27 delegate27_0;
		public static void LoginToAccount(string accountName, string accountPassword)
		{
			LoginHelper.Class36 @class = new LoginHelper.Class36();
			@class.string_0 = accountName;
			@class.string_1 = accountPassword;
			Framework.RunInD3ContextSynced(new Action(@class.method_0));
		}
	}
}
