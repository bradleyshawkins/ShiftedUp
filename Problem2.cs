using System.Collections.Generic;

namespace shiftedup
{
	public class Problem2<T>
	{
		public List<T> CombineList(List<T> list1, List<T> list2)
		{
			var combinedList = new List<T>();

			int len = list1.Count >= list2.Count ? list2.Count : list1.Count;

			for (int i = 0; i < len; i++)
			{
				combinedList.Add(list1[i]);
				combinedList.Add(list2[i]);
			}

			if (list1.Count > list2.Count)
			{
				AddRemainer(combinedList, list1, len);
			}
			else if (list2.Count > list1.Count)
			{
				AddRemainer(combinedList, list2, len);
			}

			return combinedList;
		}

		private void AddRemainer(List<T> combinedList, List<T> remainder, int startIndex)
		{
			for (int i = startIndex; i < remainder.Count; i++)
			{
				combinedList.Add(remainder[i]);
			}
		}
	}
}