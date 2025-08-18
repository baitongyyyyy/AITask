﻿using AITaskDomain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AITaskInterfastructure.Configuration
{
    public class TaskConfiguration : IEntityTypeConfiguration<TaskEntity>
    {
        public void Configure(EntityTypeBuilder<TaskEntity> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Title).IsRequired().HasMaxLength(100);
            builder.Property(t => t.Description).HasMaxLength(500);
            builder.Property(t => t.Status).IsRequired().HasMaxLength(20);
            builder.Property(t => t.DueDate).IsRequired(false);
            builder.Property(t => t.CreatedAt).IsRequired();
        }
    }
}
