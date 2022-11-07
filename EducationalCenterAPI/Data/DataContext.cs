using EducationalCenterAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EducationalCenterAPI.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {}

        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
