using System;

namespace c_StringStrategy {
	class MainClass {
		public static void Main (string[] args) {
			LengthDifference lengthDifference = new LengthDifference ();
			LeventshteinDistance leventshteinDistance = new LeventshteinDistance ();
			HammingDistance hammingDistance = new HammingDistance ();

			StringContext first = new StringContext ("Wolkenkratzer", "Zwergenhütte", lengthDifference);
			StringContext second = new StringContext ("Darth Vader", "Anakin Skywalker", leventshteinDistance);
			StringContext third = new StringContext ("Tom Marvolo Riddle", "Iam Lord Voldemort", hammingDistance);

			try{
				Console.Out.WriteLine ("Length:\t\t{0}", first.computeDifference ());
				Console.Out.WriteLine ("Leventshtein:\t{0}",second.computeDifference ());
				Console.Out.WriteLine ("Hamming:\t{0}",third.computeDifference ());
			}
			catch(Exception e){
				Console.Out.WriteLine (e.Message);
			}
		}
	}
}
