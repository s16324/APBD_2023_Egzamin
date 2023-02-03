using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apbd_2023_egzamin_s16324.Models;

namespace apbd_2023_egzamin_s16324.EfConfigurations
{
    public class TaskEfConfiguration : IEntityTypeConfiguration<Models.Task>
    {
        public void Configure(EntityTypeBuilder<Models.Task> builder)
        {
            builder.HasKey(e => e.IdTask);
            builder.Property(e => e.IdTask).UseIdentityColumn();
            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Description).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Deadline).IsRequired();

            builder.HasOne(e => e.IdProjectNavigation)
                .WithMany(e => e.Tasks)
                .HasForeignKey(e => e.IdTeam);

            builder.HasOne(e => e.IdTaskTypeNavigation)
                .WithMany(e => e.Tasks)
                .HasForeignKey(e => e.IdTeam);

            builder.HasOne(e => e.IdTeamMemberNavigation)
                .WithMany(e => e.Tasks)
                .HasForeignKey(e => e.IdTeam);

            builder.HasData(
                new Models.Task { IdTask = 1, Name="Napisać egzamin", Description="testowy opis", Deadline = DateTime.Parse("01/01/2043"), IdTeam=1, IdTaskType=1, IdAssignedTo=1, IdCreator=1 },
                new Models.Task { IdTask = 2, Name = "Wrócić do domu", Description = "testowy opis2", Deadline = DateTime.Parse("01/01/2044"), IdTeam = 1, IdTaskType = 2, IdAssignedTo = 1, IdCreator = 2 },
                new Models.Task { IdTask = 3, Name = "Zalogować się do pracy", Description = "testowy opis3", Deadline = DateTime.Parse("01/01/2045"), IdTeam = 1, IdTaskType = 1, IdAssignedTo = 1, IdCreator = 1 },
                new Models.Task { IdTask = 4, Name = "Udawać żę cały czas byłam w pracy", Description = "testowy opi4s", Deadline = DateTime.Parse("01/01/2046"), IdTeam = 1, IdTaskType = 2, IdAssignedTo = 1, IdCreator = 2 }
                );
        }

        

    }
}
