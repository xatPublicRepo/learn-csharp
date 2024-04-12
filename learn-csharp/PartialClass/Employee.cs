using System;
namespace learn_csharp.PartialClass
{
	public partial class Employee
	{
		public int i = 0;
		public Employee()
		{
			Console.WriteLine("This is Emp Partial class constructor");
		}

		public void M1()
		{
			Console.WriteLine("M1 method..");
		}

        partial void  MyPartialMethod();
	}
}

