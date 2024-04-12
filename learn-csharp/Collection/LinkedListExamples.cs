using System;
namespace learn_csharp.Collection
{
	public class LinkedListExamples
	{

		public static void LinkedListBasics()
		{
			LinkedList<String> ll = new LinkedList<string>();
			ll.AddLast("Suro");
            ll.AddLast("Soma");
            ll.AddLast("Roma");
            ll.AddLast("Googlie");
            ll.AddLast("Poppins");


			foreach(string name in ll)
			{
				Console.WriteLine(name);
			}

        }



	}
}

