using System;
namespace learn_csharp.Collection
{
	public class MySortedList
	{
		public static void SortedListExample()
		{
            SortedList<int, string> empDir = new SortedList<int, string>();
            empDir.Add(101, "Googlie");
            empDir.Add(104, "Poppins");
            empDir.Add(103, "Bonus");
            empDir.Add(105, "Rio");
            empDir.Add(102, "Jack");

            foreach (KeyValuePair<int, string> kv in empDir)
            {
                Console.WriteLine("Keys is {0}, and its Value is {1}", kv.Key, kv.Value);
            }

        }
    }
}

