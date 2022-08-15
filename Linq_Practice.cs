using Practice.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Linq_Practice
    {
        //[Params(10, 20, 30, 40)]
        //public int N;
        //static void Main(string[] args)
        //{

        //    using (AdventureWorks2017Entities _adventure = new AdventureWorks2017Entities())
        //    {
                //----------------------------------------------------------------------------------
                //              var Join = (from e in _adventure.Employees
                //                               join d in _adventure.EmployeeDepartmentHistories
                //on e.BusinessEntityID equals d.BusinessEntityID into Table1
                //                               from f in Table1
                //                               join i in _adventure.EmployeePayHistories on f.BusinessEntityID equals i.BusinessEntityID
                //                               into Table2
                //                               //where e.Gender == "Male"
                //                               select new
                //                               {
                //                                   EmployeeGender = e.Gender,
                //                                   EmployeeJonTitle = e.JobTitle
                //                               }).ToList();

                //-------------------------------------------------------------------------------------

                //var join = (from e in _adventure.Employees
                //            select new
                //            {
                //                EnployeeGender = e.Gender,
                //                EmployeeJobTitle = e.JobTitle
                //            }
                //            ).ToArray();
        //        var join2 = (from e in _adventure.Employees
        //                     group e by e.Gender into Table1
        //                     select Table1
        //                  ).ToList();
        //        var join3 = (from e in _adventure.Employees
        //                     where e.OrganizationLevel != null
        //                     group new { e.Gender, e.JobTitle } by e into Table1
        //                     orderby Table1.Key.BirthDate ascending
        //                     select Table1
        //  ).ToList();
        //    }
        //    Console.ReadLine();
        //}
    }
}
