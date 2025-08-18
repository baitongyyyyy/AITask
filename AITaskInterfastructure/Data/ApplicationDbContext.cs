using AITaskDomain.Entites;
using Microsoft.EntityFrameworkCore;
using AITaskInterfastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITaskInterfastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ActivityLogEntity> ActivityLogs { get; set; }
        public DbSet<PriorityEntity> Priorities { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<TaskEntity> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ActivityLogConfiguration());
            modelBuilder.ApplyConfiguration(new PriorityConfiguration());
            modelBuilder.ApplyConfiguration(new TaskConfiguration());
        }
    }
}
