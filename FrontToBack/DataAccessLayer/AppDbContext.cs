using FrontToBack.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.DataAccessLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options) 
        {
            
        }
        public DbSet<Teacher>  Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<TeacherStudent> TeacherStudents { get; set; }
    }
}
