using System;
using Gtk;

namespace IERG3080
{
	class MainClass
	{
		public static void Main ()
		{
			Application.Init ();
			MainWindow win = new MainWindow("Bank of Group 13");
			Application.Run ();
		}
	}
}
