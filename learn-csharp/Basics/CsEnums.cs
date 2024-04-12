using System;
namespace learn_csharp.Basics
{
	public class CsEnums
	{

		public enum Browser
		{
			CHROME,
			FIREFOX,
			EDGE,
			SAFARI,
			OPERA
		}


		public static void launchBrowser(Browser browser)
		{
			switch(browser)
			{
				case Browser.CHROME:	Console.WriteLine("Launching Chrome browser...");
										break;
                case Browser.SAFARI:	Console.WriteLine("Launching Safari browser...");
										break;
                case Browser.FIREFOX:	Console.WriteLine("Launching Firefox browser...");
										break;
                case Browser.EDGE:		Console.WriteLine("Launching Edge browser...");
										break;
                case Browser.OPERA:		Console.WriteLine("Launching Opera browser...");
										break;

            }

		}
	}
}

