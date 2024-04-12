using System;
using System.Reflection;
using System.Xml.Linq;

namespace learn_csharp.Linq
{
	class Student
	{
		public string Name { get; set; }
        public int Age { get; set; }
        public int Roll { get; set; }
        public string Std { get; set; }
        public int Rank { get; set; }

    }

	public class LinqBasics
	{

		public static void LinqBasicOps()
		{
            List<Student> students = new List<Student>()
            {
                new Student
                {
                    Name = "Rohan",
                    Age = 13,
                    Roll = 65,
                    Std = "9-A",
                    Rank = 3
                },
                new Student
                {
                    Name = "Suro",
                    Age = 14,
                    Roll = 12,
                    Std = "10-C",
                    Rank = 34
                },
                new Student
                {
                    Name = "Roma",
                    Age = 10,
                    Roll = 22,
                    Std = "6-B",
                    Rank = 16
                },
                new Student
                {
                    Name = "Googlie",
                    Age = 16,
                    Roll = 2,
                    Std = "11-A",
                    Rank = 1
                },
                new Student
                {
                    Name = "Poppins",
                    Age = 6,
                    Roll = 14,
                    Std = "1-A",
                    Rank = 8
                }
            };

            //get all student names using query
            var studentNames = from studList in students
                               select studList.Name;
            Console.WriteLine("Printing all Student's Name using query- ");
            foreach (var sName in studentNames)
            {
                Console.WriteLine(sName);
            }

            //get all student names using method
            studentNames = students.Select(stud => stud.Name);
            Console.WriteLine("Printing all Student's Name using method - ");
            foreach (var sName in studentNames)
            {
                Console.WriteLine(sName);
            }

            // get all students whose Rank is under 10 using query
            var studDetails = from studData in students
                               where studData.Rank<10
                            select studData;
            Console.WriteLine("Printing all Student's Name whose Rank is under 10 using query- ");
            foreach (var stu in studDetails)
            {
                Console.WriteLine("Name = {0} Rank = {1} ", stu.Name, stu.Rank);
            }

            //get all students whose Rank is under 10 using method
            studDetails = students.Where(Stud=> Stud.Rank<10).Select(stud => stud);
            Console.WriteLine("Printing all Student's Name whose Rank is under 10 using method- ");
            foreach (var stud in studDetails)
            {
                Console.WriteLine("Name = {0} Rank = {1} ",stud.Name,stud.Rank);
            }
        }
	}
}

