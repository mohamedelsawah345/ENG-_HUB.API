

using ENG__HUB.API.Entities;

namespace ENG__HUB.API.Presistance.EntitiesConfigration
{
    public class UserConfigration :IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(x=>x.FirstName).HasMaxLength(50);
            builder.Property(x=>x.LastName).HasMaxLength(50);
            
            
            
        }
    }
    
}
