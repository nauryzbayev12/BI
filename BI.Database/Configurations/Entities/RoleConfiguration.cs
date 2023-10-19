using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BI.Database.Configurations.Entities
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        private const string developerRoleId = "2301D884-221A-4E7D-B509-0113DCC043E1";
           
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = developerRoleId,
                    Name = "Developer",
                    NormalizedName = "DEVELOPER"
                }
            );
        }
    }
}
