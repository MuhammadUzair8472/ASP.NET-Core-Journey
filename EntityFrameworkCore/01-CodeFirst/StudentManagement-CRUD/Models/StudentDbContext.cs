using Microsoft.EntityFrameworkCore;

namespace StudentManagment.Models
{
    public class StudentDbContext: DbContext
    {
        public StudentDbContext(DbContextOptions options) :base (options)
        {
                
        }
        public DbSet<Student> Students { get; set; }

    }

    
}
