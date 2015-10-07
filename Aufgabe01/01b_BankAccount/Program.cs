using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount {
    class Program {
        static void Main(string[] args) {
			
            Manager m = new Manager();
			BoundedAccount boundedAccount = new BoundedAccount ();
			UnboundedAccount unboundedAccount = new UnboundedAccount ();

			Account a = new Account("Hans", "1234-001", boundedAccount);
			Account b = new Account("Susi", "1234-002", unboundedAccount);

            m.AddAccount(a);
            m.AddAccount(b);
            Console.Out.WriteLine("---");
            DumpAccounts(m);
            Console.Out.WriteLine("---");
            Console.Out.WriteLine(a);
            a.Deposit(100);
            Console.Out.WriteLine(a);
            a.withDraw(200);
            Console.Out.WriteLine(a);
            Console.Out.WriteLine("---");
            DumpAccounts(m);
            Console.In.ReadLine();
        }

		static void DumpAccounts(Manager m) {
			foreach (Account a in m.Accounts) Console.Out.WriteLine(a);
		}
    }
}
