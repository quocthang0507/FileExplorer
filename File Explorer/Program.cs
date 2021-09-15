using System;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace File_Explorer
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			using (Mutex mutex = new Mutex(true, "FileExplorer", out bool mutexCreated))
			{
				if (mutexCreated)
				{
					if (IsAdministrator())
					{
						Application.EnableVisualStyles();
						Application.SetCompatibleTextRenderingDefault(false);
						Application.Run(new Form1());
					}
					else
					{
						MessageBox.Show("Please run this program with Administrator permision.", "Program is already running", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					MessageBox.Show("Another instance of File Explorer is already running.", "Program is already running", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		static bool IsAdministrator()
		{
			WindowsIdentity identity = WindowsIdentity.GetCurrent();
			WindowsPrincipal principal = new WindowsPrincipal(identity);
			return principal.IsInRole(WindowsBuiltInRole.Administrator);
		}

	}
}
