using System;
using System.Collections.Generic;

namespace IERG3080
{
	public class MyReader
	{
		public MyReader (){}

		public List<Account> ImportAccount(string filename)
		{
			string[] lines=System.IO.File.ReadAllLines(@filename);
			List<Account> acc_lst = new List<Account> ();
			foreach (string str in lines) 
			{
				if (str.Substring (0,6) != "Region") 
				{
					acc_lst.Add (CreateAccount (str.Trim()));
				}
			}
			return acc_lst;
		}

		public Account CreateAccount(string str)
		{
			var profile = str.Split (',');
			Account acc;
			switch (profile [3])
			{
			case "Saving":
				acc = new SavingAccount (profile [2], Convert.ToDouble (profile [4]), profile [0], profile [1]);
				break;
			case "Current":
				acc = new CurrentAccount (profile [2], Convert.ToDouble (profile [4]), profile [0], profile [1]);
				break;
			default:
				acc = null;
				break;
			}
			return acc;
		}
	}
}

