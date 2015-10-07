using System;

namespace c_StringStrategy {
	public class StringContext {
		string S { get; set; }
		string T { get; set; }
		ICalcStrategy Strategy { get; set; }

		public StringContext (string s, string t, ICalcStrategy strategy) {
			this.S = s;
			this.T = t;
			this.Strategy = strategy;
		}

		public int computeDifference(){
			return Strategy.compute (S, T);
		}
	}
}

