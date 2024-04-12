using System;
namespace learn_csharp.Delegate
{

    delegate void Calculate(int n1, int n2);
    delegate void ConcatString(string s1, string s2);

    public class DelegateExamples
	{

		

		public static void Add(int n1,int n2)
		{
			int res = n1 + n2;
			Console.WriteLine("Addition Result is " + res);
		}

        public static void Mul(int n1, int n2)
        {
            int res = n1 * n2;
            Console.WriteLine("Multiplication Result is " + res);
        }

        public static void Sub(int n1, int n2)
        {
            int res = n1 - n2;
            Console.WriteLine("Substraction Result is " + res);
        }
        public static void Div(int n1, int n2)
        {
            int res = n1 / n2;
            Console.WriteLine("Division Result is " + res);
        }



    }
}

