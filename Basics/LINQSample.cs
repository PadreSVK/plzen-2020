using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics
{
    public class LINQSample : ISample
    {
        public void Run()
        {
            Sample1();
            Sample3();
        }

        public void Sample1()
        {
            var numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            var numQuery =
                from num in numbers
                where num % 2 == 0
                orderby num
                select num;

            foreach (var num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }
        }
        public void Sample2()
        {
            var musos = new []{ "David Gilmour", "Roger Waters", "Rick Wright", "Nick Mason" };

            IEnumerable<string> queryFluent = musos.OrderBy(m => m.Split().Last());

            var query = from m in musos
                orderby m.Split().Last()
                select m;
        }



        public void Sample3()
        {
            var students = new List<Student>
            {
                new Student
                {
                    First = "Svetlana",
                    Last = "Omelchenko",
                    ID = 111,
                    Street = "123 Main Street",
                    City = "Seattle",
                    Scores = new List<int> {97, 92, 81, 60}
                },
                new Student
                {
                    First = "Claire",
                    Last = "O’Donnell",
                    ID = 112,
                    Street = "124 Main Street",
                    City = "Redmond",
                    Scores = new List<int> {75, 84, 91, 39}
                },
                new Student
                {
                    First = "Sven",
                    Last = "Mortensen",
                    ID = 113,
                    Street = "125 Main Street",
                    City = "Lake City",
                    Scores = new List<int> {88, 94, 65, 91}
                }
            };

            // Create the second data source.
            var teachers = new List<Teacher>
            {
                new Teacher {First = "Ann", Last = "Beebe", ID = 945, City = "Seattle"},
                new Teacher {First = "Alex", Last = "Robinson", ID = 956, City = "Redmond"},
                new Teacher {First = "Michiyo", Last = "Sato", ID = 972, City = "Tacoma"}
            };

            // Create the query.
            var peopleInSeattle = (from student in students
                    where student.City == "Seattle"
                    select student.Last)
                .Concat(from teacher in teachers
                    where teacher.City == "Seattle"
                    select teacher.Last);

            Console.WriteLine("The following students and teachers live in Seattle:");
            // Execute the query.
            foreach (var person in peopleInSeattle)
            {
                Console.WriteLine(person);
            }
        }

        private class Student
        {
            public List<int> Scores { get; set; }
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }
            public string Street { get; set; }
            public string City { get; set; }
        }

        private class Teacher
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }
            public string City { get; set; }
        }
    }
}