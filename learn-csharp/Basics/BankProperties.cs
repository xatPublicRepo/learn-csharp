using System;
namespace learn_csharp.Basics
{
	public class BankProperties
	{
		private int accBal;
		private float roi;
        public BankProperties()
		{
			ROI = 6.05f;

        }
        public int AccBal
		{
			set
			{
				if (value < 1000)
				{
					Console.WriteLine("OPPS!!! You must deposit amount min amount of 1000");
					return;
				}
				accBal = value;
			}
			get
			{
				return accBal;
			}
		}

		public float ROI
		{
			private set
			{
				roi = value;
			}
			get
			{
				return roi;
			}

		}
	}
}

