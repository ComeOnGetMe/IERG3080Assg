using System;

namespace IERG3080
{
	public class CurrentAccount: Account
	{
		public override void PrintBalance ()
		{
			Console.WriteLine ("The balance of current account ID={0} is {1}", this.ID, this.Balance);
		}

		public override void Report()
		{
			Console.WriteLine("Current account {0}-{1}-{2} balance = {3}", this.Region, this.Branch, this.ID, this.Balance.ToString());
		}

		public CurrentAccount (string id, double balance, string region, string branch): base(id, balance,region,branch){}
	}
}

