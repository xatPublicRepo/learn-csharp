using learn_csharp.Browsers;
//using learn_csharp.WebDriver;
using static learn_csharp.Basics.CsEnums;
using learn_csharp.ExtentsionMethods;
using learn_csharp.Linq;
using learn_csharp.Delegate;
using learn_csharp.Inheritence;
using learn_csharp.Interface;
using learn_csharp.Exceptions;
using learn_csharp.Collection;
using learn_csharp.Generics;
using learn_csharp.PartialClass;

namespace learn_csharp.Basics
{
	public class Runner
	{
        public static void Main(string[] args)
        {
            //CsArrays.ArrayBasics();
            //CsHashtable.HashtableBasics();
            //CsDictionary.DictionaryBasics();
            //ListCustomType.UserData();
            //CsEnums.launchBrowser(Browser.FIREFOX);
            /*IWebDriver driver = new Chrome();
            driver.FindElement();
            driver.Click();
            driver.SendKeys("Hello Google");
            driver.TypeText("Hello Linkedin.");


            driver = new Firefox();
            driver.FindElement();
            driver.Click();
            driver.SendKeys("Hello Facebook");
            driver.TypeText("Hello Linkedin.");*/

            //LinqBasics.LinqBasicOps();

            /*
            //Delegate Example
            Calculate ops = DelegateExamples.Add;
            ops(20, 10);
            ops = DelegateExamples.Mul;
            ops(20, 10);
            ops = DelegateExamples.Sub;
            ops(20, 10);
            ops = DelegateExamples.Div;
            ops(20, 10);

            //Delegate using Lambda
            ConcatString cs = (str1, str2) => { Console.WriteLine("Concatinated String is " + str1 + str2); };
            cs("Hello", "C#");
            */

            /*

            //Call by Reference
            int a = 100;
            Console.WriteLine("Before making any calls " + a);
            methodVal(a);
            Console.WriteLine("After making a call to Method Val " + a);
            methodRef(ref a);
            Console.WriteLine("After making a call to Method " + a);

            */

            //Params example
            //Params.ParamExample(10, "Suro", true, 'M');


            /*
            //Understand Struct and Class difference
            //Class is call by reference
            //Struct is call by value
            StructExample c1 = new StructExample();
            c1.myData = 100;
            StructExample c2 = c1;
            Console.WriteLine(c1.myData);
            Console.WriteLine(c2.myData);
            c1.myData = 200;
            Console.WriteLine(c1.myData);
            Console.WriteLine(c2.myData);

            MyStruct s1 = new MyStruct();
            s1.Val = 300;
            MyStruct s2 = s1;
            Console.WriteLine(s1.Val);
            Console.WriteLine(s2.Val);
            s1.Val = 400;
            Console.WriteLine(s1.Val);
            Console.WriteLine(s2.Val);
            */

            /*
            //Properties Example
            BankProperties bank = new BankProperties();
            bank.AccBal = 100;
            Console.WriteLine("Balance " + bank.AccBal);
            Console.WriteLine("ROI " + bank.ROI);
            bank.AccBal = 3000;
            Console.WriteLine("Balance " + bank.AccBal);
            Console.WriteLine("ROI " + bank.ROI);
            */


            /*
            //Inheritence
            GSD gsd = new GSD();
            gsd.printMsg();
            gsd.printDogMsg();
            gsd.PrintGSD();
            Animal a = new Dog();
            a.printMsg2();
            */


            /*
            //Interface
            IWebDriver wd = new MyBrowser();
            wd.FindElement();
            wd.Get();
            */



            /*
            //Custom Exception
            string l2Feedback = "Negative";

            try
            {

                if (l2Feedback != "Positive")
                {
                    throw new NoOfferException("L2 Feedback was " + l2Feedback);
                }
                else
                {
                    Console.WriteLine("Congratulations!! Your Offer is on its way...");

                }
            }catch(NoOfferException ex)
            {
                //Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex);
                //Console.WriteLine(ex.GetType());
            }
            */

            /*
             * Collection Examples

            //LinkedList example
            LinkedListExamples.LinkedListBasics();
            //SortedSet Examples
            SortedSet.SortedSetExamples();
            //Dictionary Examples
            MyDictionary.DictionaryExample();
            MyDictionary.SortedDictionaryExample();
            //SortedList Examples
            MySortedList.SortedListExample();
            */

            /*

            //Generics Example
            MyGenericClass<string> mg = new MyGenericClass<string>("This is My String Class");
            MyGenericClass<int> mg1 = new MyGenericClass<int>(100);
            MyGenericClass<bool> mg2 = new MyGenericClass<bool>(true);
            MyGenericClass<char> mg3 = new MyGenericClass<char>('S');
            MyGenericClass<float> mg4 = new MyGenericClass<float>(100.06f);
            */

            

            //Partial Class Exapmles
            Employee emp = new Employee();
            emp.M1();
            emp.M2();
            Console.WriteLine(emp.i);
            Console.WriteLine(emp.x);
            
        }

        public static void methodRef(ref int x)
        {
            x = 400;
            Console.WriteLine("In Ref Method , Value is changed to " + x);
        }
        public static void methodVal(int x)
        {
            x = 300;
            Console.WriteLine("In Val Method , Value is changed to " + x);
        }

    }
}

