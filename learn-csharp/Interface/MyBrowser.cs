namespace learn_csharp.Interface
{
	public class MyBrowser : IWebDriver
	{
		public MyBrowser()
		{
		}

        public void FindElement()
        {
            Console.WriteLine("My Browser FindElement");
        }

        public void Get()
        {
            Console.WriteLine("My Browser Get method");
        }
    }
}

