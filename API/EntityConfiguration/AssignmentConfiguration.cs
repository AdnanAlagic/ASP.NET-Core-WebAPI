using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.EntityConfiguration
{
    public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.HasKey(a => a.AssignmentId);
            builder.Property(a => a.AssignmentTitle).IsRequired();
            builder.Property(a => a.AssignmentDescription).IsRequired();
            builder.Property(a => a.AssignmentStartDate).IsRequired();
            builder.Property(a => a.AssignmentEndDate).IsRequired();
            builder.HasOne(a => a.StatusAssignment).WithMany(s => s.AssignmentsStatus).HasForeignKey(a => a.AssignmentStatusId);
            builder.HasOne(a => a.PriorityAssignment).WithMany(p => p.AssignmentsPriority).HasForeignKey(a => a.AssignmentPriorityId);
            builder.HasOne(a => a.UserAssignment).WithMany(u => u.Assignments).HasForeignKey(a => a.AssignmentUserId);
        }
    }
}
