using Microsoft.EntityFrameworkCore;
using StudentManager.DataAccess.Models;

namespace StudentManager.DataAccess.Connection
{
    public class AppDbContext: DbContext
    {
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<CourseModel> Courses { get; set; }
        public DbSet<EnrollmentModel> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "Data Source=localhost;Initial Catalog=StudentManager; user id=AM_MEDIC; Password=123; MultipleActiveResultSets=true";
            // System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString

            optionsBuilder.UseSqlServer(
                connection
            );   
        }

    }
}
