using System;
namespace learn_csharp.Generics;

	public class MyGenericClass<T>
	{
		public MyGenericClass(T val)
		{
			if(val.GetType().ToString().Contains("String"))
			{
				Console.WriteLine("This value is of type string and the value is " + val);
			}
        else if (val.GetType().ToString().Contains("Int"))
        {
            Console.WriteLine("This value is of type Integer and the value is " + val);
        }
        else if (val.GetType().ToString().Contains("Boolean"))
        {
            Console.WriteLine("This value is of type Boolean and the value is " + val);
        }
        else if (val.GetType().ToString().Contains("Char"))
        {
            Console.WriteLine("This value is of type Char and the value is " + val);
        }
        else
        {
            Console.WriteLine("This value is of type {0} and the value is {1}", val.GetType().ToString(),val);
        }
    }
	}

