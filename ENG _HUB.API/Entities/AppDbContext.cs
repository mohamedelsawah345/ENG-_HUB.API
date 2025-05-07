
namespace ENG__HUB.API.Models
{
    //public class AppDbContext : DbContext
    //{
    //    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    //    public DbSet<User> Users { get; set; }
    //    public DbSet<Department> Departments { get; set; }
    //    public DbSet<Course> Courses { get; set; }
    //    public DbSet<ToDoList> ToDoLists { get; set; }
    //    public DbSet<Note> Notes { get; set; }
    //    public DbSet<PromptHistory> PromptHistories { get; set; }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        //// User
    //        //modelBuilder.Entity<User>(entity =>
    //        //{
    //        //    entity.HasKey(u => u.UserID);

    //        //    entity.Property(u => u.UserName).IsRequired();
    //        //    entity.Property(u => u.Email).IsRequired();
    //        //    entity.Property(u => u.Password).IsRequired();
    //        //    entity.Property(u => u.ProfilePhoto);
    //        //    entity.Property(u => u.Major);
    //        //    entity.Property(u => u.Role);

    //        //    entity.HasOne(u => u.Department)
    //        //          .WithMany(d => d.Users)
    //        //          .HasForeignKey(u => u.DepartmentID);

    //        //    entity.HasMany(u => u.ToDoLists)
    //        //          .WithOne(t => t.User)
    //        //          .HasForeignKey(t => t.UserID);

    //        //    entity.HasMany(u => u.Notes)
    //        //          .WithOne(n => n.User)
    //        //          .HasForeignKey(n => n.UserID);

    //        //    entity.HasMany(u => u.PromptHistories)
    //        //          .WithOne(p => p.User)
    //        //          .HasForeignKey(p => p.UserID);

    //        //    entity.HasMany(u => u.Courses)
    //        //    .WithMany(c => c.Users)
    //        //    .UsingEntity<Dictionary<string, object>>("UserCourses",j => j.HasOne<Course>()
    //        //    .WithMany()
    //        //    .HasForeignKey("CourseID")
    //        //    .OnDelete(DeleteBehavior.Cascade),
    //        //    j => j.HasOne<User>()
    //        //    .WithMany()
    //        //    .HasForeignKey("UserID")
    //        //    .OnDelete(DeleteBehavior.Cascade)
    //        //    );

    //        //});




    //        //// Department
    //        //modelBuilder.Entity<Department>(entity =>
    //        //{
    //        //    entity.HasKey(d => d.DepartmentID);

    //        //    entity.Property(d => d.DepartmentName).IsRequired();

    //        //    entity.HasMany(d => d.Courses)
    //        //    .WithMany(c => c.Departments)
    //        //    .UsingEntity<Dictionary<string, object>>("DepartmentCourses",j => j.HasOne<Course>()
    //        //   .WithMany()
    //        //   .HasForeignKey("CourseID")
    //        //   .OnDelete(DeleteBehavior.Cascade),
    //        //    j => j.HasOne<Department>()
    //        //   .WithMany()
    //        //   .HasForeignKey("DepartmentID")
    //        //   .OnDelete(DeleteBehavior.Cascade)
    //        //    );

    //        //});

           

    //        //// ToDoList
    //        //modelBuilder.Entity<ToDoList>(entity =>
    //        //{
    //        //    entity.HasKey(t => t.ToDoListID);

    //        //    entity.Property(t => t.ToDoText).IsRequired();
    //        //    entity.Property(t => t.CreationDate).IsRequired();
    //        //    entity.Property(t => t.DeadLineDate);
    //        //});

    //        //// Note
    //        //modelBuilder.Entity<Note>(entity =>
    //        //{
    //        //    entity.HasKey(n => n.NoteID);

    //        //    entity.Property(n => n.NoteText).IsRequired();
    //        //    entity.Property(n => n.CreationDate).IsRequired();
    //        //});

    //        //// PromptHistory
    //        //modelBuilder.Entity<PromptHistory>(entity =>
    //        //{
    //        //    entity.HasKey(p => p.PromptHistoryID);

    //        //    entity.Property(p => p.PromptText).IsRequired();
    //        //});
    //    }
    //}

}
