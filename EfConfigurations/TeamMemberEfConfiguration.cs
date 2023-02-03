using apbd_2023_egzamin_s16324.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apbd_2023_egzamin_s16324.EfConfigurations
{
    public class TeamMemberEfConfiguration : IEntityTypeConfiguration<TeamMember>
    {
        public void Configure(EntityTypeBuilder<TeamMember> builder)
        {

            builder.HasKey(e => e.IdTeamMember);
            builder.Property(e => e.IdTeamMember).UseIdentityColumn();
            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Email).HasMaxLength(100).IsRequired();

            builder.HasData(
                new TeamMember { IdTeamMember=1, FirstName="Jakub", LastName="Lewandowski", Email="s16324@pjwstk.edu.pl"},
                new TeamMember { IdTeamMember=2, FirstName="Basz", LastName="Kot", Email="basz@kot.pl"}
                );
        }
    }
}
