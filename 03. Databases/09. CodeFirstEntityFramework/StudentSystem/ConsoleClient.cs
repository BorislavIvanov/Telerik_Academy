using System;
using System.Linq;

namespace StudentSystem
{
    class ConsoleClient
    {
        static void Main(string[] args)
        {
            var db = new StudentSystemContext();

            using (db)
            {
                CreateNewStudent(db, "Georgi Jivkov", "094276");
                CreateNewStudent(db, "Kiril Ivanov", "042758");
                CreateNewStudent(db, "Dragomir Ivanov", "084868");

                var allStudents =
                    from s in db.Students
                    select s;

                foreach (var student in allStudents)
                {
                    Console.WriteLine(student.Name);
                }
            }
        }

        private static void CreateNewStudent(StudentSystemContext db, string newStudentName, string newStudentNumber)
        {
            var newStudent = new Student()
            {
                Name = newStudentName,
                Number = newStudentNumber
            };

            db.Students.Add(newStudent);
            db.SaveChanges();
        }
    }
}
