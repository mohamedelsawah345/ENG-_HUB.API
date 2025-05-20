namespace ENG__HUB.API.Presistence.EntitiesConfigration
{
    public class NoteConfigration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(p => p.ID);
           
            builder.Property(p => p.Text).IsRequired();

        }
    }
}
