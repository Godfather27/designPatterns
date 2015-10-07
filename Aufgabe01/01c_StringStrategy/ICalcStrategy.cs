using System;
using System.Linq;

namespace c_StringStrategy {
	// Strategy
	public interface ICalcStrategy {
		int compute (string s, string t);
	}

	// Concrete Strategies
	// Length difference
	public class LengthDifference : ICalcStrategy {
		public int compute (string s, string t){
			return Math.Abs(s.Length - t.Length);
		}
	}

	// Levenshtein distance
	// source:
	// http://davefancher.com/2012/04/22/string-distances-9/
	// http://creativecommons.org/licenses/by/3.0/
	// replaced "return"s with "Console.Out.WriteLine"s
	public class LeventshteinDistance : ICalcStrategy{
		public int compute (string s, string t){
			var bounds = new { Height = s.Length + 1, Width = t.Length + 1 };

			int[,] matrix = new int[bounds.Height, bounds.Width];

			for(int height = 0; height < bounds.Height; height++) { matrix[height, 0] = height; };
			for(int width = 0; width < bounds.Width; width++) { matrix[0, width] = width; };

			for(int height = 1; height < bounds.Height; height++)
			{
				for(int width = 1; width < bounds.Width; width++)
				{
					int cost = (s[height - 1] == t[width - 1]) ? 0 : 1;
					int insertion = matrix[height, width - 1] + 1;
					int deletion = matrix[height - 1, width] + 1;
					int substitution = matrix[height - 1, width - 1] + cost;

					int distance = Math.Min(insertion, Math.Min(deletion, substitution));

					matrix[height, width] = distance;
				}
			}

			return matrix[bounds.Height - 1, bounds.Width - 1];
		}
	}

	// Hamming distance
	// source:
	// http://davefancher.com/2012/04/22/string-distances-9/
	// http://creativecommons.org/licenses/by/3.0/
	public class HammingDistance : ICalcStrategy{
		public int compute (string s, string t){
			if(s.Length != t.Length)
			{
				throw new Exception("Strings must be equal length");
			}

			int distance =
				s.ToCharArray()
					.Zip(t.ToCharArray(), (c1, c2) => new { c1, c2 })
					.Count(m => m.c1 != m.c2);

			return distance;
		}
	}

}

