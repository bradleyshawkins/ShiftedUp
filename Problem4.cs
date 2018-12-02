using System;
using System.Collections.Generic;
using System.Linq;

namespace shiftedup
{
	public class Problem4
	{
		public int LargestNumber(List<int> nums)
		{

			nums.Sort((x, y) =>
			{
				var xStr = x.ToString();
				var yStr = y.ToString();

				return (xStr + yStr).CompareTo(yStr + xStr) * -1;
			});

			string number = "";
			foreach (int i in nums)
			{
				number += i.ToString();
			}

			return int.Parse(number);
		}
	}
}