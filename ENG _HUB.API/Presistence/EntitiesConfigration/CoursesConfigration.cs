

namespace ENG__HUB.API.Presistance.EntitiesConfigration
{
    public class CourseConfigration :IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(p => p.ID);
            builder.HasIndex(p => p.Name).IsUnique();
            builder.Property(p => p.IsAvilable).IsRequired();
            
        }
    }
    
}
