using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations
{
    public class SupportHoursConfiguration : EntityTypeConfiguration<SupportHours>
    {
        public SupportHoursConfiguration()
        {
            ToTable("SupportHours");
            Property(d => d.SupportHoursName).IsRequired();
            Property(d => d.SupportHoursName).HasMaxLength(105);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
