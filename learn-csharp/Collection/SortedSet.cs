using System;
namespace learn_csharp.Collection
{
	public class SortedSet
	{
		public static void SortedSetExamples()
		{
			SortedSet<String> ss = new SortedSet<String>();
			ss.Add("Banana");
            ss.Add("Apple");
            ss.Add("Guava");
            ss.Add("Carrot");
            ss.Add("Guava");

			foreach(var fruits in ss)
			{
				Console.WriteLine(fruits);
			}
        }
	}
}

