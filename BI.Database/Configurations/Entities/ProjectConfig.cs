using BI.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI.Database.Configurations.Entities
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        private const string userId = "38815E40-2E91-4033-849F-1202B5A319B8";

        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasData(
               new Project
               {
                   Id = 1 ,
                   Name = "BI HOME",
                   Created = DateTime.UtcNow , 
                   UserId = userId 
               },
                new Project
                {
                    Id = 2,
                    Name = "BI SPORT",
                    Created = DateTime.UtcNow ,
                    UserId = userId
                },
                 new Project
                 {
                     Id = 3 ,
                     Name = "BI AUYL",
                     Created = DateTime.UtcNow ,
                     UserId = userId
                 }
           ) ;
            
          

        }
    }
}
