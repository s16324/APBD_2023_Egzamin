using apbd_2023_egzamin_s16324.EfConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apbd_2023_egzamin_s16324.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext() { }
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options) { }


        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<TaskType> TaskType { get; set; }
        public virtual DbSet<TeamMember> TeamMember { get; set; }
        public virtual DbSet<Task> Task { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProjectEfConfiguration());
            modelBuilder.ApplyConfiguration(new TaskTypeEfConfiguration());
            modelBuilder.ApplyConfiguration(new TeamMemberEfConfiguration());
            modelBuilder.ApplyConfiguration(new TaskEfConfiguration());

        }
    }
}
