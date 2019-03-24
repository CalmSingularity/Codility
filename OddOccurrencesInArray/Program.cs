using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrencesInArray
{
	public class Program
	{
		public static int FindOddOccurrenceInArray(int[] A)
		{
			foreach (int i in A.Distinct().ToList())
				if (Array.FindAll(A, n => n == i).Length % 2 == 1)
					return i;
			return 0;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(FindOddOccurrenceInArray(new int[] { 9, 3, 9, 3, 9, 7, 9 }));
			Console.WriteLine(FindOddOccurrenceInArray(new int[] { 4, 7, 6, 9, 5, 7, 4, 9, 6 }));
			Console.WriteLine(FindOddOccurrenceInArray(new int[] { 0 }));
			Console.WriteLine(FindOddOccurrenceInArray(new int[] { 1 }));
			Console.WriteLine(FindOddOccurrenceInArray(new int[] { 0,0,1 }));
			Console.WriteLine(FindOddOccurrenceInArray(new int[] { 0, 1, 2, 3, 4, 5, 4, 3, 2, 1, 0 }));

		}
	}
}
