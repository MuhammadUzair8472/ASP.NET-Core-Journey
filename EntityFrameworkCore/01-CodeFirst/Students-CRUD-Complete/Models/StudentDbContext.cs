using Microsoft.EntityFrameworkCore;

namespace students_crud.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext( DbContextOptions options):base (options)
        {
            
        }
        public DbSet<Student> Students  { get; set; }

    }
}
