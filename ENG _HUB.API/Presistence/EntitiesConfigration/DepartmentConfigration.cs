namespace ENG__HUB.API.Presistence.EntitiesConfigration
{
    public class DepartmentConfigration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(p => p.ID);
            builder.HasIndex(p => p.Name).IsUnique();
           

        }
    }
    
}
