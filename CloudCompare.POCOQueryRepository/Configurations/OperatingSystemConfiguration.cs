using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations
{
    public class OperatingSystemConfiguration : EntityTypeConfiguration<CloudCompare.Domain.Models.OperatingSystem>
    {
        public OperatingSystemConfiguration()
        {
            ToTable("OperatingSystems");
            Property(d => d.OperatingSystemName).IsRequired();
            Property(d => d.OperatingSystemName).HasMaxLength(105);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
