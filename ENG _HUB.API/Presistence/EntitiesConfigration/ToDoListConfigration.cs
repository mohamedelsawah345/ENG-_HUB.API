namespace ENG__HUB.API.Presistence.EntitiesConfigration
{
    public class ToDoListConfigration : IEntityTypeConfiguration<ToDoList>
    {
        public void Configure(EntityTypeBuilder<ToDoList> builder)
        {
            builder.HasKey(p => p.ID);

            builder.Property(p => p.Text).IsRequired();

        }
    }
}
