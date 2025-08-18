using AITaskDomain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITaskInterfastructure.Configuration
{
    public class PriorityConfiguration : IEntityTypeConfiguration<PriorityEntity>
    {
        public void Configure(EntityTypeBuilder<PriorityEntity> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Feasibility).IsRequired();
            // Additional configurations can be added here
        }
    }
}
