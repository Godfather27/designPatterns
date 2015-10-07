using System;
namespace BankAccount
{
	// strategy
	public interface IOverdraft
	{
		void WithDraw(double value, Account that);
	}

	// strategy for accounts without overdraft
	class BoundedAccount : IOverdraft {
		// if there is more or the same amount of money deposited as it should be withdrawn, do it
		// else write an errormessage
		public void WithDraw(double value, Account that){
			if (value <= that.Money)
				that.Money -= value;
			else
				Console.Out.WriteLine ("---\nyou can't withdraw {0}\nyour balance is only {1}\n---", value, that.Money);
		}
	}

	// strategy for accounts with overdraft
	class UnboundedAccount : IOverdraft {
		public void WithDraw(double value, Account that){
			that.Money -= value;
		}
	}
}

