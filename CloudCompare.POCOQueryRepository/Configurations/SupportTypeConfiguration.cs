using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository.Configurations
{
    public class SupportTypeConfiguration : EntityTypeConfiguration<SupportType>
    {
        public SupportTypeConfiguration()
        {
            ToTable("SupportTypes");
            Property(d => d.SupportTypeName).IsRequired();
            Property(d => d.SupportTypeName).HasMaxLength(105);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
