using System;
namespace learn_csharp.Basics
{
	public class ListCustomType
	{
		public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public Int64 Phone { get; set; }



        public static void UserData()
        {
            List<ListCustomType> userList = new List<ListCustomType>()
            {
                new ListCustomType
                {
                    UserId=101,
                    Name="Suro",
                    Age=32,
                    Gender='M',
                    Phone=98999899222
                },
                new ListCustomType
                {
                    UserId=102,
                    Name="Roma",
                    Age=30,
                    Gender='F',
                    Phone=89282222922
                },
                new ListCustomType
                {
                    UserId=103,
                    Name="Sumit",
                    Age=33,
                    Gender='M',
                    Phone=862736372622
                }
            };

            Console.WriteLine("Printing Users Data --> ");
            foreach(var udata in userList)
            {
                Console.WriteLine("User Id is {0} , Name is {1} , Age is {2}, Gender is  {3}, Phone Number is  {4}", udata.UserId, udata.Name, udata.Age, udata.Gender, udata.Phone);
            }




        }

    }


}

