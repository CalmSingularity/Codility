using System;
using static BinaryGap.Program;
using static CyclicRotation.Program;
using static OddOccurrencesInArray.Program;


namespace Codility
{
	class Program
	{
		static void Main(string[] args)
		{
			// https://app.codility.com/programmers/lessons/1-iterations/
			// BinaryGap
			Console.WriteLine(MaxBinaryGap(5));
			Console.WriteLine(MaxBinaryGap(9));
			Console.WriteLine(MaxBinaryGap(32));
			Console.WriteLine(MaxBinaryGap(529));
			Console.WriteLine(MaxBinaryGap(549));

			// https://app.codility.com/programmers/lessons/2-arrays/
			// CyclicRotation
			Console.WriteLine(ArrayToString(CyclicRotate(new int[] { 3, 8, 9, 7, 6 }, 3)));
			Console.WriteLine(ArrayToString(CyclicRotate(new int[] { 0, 0, 0 }, 1)));
			Console.WriteLine(ArrayToString(CyclicRotate(new int[] { 1, 2, 3, 4 }, 4)));
			Console.WriteLine(ArrayToString(CyclicRotate(new int[] { -100, -1, 0, 1, 6 }, 0)));
			Console.WriteLine(ArrayToString(CyclicRotate(new int[] { -100, -1, 0, 1, 6 }, 1)));
			Console.WriteLine(ArrayToString(CyclicRotate(new int[] { -100, -1, 0, 1, 6 }, 4)));
			Console.WriteLine(ArrayToString(CyclicRotate(new int[] { -100, -1, 0, 1, 6 }, 5)));
			Console.WriteLine(ArrayToString(CyclicRotate(new int[] { -100, -1, 0, 1, 6 }, 6)));
			Console.WriteLine(ArrayToString(CyclicRotate(new int[] { -100, -1, 0, 1, 6 }, 10)));
			Console.WriteLine(ArrayToString(CyclicRotate(new int[] { }, 10)));

			// OddOccurrencesInArray
			Console.WriteLine(FindOddOccurrenceInArray(new int[] { 9, 3, 9, 3, 9, 7, 9 }));
			Console.WriteLine(FindOddOccurrenceInArray(new int[] { 4, 7, 6, 9, 5, 7, 4, 9, 6 }));
			Console.WriteLine(FindOddOccurrenceInArray(new int[] { 0 }));
			Console.WriteLine(FindOddOccurrenceInArray(new int[] { 1 }));
			Console.WriteLine(FindOddOccurrenceInArray(new int[] { 0, 0, 1 }));
			Console.WriteLine(FindOddOccurrenceInArray(new int[] { 0, 1, 2, 3, 4, 5, 4, 3, 2, 1, 0 }));

		}
	}
}
