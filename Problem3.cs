namespace shiftedup
{
	public class Problem3
	{
		public int Fib(int numComputations)
		{
			int first = 0;
			int second = 1;

			for (int i = 0; i < numComputations; i++)
			{
				int tmp = first + second;
				first = second;
				second = tmp;
			}

			return second;
		}
	}
}