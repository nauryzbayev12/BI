using BI.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI.Database.Configurations.Entities
{
    public class UserConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        private const string userId = "38815E40-2E91-4033-849F-1202B5A319B8";
          
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var admin = new ApplicationUser
            {
                Id = userId,
                UserName = "user",
                NormalizedUserName = "USER",
                Email = "user@bi.kz",
                NormalizedEmail = "USER@BI.KZ",
                PhoneNumber = "+77071281494",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString("D"),
               
            };
        }
    }
}
