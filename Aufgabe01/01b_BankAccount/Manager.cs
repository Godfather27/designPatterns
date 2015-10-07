using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount {
    class Manager {
        private List<Account> accounts = new List<Account>();

		// added Property to access backing field
		// readonly accessor
		public List<Account> Accounts {
			get {
				return accounts;
			}
		}

        public void AddAccount(Account a) {
            accounts.Add(a);
        }
    }
}
