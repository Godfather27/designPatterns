using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimUDuck {
	
	// Strategy
	interface IQuackBehaviour {
		void quack ();
	}

	// Concrete Strategies
	class Squeak : IQuackBehaviour {
		public void quack() {
			Console.Out.WriteLine ("Squeak");
		}
	}

	class Quack : IQuackBehaviour {
		public void quack() {
			Console.Out.WriteLine ("Quack");
		}
	}

	class MuteQuack : IQuackBehaviour {
		public void quack() {
			Console.Out.WriteLine ("*silence*");
		}
	}
}