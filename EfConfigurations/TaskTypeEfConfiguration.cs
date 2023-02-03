using apbd_2023_egzamin_s16324.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apbd_2023_egzamin_s16324.EfConfigurations
{
    public class TaskTypeEfConfiguration : IEntityTypeConfiguration<TaskType>
    {
        public void Configure(EntityTypeBuilder<TaskType> builder)
        {
            builder.HasKey(e => e.IdTaskType);
            builder.Property(e => e.IdTaskType).UseIdentityColumn();
            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();

            builder.HasData(
                new TaskType { IdTaskType=1, Name="Zrobić"},
                new TaskType { IdTaskType = 2, Name="Ogarnąć"}
                );

        }
    }
}
