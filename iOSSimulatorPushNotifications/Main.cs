using System.Diagnostics;
using AppKit;

namespace iOSSimulatorPushNotifications
{
	static class MainClass
	{
		static void Main (string [] args)
		{
			NSApplication.Init ();
			NSApplication.Main (args);
		}
	}
}
