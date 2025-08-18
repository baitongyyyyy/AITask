using AITaskDomain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AITaskInterfastructure.Configuration
{
    public class ActivityLogConfiguration : IEntityTypeConfiguration<ActivityLogEntity>
    {
        public void Configure(EntityTypeBuilder<ActivityLogEntity> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Action).IsRequired().HasMaxLength(200);
            builder.Property(a => a.Timestamp).IsRequired();
            builder.Property(a => a.UserId).IsRequired();
            builder.HasOne(a => a.User)
                   .WithMany(u => u.ActivityLogs)
                   .HasForeignKey(a => a.UserId);
        }
    }
}
