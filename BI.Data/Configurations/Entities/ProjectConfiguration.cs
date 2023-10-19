using BI.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BI.Data.Configurations.Entities
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasData(
                new Project
                {
                    Id = 1,
                    Name = "BI PRO",
                    
                },
                new Project
                {
                    Id = 2,
                    Name = "BI SPORT",
                  
                },
                new Project
                {
                    Id = 3,
                    Name = "BI HANDBOOK",
                   
                }
            );
        }
    }
}
