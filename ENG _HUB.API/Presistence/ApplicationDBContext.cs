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
        public DbSet<ApplicationUserCourse> ApplicationUserCourses { get; set; } // ✅ أضفنا الجدول

        //public DbSet<PromptHistory> PromptHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            var CascadeFKs = modelBuilder.Model.GetEntityTypes()
               .SelectMany(e => e.GetForeignKeys())
               .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);
            foreach (var fk in CascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            


            // تعريف العلاقة Many-to-Many
            modelBuilder.Entity<ApplicationUserCourse>()
                .HasKey(x => new { x.UserId, x.CourseId });

            modelBuilder.Entity<ApplicationUserCourse>()
                .HasOne(x => x.User)
                .WithMany(u => u.UserCourses)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<ApplicationUserCourse>()
                .HasOne(x => x.Course)
                .WithMany(c => c.UserCourses)
                .HasForeignKey(x => x.CourseId);

        }

    }
}
