using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.UsingIncludeInSQLQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch testWithOutInclude = new Stopwatch();
            testWithOutInclude.Start();
            SQLQueryWhitOutInclude();
            testWithOutInclude.Stop();

            Stopwatch testWithInclude = new Stopwatch();
            testWithInclude.Start();
            SQLQueryWhitInclude();
            testWithInclude.Stop();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Execution time with Include(): " + testWithInclude.Elapsed);
            Console.WriteLine("Execution time without Include(): " + testWithOutInclude.Elapsed);
            Console.ResetColor();
        }

        private static void SQLQueryWhitOutInclude()
        {
            TelerikAcademyEntities db = new TelerikAcademyEntities();

            using (db)
            {
                var allEmployees =
                    from e in db.Employees
                    select e;

                foreach (var employee in allEmployees)
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName +
                        " from " + employee.Department.Name +
                        " and address " + employee.Address.AddressText);
                }
            }
        }

        private static void SQLQueryWhitInclude()
        {
            TelerikAcademyEntities db = new TelerikAcademyEntities();

            using (db)
            {
                foreach (var employee in db.Employees.Include("Address").Include("Department"))
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName +
                        " from " + employee.Department.Name +
                        " and address " + employee.Address.AddressText);
                }
            }
        }
    }
}
