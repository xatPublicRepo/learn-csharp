using System;
namespace learn_csharp.Inheritence
{
	public class Animal
	{
		public void printMsg()
		{
			Console.WriteLine("I am Animal");
		}
        public virtual void printMsg2()
        {
            Console.WriteLine("I am Animal2");
        }


    }
}

