using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations
{
    public class SetupFeeConfiguration : EntityTypeConfiguration<SetupFee>
    {
        public SetupFeeConfiguration()
        {
            ToTable("SetupFees");
            Property(d => d.SetupFeeName).IsRequired();
            Property(d => d.SetupFeeName).HasMaxLength(105);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
