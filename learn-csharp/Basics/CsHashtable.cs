
using System.Collections;

namespace learn_csharp.Basics
{
	public class CsHashtable
	{
        public static void HashtableBasics()
        {

			Hashtable table = new Hashtable();
			table.Add("Name", "Ram");
			table.Add(100, "Data");
            table.Add(true, "Male");
			Console.WriteLine("Printing Hashtable data - ");
			foreach(var data in table.Keys)
			{
				Console.WriteLine("Key is {0} and its value is {1}", data, table[data]);
			}


        }
	}
}

