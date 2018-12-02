using System;
using System.Collections.Generic;
using System.Linq;

namespace shiftedup
{
	public class Problem5
	{
		private List<int> Numbers = new List<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

		public List<string> AddTo100()
		{
			return Recursive(0, Numbers[0], 1, Numbers);
		}

		public List<string> Recursive(int total, int num, int index, List<int> nums)
		{
			int digit = num % 10;
			if (index == nums.Count)
			{
				if (Math.Abs(100 - total) == num)
				{
					return new List<string>() { digit.ToString() };
				}
				return new List<string>();
			}


			List<string> add = Recursive(total + num, nums[index], index + 1, nums);
			List<string> sub = Recursive(total + num, -nums[index], index + 1, nums);

			var catNum = int.Parse(num.ToString() + nums[index].ToString());
			List<string> cat = Recursive(total, catNum, index + 1, nums);

			var results = new List<string>();
			results.AddRange(Concat(digit, "+", add));
			results.AddRange(Concat(digit, "", sub));
			results.AddRange(Concat(digit, "", cat));
			return results;
		}

		public List<string> Concat(int num, string symbol, List<string> nums)
		{
			var formulolee = new List<string>();
			foreach (var s in nums)
			{
				formulolee.Add(String.Format("{0}{1}{2}", num, symbol, s));
			}
			return formulolee;
		}
	}
}