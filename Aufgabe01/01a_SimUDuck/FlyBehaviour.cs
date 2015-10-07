using System;

namespace SimUDuck {
	
	// Strategy
	interface IFlyBehaviour {
		void fly();
	}

	// Concrete Strategies
	class FlyWithWings : IFlyBehaviour {
		public void fly() {
			Console.Out.WriteLine ("Fly");
		}
	}

	class Flyless : IFlyBehaviour {
		public void fly() {
			Console.Out.WriteLine ("Don't fly");
		}
	}
}

