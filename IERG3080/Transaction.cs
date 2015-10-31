using System;

namespace IERG3080
{
	public class Transaction
	{
		public string TransType{ get; private set;}
		public Account Account{ get; private set;}
		public double Amount{ get; private set;}
		public string Type{ get; private set;}
		public Account targetAccount{ get; private set;}
		public string targetType{ get; private set;}

		public Transaction (Account account, double amount, string type, Account to_account, string to_type)
		{
			this.Account = account;
			this.Amount = amount;
			this.Type = type;
			this.targetAccount = to_account;
			this.targetType = to_type;
		}

		public static void Do(double amount, Account acc, Account to_acc){
		}
	}
}

