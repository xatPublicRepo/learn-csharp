using System;
namespace learn_csharp.Inheritence
{
	public class Dog : Animal
	{
		public void printDogMsg()
		{
			Console.WriteLine("I am a dog");
		}
        public override void printMsg2()
        {
            Console.WriteLine("I am Dog2");
        }
    }
}

