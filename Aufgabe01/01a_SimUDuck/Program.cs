using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimUDuck {
	class Program {
		static void Main(string[] args) {

			// Create Instances of Strategies and Contexts.
			Squeak theSqueak = new Squeak ();
			Quack theQuack = new Quack ();
			MuteQuack theMuteQuack = new MuteQuack ();
			FlyWithWings theFly = new FlyWithWings ();
			Flyless theFlyless = new Flyless ();

			Duck magicDuck = new MallardDuck(theQuack, theFly);
			Duck rorschachDuck = new RedheadDuck (theMuteQuack, theFlyless);

			// Call functions.
			magicDuck.display();
			magicDuck.performQuack();
			magicDuck.performFly();
			Console.Out.WriteLine ();

			rorschachDuck.display();
			rorschachDuck.performQuack();
			rorschachDuck.performFly();
			Console.Out.WriteLine ();

			// Assign new Strategies to Instances.
			magicDuck.QuackBehaviour = theSqueak;
			magicDuck.FlyBehaviour = theFlyless;
			rorschachDuck.QuackBehaviour = theQuack;
			rorschachDuck.FlyBehaviour = theFly;

			// Call functions.
			magicDuck.display();
			magicDuck.performQuack();
			magicDuck.performFly();
			Console.Out.WriteLine ();

			rorschachDuck.display();
			rorschachDuck.performQuack();
			rorschachDuck.performFly();

			Console.In.ReadLine();
		}
	}
}