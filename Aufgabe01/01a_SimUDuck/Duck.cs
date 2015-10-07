using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimUDuck {

	// Context Class.
	abstract class Duck {
		public IQuackBehaviour QuackBehaviour { get; set; }
		public IFlyBehaviour FlyBehaviour { get; set; }

		public Duck(IQuackBehaviour QuackBehaviour, IFlyBehaviour FlyBehaviour) {
			this.QuackBehaviour = QuackBehaviour;
			this.FlyBehaviour = FlyBehaviour;
		}

		public void performQuack() {
			QuackBehaviour.quack ();
		}

		public void performFly() {
			FlyBehaviour.fly ();
		}

		public void swim() {
			Console.Out.WriteLine("Swim");
		}

		public abstract void display();
	}

	// Derived Context Classes.
	class MallardDuck : Duck {
		public MallardDuck(IQuackBehaviour QuackBehaviour, IFlyBehaviour FlyBehaviour):base(QuackBehaviour, FlyBehaviour){}

		public override void display() {
			Console.Out.WriteLine("Mallard:");
		}
	}

	class RedheadDuck : Duck {
		public RedheadDuck(IQuackBehaviour QuackBehaviour, IFlyBehaviour FlyBehaviour):base(QuackBehaviour, FlyBehaviour){}

		public override void display() {
			Console.Out.WriteLine("RedheadDuck:");
		}
	}
}