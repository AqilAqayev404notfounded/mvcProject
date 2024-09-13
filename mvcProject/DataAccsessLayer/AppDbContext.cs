using Microsoft.EntityFrameworkCore;
using mvcProject.Models;

namespace mvcProject.DataAccsessLayer
{
    public class AppDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<TeacherStudent> TeacherStudents { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext>options):base (options)
        {
            
        }
    }
}
