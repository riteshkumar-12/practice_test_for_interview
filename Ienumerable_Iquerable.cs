using System.Linq;
using System.Collections;
using System;
using System.Collections.Generic;

namespace Class1
{

    public class Examples
    {
        //static void Main(string[] args)
        //{
        //    Method();
        //}
        public static void Method()
        {

            List<Student> studentlist = new List<Student>()
                {
                     new Student(){ID = 1, Name = "James", Gender = "Male"},
                    new Student(){ID = 2, Name = "Sara", Gender = "Female"},
                    new Student(){ID = 3, Name = "Steve", Gender = "Male"},
                    new Student(){ID = 4, Name = "Pam", Gender = "Female"}
            };

            IEnumerable<Student> Quetry = from std in studentlist where std.Gender == "Male" select std;
            IQueryable<Student> query2 = studentlist.AsQueryable().Where(x => x.Gender == "Male");
            ////-----------------------------------------------------------------------------------------------

            var Emp_List = new List<Employee>(
                 new Employee[]
                 {
                    new Employee{Emp_ID=1, Name="Shambhu Sharma", Email="shambhu@shambhu.com", Country="India"},
                    new Employee{Emp_ID=2, Name="Manu Khanna", Email="manu@manu.com", Country="India"},
                    new Employee{Emp_ID=3, Name="Abhishek Nigam", Email="abhishek@abhishek.com", Country="USA"},
                    new Employee{Emp_ID=4, Name="Yogesh Gupta", Email="yogesh@yogesh.com", Country="USA"},
                    new Employee{Emp_ID=5, Name="Shweta Kashyap", Email="Shweta@Shweta.com", Country="India"},
                    new Employee{Emp_ID=6, Name="Shraddha Gaur", Email="Shraddha@Shraddha.com", Country="India"},
                    new Employee{Emp_ID=7, Name="Akhilesh Atwal", Email="Akhilesh@Akhilesh.com", Country="India"},
                    new Employee{Emp_ID=6, Name="Mayank Dhulekar", Email="Mayank@Mayank.com", Country="USA"},
                    new Employee{Emp_ID=7, Name="Saurabh Mehrotra", Email="Saurabh@Saurabh.com", Country="USA"},
                    new Employee{Emp_ID=7, Name="Mehak Jain", Email="Mehak@Mehak.com", Country="India"},
                 });

            var Result = from a in Emp_List
                         where a.Country.Equals("India")
                         select new { a.Name };
            ////If we remove the ToList() method from the above linq then it is deffered execution and Result object will also
            ////    contain the below new added employee.

            ////You can force a query to execute immediately of by calling ToList, ToArray methods.

            Emp_List.Add(new Employee
            {
                Emp_ID = 8,
                Name = "Ritesh Kumar",
                Email = "Riteshk208994@gmail.com",
                Country = "India"
            });

            foreach (var EMP in Result)
            { Console.WriteLine(EMP.Name + "</br>"); }

            Console.ReadLine();

            //--------------------------------------------------------------------------
            // Method to find the missing no in array.

            //bool isTrue = false;
            //int[] arr = new[] { 1, 2, 3, 4, 6, 7, 8, 9, 10 };

            //int counter = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (!isTrue) { counter++; }

            //    if (arr[i] == (counter))
            //    {
            //        isTrue = false;
            //        Console.WriteLine(arr[i].ToString());
            //    }
            //    else
            //    {
            //        Console.WriteLine("The missing no is: -" + counter.ToString());
            //        counter++;
            //        i--;
            //        isTrue = true;
            //    }
            //}
            //Console.ReadLine();
            //---------------------------------------------------------------------------------------
        }

        public class Employee
        {
            public int Emp_ID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Country { get; set; }
        }

        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
        }

    }
}

