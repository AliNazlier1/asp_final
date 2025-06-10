using Microsoft.EntityFrameworkCore;

namespace Final.Models
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FinalStudentDb;Trusted_Connection=True;");
        }
    }
}