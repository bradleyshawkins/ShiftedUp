using System;
using System.Collections.Generic;

namespace shiftedup
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("--- Problem 1 ---");
			var problem1 = new Problem1();
			var numbers = new List<int>()
			{
				1,
				2,
				3,
				4,
				5
			};

			var total = problem1.ForLoop(numbers);
			Console.WriteLine("For loop total: {0}", total);

			total = problem1.WhileLoop(numbers);
			Console.WriteLine("While loop total: {0}", total);

			total = problem1.Recursive(numbers, 0);
			Console.WriteLine("Recursive total: {0}", total);

			Console.WriteLine("--- Problem 2 ---");

			var problem2 = new Problem2<int>();

			var list1 = new List<int>() { 1, 3, 5, 7, 9 };
			var list2 = new List<int>() { 2, 4, 6, 8 };

			var combinedList = problem2.CombineList(list1, list2);
			Console.WriteLine("Combined List: {0}", string.Join(',', combinedList));

			Console.WriteLine("--- Problem 3 ---");

			var problem3 = new Problem3();

			var fib = problem3.Fib(8);
			Console.WriteLine("Fib {0} = {1}", 8, fib);

			Console.WriteLine("--- Problem 4 ---");

			var problem4 = new Problem4();

			var nums = new List<int>() { 5, 2, 1, 9, 50, 56 };

			var largestNum = problem4.LargestNumber(nums);

			Console.WriteLine("Largest Number: {0}", largestNum);

		}
	}
}
