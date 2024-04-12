using System;
namespace learn_csharp.Collection
{
	public class MyDictionary
	{
		public static void DictionaryExample()
		{
			Dictionary<int, string> empDir = new Dictionary<int, string>();
			empDir.Add(101, "Googlie");
            empDir.Add(104, "Poppins");
            empDir.Add(103, "Bonus");
            empDir.Add(105, "Rio");
            empDir.Add(102, "Jack");

			foreach(KeyValuePair<int,string> kv in empDir)
			{
				Console.WriteLine("Keys is {0}, and its Value is {1}", kv.Key, kv.Value);
			}

        }
        public static void SortedDictionaryExample()
        {
            SortedDictionary<int, string> empDir = new SortedDictionary<int, string>();
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

