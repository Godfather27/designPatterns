using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount {

	// context
    public class Account {
		public IOverdraft Type { get; set;}
        public string Name {get; set;}
        public string Number { get; set;}
        public double Money { get; set;}

		public Account(string name, string number, IOverdraft type) {
			Type = type;
            Name = name;
            Number = number;
        }

        public void Deposit(double value) {
            Money += value;
        }

        public virtual void WithDraw(double value) {
            Money -= value;
        }

        public double GetBalance() {
            return Money;
        }

        public override string ToString() {
            return Number + " (" + Name + "): " + Money;
        }

		public void withDraw(double value){
			Type.WithDraw (value, this);
		}
    }
}
