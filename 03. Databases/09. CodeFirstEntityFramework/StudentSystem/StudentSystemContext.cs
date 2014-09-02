namespace StudentSystem
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
            : base("name=StudentSystemContext")
        {
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Homework> Homeworks { get; set; }

        public DbSet<Student> Students { get; set; }

    }
}