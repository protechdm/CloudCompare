using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations
{
    public class MobilePlatformConfiguration : EntityTypeConfiguration<MobilePlatform>
    {
        public MobilePlatformConfiguration()
        {
            ToTable("MobilePlatforms");
            Property(d => d.MobilePlatformName).IsRequired();
            Property(d => d.MobilePlatformName).HasMaxLength(105);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
