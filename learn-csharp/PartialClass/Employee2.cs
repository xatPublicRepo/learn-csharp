using System;
namespace learn_csharp.PartialClass
{
	public partial class Employee
	{
		/*
		public Employee()
		{
			Console.WriteLine("This is Partial Class 2 , constructor");
		}*/

		//public int i = 300;
		public int x = 456;
		public void M2()
		{
			Console.WriteLine("M2 method..");
			MyPartialMethod();
		}

		partial void MyPartialMethod()
		{
			Console.WriteLine("I am a partial method...");
		}

		
	}
}

