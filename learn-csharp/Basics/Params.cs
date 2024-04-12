using System;
namespace learn_csharp.Basics
{
	public class Params
	{
		public static void ParamExample(params Object[] args)
		{
			Console.WriteLine("Arguments received are - ");
			args.ToList().ForEach(d => Console.WriteLine(d));
		}
	}
}

