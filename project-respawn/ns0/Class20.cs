using System;
using System.Threading;
using System.Windows.Forms;
namespace ns0
{
	internal static class Class20
	{
		private static Mutex mutex_0 = new Mutex(true, "{66006A19-D3EF-4CB8-803B-64ED8C0FB27E}");
		[STAThread]
		private static void Main()
		{
			if (!Class20.mutex_0.WaitOne(TimeSpan.Zero, true))
			{
				MessageBox.Show("Launcher is already running. You only need one launcher to start multiple instances. Just add more profiles and start them!");
				Environment.Exit(0);
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//BetaWarning betaWarning = new BetaWarning();
			//betaWarning.ShowDialog();
			Application.Run(new LoginWindow());
		}
	}
}
