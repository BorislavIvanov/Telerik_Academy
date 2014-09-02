using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SQLToListPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch testWithToList = new Stopwatch();
            testWithToList.Start();
            SQLQueryWithToList();
            testWithToList.Stop();

            Stopwatch testWithOutToList = new Stopwatch();
            testWithOutToList.Start();
            SQLQueryWithOutToList();
            testWithOutToList.Stop();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test With ToList(): " + testWithToList.Elapsed);
            Console.WriteLine("Test WithOut ToList(): " + testWithOutToList.Elapsed);
            Console.ResetColor();
        }

        private static void SQLQueryWithOutToList()
        {
            TelerikAcademyEntities db = new TelerikAcademyEntities();

            using (db)
            {
                var allEmployees =
                    db.Employees
                    .Select(a => a.Address)
                    .Select(t => t.Town)
                    .Where(s => s.Name == "Sofia");

                foreach (var employee in allEmployees)
                {
                    Console.WriteLine(employee.Name);
                }
            }
        }

        private static void SQLQueryWithToList()
        {
            TelerikAcademyEntities db = new TelerikAcademyEntities();

            using (db)
            {
                var allEmployees =
                    db.Employees.ToList()
                    .Select(a => a.Address).ToList()
                    .Select(t => t.Town).ToList()
                    .Where(s => s.Name == "Sofia");

                foreach (var employee in allEmployees)
                {
                    Console.WriteLine(employee.Name);
                }
            }
        }
    }
}
