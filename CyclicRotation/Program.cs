using System;
using System.Text;

namespace CyclicRotation
{
	public class Program
	{

		public static int[] CyclicRotate(int[] A, int K)
		{
			int N = A.Length;
			if (N == 0)
				return A;
			if (K % N == 0)
				return A;

			int[] result = new int[N];
			for (int i = 0; i < N; ++i)
			{
				result[(i + K) % N] = A[i];
			}
			return result;
		}

		public static string ArrayToString(int[] A)
		{
			StringBuilder result = new StringBuilder();
			foreach (int n in A)
				result.Append(n.ToString()).Append(" ");
			return result.ToString();
		}

		static void Main(string[] args)
		{
			// Test
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

			//..
		}
	}
}
