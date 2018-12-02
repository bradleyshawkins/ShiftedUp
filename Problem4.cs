using System;
using System.Collections.Generic;
using System.Linq;

namespace shiftedup
{
	public class Problem4
	{
		public int LargestNumber(List<int> nums)
		{
			for (int i = 0; i < nums.Count; i++)
			{
				for (int j = i + 1; j < nums.Count; j++)
				{
					if (ShouldSwitchNums(nums[i], nums[j]))
					{
						var tmp = nums[i];
						nums[i] = nums[j];
						nums[j] = tmp;
					}
				}
			}

			var numStr = "";
			nums.Reverse();
			foreach (var n in nums)
			{
				numStr += n.ToString();
			}
			return int.Parse(numStr);
		}

		private bool ShouldSwitchNums(int first, int second)
		{
			// 91 => [9, 1]
			var num1 = first.ToString();
			// 872 => [8, 7, 2]
			var num2 = second.ToString();

			var len = num1.Length >= num2.Length ? num2.Length : num1.Length;

			for (int i = 0; i < len; i++)
			{
				// If the first numbers digit is larger, they should be switched
				if (num1[i] > num2[i])
					return true;
				// If the first number's digit is smaller, they should not be switched
				else if (num1[i] < num2[i])
					return false;
			}
			// If the numbers are equal up to the matching number of digits, return true if num1 has less digits than num2
			return num1.Length < num2.Length;
		}

		private List<int> BreakNum(int num)
		{
			var nums = new List<int>();

			var len = num.ToString().Count();
			for (int i = len - 1; i >= 1; i--)
			{
				var power = Math.Pow(10, i);
				var digit = num / (int)power;
				nums.Add(digit);
			}

			nums.Add(num % 10);

			return nums;
		}

	}
}