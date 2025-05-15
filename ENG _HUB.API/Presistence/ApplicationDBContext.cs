using ENG__HUB.API.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ENG__HUB.API.Presistance
{
    public class ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):
        IdentityDbContext<ApplicationUser>(options)
    {   public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<Note> Notes { get; set; }
        //public DbSet<PromptHistory> PromptHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

    }
}
