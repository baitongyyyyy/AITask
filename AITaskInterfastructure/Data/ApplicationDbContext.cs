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
        public required DbSet<ActivityLogEntity> ActivityLogs { get; set; }
        public required DbSet<PriorityEntity> Priorities { get; set; }
        public required DbSet<UserEntity> Users { get; set; }
        public required DbSet<TaskEntity> Tasks { get; set; }

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
