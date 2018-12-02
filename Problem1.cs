using System.Collections.Generic;

namespace shiftedup
{
	public class Problem1
	{
		public int ForLoop(List<int> numbers)
		{
			int total = 0;
			for (int i = 0; i < numbers.Count; i++)
			{
				total += numbers[i];
			}

			return total;
		}

		public int WhileLoop(List<int> numbers)
		{
			int i = 0;
			int total = 0;
			while (i < numbers.Count)
			{
				total += numbers[i];
				i++;
			}
			return total;
		}

		public int Recursive(List<int> numbers, int i)
		{
			if (i == numbers.Count)
				return 0;
			return numbers[i] + Recursive(numbers, ++i);
		}
	}
}