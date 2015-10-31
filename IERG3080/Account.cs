using System;

namespace IERG3080
{
	public class Account
	{
		public string ID{ get; private set;}
		public double Balance{ get; private set;}
		public string Region{ get; private set;}
		public string Branch{ get; private set;}

		public virtual void PrintBalance()
		{
			Console.WriteLine (this.Balance);
		}

		public virtual void Report()
		{
			Console.WriteLine("Account {0}-{1}-{2} balance = {3}", this.Region, this.Branch, this.ID, this.Balance);
		}

		public void Deposit(double amount)
		{
			this.Balance += amount;
		}

		public Account (string id, double balance, string region, string branch)
		{
			this.ID = id;
			this.Balance = balance;
			this.Region = region;
			this.Branch = branch;
		}
	}
}

