using Microsoft.EntityFrameworkCore;
using StudentPortal.API.Models;
using StudentPortal.API.Models.StudentPortal.API.Models;

namespace StudentPortal.API.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}