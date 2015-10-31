using System;

namespace IERG3080
{
	public class TransferTransaction
	{
		public Account toAccount;
		public string toType;
		public TransferTransaction (Account account, double amount, string type, Account to_account, string to_type ): base(account, amount, type){
			this.toAccount = to_account;
			this.toType = to_type;
		}

	}
}

