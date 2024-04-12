using learn_csharp.WebDriver;

namespace learn_csharp.ExtentsionMethods
{
	public static class ExtensionMethods
	{


		public static void TypeText(this IWebDriver driver, string text)
		{
            driver.SendKeys("Extension method invoked...");
            driver.SendKeys(text);

		}


	}
}

