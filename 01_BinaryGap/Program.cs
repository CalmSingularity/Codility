using System;

namespace BinaryGap
{
	public class Program
	{
		public static int MaxBinaryGap(int N)
		{
			int maxGap = 0;
			int currentGap = -1; // no gap found yet

			while (N > 0)
			{
				if ((N & 1) == 1)  // rightmost bit == 1
				{
					if (currentGap == -1)
					{
						currentGap = 0;  // start counting the gap
					}
					else 
					{
						if (currentGap > maxGap)
							maxGap = currentGap;
						currentGap = 0;  // reset the current gap as we met 1
					}
				}
				else if (currentGap >= 0)  // rightmost bit == 0 && current gap != -1 (we've met at least one 1)
				{
					++currentGap;
				}
				N = N >> 1;  // right bit shift to evaluate the next bit in the next while cycle
			}
			return maxGap;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(MaxBinaryGap(529));
			Console.WriteLine(MaxBinaryGap(579));
			//...
		}
	}
}
