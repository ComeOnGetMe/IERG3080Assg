using System;
using Gtk;
using System.Collections.Generic;

namespace IERG3080{
	public partial class MainWindow: Gtk.Window
	{
		public MainWindow (string title) : base (Gtk.WindowType.Toplevel)
		{
			Build ();
			MyReader mr = new MyReader ();
			List<Account> acc_list = mr.ImportAccount("../../src/Assignment4.csv");
			Dictionary<string, List<Account>> dict = new Dictionary<string, List<Account>>();
			foreach (Account acc in acc_list) 
			{
				acc.Report ();
				try
				{
					dict.Add(acc.ID, new List<Account>());
				} 
				catch (ArgumentException)
				{
					dict[acc.ID].Add(acc);
				}
			}
		}

		protected virtual void Deposit(){
		}

		protected virtual void Withdraw(){
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}
	}
}