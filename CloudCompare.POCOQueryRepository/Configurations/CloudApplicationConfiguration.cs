using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations
{
    public class CloudApplicationConfiguration : EntityTypeConfiguration<CloudApplication>
    {
        public CloudApplicationConfiguration()
        {
            ToTable("CloudApplications");
            Property(d => d.ServiceName).IsRequired().HasMaxLength(102);
            Property(d => d.Description).IsRequired().HasMaxLength(4000);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
