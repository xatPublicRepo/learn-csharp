using System;
namespace learn_csharp.Basics
{
	public class CsDictionary
	{
		public static void DictionaryBasics()
		{
			Dictionary<int, Object[]> empData = new Dictionary<int, object[]>();
			Object[] emp1 = new Object[] { "Ram", "Pune", 30000, 'M', 98.2 };
            Object[] emp2 = new Object[] { "Rohini", "Mumbai", 20000, 'F', 93.7 };
            Object[] emp3 = new Object[] { "Mohini", "Bangalore", 40000, 'F', 96.9 };
			empData.Add(101, emp1);
            empData.Add(102, emp2);
            empData.Add(103, emp3);

			Console.WriteLine("Printing Dictionary Data");
			foreach(var data in empData.Keys)
			{
				Console.WriteLine("Employee id is {0} ", data);
				Console.Write(" and its details are - ");
                Console.WriteLine("");
                foreach (var e in empData[data])
				{
					Console.WriteLine(e);

				}
			}
        }
	}
}

