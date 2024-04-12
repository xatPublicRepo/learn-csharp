using System;
using learn_csharp.WebDriver;

namespace learn_csharp.Browsers
{
    public class Chrome : IWebDriver
    {
        public void Click()
        {
            Console.WriteLine("Chrome Click...");
        }

        public void FindElement()
        {
            Console.WriteLine("Chrome Find Elements...");
        }

        public void SendKeys(string txt)
        {
            Console.WriteLine("Chrome SendKeys..."+txt);
        }
    }
}

