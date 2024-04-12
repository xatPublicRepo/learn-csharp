using System;
namespace learn_csharp.WebDriver
{
	public interface IWebDriver
	{

		void FindElement();

		void SendKeys(string text);

		void Click();

	}
}

