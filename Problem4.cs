using System;
using System.Collections.Generic;
using System.Linq;

namespace shiftedup
{
	public class Problem4
	{
		public int LargestNumber(List<int> nums)
		{
			// Put each number into a bucket
			for (int i = 0; i < nums.Count; i++)
			{
				for (int j = 1; j < nums.Count; j++)
				{
					CompareNums(nums[i], nums[j]);
				}
			}

			// Sort each bucket

			// Concat to form string


			return 0;
		}

		private void CompareNums(int v1, int v2)
		{

		}


		// First number that is higher is best
		// If numbers match, shorter number is best
		public int NextDigit(int i, int mod)
		{
			if (i < mod)
				return i;
			return NextDigit(i % mod, mod);
		}
	}
}