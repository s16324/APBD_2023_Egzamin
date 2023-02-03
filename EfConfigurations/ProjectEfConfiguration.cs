using apbd_2023_egzamin_s16324.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apbd_2023_egzamin_s16324.EfConfigurations
{
    public class ProjectEfConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {

            builder.HasKey(e => e.IdTeam);
            builder.Property(e => e.IdTeam).UseIdentityColumn();
            builder.Property(e => e.Deadline).IsRequired();
            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();


            builder.HasData(
                new Project { IdTeam = 1, Name = "Projekt Egzamin", Deadline = DateTime.Parse("01/01/2033") },
                new Project { IdTeam = 2, Name = "Testowy", Deadline = DateTime.Parse("01/01/2043") }
                );

        }
    }
}
